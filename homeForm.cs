using monitoring_network.controller;
using monitoring_network.DAL;
using System.Media;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Timers;
using System.Xml.Linq;



namespace monitoring_network
{
    public partial class homeForm : Form
    {
        // 鼠标消息常量，用于实现窗口拖动
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        //定时器
        private static System.Timers.Timer aTimer;
        private static bool isTimerRunning = false;
        // 报警声音控制器
        private int open = 0;
        //记录次数
        private int totalCount = 1;

        // 引入 Windows API 函数，用于实现窗口拖动
        [DllImportAttribute("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        private static extern bool ReleaseCapture();

        public homeForm()
        {
            InitializeComponent();
            CenterToScreen();  // 将窗口居中显示
            AssignmentListView(); // 列表视图赋值
            FillDataGridView(); // 数据表格赋值
            logMTime.SelectedIndex = 0;
        }

        // 鼠标按下事件处理，主要用于实现窗口拖动
        private void homeForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        // 打开地址池窗口
        private void addressPools_Click(object sender, EventArgs e)
        {
            addressPoolsForm addressPoolsForm = new addressPoolsForm(AssignmentListView, "add", null);
            addressPoolsForm.ShowDialog();
        }

        // 退出程序
        private void quit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        // 切换到地址池窗口
        private void addPoolsB_Click(object sender, EventArgs e)
        {
            SwitchPanel(addPoolsB, addPoolsWindowPanel);
        }

        // 切换到日志管理窗口
        private void logMB_Click(object sender, EventArgs e)
        {
            SwitchPanel(logMB, logMWindowPanel);
        }

        // 切换到丢包率监控窗口
        private void packetLossRateB_Click(object sender, EventArgs e)
        {
            SwitchPanel(packetLossRateB, packetLossRateWindowPanel);
            // 清空ListBox
            packetLossRatelistBox.Items.Clear();
            List<Address> addresses = new read_write().ReadXmlRecords();
            foreach (Address address in addresses)
            {
                packetLossRatelistBox.Items.Add($"名称:{address.Name}|IP:{address.Add}-----异常次数:{address.Count}");
            }
        }
        // 辅助方法：切换面板和按钮背景色
        private void SwitchPanel(Button activeButton, Panel activePanel)
        {
            // 重置所有按钮的背景色
            ResetButtonBackgroundColor();
            // 设置活动按钮的背景色
            activeButton.BackColor = Color.LightGray;
            // 隐藏所有面板
            HideAllPanels();
            // 显示活动面板
            activePanel.Visible = true;
        }

        private void ResetButtonBackgroundColor()
        {
            addPoolsB.BackColor = SystemColors.Control;
            logMB.BackColor = SystemColors.Control;
            packetLossRateB.BackColor = SystemColors.Control;
        }

        private void HideAllPanels()
        {
            addPoolsWindowPanel.Visible = false;
            logMWindowPanel.Visible = false;
            packetLossRateWindowPanel.Visible = false;
        }

        // 计算并显示地址池总数
        public void AssignmentListView()
        {
            read_write read_Write = new read_write();
            List<Address> addresses = read_Write.ReadXmlRecords();
            addPoolsB.Text = $"地址池共有 {addresses.Count} 个IP";
            PopulateDataGridView(addresses);
        }

        // 填充DataGridView
        private void PopulateDataGridView(List<Address> addresses)
        {
            // 清除现有项
            addPoolsDataGridView.Rows.Clear();
            addPoolsDataGridView.Columns.Clear();

            // 添加列
            addPoolsDataGridView.Columns.Add("Name", "地址池名称");
            addPoolsDataGridView.Columns.Add("Address", "IP");

            // 添加按钮列
            AddButtonColumn("Edit", "操作");
            AddButtonColumn("Delete", "操作");
            AddButtonColumn("Work", "操作");

            // 添加行
            foreach (var address in addresses)
            {
                int rowIndex = addPoolsDataGridView.Rows.Add(address.Name, address.Add);
                addPoolsDataGridView.Rows[rowIndex].Tag = address.Id; // 将ID存储在行的Tag属性中

                DataGridViewButtonCell editButtonCell = (DataGridViewButtonCell)addPoolsDataGridView.Rows[rowIndex].Cells["Edit"];
                editButtonCell.Value = "修改";

                DataGridViewButtonCell deleteButtonCell = (DataGridViewButtonCell)addPoolsDataGridView.Rows[rowIndex].Cells["Delete"];
                deleteButtonCell.Value = "删除";

                DataGridViewButtonCell workButtonCell = (DataGridViewButtonCell)addPoolsDataGridView.Rows[rowIndex].Cells["Work"];
                workButtonCell.Value = address.Work == 1 ? "关闭" : "开启";
            }
        }

        // 辅助方法：添加按钮列
        private void AddButtonColumn(string name, string headerText)
        {
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn
            {
                Name = name,
                HeaderText = headerText,
                UseColumnTextForButtonValue = false, // 禁用使用列文本作为按钮值
                FlatStyle = FlatStyle.Flat
            };
            addPoolsDataGridView.Columns.Add(buttonColumn);
        }


        // 处理DataGridView中的按钮点击事件
        private void addPoolsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            read_write read_Write = new read_write();
            int? id = null;

            if (e.ColumnIndex == addPoolsDataGridView.Columns["Edit"].Index && e.RowIndex >= 0)
            {
                id = (int)addPoolsDataGridView.Rows[e.RowIndex].Tag;
                addressPoolsForm addressPoolsForm = new addressPoolsForm(AssignmentListView, "update", id);
                addressPoolsForm.ShowDialog();
            }
            else if (e.ColumnIndex == addPoolsDataGridView.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                id = (int)addPoolsDataGridView.Rows[e.RowIndex].Tag;
                DialogResult result = MessageBox.Show("是否确定删除", "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                if (result == DialogResult.OK)
                {
                    try
                    {
                        if (read_Write.DeleteXmlRecord(id.Value))
                        {
                            MessageBox.Show("删除成功！", "操作提示");
                            AssignmentListView();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"删除失败: {ex.Message}", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (e.ColumnIndex == addPoolsDataGridView.Columns["Work"].Index && e.RowIndex >= 0)
            {
                id = (int)addPoolsDataGridView.Rows[e.RowIndex].Tag;
                Address address = read_Write.GetAddressById(id.ToString());
                if (address != null)
                {
                    string action = address.Work == 1 ? "关闭" : "开启";
                    string promptMessage = $"是否确定{action}，{action}后将{(action == "关闭" ? "不" : "")}加入巡检测试.";
                    DialogResult result = MessageBox.Show(promptMessage, "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

                    if (result == DialogResult.OK)
                    {
                        try
                        {
                            address.Work = address.Work == 1 ? 0 : 1;
                            if (read_Write.UpdateXmlRecord(address))
                            {
                                MessageBox.Show($"{action}成功！", "操作提示");
                                AssignmentListView();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"{action}失败: {ex.Message}", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("操作失败, 请联系管理员!", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void begin_Click(object sender, EventArgs e)
        {
            // 如果按钮文本是“开 始 巡 检”
            if (begin.Text == "开 始 巡 检")
            {
                // 尝试将 logMTime 转换为整数
                if (int.TryParse(logMTime.Text, out int LogMTimeint) && LogMTimeint > 0)
                {
                    // 显示确认消息框
                    if (MessageBox.Show("开始巡检后，请勿关闭程序，否则巡检将无法正常进行，是否继续？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        // 禁用 logMTime 文本框，并更改按钮文本
                        logMTime.Enabled = false;
                        logMbutton.Enabled = false;
                        logMlabel.Visible = true;
                        begin.Text = "停 止 巡 检";
                        StartTimer(LogMTimeint * 1000);
                        isTimerRunning = true;
                        warningbutton.Visible = true;
                        warningbutton.Text = "开启告警器";
                    }
                }
                else
                {
                    // 提示输入的值无效
                    MessageBox.Show("请输入一个有效的巡检时间。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // 启用 logMTime 文本框，并更改按钮文本
                logMTime.Enabled = true;
                begin.Text = "开 始 巡 检";
                StopTimer();
                isTimerRunning = false;
                logMbutton.Enabled = true;
                logMlabel.Visible = false;
                warningbutton.Visible = false;
                open = 0;
            }
        }

        private void StartTimer(double interval)
        {
            // 创建一个计时器并设置间隔时间（毫秒）
            aTimer = new System.Timers.Timer(interval);

            // 设置计时器的事件处理方法
            aTimer.Elapsed += OnTimedEvent;

            // 设置计时器的自动重置属性（每次间隔时间到时都会触发事件）
            aTimer.AutoReset = true;

            // 启动计时器
            aTimer.Enabled = true;
        }

        private async void OnTimedEvent(object? sender, ElapsedEventArgs e)
        {
            await StartPolling();
        }

        private static void StopTimer()
        {
            if (aTimer != null)
            {
                // 停止计时器
                aTimer.Stop();
                aTimer.Dispose();
            }
        }

        private async Task StartPolling()
        {
            // 创建PollingIP对象
            var polling = new pollingIP();

            // 调用PingAddressesAsync方法并等待结果
            var results = await polling.PingAddressesAsync();

            // 填充ListBox
            FillListBox(results);
        }

        private void FillListBox(Dictionary<Address, bool> results)
        {
            if (logMlistBox.InvokeRequired)
            {
                // 如果需要在UI线程上调用，则使用Invoke方法
                logMlistBox.Invoke(new Action<Dictionary<Address, bool>>(FillListBox), results);
            }
            else
            {
                // 清空ListBox
                logMlistBox.Items.Clear();
                frequency.Text = totalCount++.ToString();
                DateTime now = DateTime.Now;
                string formattedTime = "";
                directoryStructure directoryStructure = new directoryStructure();
                read_write read_write = new read_write();             // 将结果添加到ListBox中

                foreach (var result in results)
                {
                    now = DateTime.Now;
                    formattedTime = now.ToString("yyyy年MM月dd日 HH:mm:ss");
                    // 判断Ping是否成功
                    if (result.Value)
                    {
                        // 如果Ping成功，添加成功的消息
                        logMlistBox.Items.Add($"时间: {formattedTime} 巡检通过 名称: {result.Key.Name}");
                        directoryStructure.LogMessage($"时间: {formattedTime} 巡检通过 名称: {result.Key.Name}");
                    }
                    else
                    {
                        // 如果Ping失败，添加失败的消息
                        logMlistBox.Items.Add($"时间: {formattedTime} Ping不通过！！！ 名称: {result.Key.Name} IP: {result.Key.Add}");

                        // 添加到DataGridView
                        int rowIndex = logMwrongsGridView.Rows.Add($"时间: {formattedTime} Ping不通过！！！ 名称: {result.Key.Name} IP: {result.Key.Add}");
                        logMwrongsGridView.Rows[rowIndex].Tag = result.Key.Id; // 将ID存储在行的Tag属性中
                        DataGridViewButtonCell editButtonCell = (DataGridViewButtonCell)logMwrongsGridView.Rows[rowIndex].Cells["check"];
                        editButtonCell.Value = "查看";

                        // 添加到日志文件
                        directoryStructure.LogMessage($"时间: {formattedTime} Ping不通过！！！ 名称: {result.Key.Name} IP: {result.Key.Add}");
                        read_write.UpdateXmlRecord(new Address(result.Key.Id, result.Key.Work, result.Key.Name, result.Key.Add, result.Key.Count + 1));
                        PlayAlarmSound();
                    }
                }
            }

        }


        // 处理DataGridView中的按钮点击事件
        private void logMwrongsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            read_write read_Write = new read_write();
            int? id = null;

            if (e.ColumnIndex == logMwrongsGridView.Columns["check"].Index && e.RowIndex >= 0)
            {
                id = (int)logMwrongsGridView.Rows[e.RowIndex].Tag;
                errorDetails errorDetails = new errorDetails(id);
                errorDetails.ShowDialog();
            }
        }

        private void logMbutton_Click(object sender, EventArgs e)
        {
            directoryStructure directoryStructure = new directoryStructure();
            directoryStructure.OpenDirectory();
        }

        private void logMwrongsClearbutton_Click(object sender, EventArgs e)
        {
            // 清除现有项
            logMwrongsGridView.Rows.Clear();
            //logMwrongsGridView.Columns.Clear();
        }

        private void warningbutton_Click(object sender, EventArgs e)
        {
            if (warningbutton.Text == "关闭告警器")
            {
                warningbutton.Text = "开启告警器";
                open = 0;
            }
            else
            {
                warningbutton.Text = "关闭告警器";
                open = 1;
            }
        }

        private void PlayAlarmSound()
        {
            if (open == 1)
            {
                // 获取当前程序集
                Assembly assembly = Assembly.GetExecutingAssembly();

                // 构建嵌入资源的名称
                string resourceName = "monitoring_network.Resources.warning.wav";

                // 从嵌入资源中读取音频数据
                using (Stream stream = assembly.GetManifestResourceStream(resourceName))
                {
                    if (stream == null)
                    {
                        return;
                    }

                    using (SoundPlayer player = new SoundPlayer(stream))
                    {
                        player.PlaySync();
                    }
                }
            }
        }




        // 填充DataGridView
        private void FillDataGridView()
        {
            // 添加列
            logMwrongsGridView.Columns.Add("wrongs", "错 误 信 息");

            // 添加按钮列
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn
            {
                Name = "check",
                HeaderText = "操 作",
                UseColumnTextForButtonValue = false, // 禁用使用列文本作为按钮值
                FlatStyle = FlatStyle.Flat,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None, // 设置为不自动调整大小
                Width = 80 // 设置列宽
            };
            logMwrongsGridView.Columns.Add(buttonColumn);
        }
    }
}



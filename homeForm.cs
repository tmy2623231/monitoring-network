using monitoring_for_Airport_network.controller;
using MonitoringForAirportNetwork.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace monitoring_for_Airport_network
{
    public partial class homeForm : Form
    {
        // 鼠标消息常量，用于实现窗口拖动
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

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
    }
}



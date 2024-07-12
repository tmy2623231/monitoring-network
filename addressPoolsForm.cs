using monitoring_for_Airport_network.controller;
using MonitoringForAirportNetwork.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace monitoring_for_Airport_network
{
    public partial class addressPoolsForm : Form
    {
        private Action refreshCallback;  // 回调函数，用于刷新主界面
        private int? Id;  // 地址池ID，null表示添加新记录
        private const int WM_NCLBUTTONDOWN = 0xA1;  // Windows消息常量，表示鼠标左键按下
        private const int HT_CAPTION = 0x2;  // Windows消息常量，表示鼠标在标题栏

        // 引入 Windows API 函数，用于实现窗口拖动
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        public addressPoolsForm(Action refreshCallback, string Text, int? id)
        {
            InitializeComponent();
            Id = id;
            this.refreshCallback = refreshCallback;
            CenterToScreen();
            SetLabelText(Text);
        }

        // 窗口拖动事件处理
        private void addressPools_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        // 返回按钮点击事件处理
        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 保存按钮点击事件处理
        private void Save_Click(object sender, EventArgs e)
        {
            if (Id == null)
            {
                SaveRecord(false);
            }
            else
            {
                SaveRecord(true);
            }
        }

        // 设置标签文本，根据不同操作类型（添加/修改）
        private void SetLabelText(string Text)
        {
            if (Text == "add")
            {
                label1.Text = "添加地址池中的IP";
            }
            else if (Text == "update")
            {
                label1.Text = "修改地址池中的IP";
                LoadRecordById(Id);
            }
            else
            {
                label1.Text = "错误！！！！";
            }
        }

        // 根据ID加载记录
        private void LoadRecordById(int? id)
        {
            if (id != null)
            {
                read_write read_Write = new read_write();
                Address? address = read_Write.GetAddressById(id.ToString());
                if (address != null)
                {
                    IDtext.Text = address.Id.ToString();
                    nameTextBox.Text = address.Name;
                    addTextBox.Text = address.Add;
                }
                else
                {
                    MessageBox.Show("数据有误！请联系管理员！", "系统提示");
                }
            }
        }
        // 保存记录，isUpdate表示是更新还是添加
        private void SaveRecord(bool isUpdate)
        {
            if (!ValidateInputs(out string errorMessage))
            {
                MessageBox.Show(errorMessage, "系统提示");
                return;
            }

            Address address = new Address(Id, 1, nameTextBox.Text, addTextBox.Text,0);
            read_write read_Write = new read_write();
            bool result = isUpdate ? read_Write.UpdateXmlRecord(address) : read_Write.AddXmlRecord(address);

            if (result)
            {
                MessageBox.Show(isUpdate ? "修改成功！！" : "添加成功！！", "系统提示");
                this.Close();
                refreshCallback?.Invoke();
            }
            else
            {
                MessageBox.Show("数据有误！请联系管理员！", "系统提示");
            }
        }

        // 验证输入
        private bool ValidateInputs(out string errorMessage)
        {
            if (string.IsNullOrEmpty(nameTextBox.Text))
            {
                errorMessage = "请填写地址池名称！！！";
                return false;
            }

            if (string.IsNullOrEmpty(addTextBox.Text))
            {
                errorMessage = "请填写IP地址！！！";
                return false;
            }

            if (!IsValidIP(addTextBox.Text))
            {
                errorMessage = "输入的不是一个有效的IP地址！";
                return false;
            }

            if (!IsUniqueIP(addTextBox.Text))
            {
                errorMessage = "输入的是一个重复已有的IP地址！";
                return false;
            }

            errorMessage = string.Empty;
            return true;
        }

        // 验证IP地址是否合法
        private bool IsValidIP(string ipAddress)
        {
            string pattern = @"^((25[0-5]|2[0-4][0-9]|[0-1]?[0-9][0-9]?)\.){3}(25[0-5]|2[0-4][0-9]|[0-1]?[0-9][0-9]?)$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(ipAddress);
        }

        // 验证IP地址是否唯一
        private bool IsUniqueIP(string ipAddress)
        {
            read_write read_Write = new read_write();
            List<Address> addresses = read_Write.ReadXmlRecords();
            return addresses.All(a => a.Add != ipAddress);
        }

    }
}

using monitoring_network.controller;
using monitoring_network.DAL;
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

namespace monitoring_network
{
    public partial class errorDetails : Form
    {
        public errorDetails(int? id)
        {
            InitializeComponent();
            CenterToScreen();
            LoadRecordById(id);
        }

        private const int WM_NCLBUTTONDOWN = 0xA1;  // Windows消息常量，表示鼠标左键按下
        private const int HT_CAPTION = 0x2;  // Windows消息常量，表示鼠标在标题栏

        // 引入 Windows API 函数，用于实现窗口拖动
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

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

        // 根据ID加载记录
        private void LoadRecordById(int? id)
        {
            if (id != null)
            {
                read_write read_Write = new read_write();
                Address? address = read_Write.GetAddressById(id.ToString());
                if (address != null)
                {
                    idlabel.Text = address.Id.ToString();
                    namelabel.Text = address.Name;
                    addlabel.Text = address.Add;
                }
                else
                {
                    MessageBox.Show("数据有误！请联系管理员！", "系统提示");
                    this.Close();
                }
            }
        }
    }
}

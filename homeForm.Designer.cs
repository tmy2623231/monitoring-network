namespace monitoring_for_Airport_network
{
    partial class homeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            addressPools = new Button();
            quit = new Button();
            homeLabel = new Label();
            addPoolsWindowPanel = new Panel();
            logMWindowPanel = new Panel();
            packetLossRateWindowPanel = new Panel();
            frequency = new Label();
            packetLossRatelabel = new Label();
            packetLossRatelistBox = new ListBox();
            logMwrongs = new Label();
            logMwrongslistBox = new ListBox();
            logMlabel = new Label();
            logMlistBox = new ListBox();
            Unit = new Label();
            logMCycleTime = new Label();
            logMwrongsClearbutton = new Button();
            logMbutton = new Button();
            warningbutton = new Button();
            begin = new Button();
            logMTime = new ComboBox();
            addPoolsDataGridView = new DataGridView();
            addPoolsB = new Button();
            logMB = new Button();
            packetLossRateB = new Button();
            readwriteBindingSource = new BindingSource(components);
            readwriteBindingSource1 = new BindingSource(components);
            addPoolsWindowPanel.SuspendLayout();
            logMWindowPanel.SuspendLayout();
            packetLossRateWindowPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)addPoolsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)readwriteBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)readwriteBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // addressPools
            // 
            addressPools.FlatAppearance.BorderColor = Color.Gainsboro;
            addressPools.FlatStyle = FlatStyle.Flat;
            addressPools.ForeColor = SystemColors.ControlText;
            addressPools.Location = new Point(423, 3);
            addressPools.Name = "addressPools";
            addressPools.Size = new Size(130, 40);
            addressPools.TabIndex = 1;
            addressPools.Text = "添加地址池IP";
            addressPools.UseVisualStyleBackColor = true;
            addressPools.Click += addressPools_Click;
            // 
            // quit
            // 
            quit.FlatAppearance.BorderColor = Color.Gainsboro;
            quit.FlatStyle = FlatStyle.Flat;
            quit.ForeColor = SystemColors.ControlText;
            quit.Location = new Point(400, 738);
            quit.Name = "quit";
            quit.Size = new Size(180, 50);
            quit.TabIndex = 1;
            quit.Text = "退  出";
            quit.UseVisualStyleBackColor = true;
            quit.Click += quit_Click;
            // 
            // homeLabel
            // 
            homeLabel.AutoSize = true;
            homeLabel.Font = new Font("Microsoft YaHei UI", 25F);
            homeLabel.Location = new Point(200, 30);
            homeLabel.Name = "homeLabel";
            homeLabel.Size = new Size(224, 45);
            homeLabel.TabIndex = 2;
            homeLabel.Text = "机场网络监控";
            // 
            // addPoolsWindowPanel
            // 
            addPoolsWindowPanel.Controls.Add(addPoolsDataGridView);
            addPoolsWindowPanel.Controls.Add(addressPools);
            addPoolsWindowPanel.Location = new Point(10, 146);
            addPoolsWindowPanel.Name = "addPoolsWindowPanel";
            addPoolsWindowPanel.Size = new Size(570, 580);
            addPoolsWindowPanel.TabIndex = 7;
            addPoolsWindowPanel.Visible = false;
            // 
            // logMWindowPanel
            // 
            logMWindowPanel.Controls.Add(logMwrongs);
            logMWindowPanel.Controls.Add(logMwrongslistBox);
            logMWindowPanel.Controls.Add(logMlabel);
            logMWindowPanel.Controls.Add(logMlistBox);
            logMWindowPanel.Controls.Add(Unit);
            logMWindowPanel.Controls.Add(logMCycleTime);
            logMWindowPanel.Controls.Add(logMwrongsClearbutton);
            logMWindowPanel.Controls.Add(logMbutton);
            logMWindowPanel.Controls.Add(warningbutton);
            logMWindowPanel.Controls.Add(begin);
            logMWindowPanel.Controls.Add(logMTime);
            logMWindowPanel.Location = new Point(12, 143);
            logMWindowPanel.Name = "logMWindowPanel";
            logMWindowPanel.Size = new Size(570, 580);
            logMWindowPanel.TabIndex = 9;
            // 
            // packetLossRateWindowPanel
            // 
            packetLossRateWindowPanel.Controls.Add(frequency);
            packetLossRateWindowPanel.Controls.Add(packetLossRatelabel);
            packetLossRateWindowPanel.Controls.Add(packetLossRatelistBox);
            packetLossRateWindowPanel.Location = new Point(9, 146);
            packetLossRateWindowPanel.Name = "packetLossRateWindowPanel";
            packetLossRateWindowPanel.Size = new Size(570, 580);
            packetLossRateWindowPanel.TabIndex = 8;
            packetLossRateWindowPanel.Visible = false;
            // 
            // frequency
            // 
            frequency.AutoSize = true;
            frequency.Location = new Point(111, 15);
            frequency.Name = "frequency";
            frequency.Size = new Size(15, 17);
            frequency.TabIndex = 17;
            frequency.Text = "0";
            // 
            // packetLossRatelabel
            // 
            packetLossRatelabel.AutoSize = true;
            packetLossRatelabel.Location = new Point(12, 15);
            packetLossRatelabel.Name = "packetLossRatelabel";
            packetLossRatelabel.Size = new Size(104, 17);
            packetLossRatelabel.TabIndex = 16;
            packetLossRatelabel.Text = "本次巡检总次数：";
            // 
            // packetLossRatelistBox
            // 
            packetLossRatelistBox.BackColor = SystemColors.Control;
            packetLossRatelistBox.BorderStyle = BorderStyle.None;
            packetLossRatelistBox.FormattingEnabled = true;
            packetLossRatelistBox.ItemHeight = 17;
            packetLossRatelistBox.Location = new Point(3, 49);
            packetLossRatelistBox.Name = "packetLossRatelistBox";
            packetLossRatelistBox.Size = new Size(550, 493);
            packetLossRatelistBox.TabIndex = 14;
            // 
            // logMwrongs
            // 
            logMwrongs.AutoSize = true;
            logMwrongs.Location = new Point(6, 370);
            logMwrongs.Name = "logMwrongs";
            logMwrongs.Size = new Size(140, 17);
            logMwrongs.TabIndex = 17;
            logMwrongs.Text = "运行期间循行失败记录：";
            // 
            // logMwrongslistBox
            // 
            logMwrongslistBox.BackColor = SystemColors.Control;
            logMwrongslistBox.BorderStyle = BorderStyle.None;
            logMwrongslistBox.FormattingEnabled = true;
            logMwrongslistBox.ItemHeight = 17;
            logMwrongslistBox.Location = new Point(3, 395);
            logMwrongslistBox.Name = "logMwrongslistBox";
            logMwrongslistBox.Size = new Size(550, 136);
            logMwrongslistBox.TabIndex = 16;
            // 
            // logMlabel
            // 
            logMlabel.AutoSize = true;
            logMlabel.Location = new Point(241, 554);
            logMlabel.Name = "logMlabel";
            logMlabel.Size = new Size(176, 17);
            logMlabel.TabIndex = 15;
            logMlabel.Text = "停止巡检后，激活日志目录按钮";
            logMlabel.Visible = false;
            // 
            // logMlistBox
            // 
            logMlistBox.BackColor = SystemColors.Control;
            logMlistBox.BorderStyle = BorderStyle.None;
            logMlistBox.FormattingEnabled = true;
            logMlistBox.ItemHeight = 17;
            logMlistBox.Location = new Point(3, 49);
            logMlistBox.Name = "logMlistBox";
            logMlistBox.Size = new Size(550, 306);
            logMlistBox.TabIndex = 14;
            // 
            // Unit
            // 
            Unit.AutoSize = true;
            Unit.Location = new Point(165, 15);
            Unit.Name = "Unit";
            Unit.Size = new Size(20, 17);
            Unit.TabIndex = 13;
            Unit.Text = "秒";
            // 
            // logMCycleTime
            // 
            logMCycleTime.AutoSize = true;
            logMCycleTime.Location = new Point(11, 15);
            logMCycleTime.Name = "logMCycleTime";
            logMCycleTime.Size = new Size(92, 17);
            logMCycleTime.TabIndex = 12;
            logMCycleTime.Text = "巡检循环时间：";
            // 
            // logMwrongsClearbutton
            // 
            logMwrongsClearbutton.FlatAppearance.BorderColor = Color.Gainsboro;
            logMwrongsClearbutton.FlatStyle = FlatStyle.Flat;
            logMwrongsClearbutton.ForeColor = SystemColors.ControlText;
            logMwrongsClearbutton.Location = new Point(423, 364);
            logMwrongsClearbutton.Name = "logMwrongsClearbutton";
            logMwrongsClearbutton.Size = new Size(130, 29);
            logMwrongsClearbutton.TabIndex = 1;
            logMwrongsClearbutton.Text = "清除错误日志";
            logMwrongsClearbutton.UseVisualStyleBackColor = true;
            logMwrongsClearbutton.Click += logMwrongsClearbutton_Click;
            // 
            // logMbutton
            // 
            logMbutton.FlatAppearance.BorderColor = Color.Gainsboro;
            logMbutton.FlatStyle = FlatStyle.Flat;
            logMbutton.ForeColor = SystemColors.ControlText;
            logMbutton.Location = new Point(423, 548);
            logMbutton.Name = "logMbutton";
            logMbutton.Size = new Size(130, 29);
            logMbutton.TabIndex = 1;
            logMbutton.Text = "打开日志目录";
            logMbutton.UseVisualStyleBackColor = true;
            logMbutton.Click += logMbutton_Click;
            // 
            // warningbutton
            // 
            warningbutton.FlatAppearance.BorderColor = Color.Gainsboro;
            warningbutton.FlatStyle = FlatStyle.Flat;
            warningbutton.ForeColor = SystemColors.ControlText;
            warningbutton.Location = new Point(191, 9);
            warningbutton.Name = "warningbutton";
            warningbutton.Size = new Size(84, 28);
            warningbutton.TabIndex = 1;
            warningbutton.Text = "开启告警器";
            warningbutton.UseVisualStyleBackColor = true;
            warningbutton.Visible = false;
            warningbutton.Click += warningbutton_Click;
            // 
            // begin
            // 
            begin.FlatAppearance.BorderColor = Color.Gainsboro;
            begin.FlatStyle = FlatStyle.Flat;
            begin.ForeColor = SystemColors.ControlText;
            begin.Location = new Point(423, 3);
            begin.Name = "begin";
            begin.Size = new Size(130, 40);
            begin.TabIndex = 1;
            begin.Text = "开 始 巡 检";
            begin.UseVisualStyleBackColor = true;
            begin.Click += begin_Click;
            // 
            // logMTime
            // 
            logMTime.DropDownStyle = ComboBoxStyle.DropDownList;
            logMTime.FormattingEnabled = true;
            logMTime.Items.AddRange(new object[] { "5", "10", "15", "20", "25", "30" });
            logMTime.Location = new Point(109, 12);
            logMTime.Name = "logMTime";
            logMTime.Size = new Size(50, 25);
            logMTime.TabIndex = 11;
            // 
            // addPoolsDataGridView
            // 
            addPoolsDataGridView.AllowUserToAddRows = false;
            addPoolsDataGridView.AllowUserToDeleteRows = false;
            addPoolsDataGridView.AllowUserToResizeColumns = false;
            addPoolsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            addPoolsDataGridView.BackgroundColor = SystemColors.Control;
            addPoolsDataGridView.BorderStyle = BorderStyle.None;
            addPoolsDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            addPoolsDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft YaHei UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            addPoolsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            addPoolsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Microsoft YaHei UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            addPoolsDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            addPoolsDataGridView.EnableHeadersVisualStyles = false;
            addPoolsDataGridView.GridColor = SystemColors.Control;
            addPoolsDataGridView.Location = new Point(3, 49);
            addPoolsDataGridView.Name = "addPoolsDataGridView";
            addPoolsDataGridView.ReadOnly = true;
            addPoolsDataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            addPoolsDataGridView.RowHeadersVisible = false;
            addPoolsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            addPoolsDataGridView.Size = new Size(550, 493);
            addPoolsDataGridView.TabIndex = 10;
            addPoolsDataGridView.CellContentClick += addPoolsDataGridView_CellContentClick;
            // 
            // addPoolsB
            // 
            addPoolsB.FlatAppearance.BorderColor = Color.Gainsboro;
            addPoolsB.FlatStyle = FlatStyle.Flat;
            addPoolsB.ForeColor = SystemColors.ControlText;
            addPoolsB.Location = new Point(10, 100);
            addPoolsB.Name = "addPoolsB";
            addPoolsB.Size = new Size(130, 40);
            addPoolsB.TabIndex = 1;
            addPoolsB.Text = "地址池共有0个IP";
            addPoolsB.UseVisualStyleBackColor = true;
            addPoolsB.Click += addPoolsB_Click;
            // 
            // logMB
            // 
            logMB.BackColor = Color.LightGray;
            logMB.FlatAppearance.BorderColor = Color.Gainsboro;
            logMB.FlatStyle = FlatStyle.Flat;
            logMB.ForeColor = SystemColors.ControlText;
            logMB.Location = new Point(146, 101);
            logMB.Name = "logMB";
            logMB.Size = new Size(130, 40);
            logMB.TabIndex = 1;
            logMB.Text = "日志信息";
            logMB.UseVisualStyleBackColor = false;
            logMB.Click += logMB_Click;
            // 
            // packetLossRateB
            // 
            packetLossRateB.FlatAppearance.BorderColor = Color.Gainsboro;
            packetLossRateB.FlatStyle = FlatStyle.Flat;
            packetLossRateB.ForeColor = SystemColors.ControlText;
            packetLossRateB.Location = new Point(282, 100);
            packetLossRateB.Name = "packetLossRateB";
            packetLossRateB.Size = new Size(130, 40);
            packetLossRateB.TabIndex = 1;
            packetLossRateB.Text = "故障统计";
            packetLossRateB.UseVisualStyleBackColor = true;
            packetLossRateB.Click += packetLossRateB_Click;
            // 
            // readwriteBindingSource
            // 
            readwriteBindingSource.DataSource = typeof(controller.read_write);
            // 
            // readwriteBindingSource1
            // 
            readwriteBindingSource1.DataSource = typeof(controller.read_write);
            // 
            // homeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 800);
            ControlBox = false;
            Controls.Add(packetLossRateWindowPanel);
            Controls.Add(logMWindowPanel);
            Controls.Add(addPoolsWindowPanel);
            Controls.Add(homeLabel);
            Controls.Add(packetLossRateB);
            Controls.Add(logMB);
            Controls.Add(addPoolsB);
            Controls.Add(quit);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "homeForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "homeForm";
            MouseDown += homeForm_MouseDown;
            addPoolsWindowPanel.ResumeLayout(false);
            logMWindowPanel.ResumeLayout(false);
            logMWindowPanel.PerformLayout();
            packetLossRateWindowPanel.ResumeLayout(false);
            packetLossRateWindowPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)addPoolsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)readwriteBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)readwriteBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button addressPools;
        private Button quit;
        private Label homeLabel;
        private Panel addPoolsWindowPanel;
        private Panel packetLossRateWindowPanel;
        private Panel logMWindowPanel;
        private Button addPoolsB;
        private Button logMB;
        private Button packetLossRateB;
        private BindingSource readwriteBindingSource;
        private BindingSource readwriteBindingSource1;
        private DataGridView addPoolsDataGridView;
        private Label logMCycleTime;
        private ComboBox logMTime;
        private Label Unit;
        private Button begin;
        private ListBox logMlistBox;
        private ListBox packetLossRatelistBox;
        private Label frequency;
        private Label packetLossRatelabel;
        private Button logMbutton;
        private Label logMlabel;
        private ListBox logMwrongslistBox;
        private Label logMwrongs;
        private Button logMwrongsClearbutton;
        private Button warningbutton;
    }
}
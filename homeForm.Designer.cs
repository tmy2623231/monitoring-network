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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            addressPools = new Button();
            quit = new Button();
            homeLabel = new Label();
            addPoolsWindowPanel = new Panel();
            addPoolsDataGridView = new DataGridView();
            logMWindowPanel = new Panel();
            logMCycleTime = new Label();
            comboBox1 = new ComboBox();
            logMdataGridView = new DataGridView();
            packetLossRateWindowPanel = new Panel();
            packetLossRatedataGridView = new DataGridView();
            addPoolsB = new Button();
            logMB = new Button();
            packetLossRateB = new Button();
            readwriteBindingSource = new BindingSource(components);
            readwriteBindingSource1 = new BindingSource(components);
            Unit = new Label();
            addPoolsWindowPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)addPoolsDataGridView).BeginInit();
            logMWindowPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logMdataGridView).BeginInit();
            packetLossRateWindowPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)packetLossRatedataGridView).BeginInit();
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
            // logMWindowPanel
            // 
            logMWindowPanel.Controls.Add(Unit);
            logMWindowPanel.Controls.Add(logMCycleTime);
            logMWindowPanel.Controls.Add(comboBox1);
            logMWindowPanel.Controls.Add(logMdataGridView);
            logMWindowPanel.Location = new Point(594, 146);
            logMWindowPanel.Name = "logMWindowPanel";
            logMWindowPanel.Size = new Size(570, 580);
            logMWindowPanel.TabIndex = 9;
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
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(109, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(56, 25);
            comboBox1.TabIndex = 11;
            // 
            // logMdataGridView
            // 
            logMdataGridView.AllowUserToAddRows = false;
            logMdataGridView.AllowUserToDeleteRows = false;
            logMdataGridView.AllowUserToResizeColumns = false;
            logMdataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            logMdataGridView.BackgroundColor = SystemColors.Control;
            logMdataGridView.BorderStyle = BorderStyle.None;
            logMdataGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            logMdataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Microsoft YaHei UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            logMdataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            logMdataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Microsoft YaHei UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            logMdataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            logMdataGridView.EnableHeadersVisualStyles = false;
            logMdataGridView.GridColor = SystemColors.Control;
            logMdataGridView.Location = new Point(3, 84);
            logMdataGridView.Name = "logMdataGridView";
            logMdataGridView.ReadOnly = true;
            logMdataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            logMdataGridView.RowHeadersVisible = false;
            logMdataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            logMdataGridView.Size = new Size(550, 493);
            logMdataGridView.TabIndex = 10;
            // 
            // packetLossRateWindowPanel
            // 
            packetLossRateWindowPanel.Controls.Add(packetLossRatedataGridView);
            packetLossRateWindowPanel.Location = new Point(1181, 146);
            packetLossRateWindowPanel.Name = "packetLossRateWindowPanel";
            packetLossRateWindowPanel.Size = new Size(570, 580);
            packetLossRateWindowPanel.TabIndex = 8;
            packetLossRateWindowPanel.Visible = false;
            // 
            // packetLossRatedataGridView
            // 
            packetLossRatedataGridView.AllowUserToAddRows = false;
            packetLossRatedataGridView.AllowUserToDeleteRows = false;
            packetLossRatedataGridView.AllowUserToResizeColumns = false;
            packetLossRatedataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            packetLossRatedataGridView.BackgroundColor = SystemColors.Control;
            packetLossRatedataGridView.BorderStyle = BorderStyle.None;
            packetLossRatedataGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            packetLossRatedataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Microsoft YaHei UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            packetLossRatedataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            packetLossRatedataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Microsoft YaHei UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            packetLossRatedataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            packetLossRatedataGridView.EnableHeadersVisualStyles = false;
            packetLossRatedataGridView.GridColor = SystemColors.Control;
            packetLossRatedataGridView.Location = new Point(3, 28);
            packetLossRatedataGridView.Name = "packetLossRatedataGridView";
            packetLossRatedataGridView.ReadOnly = true;
            packetLossRatedataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            packetLossRatedataGridView.RowHeadersVisible = false;
            packetLossRatedataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            packetLossRatedataGridView.Size = new Size(550, 493);
            packetLossRatedataGridView.TabIndex = 10;
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
            packetLossRateB.Text = "丢包率";
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
            // Unit
            // 
            Unit.AutoSize = true;
            Unit.Location = new Point(171, 15);
            Unit.Name = "Unit";
            Unit.Size = new Size(20, 17);
            Unit.TabIndex = 13;
            Unit.Text = "秒";
            // 
            // homeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1824, 800);
            ControlBox = false;
            Controls.Add(logMWindowPanel);
            Controls.Add(packetLossRateWindowPanel);
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
            ((System.ComponentModel.ISupportInitialize)addPoolsDataGridView).EndInit();
            logMWindowPanel.ResumeLayout(false);
            logMWindowPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logMdataGridView).EndInit();
            packetLossRateWindowPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)packetLossRatedataGridView).EndInit();
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
        private DataGridView logMdataGridView;
        private DataGridView packetLossRatedataGridView;
        private Label logMCycleTime;
        private ComboBox comboBox1;
        private Label Unit;
    }
}
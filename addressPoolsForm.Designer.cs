namespace monitoring_for_Airport_network
{
    partial class addressPoolsForm
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
            Save = new Button();
            back = new Button();
            label1 = new Label();
            id = new Label();
            name = new Label();
            add = new Label();
            IDtext = new Label();
            nameTextBox = new TextBox();
            addTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // Save
            // 
            Save.FlatAppearance.BorderColor = Color.Gainsboro;
            Save.FlatStyle = FlatStyle.Flat;
            Save.ForeColor = SystemColors.ControlText;
            Save.Location = new Point(408, 738);
            Save.Name = "Save";
            Save.Size = new Size(180, 50);
            Save.TabIndex = 3;
            Save.Text = "保   存";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // back
            // 
            back.FlatAppearance.BorderColor = Color.Gainsboro;
            back.FlatStyle = FlatStyle.Flat;
            back.ForeColor = SystemColors.ControlText;
            back.Location = new Point(12, 738);
            back.Name = "back";
            back.Size = new Size(180, 50);
            back.TabIndex = 4;
            back.Text = "返   回";
            back.UseVisualStyleBackColor = true;
            back.Click += back_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 25F);
            label1.Location = new Point(149, 38);
            label1.Name = "label1";
            label1.Size = new Size(122, 45);
            label1.TabIndex = 5;
            label1.Text = "地址池";
            // 
            // id
            // 
            id.AutoSize = true;
            id.Location = new Point(108, 245);
            id.Name = "id";
            id.Size = new Size(24, 17);
            id.TabIndex = 6;
            id.Text = "ID:";
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new Point(61, 349);
            name.Name = "name";
            name.Size = new Size(71, 17);
            name.TabIndex = 7;
            name.Text = "地址池名称:";
            // 
            // add
            // 
            add.AutoSize = true;
            add.Location = new Point(86, 472);
            add.Name = "add";
            add.Size = new Size(46, 17);
            add.TabIndex = 8;
            add.Text = "IP地址:";
            // 
            // IDtext
            // 
            IDtext.AutoSize = true;
            IDtext.Location = new Point(183, 244);
            IDtext.Name = "IDtext";
            IDtext.Size = new Size(45, 17);
            IDtext.TabIndex = 9;
            IDtext.Text = "自增ID";
            // 
            // nameTextBox
            // 
            nameTextBox.BorderStyle = BorderStyle.None;
            nameTextBox.Location = new Point(183, 346);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(321, 16);
            nameTextBox.TabIndex = 10;
            // 
            // addTextBox
            // 
            addTextBox.BorderStyle = BorderStyle.None;
            addTextBox.Location = new Point(183, 473);
            addTextBox.Name = "addTextBox";
            addTextBox.Size = new Size(321, 16);
            addTextBox.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(183, 384);
            label2.Name = "label2";
            label2.Size = new Size(140, 17);
            label2.TabIndex = 11;
            label2.Text = "(请输入名称，不能为空!)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(183, 505);
            label3.Name = "label3";
            label3.Size = new Size(127, 17);
            label3.TabIndex = 12;
            label3.Text = "(请输入IP，不能为空!)";
            // 
            // addressPoolsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 800);
            ControlBox = false;
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(addTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(IDtext);
            Controls.Add(add);
            Controls.Add(name);
            Controls.Add(id);
            Controls.Add(label1);
            Controls.Add(Save);
            Controls.Add(back);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "addressPoolsForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "addressPoolsForm";
            MouseDown += addressPools_MouseDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Save;
        private Button back;
        private Label label1;
        private Label id;
        private Label name;
        private Label add;
        private Label IDtext;
        private TextBox nameTextBox;
        private TextBox addTextBox;
        private Label label2;
        private Label label3;
    }
}
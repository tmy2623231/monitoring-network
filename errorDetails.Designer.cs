namespace monitoring_network
{
    partial class errorDetails
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
            label1 = new Label();
            add = new Label();
            name = new Label();
            id = new Label();
            label2 = new Label();
            back = new Button();
            idlabel = new Label();
            namelabel = new Label();
            addlabel = new Label();
            errorText = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 25F);
            label1.Location = new Point(174, 43);
            label1.Name = "label1";
            label1.Size = new Size(224, 45);
            label1.TabIndex = 6;
            label1.Text = "网络错误路径";
            // 
            // add
            // 
            add.AutoSize = true;
            add.Location = new Point(81, 205);
            add.Name = "add";
            add.Size = new Size(46, 17);
            add.TabIndex = 11;
            add.Text = "IP地址:";
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new Point(56, 170);
            name.Name = "name";
            name.Size = new Size(71, 17);
            name.TabIndex = 10;
            name.Text = "地址池名称:";
            // 
            // id
            // 
            id.AutoSize = true;
            id.Location = new Point(103, 139);
            id.Name = "id";
            id.Size = new Size(24, 17);
            id.TabIndex = 9;
            id.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 7F, FontStyle.Regular, GraphicsUnit.Millimeter);
            label2.Location = new Point(167, 274);
            label2.Name = "label2";
            label2.Size = new Size(231, 35);
            label2.TabIndex = 12;
            label2.Text = "错误日志详细路径";
            // 
            // back
            // 
            back.FlatAppearance.BorderColor = Color.Gainsboro;
            back.FlatStyle = FlatStyle.Flat;
            back.ForeColor = SystemColors.ControlText;
            back.Location = new Point(392, 699);
            back.Name = "back";
            back.Size = new Size(180, 50);
            back.TabIndex = 14;
            back.Text = "返   回";
            back.UseVisualStyleBackColor = true;
            back.Click += back_Click;
            // 
            // idlabel
            // 
            idlabel.AutoSize = true;
            idlabel.Location = new Point(133, 139);
            idlabel.Name = "idlabel";
            idlabel.Size = new Size(43, 17);
            idlabel.TabIndex = 16;
            idlabel.Text = "label3";
            // 
            // namelabel
            // 
            namelabel.AutoSize = true;
            namelabel.Location = new Point(133, 170);
            namelabel.Name = "namelabel";
            namelabel.Size = new Size(43, 17);
            namelabel.TabIndex = 16;
            namelabel.Text = "label3";
            // 
            // addlabel
            // 
            addlabel.AutoSize = true;
            addlabel.Location = new Point(132, 205);
            addlabel.Name = "addlabel";
            addlabel.Size = new Size(43, 17);
            addlabel.TabIndex = 16;
            addlabel.Text = "label3";
            // 
            // errorText
            // 
            errorText.AutoSize = true;
            errorText.Location = new Point(56, 329);
            errorText.Name = "errorText";
            errorText.Size = new Size(39, 17);
            errorText.TabIndex = 17;
            errorText.Text = "NULL";
            // 
            // errorDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 761);
            ControlBox = false;
            Controls.Add(errorText);
            Controls.Add(addlabel);
            Controls.Add(namelabel);
            Controls.Add(idlabel);
            Controls.Add(back);
            Controls.Add(label2);
            Controls.Add(add);
            Controls.Add(name);
            Controls.Add(id);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "errorDetails";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "errorDetails";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label add;
        private Label name;
        private Label id;
        private Label label2;
        private Button back;
        private Label idlabel;
        private Label namelabel;
        private Label addlabel;
        private Label errorText;
    }
}
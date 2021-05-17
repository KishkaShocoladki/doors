namespace doors
{
    partial class main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboPanel = new System.Windows.Forms.Panel();
            this.passTB = new System.Windows.Forms.TextBox();
            this.loginTB = new System.Windows.Forms.TextBox();
            this.passLbl = new System.Windows.Forms.Label();
            this.loginLBL = new System.Windows.Forms.Label();
            this.adminBtn = new System.Windows.Forms.Button();
            this.modelLabel = new System.Windows.Forms.Label();
            this.modelComboBox = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.doorsPanel = new System.Windows.Forms.Panel();
            this.comboPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboPanel
            // 
            this.comboPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(210)))));
            this.comboPanel.Controls.Add(this.passTB);
            this.comboPanel.Controls.Add(this.loginTB);
            this.comboPanel.Controls.Add(this.passLbl);
            this.comboPanel.Controls.Add(this.loginLBL);
            this.comboPanel.Controls.Add(this.adminBtn);
            this.comboPanel.Controls.Add(this.modelLabel);
            this.comboPanel.Controls.Add(this.modelComboBox);
            this.comboPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboPanel.Location = new System.Drawing.Point(0, 0);
            this.comboPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboPanel.Name = "comboPanel";
            this.comboPanel.Size = new System.Drawing.Size(931, 44);
            this.comboPanel.TabIndex = 0;
            this.comboPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.comboPanel_Paint);
            // 
            // passTB
            // 
            this.passTB.Location = new System.Drawing.Point(708, 9);
            this.passTB.Name = "passTB";
            this.passTB.Size = new System.Drawing.Size(125, 27);
            this.passTB.TabIndex = 9;
            this.passTB.UseSystemPasswordChar = true;
            this.passTB.Visible = false;
            // 
            // loginTB
            // 
            this.loginTB.Location = new System.Drawing.Point(509, 9);
            this.loginTB.Name = "loginTB";
            this.loginTB.Size = new System.Drawing.Size(125, 27);
            this.loginTB.TabIndex = 8;
            this.loginTB.Visible = false;
            // 
            // passLbl
            // 
            this.passLbl.AutoSize = true;
            this.passLbl.Location = new System.Drawing.Point(640, 12);
            this.passLbl.Name = "passLbl";
            this.passLbl.Size = new System.Drawing.Size(62, 20);
            this.passLbl.TabIndex = 7;
            this.passLbl.Text = "Пароль";
            this.passLbl.Visible = false;
            // 
            // loginLBL
            // 
            this.loginLBL.AutoSize = true;
            this.loginLBL.Location = new System.Drawing.Point(451, 16);
            this.loginLBL.Name = "loginLBL";
            this.loginLBL.Size = new System.Drawing.Size(52, 20);
            this.loginLBL.TabIndex = 6;
            this.loginLBL.Text = "Логин";
            this.loginLBL.Visible = false;
            // 
            // adminBtn
            // 
            this.adminBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.adminBtn.Location = new System.Drawing.Point(839, 0);
            this.adminBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.adminBtn.Name = "adminBtn";
            this.adminBtn.Size = new System.Drawing.Size(92, 44);
            this.adminBtn.TabIndex = 5;
            this.adminBtn.Text = "admin";
            this.adminBtn.UseVisualStyleBackColor = true;
            this.adminBtn.Visible = false;
            this.adminBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.modelLabel.Location = new System.Drawing.Point(12, 9);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(63, 20);
            this.modelLabel.TabIndex = 1;
            this.modelLabel.Text = "Модель";
            this.modelLabel.Click += new System.EventHandler(this.modelLabel_Click);
            // 
            // modelComboBox
            // 
            this.modelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modelComboBox.FormattingEnabled = true;
            this.modelComboBox.Location = new System.Drawing.Point(81, 9);
            this.modelComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.modelComboBox.Name = "modelComboBox";
            this.modelComboBox.Size = new System.Drawing.Size(231, 28);
            this.modelComboBox.TabIndex = 0;
            this.modelComboBox.SelectedIndexChanged += new System.EventHandler(this.modelComboBox_SelectedIndexChanged);
            // 
            // doorsPanel
            // 
            this.doorsPanel.AutoScroll = true;
            this.doorsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.doorsPanel.Location = new System.Drawing.Point(0, 44);
            this.doorsPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.doorsPanel.Name = "doorsPanel";
            this.doorsPanel.Size = new System.Drawing.Size(931, 489);
            this.doorsPanel.TabIndex = 0;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 533);
            this.Controls.Add(this.doorsPanel);
            this.Controls.Add(this.comboPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "main";
            this.Text = "двери...";
            this.Load += new System.EventHandler(this.main_Load);
            this.comboPanel.ResumeLayout(false);
            this.comboPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel comboPanel;
        private System.Windows.Forms.Panel doorsPanel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.ComboBox modelComboBox;
        private System.Windows.Forms.Button adminBtn;
        private System.Windows.Forms.TextBox passTB;
        private System.Windows.Forms.TextBox loginTB;
        private System.Windows.Forms.Label passLbl;
        private System.Windows.Forms.Label loginLBL;
    }
}


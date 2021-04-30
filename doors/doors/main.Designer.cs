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
            this.comboPanel = new System.Windows.Forms.Panel();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.doorsPanel = new System.Windows.Forms.Panel();
            this.comboPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboPanel
            // 
            this.comboPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(210)))));
            this.comboPanel.Controls.Add(this.checkBox3);
            this.comboPanel.Controls.Add(this.checkBox2);
            this.comboPanel.Controls.Add(this.checkBox1);
            this.comboPanel.Controls.Add(this.label7);
            this.comboPanel.Controls.Add(this.label6);
            this.comboPanel.Controls.Add(this.comboBox2);
            this.comboPanel.Controls.Add(this.label1);
            this.comboPanel.Controls.Add(this.comboBox1);
            this.comboPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.comboPanel.Location = new System.Drawing.Point(0, 0);
            this.comboPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboPanel.Name = "comboPanel";
            this.comboPanel.Size = new System.Drawing.Size(258, 431);
            this.comboPanel.TabIndex = 0;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(12, 304);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(82, 24);
            this.checkBox3.TabIndex = 4;
            this.checkBox3.Text = "Сборка";
            this.toolTip1.SetToolTip(this.checkBox3, "Все соберем и даже проверим");
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(13, 274);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(109, 24);
            this.checkBox2.TabIndex = 4;
            this.checkBox2.Text = "Наличники";
            this.toolTip1.SetToolTip(this.checkBox2, "Красивые наличники чтобы монтажная пена не торчала изо всех щелей");
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(13, 243);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(69, 24);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Ручка";
            this.toolTip1.SetToolTip(this.checkBox1, "Супер-ручка с замком");
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Цвет";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Ширина полотна, мм";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(13, 171);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(162, 28);
            this.comboBox2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "панелька выбора параметров дверей";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "400",
            "500",
            "600",
            "700",
            "800"});
            this.comboBox1.Location = new System.Drawing.Point(14, 105);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(162, 28);
            this.comboBox1.TabIndex = 0;
            // 
            // doorsPanel
            // 
            this.doorsPanel.AutoScroll = true;
            this.doorsPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.doorsPanel.Location = new System.Drawing.Point(265, 0);
            this.doorsPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.doorsPanel.Name = "doorsPanel";
            this.doorsPanel.Size = new System.Drawing.Size(425, 431);
            this.doorsPanel.TabIndex = 0;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 431);
            this.Controls.Add(this.doorsPanel);
            this.Controls.Add(this.comboPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "main";
            this.Text = "двери...";
            this.comboPanel.ResumeLayout(false);
            this.comboPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel comboPanel;
        private System.Windows.Forms.Panel doorsPanel;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}


namespace doors
{
    partial class AdminControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.doorsPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.NameLbl = new System.Windows.Forms.Label();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.PriceLbl = new System.Windows.Forms.Label();
            this.PriceTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ColorsCLB = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // doorsPanel
            // 
            this.doorsPanel.AutoScroll = true;
            this.doorsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.doorsPanel.Location = new System.Drawing.Point(0, 0);
            this.doorsPanel.Name = "doorsPanel";
            this.doorsPanel.Size = new System.Drawing.Size(250, 480);
            this.doorsPanel.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(300, 433);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(516, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Location = new System.Drawing.Point(285, 17);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(77, 20);
            this.NameLbl.TabIndex = 2;
            this.NameLbl.Text = "Название";
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(368, 17);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(448, 27);
            this.NameTB.TabIndex = 3;
            // 
            // PriceLbl
            // 
            this.PriceLbl.AutoSize = true;
            this.PriceLbl.Location = new System.Drawing.Point(285, 62);
            this.PriceLbl.Name = "PriceLbl";
            this.PriceLbl.Size = new System.Drawing.Size(45, 20);
            this.PriceLbl.TabIndex = 2;
            this.PriceLbl.Text = "Цена";
            // 
            // PriceTB
            // 
            this.PriceTB.Location = new System.Drawing.Point(368, 59);
            this.PriceTB.Name = "PriceTB";
            this.PriceTB.Size = new System.Drawing.Size(448, 27);
            this.PriceTB.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Цвета";
            // 
            // ColorsCLB
            // 
            this.ColorsCLB.FormattingEnabled = true;
            this.ColorsCLB.Location = new System.Drawing.Point(368, 136);
            this.ColorsCLB.Name = "ColorsCLB";
            this.ColorsCLB.Size = new System.Drawing.Size(448, 114);
            this.ColorsCLB.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Фоточка";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(368, 266);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(448, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Масса";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(368, 92);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(448, 27);
            this.textBox1.TabIndex = 3;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // AdminControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ColorsCLB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PriceTB);
            this.Controls.Add(this.PriceLbl);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.doorsPanel);
            this.Name = "AdminControl";
            this.Size = new System.Drawing.Size(860, 480);
            this.Load += new System.EventHandler(this.AdminControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel doorsPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.Label PriceLbl;
        private System.Windows.Forms.TextBox PriceTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox ColorsCLB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

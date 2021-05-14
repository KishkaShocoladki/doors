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
            this.button1 = new System.Windows.Forms.Button();
            this.assemblyChechBox = new System.Windows.Forms.CheckBox();
            this.panelsCheckBox = new System.Windows.Forms.CheckBox();
            this.handleCheckBox = new System.Windows.Forms.CheckBox();
            this.colorLabel = new System.Windows.Forms.Label();
            this.modelLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.colorComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.modelComboBox = new System.Windows.Forms.ComboBox();
            this.widthComboBox = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.doorsPanel = new System.Windows.Forms.Panel();
            this.comboPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboPanel
            // 
            this.comboPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(210)))));
            this.comboPanel.Controls.Add(this.button1);
            this.comboPanel.Controls.Add(this.assemblyChechBox);
            this.comboPanel.Controls.Add(this.panelsCheckBox);
            this.comboPanel.Controls.Add(this.handleCheckBox);
            this.comboPanel.Controls.Add(this.colorLabel);
            this.comboPanel.Controls.Add(this.modelLabel);
            this.comboPanel.Controls.Add(this.widthLabel);
            this.comboPanel.Controls.Add(this.colorComboBox);
            this.comboPanel.Controls.Add(this.label1);
            this.comboPanel.Controls.Add(this.modelComboBox);
            this.comboPanel.Controls.Add(this.widthComboBox);
            this.comboPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboPanel.Location = new System.Drawing.Point(0, 0);
            this.comboPanel.Name = "comboPanel";
            this.comboPanel.Size = new System.Drawing.Size(815, 51);
            this.comboPanel.TabIndex = 0;
            this.comboPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.comboPanel_Paint);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(751, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 22);
            this.button1.TabIndex = 5;
            this.button1.Text = "admin";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // assemblyChechBox
            // 
            this.assemblyChechBox.AutoSize = true;
            this.assemblyChechBox.Location = new System.Drawing.Point(727, 27);
            this.assemblyChechBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.assemblyChechBox.Name = "assemblyChechBox";
            this.assemblyChechBox.Size = new System.Drawing.Size(67, 19);
            this.assemblyChechBox.TabIndex = 4;
            this.assemblyChechBox.Text = "Сборка";
            this.toolTip1.SetToolTip(this.assemblyChechBox, "Все соберем и даже проверим");
            this.assemblyChechBox.UseVisualStyleBackColor = true;
            this.assemblyChechBox.CheckedChanged += new System.EventHandler(this.UpdatePrice);
            // 
            // panelsCheckBox
            // 
            this.panelsCheckBox.AutoSize = true;
            this.panelsCheckBox.Location = new System.Drawing.Point(632, 27);
            this.panelsCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelsCheckBox.Name = "panelsCheckBox";
            this.panelsCheckBox.Size = new System.Drawing.Size(89, 19);
            this.panelsCheckBox.TabIndex = 4;
            this.panelsCheckBox.Text = "Наличники";
            this.toolTip1.SetToolTip(this.panelsCheckBox, "Красивые наличники чтобы монтажная пена не торчала изо всех щелей");
            this.panelsCheckBox.UseVisualStyleBackColor = true;
            this.panelsCheckBox.CheckedChanged += new System.EventHandler(this.UpdatePrice);
            // 
            // handleCheckBox
            // 
            this.handleCheckBox.AutoSize = true;
            this.handleCheckBox.Location = new System.Drawing.Point(568, 27);
            this.handleCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.handleCheckBox.Name = "handleCheckBox";
            this.handleCheckBox.Size = new System.Drawing.Size(58, 19);
            this.handleCheckBox.TabIndex = 3;
            this.handleCheckBox.Text = "Ручка";
            this.toolTip1.SetToolTip(this.handleCheckBox, "Супер-ручка с замком");
            this.handleCheckBox.UseVisualStyleBackColor = true;
            this.handleCheckBox.CheckedChanged += new System.EventHandler(this.UpdatePrice);
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Location = new System.Drawing.Point(419, 5);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(33, 15);
            this.colorLabel.TabIndex = 2;
            this.colorLabel.Text = "Цвет";
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.modelLabel.Location = new System.Drawing.Point(123, 5);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(50, 15);
            this.modelLabel.TabIndex = 1;
            this.modelLabel.Text = "Модель";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(271, 5);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(125, 15);
            this.widthLabel.TabIndex = 1;
            this.widthLabel.Text = "Ширина полотна, мм";
            // 
            // colorComboBox
            // 
            this.colorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colorComboBox.FormattingEnabled = true;
            this.colorComboBox.Location = new System.Drawing.Point(420, 23);
            this.colorComboBox.Name = "colorComboBox";
            this.colorComboBox.Size = new System.Drawing.Size(142, 23);
            this.colorComboBox.TabIndex = 0;
            this.colorComboBox.SelectedIndexChanged += new System.EventHandler(this.colorComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(1, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "панелька выбора параметров дверей";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // modelComboBox
            // 
            this.modelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modelComboBox.FormattingEnabled = true;
            this.modelComboBox.Location = new System.Drawing.Point(124, 23);
            this.modelComboBox.Name = "modelComboBox";
            this.modelComboBox.Size = new System.Drawing.Size(142, 23);
            this.modelComboBox.TabIndex = 0;
            this.modelComboBox.SelectedIndexChanged += new System.EventHandler(this.modelComboBox_SelectedIndexChanged);
            // 
            // widthComboBox
            // 
            this.widthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.widthComboBox.FormattingEnabled = true;
            this.widthComboBox.Items.AddRange(new object[] {
            "400",
            "500",
            "600",
            "700",
            "800"});
            this.widthComboBox.Location = new System.Drawing.Point(272, 23);
            this.widthComboBox.Name = "widthComboBox";
            this.widthComboBox.Size = new System.Drawing.Size(142, 23);
            this.widthComboBox.TabIndex = 0;
            this.widthComboBox.SelectedIndexChanged += new System.EventHandler(this.UpdatePrice);
            // 
            // doorsPanel
            // 
            this.doorsPanel.AutoScroll = true;
            this.doorsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.doorsPanel.Location = new System.Drawing.Point(0, 52);
            this.doorsPanel.Name = "doorsPanel";
            this.doorsPanel.Size = new System.Drawing.Size(815, 450);
            this.doorsPanel.TabIndex = 0;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 502);
            this.Controls.Add(this.doorsPanel);
            this.Controls.Add(this.comboPanel);
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
        private System.Windows.Forms.ComboBox colorComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox widthComboBox;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.CheckBox assemblyChechBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox panelsCheckBox;
        private System.Windows.Forms.CheckBox handleCheckBox;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.ComboBox modelComboBox;
        private System.Windows.Forms.Button button1;
    }
}


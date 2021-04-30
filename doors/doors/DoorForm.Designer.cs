namespace doors
{
    partial class DoorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoorForm));
            this.nameLabel = new System.Windows.Forms.Label();
            this.doorPicture = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.colorComboBox = new System.Windows.Forms.ComboBox();
            this.colorLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.trimPanelsCheckBox = new System.Windows.Forms.CheckBox();
            this.handleCheckBox = new System.Windows.Forms.CheckBox();
            this.specialManCheclBox = new System.Windows.Forms.CheckBox();
            this.deliveryCheckBox = new System.Windows.Forms.CheckBox();
            this.ulyanovskCheckBox = new System.Windows.Forms.CheckBox();
            this.floorNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.widthComboBox = new System.Windows.Forms.ComboBox();
            this.floorLabel = new System.Windows.Forms.Label();
            this.elevatorCheckBox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.priseLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.doorPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floorNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.Location = new System.Drawing.Point(312, 0);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(406, 37);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "дверь 1";
            // 
            // doorPicture
            // 
            this.doorPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.doorPicture.Dock = System.Windows.Forms.DockStyle.Left;
            //this.doorPicture.Image = ((System.Drawing.Image)(resources.GetObject("doorPicture.Image")));
            this.doorPicture.Location = new System.Drawing.Point(0, 0);
            this.doorPicture.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.doorPicture.Name = "doorPicture";
            this.doorPicture.Size = new System.Drawing.Size(300, 480);
            this.doorPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.doorPicture.TabIndex = 1;
            this.doorPicture.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(525, 473);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "Цена: 12000 рублей";
            // 
            // colorComboBox
            // 
            this.colorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colorComboBox.FormattingEnabled = true;
            this.colorComboBox.Items.AddRange(new object[] {
            "Дубовый",
            "Серый",
            "Белый"});
            this.colorComboBox.Location = new System.Drawing.Point(436, 40);
            this.colorComboBox.Name = "colorComboBox";
            this.colorComboBox.Size = new System.Drawing.Size(411, 45);
            this.colorComboBox.TabIndex = 2;
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Location = new System.Drawing.Point(309, 43);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(76, 37);
            this.colorLabel.TabIndex = 3;
            this.colorLabel.Text = "Цвет";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(309, 95);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(121, 37);
            this.widthLabel.TabIndex = 3;
            this.widthLabel.Text = "Ширина";
            // 
            // trimPanelsCheckBox
            // 
            this.trimPanelsCheckBox.AutoSize = true;
            this.trimPanelsCheckBox.Location = new System.Drawing.Point(312, 141);
            this.trimPanelsCheckBox.Name = "trimPanelsCheckBox";
            this.trimPanelsCheckBox.Size = new System.Drawing.Size(306, 41);
            this.trimPanelsCheckBox.TabIndex = 5;
            this.trimPanelsCheckBox.Text = "Наличники (1000руб)";
            this.trimPanelsCheckBox.UseVisualStyleBackColor = true;
            // 
            // handleCheckBox
            // 
            this.handleCheckBox.AutoSize = true;
            this.handleCheckBox.Location = new System.Drawing.Point(624, 142);
            this.handleCheckBox.Name = "handleCheckBox";
            this.handleCheckBox.Size = new System.Drawing.Size(237, 41);
            this.handleCheckBox.TabIndex = 5;
            this.handleCheckBox.Text = "Ручка (1200руб)";
            this.handleCheckBox.UseVisualStyleBackColor = true;
            // 
            // specialManCheclBox
            // 
            this.specialManCheclBox.AutoSize = true;
            this.specialManCheclBox.Location = new System.Drawing.Point(312, 189);
            this.specialManCheclBox.Name = "specialManCheclBox";
            this.specialManCheclBox.Size = new System.Drawing.Size(427, 41);
            this.specialManCheclBox.TabIndex = 6;
            this.specialManCheclBox.Text = "Сборка специалистом (500руб)";
            this.specialManCheclBox.UseVisualStyleBackColor = true;
            // 
            // deliveryCheckBox
            // 
            this.deliveryCheckBox.AutoSize = true;
            this.deliveryCheckBox.Location = new System.Drawing.Point(312, 236);
            this.deliveryCheckBox.Name = "deliveryCheckBox";
            this.deliveryCheckBox.Size = new System.Drawing.Size(152, 41);
            this.deliveryCheckBox.TabIndex = 7;
            this.deliveryCheckBox.Text = "Доставка";
            this.deliveryCheckBox.UseVisualStyleBackColor = true;
            // 
            // ulyanovskCheckBox
            // 
            this.ulyanovskCheckBox.AutoSize = true;
            this.ulyanovskCheckBox.Location = new System.Drawing.Point(312, 283);
            this.ulyanovskCheckBox.Name = "ulyanovskCheckBox";
            this.ulyanovskCheckBox.Size = new System.Drawing.Size(189, 41);
            this.ulyanovskCheckBox.TabIndex = 8;
            this.ulyanovskCheckBox.Text = "В Ульяновск";
            this.ulyanovskCheckBox.UseVisualStyleBackColor = true;
            this.ulyanovskCheckBox.Visible = false;
            // 
            // floorNumericUpDown
            // 
            this.floorNumericUpDown.Location = new System.Drawing.Point(394, 349);
            this.floorNumericUpDown.Name = "floorNumericUpDown";
            this.floorNumericUpDown.Size = new System.Drawing.Size(203, 43);
            this.floorNumericUpDown.TabIndex = 9;
            this.floorNumericUpDown.Visible = false;
            // 
            // widthComboBox
            // 
            this.widthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.widthComboBox.FormattingEnabled = true;
            this.widthComboBox.Items.AddRange(new object[] {
            "40",
            "50",
            "60",
            "70",
            "80"});
            this.widthComboBox.Location = new System.Drawing.Point(436, 91);
            this.widthComboBox.Name = "widthComboBox";
            this.widthComboBox.Size = new System.Drawing.Size(411, 45);
            this.widthComboBox.TabIndex = 2;
            this.widthComboBox.SelectedIndexChanged += new System.EventHandler(this.widthComboBox_SelectedIndexChanged);
            // 
            // floorLabel
            // 
            this.floorLabel.AutoSize = true;
            this.floorLabel.Location = new System.Drawing.Point(309, 351);
            this.floorLabel.Name = "floorLabel";
            this.floorLabel.Size = new System.Drawing.Size(79, 37);
            this.floorLabel.TabIndex = 3;
            this.floorLabel.Text = "Этаж";
            this.floorLabel.Visible = false;
            // 
            // elevatorCheckBox
            // 
            this.elevatorCheckBox.AutoSize = true;
            this.elevatorCheckBox.Location = new System.Drawing.Point(636, 350);
            this.elevatorCheckBox.Name = "elevatorCheckBox";
            this.elevatorCheckBox.Size = new System.Drawing.Size(103, 41);
            this.elevatorCheckBox.TabIndex = 8;
            this.elevatorCheckBox.Text = "Лифт";
            this.elevatorCheckBox.UseVisualStyleBackColor = true;
            this.elevatorCheckBox.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(312, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(406, 70);
            this.button1.TabIndex = 10;
            this.button1.Text = "Посчиатать цену";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // priseLabel
            // 
            this.priseLabel.AutoSize = true;
            this.priseLabel.Location = new System.Drawing.Point(718, 415);
            this.priseLabel.Name = "priseLabel";
            this.priseLabel.Size = new System.Drawing.Size(129, 37);
            this.priseLabel.TabIndex = 3;
            this.priseLabel.Text = "7410 руб";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "до квартиры",
            "до подъезда"});
            this.comboBox1.Location = new System.Drawing.Point(470, 234);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(377, 45);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Visible = false;
            // 
            // DoorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 480);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.elevatorCheckBox);
            this.Controls.Add(this.floorNumericUpDown);
            this.Controls.Add(this.ulyanovskCheckBox);
            this.Controls.Add(this.deliveryCheckBox);
            this.Controls.Add(this.specialManCheclBox);
            this.Controls.Add(this.handleCheckBox);
            this.Controls.Add(this.trimPanelsCheckBox);
            this.Controls.Add(this.priseLabel);
            this.Controls.Add(this.floorLabel);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.colorLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.widthComboBox);
            this.Controls.Add(this.colorComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.doorPicture);
            this.Controls.Add(this.nameLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "DoorForm";
            this.Text = "Детальная страница двери";
            ((System.ComponentModel.ISupportInitialize)(this.doorPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floorNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.PictureBox doorPicture;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox colorComboBox;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.CheckBox trimPanelsCheckBox;
        private System.Windows.Forms.CheckBox handleCheckBox;
        private System.Windows.Forms.CheckBox specialManCheclBox;
        private System.Windows.Forms.CheckBox deliveryCheckBox;
        private System.Windows.Forms.CheckBox ulyanovskCheckBox;
        private System.Windows.Forms.NumericUpDown floorNumericUpDown;
        private System.Windows.Forms.ComboBox widthComboBox;
        private System.Windows.Forms.Label floorLabel;
        private System.Windows.Forms.CheckBox elevatorCheckBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label priseLabel;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
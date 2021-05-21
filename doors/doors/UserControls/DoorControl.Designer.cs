namespace doors
{
    partial class DoorControl
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
            this.floorNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.widthComboBox = new System.Windows.Forms.ComboBox();
            this.floorLabel = new System.Windows.Forms.Label();
            this.elevatorCheckBox = new System.Windows.Forms.CheckBox();
            this.deliveryTypeComboBox = new System.Windows.Forms.ComboBox();
            this.priseLabel = new System.Windows.Forms.Label();
            this.distanceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ulyanovskRB = new System.Windows.Forms.RadioButton();
            this.anotherCityRB = new System.Windows.Forms.RadioButton();
            this.DeliveryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.doorPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floorNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distanceNumericUpDown)).BeginInit();
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
            this.colorComboBox.SelectedIndexChanged += new System.EventHandler(this.colorComboBox_SelectedIndexChanged);
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
            this.trimPanelsCheckBox.CheckedChanged += new System.EventHandler(this.trimPanelsCheckBox_CheckedChanged);
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
            this.handleCheckBox.CheckedChanged += new System.EventHandler(this.trimPanelsCheckBox_CheckedChanged);
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
            this.specialManCheclBox.CheckedChanged += new System.EventHandler(this.trimPanelsCheckBox_CheckedChanged);
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
            this.deliveryCheckBox.CheckedChanged += new System.EventHandler(this.deliveryCheckBox_CheckedChanged);
            // 
            // floorNumericUpDown
            // 
            this.floorNumericUpDown.Location = new System.Drawing.Point(556, 285);
            this.floorNumericUpDown.Name = "floorNumericUpDown";
            this.floorNumericUpDown.Size = new System.Drawing.Size(121, 43);
            this.floorNumericUpDown.TabIndex = 9;
            this.floorNumericUpDown.Visible = false;
            this.floorNumericUpDown.ValueChanged += new System.EventHandler(this.widthComboBox_SelectedIndexChanged);
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
            this.widthComboBox.Location = new System.Drawing.Point(436, 95);
            this.widthComboBox.Name = "widthComboBox";
            this.widthComboBox.Size = new System.Drawing.Size(411, 45);
            this.widthComboBox.TabIndex = 2;
            this.widthComboBox.SelectedIndexChanged += new System.EventHandler(this.widthComboBox_SelectedIndexChanged);
            // 
            // floorLabel
            // 
            this.floorLabel.AutoSize = true;
            this.floorLabel.Location = new System.Drawing.Point(471, 287);
            this.floorLabel.Name = "floorLabel";
            this.floorLabel.Size = new System.Drawing.Size(79, 37);
            this.floorLabel.TabIndex = 3;
            this.floorLabel.Text = "Этаж";
            this.floorLabel.Visible = false;
            // 
            // elevatorCheckBox
            // 
            this.elevatorCheckBox.AutoSize = true;
            this.elevatorCheckBox.Location = new System.Drawing.Point(744, 287);
            this.elevatorCheckBox.Name = "elevatorCheckBox";
            this.elevatorCheckBox.Size = new System.Drawing.Size(103, 41);
            this.elevatorCheckBox.TabIndex = 8;
            this.elevatorCheckBox.Text = "Лифт";
            this.elevatorCheckBox.UseVisualStyleBackColor = true;
            this.elevatorCheckBox.Visible = false;
            this.elevatorCheckBox.CheckedChanged += new System.EventHandler(this.widthComboBox_SelectedIndexChanged);
            // 
            // deliveryTypeComboBox
            // 
            this.deliveryTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deliveryTypeComboBox.FormattingEnabled = true;
            this.deliveryTypeComboBox.Items.AddRange(new object[] {
            "до квартиры",
            "до подъезда"});
            this.deliveryTypeComboBox.Location = new System.Drawing.Point(470, 234);
            this.deliveryTypeComboBox.Name = "deliveryTypeComboBox";
            this.deliveryTypeComboBox.Size = new System.Drawing.Size(377, 45);
            this.deliveryTypeComboBox.TabIndex = 2;
            this.deliveryTypeComboBox.Visible = false;
            this.deliveryTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.widthComboBox_SelectedIndexChanged);
            // 
            // priseLabel
            // 
            this.priseLabel.AutoSize = true;
            this.priseLabel.Location = new System.Drawing.Point(309, 425);
            this.priseLabel.Name = "priseLabel";
            this.priseLabel.Size = new System.Drawing.Size(129, 37);
            this.priseLabel.TabIndex = 3;
            this.priseLabel.Text = "7410 руб";
            // 
            // distanceNumericUpDown
            // 
            this.distanceNumericUpDown.Location = new System.Drawing.Point(709, 381);
            this.distanceNumericUpDown.Name = "distanceNumericUpDown";
            this.distanceNumericUpDown.Size = new System.Drawing.Size(95, 43);
            this.distanceNumericUpDown.TabIndex = 9;
            this.distanceNumericUpDown.Visible = false;
            this.distanceNumericUpDown.ValueChanged += new System.EventHandler(this.widthComboBox_SelectedIndexChanged);
            // 
            // ulyanovskRB
            // 
            this.ulyanovskRB.AutoSize = true;
            this.ulyanovskRB.Checked = true;
            this.ulyanovskRB.Location = new System.Drawing.Point(471, 334);
            this.ulyanovskRB.Name = "ulyanovskRB";
            this.ulyanovskRB.Size = new System.Drawing.Size(218, 41);
            this.ulyanovskRB.TabIndex = 10;
            this.ulyanovskRB.TabStop = true;
            this.ulyanovskRB.Text = "по Ульяновску";
            this.ulyanovskRB.UseVisualStyleBackColor = true;
            this.ulyanovskRB.Visible = false;
            this.ulyanovskRB.CheckedChanged += new System.EventHandler(this.widthComboBox_SelectedIndexChanged);
            // 
            // anotherCityRB
            // 
            this.anotherCityRB.AutoSize = true;
            this.anotherCityRB.Location = new System.Drawing.Point(471, 381);
            this.anotherCityRB.Name = "anotherCityRB";
            this.anotherCityRB.Size = new System.Drawing.Size(387, 41);
            this.anotherCityRB.TabIndex = 10;
            this.anotherCityRB.Text = "Другой город в                  км";
            this.anotherCityRB.UseVisualStyleBackColor = true;
            this.anotherCityRB.Visible = false;
            this.anotherCityRB.CheckedChanged += new System.EventHandler(this.widthComboBox_SelectedIndexChanged);
            // 
            // DeliveryLabel
            // 
            this.DeliveryLabel.AutoSize = true;
            this.DeliveryLabel.Location = new System.Drawing.Point(471, 425);
            this.DeliveryLabel.Name = "DeliveryLabel";
            this.DeliveryLabel.Size = new System.Drawing.Size(277, 37);
            this.DeliveryLabel.TabIndex = 3;
            this.DeliveryLabel.Text = " + 7410 руб доставка";
            this.DeliveryLabel.Visible = false;
            // 
            // DoorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DeliveryLabel);
            this.Controls.Add(this.distanceNumericUpDown);
            this.Controls.Add(this.anotherCityRB);
            this.Controls.Add(this.ulyanovskRB);
            this.Controls.Add(this.elevatorCheckBox);
            this.Controls.Add(this.floorNumericUpDown);
            this.Controls.Add(this.deliveryCheckBox);
            this.Controls.Add(this.specialManCheclBox);
            this.Controls.Add(this.handleCheckBox);
            this.Controls.Add(this.trimPanelsCheckBox);
            this.Controls.Add(this.priseLabel);
            this.Controls.Add(this.floorLabel);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.colorLabel);
            this.Controls.Add(this.deliveryTypeComboBox);
            this.Controls.Add(this.widthComboBox);
            this.Controls.Add(this.colorComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.doorPicture);
            this.Controls.Add(this.nameLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "DoorControl";
            this.Size = new System.Drawing.Size(860, 480);
            ((System.ComponentModel.ISupportInitialize)(this.doorPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floorNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distanceNumericUpDown)).EndInit();
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
        private System.Windows.Forms.NumericUpDown floorNumericUpDown;
        private System.Windows.Forms.ComboBox widthComboBox;
        private System.Windows.Forms.Label floorLabel;
        private System.Windows.Forms.CheckBox elevatorCheckBox;
        private System.Windows.Forms.ComboBox deliveryTypeComboBox;
        private System.Windows.Forms.Label priseLabel;
        private System.Windows.Forms.NumericUpDown distanceNumericUpDown;
        private System.Windows.Forms.RadioButton ulyanovskRB;
        private System.Windows.Forms.RadioButton anotherCityRB;
        private System.Windows.Forms.Label DeliveryLabel;
    }
}
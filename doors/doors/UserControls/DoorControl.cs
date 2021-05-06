using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace doors
{
    public partial class DoorControl : UserControl
    {
        private Image image;
        private string name;
        private int width = 60, basePrice, finalPrice, sborkaPrice = 500, deliveryPrice;
        private float mass;

        private void widthComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            width = int.Parse(widthComboBox.Text);
            UpdatePrice();
        }

        private void deliveryCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            distanceNumericUpDown.Visible = deliveryCheckBox.Checked;
            deliveryTypeComboBox.Visible = deliveryCheckBox.Checked;
            ulyanovskRB.Visible = deliveryCheckBox.Checked;
            anotherCityRB.Visible = deliveryCheckBox.Checked;
        }

        private void trimPanelsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice();
        }

        private string[] colors;

        public DoorControl(Image _image, string _name, int _basePrice, float _mass, string[] _colors)
        {
            image = _image;
            name = _name;
            basePrice = _basePrice;
            mass = _mass;
            colors = _colors;

            InitializeComponent();

            doorPicture.Image = image;
            nameLabel.Text = name;
            colorComboBox.Items.Clear();
            colorComboBox.Items.AddRange(colors);
            colorComboBox.SelectedIndex = 0;
            widthComboBox.Text = width.ToString();
            priseLabel.Text = basePrice + " руб";
        }

        public void UpdatePrice()
        {
            //Стоимость сборки
            sborkaPrice = 500;
            if (trimPanelsCheckBox.Checked)
                sborkaPrice += 300;
            if (handleCheckBox.Checked)
                sborkaPrice += 500;

            mass = (int)(mass * (1 + (width - 60) / 50f)) + (handleCheckBox.Checked ? 1 : 0) + (trimPanelsCheckBox.Checked ? 2 : 0);

            if(deliveryCheckBox.Checked)
            {

            }

            finalPrice = (int)(basePrice * (1 + ((width - 60) / 50f))) + 
                (trimPanelsCheckBox.Checked ? 1000 : 0) +
                (handleCheckBox.Checked ? 1200 : 0) + 
                (specialManCheclBox.Checked ? sborkaPrice : 0) + deliveryPrice;

            priseLabel.Text = finalPrice + " руб";
            specialManCheclBox.Text = "Сборка специалистом (" + sborkaPrice.ToString() + " руб)";
        }
    }
}

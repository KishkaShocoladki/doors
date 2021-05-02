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
        private int width = 60, basePrice, finalPrice, deliveryPrice;
        private float mass;

        private void widthComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            width = int.Parse(widthComboBox.Text);
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
            colorComboBox.Items.AddRange(colors);
            colorComboBox.SelectedIndex = 0;
            widthComboBox.Text = width.ToString();
            priseLabel.Text = basePrice + " руб";
        }

        public void UpdatePrice()
        {
            mass = (int)(mass * (1 + (width - 60) / 50f)) + (handleCheckBox.Checked ? 1 : 0) + (trimPanelsCheckBox.Checked ? 2 : 0);

            if(deliveryCheckBox.Checked)
            {

            }

            finalPrice = (int)(basePrice * (1 + ((width - 60) / 50f))) + (trimPanelsCheckBox.Checked ? 1000 : 0) +
                (handleCheckBox.Checked ? 1200 : 0) + (specialManCheclBox.Checked ? 500 : 0) + deliveryPrice;

            priseLabel.Text = finalPrice + "руб";
        }
    }
}

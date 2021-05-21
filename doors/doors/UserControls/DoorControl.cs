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
        private int width = 60, basePrice, finalPrice, sborkaPrice = 500, deliveryPrice, count = 1;
        private float mass;

        private void widthComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            width = int.Parse(widthComboBox.Text);
            count = int.Parse(CountNUD.Value.ToString());
            UpdatePrice();
        }

        private void deliveryCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            distanceNumericUpDown.Visible = deliveryCheckBox.Checked;
            deliveryTypeComboBox.Visible = deliveryCheckBox.Checked;
            ulyanovskRB.Visible = deliveryCheckBox.Checked;
            anotherCityRB.Visible = deliveryCheckBox.Checked;
            floorLabel.Visible = deliveryCheckBox.Checked;
            floorNumericUpDown.Visible = deliveryCheckBox.Checked;
            elevatorCheckBox.Visible = deliveryCheckBox.Checked;
            DeliveryLabel.Visible = deliveryCheckBox.Checked;
        }

       

        private void colorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void trimPanelsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice();
        }

        private string[] colors;

        public DoorControl(Image _image, int _count, string _name, int _basePrice, float _mass, string[] _colors)
        {
            image = _image;
            count = _count;
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
            mass = mass * count;

            finalPrice = (int)(basePrice * (1 + ((width - 60) / 50f))) + 
                (trimPanelsCheckBox.Checked ? 1000 : 0) +
                (handleCheckBox.Checked ? 1200 : 0) + 
                (specialManCheclBox.Checked ? sborkaPrice : 0);

            priseLabel.Text = finalPrice * count + " руб";
            specialManCheclBox.Text = "Сборка специалистом (" + (sborkaPrice * count).ToString() + " руб)";


            if (deliveryCheckBox.Checked)
            {
                //Добавить учет массы
                int deliveryPrice = 0;

                //По городу / дальше
                if (ulyanovskRB.Checked)
                {
                    if (mass > 100)
                        deliveryPrice = 300;
                    else if (mass > 50)
                        deliveryPrice = 200;
                }
                else
                {
                    if (mass > 100)
                        deliveryPrice = 400 + 10 * Convert.ToInt32(distanceNumericUpDown.Value);
                    else if (mass > 50)
                        deliveryPrice = 300 + 12 * Convert.ToInt32(distanceNumericUpDown.Value);
                    else
                        deliveryPrice = 100 + 15 * Convert.ToInt32(distanceNumericUpDown.Value);
                }

                //До квартиры
                if (deliveryTypeComboBox.SelectedIndex == 0)
                {
                    if (elevatorCheckBox.Checked)
                        deliveryPrice += 500;
                    else if (mass < 100)
                        deliveryPrice += 250 * Convert.ToInt32(floorNumericUpDown.Value);
                    else
                        deliveryPrice += 300 * Convert.ToInt32(floorNumericUpDown.Value);
                }

                DeliveryLabel.Text = "+" + deliveryPrice.ToString() + " руб доставка";
            }
        }
    }
}

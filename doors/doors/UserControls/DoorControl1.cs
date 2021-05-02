using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace doors
{
    public partial class DoorControl1 : UserControl
    {
        private Image image;
        private string name;
        private int basePrice, mass;
        string[] colors;


        public DoorControl1(Image _image, string _name, int _basePrice, int _mass, string[] _colors)
        {
            image = _image;
            name = _name;
            basePrice = _basePrice;
            mass = _mass;
            colors = _colors;

            InitializeComponent();

            pictureBox1.Image = image;
            label1.Text = name;
        }

        private void DoorControl_Click(object sender, EventArgs e)
        {
            DoorControl doorFrom = new DoorControl(image, name, basePrice, mass, colors);
            doorFrom.Show();
        }
    }
}

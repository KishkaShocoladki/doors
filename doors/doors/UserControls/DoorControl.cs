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
        private int basePrise, mass;
        string[] colors;


        public DoorControl(Image _image, string _name, int _basePrise, int _mass, string[] _colors)
        {
            image = _image;
            name = _name;
            basePrise = _basePrise;
            mass = _mass;
            colors = _colors;

            InitializeComponent();

            pictureBox1.Image = image;
            label1.Text = name;
        }

        private void DoorControl_Click(object sender, EventArgs e)
        {
            DoorForm doorFrom = new DoorForm(image, name, basePrise, mass, colors);
            doorFrom.Show();
        }
    }
}

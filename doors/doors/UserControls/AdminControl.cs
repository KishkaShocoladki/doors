using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace doors
{
    public partial class AdminControl : UserControl
    {
        public AdminControl()
        {
            InitializeComponent();

            List<string> colors =
                SQLClass.Select("SELECT DISTINCT Name FROM colors ORDER BY Name");
            ColorsCLB.Items.AddRange(colors.ToArray());

            List<string> doors = SQLClass.Select("SELECT DISTINCT Name FROM doors ORDER BY Name");

            int y = 10;
            foreach (string door in doors)
            {
                Label label = new Label();
                label.Text = door;
                label.AutoSize = false;
                label.Size = new Size(doorsPanel.Width - 20, 30);
                label.Location = new Point(10, y);
                doorsPanel.Controls.Add(label);
                y += 35;
            }
        }

        private void AdminControl_Load(object sender, EventArgs e)
        {

        }

        string address = "";
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    address = openFileDialog1.FileName;
                    pictureBox1.Load(address);
                }
                catch (Exception)
                {
                    MessageBox.Show("Вы выбрали фигню, а не картинку");
                }
            }
        }
    }
}

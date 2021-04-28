using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doors
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();

            comboBox2.DataSource = 
                SQLClass.Select("SELECT DISTINCT Name FROM colors");

            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new DoorForm().Show();
        }
    }
}

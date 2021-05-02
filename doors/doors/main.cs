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
        private List<DoorControl> doors = new List<DoorControl>();

        public main()
        {
            InitializeComponent();

            List<string> list = SQLClass.Select("SELECT Name, Price, Mass FROM doors");
            List<Image> images = SQLClass.SelectImages("SELECT Image FROM doors");

            for (int i = 0; i < list.Count; i += 3)
            {
                modelComboBox.Items.Add(list[i]);
                doors.Add(new DoorControl(images[i / 3], list[i], int.Parse(list[i + 1]), float.Parse(list[i + 2]), new string[] { "э" }));
            }

            modelComboBox.SelectedIndex = 0;
            doorsPanel.Controls.Add(doors[0]);
        }

        private void UpdatePrice(object sender, EventArgs e)
        {
            doors[modelComboBox.SelectedIndex].UpdatePrice();
        }

        private void modelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            doorsPanel.Controls.Clear();
            doorsPanel.Controls.Add(doors[modelComboBox.SelectedIndex]);

            UpdatePrice(sender, e);
        }
    }
}

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

            List<string> list = SQLClass.Select("SELECT Name, Price, Mass, Id FROM doors");
            List<Image> images = SQLClass.SelectImages("SELECT Image FROM doors");

            for (int i = 0; i < list.Count; i += 4)
            {
                List<string> colors = SQLClass.Select(
                    "SELECT DISTINCT Name"+
                    " FROM colors JOIN door_colors ON colors.id = door_colors.color_id" +
                    " WHERE door_colors.door_id = " + list[i+3]);
                modelComboBox.Items.Add(list[i]);
                doors.Add(new DoorControl(images[i / 4], list[i], int.Parse(list[i + 1]), float.Parse(list[i + 2]), colors.ToArray()));
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

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void comboPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void colorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

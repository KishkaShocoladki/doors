using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace doors
{
    public partial class AdminControl : UserControl
    {
        string id = "";

        public AdminControl()
        {
            InitializeComponent();

            List<string> colors =
                SQLClass.Select("SELECT DISTINCT Name FROM colors ORDER BY Name");
            ColorsCLB.Items.AddRange(colors.ToArray());

            List<string> doors = SQLClass.Select("SELECT DISTINCT Name FROM doors ORDER BY Name");

            int y = 40;
            foreach (string door in doors)
            {
                Label label = new Label();
                label.Text = door;
                label.AutoSize = false;
                label.Size = new Size(doorsPanel.Width - 20, 30);
                label.Location = new Point(10, y);
                label.Click += new EventHandler(Edit_Click);
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

        private void AddButton_Click(object sender, EventArgs e)
        {
            NameTB.Text = "";
            PriceTB.Text = "0";
            MassTB.Text = "0";
            address = "";
            pictureBox1.Image = null;
            id = "";
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            string DoorName = (sender as Label).Text;

            List<string> DoorData = SQLClass.Select("SELECT Price, Mass, Id FROM doors WHERE Name = '" + DoorName + "'");
            if (DoorData.Count == 0)
            {
                MessageBox.Show("Странная дверь");
                return;
            }
            
            NameTB.Text = DoorName;
            PriceTB.Text = DoorData[0];
            MassTB.Text = DoorData[1];
            id = DoorData[2];
            address = "";
            pictureBox1.Image = SQLClass.SelectImages("SELECT Image FROM doors WHERE Name = '" + DoorName + "'")[0];
            
            List<string> colors = SQLClass.Select(
                    "SELECT DISTINCT Name" +
                    " FROM colors JOIN door_colors ON colors.id = door_colors.color_id" +
                    " WHERE door_colors.door_id = " + id);
            for (int i = 0; i < ColorsCLB.Items.Count; i++)
            {
                ColorsCLB.SetItemChecked(i, colors.Contains(ColorsCLB.Items[i].ToString()));
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //Новая дверь
            if (id == "")
            {
                List<MySqlParameter> pars = new List<MySqlParameter>();
                pars.Add(new MySqlParameter("Name", NameTB.Text));
                pars.Add(new MySqlParameter("Price", PriceTB.Text));
                pars.Add(new MySqlParameter("Mass", MassTB.Text));

                id = SQLClass.Insert("INSERT INTO doors(Name, Price, Mass)" +
                    " VALUES(?Name, ?Price, ?Mass)", pars).ToString();
            }
            else
            {
                List<MySqlParameter> pars = new List<MySqlParameter>();
                pars.Add(new MySqlParameter("Name", NameTB.Text));
                pars.Add(new MySqlParameter("Price", PriceTB.Text));
                pars.Add(new MySqlParameter("Mass", MassTB.Text));

                SQLClass.Insert("UPDATE doors" +
                    " SET Name = ?Name, Price = ?Price, Mass = ?Mass WHERE Id = " + id, pars);
            }

            if (address != "")
                SQLClass.UpdateImg("UPDATE doors SET Image = ?Image WHERE Id = " + id, address);

            SQLClass.Insert("DELETE FROM door_colors WHERE door_id = " + id);
            for (int i = 0; i < ColorsCLB.Items.Count; i++)
            {
                if (ColorsCLB.GetItemChecked(i))
                {
                    SQLClass.Insert("INSERT INTO door_colors(door_id, color_id)" +
                        " SELECT " + id + ", id FROM colors WHERE Name = '" + ColorsCLB.Items[i].ToString() + "'");
                }
            }

            MessageBox.Show("Сохранено");
        }        
    }
}

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
            doors.AddRange(new DoorControl[] {
            new DoorControl(Image.FromFile("../../../../Pictures/Дверь Егор.jpg"), "Егор", 1000, 1, new string[] { "э" }),
            new DoorControl(Image.FromFile("../../../../Pictures/Дверь Елена.jpg"), "Елена", 1000, 1, new string[] { "э" }),
            new DoorControl(Image.FromFile("../../../../Pictures/Дверь Курица.jpg"), "Курица", 1000, 1, new string[] { "э" }),
            new DoorControl(Image.FromFile("../../../../Pictures/Дверь Наиль.jpg"), "Наиль", 1000, 1, new string[] { "э" }),
            new DoorControl(Image.FromFile("../../../../Pictures/Дверь Родриго.jpg"), "Родриго", 1000, 1, new string[] { "э" }) });

            InitializeComponent();
            int columnsConut = doorsPanel.Size.Width / 191;
            int rowsCount = (int)Math.Ceiling((double)doors.Count / columnsConut);

            for (int y = 0; y < rowsCount; y++)
            {
                for (int x = 0; x < columnsConut; x++)
                {
                    int index = x + y * columnsConut;

                    if (doors.Count <= index)
                        break;
                    
                    doors[index].Location = new Point(191 * x, 206 * y + 6);
                    doorsPanel.Controls.Add(doors[index]);
                }
            }
        }
    }
}

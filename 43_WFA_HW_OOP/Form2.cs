using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _43_WFA_HW_OOP
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Room room = new Room();
            room.height = 250;
            room.length = 1000;
            room.width = 600;
            room.furniture = false;
            room.direction = "South";
            room.temperature = 25.5m;
            room.wallpaperColor = "White";

            string format = string.Format("Height: {0} Length: {1} Width: {2}", room.height, room.length, room.width);
            listBox1.Items.Add(format);
        }
    }
}

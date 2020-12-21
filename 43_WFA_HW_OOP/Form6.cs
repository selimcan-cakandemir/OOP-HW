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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            Picture picture = new Picture();
            picture.framed = true;
            picture.painterName = "Claude Monet";
            picture.paintingName = "Poppies";
            picture.type = "Oil painting";

            string format = string.Format("Painter: {0}, Painting Name: {1}, type: {2}", picture.painterName, picture.paintingName, picture.type);
            listBox1.Items.Add(format);
        }
    }
}

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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            Mouse mouse = new Mouse();
            mouse.brand = "Steelseries";
            mouse.model = "3Z";
            mouse.wired = false;
            mouse.year = 2010;

            string format = string.Format("Brand: {0}, Model: {1}, Wired:{2}", mouse.brand, mouse.model, mouse.wired);
            listBox1.Items.Add(format);
        }
    }
}

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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            Headphones headphones = new Headphones();
            headphones.model = "34G";
            headphones.color = "Blue";
            headphones.wireless = true;
            headphones.price = 90m;
            headphones.purpose = "Gaming";

            numericUpDown1.Value = headphones.price;
            radioButton2.Checked = true;
            checkBox1.Text = headphones.color;
            checkBox1.Checked = true;

            string format = string.Format("Model: {0}, Purpose: {1}, Wireless: {2}", headphones.model, headphones.purpose, headphones.wireless);
            listBox1.Items.Add(format);
        }
    }
}

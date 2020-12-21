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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Phone phone = new Phone();
            phone.brand = "Samsung";
            phone.model = "E5";
            phone.phoneCase = false;
            phone.ramGB = 16;
            phone.storageGB = 80;
            phone.year = 2016;
            phone.price = 700;

            string format = string.Format("Brand: {0} Model: {1} Price: {2}", phone.brand, phone.model, phone.price.ToString("C2"));
            listBox1.Items.Add(format);

        }
    }
}

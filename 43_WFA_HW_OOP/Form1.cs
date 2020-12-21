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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Bilgisayar bilgisayar = new Bilgisayar();
            bilgisayar.cpu = "Intel";
            bilgisayar.gpu = "Nvidia";
            bilgisayar.inputDevice = "Keyboard and mouse";
            bilgisayar.monitor = "AOC";
            bilgisayar.psu = "200W";
            bilgisayar.ram = "8GB";
            bilgisayar.storage = "1TB";

            string format = string.Format("CPU: {0} GPU: {1} Monitor: {2}", bilgisayar.cpu, bilgisayar.gpu, bilgisayar.monitor);
            listBox1.Items.Add(format);

        }
    }
}

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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Bathrobe bathrobe = new Bathrobe();
            bathrobe.material = "Wool";
            bathrobe.materialGrade = 'B';
            bathrobe.price = 10;
            bathrobe.soft = true;
            bathrobe.washable = true;

            string format = string.Format("Material: {0}, Price: {1}, Washable: {2}", bathrobe.material, bathrobe.price.ToString("C2"), bathrobe.washable);
            listBox1.Items.Add(format);

        }
    }
}

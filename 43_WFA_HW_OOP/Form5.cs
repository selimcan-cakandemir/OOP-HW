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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            Book book = new Book();
            book.hardcover = true;
            book.papercover = false;
            book.libraryNumber = 13143;
            book.pageNumbers = 313;
            book.name = "History of Ancient Greece";
            book.barcode = 123523634536534342L;

            string format = string.Format("Name: {0}, Page Number: {1}, Hardcover: {2}", book.name, book.pageNumbers, book.hardcover);
            listBox1.Items.Add(format);

        }
    }
}

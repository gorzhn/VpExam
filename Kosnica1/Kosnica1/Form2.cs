using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kosnica1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            p.Ime = textBox1.Text;
            p.Kategorija = textBox2.Text;
            p.Cena = Convert.ToInt16(textBox3.Text);
        }
    }
}

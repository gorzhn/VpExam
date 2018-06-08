using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashAccount
{
    public partial class NewProduct : Form
    {
        public Product product;
        public NewProduct()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            product = new Product();
            product.cena = (int)numCena.Value;
            product.kod= (int)numKod.Value;
            product.ime = textIme.Text;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;

        }

        private void numKod_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void textIme_Validating(object sender, CancelEventArgs e)
        {
            if (textIme.Text.Length <= 0)
            {
                errorProvider2.SetError(textIme, "Nevalidno ime");
                e.Cancel = true;
            }
            else
                errorProvider2.SetError(textIme, "");
        }
    }
}

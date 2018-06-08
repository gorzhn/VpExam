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
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewProduct np = new NewProduct();
            DialogResult result = np.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK) {

                listProduct.Items.Add(np.product);

            }
        }

        private void listProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listProduct.SelectedIndex == -1)
            {
                button1.Enabled = false;
            }
            else
                button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ob = (Product)listProduct.SelectedItem;
            listBox2.Items.Add(ob.cena);

            
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int vkupno= 0;
            foreach (var i in listBox2.Items) {
                vkupno += Convert.ToInt32(i);
            }
            textVkupno.Text = vkupno.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox2.Items.Remove(listBox2.SelectedItem);
        }
    }
}

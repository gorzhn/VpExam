using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orders
{
   
    public partial class NewOrder : Form
    {
        public Order order;
        public NewOrder()
        {
            InitializeComponent();
            comboBox1.Items.Add(new Product("Вода", 40));
            comboBox1.Items.Add(new Product("Сок", 80));
            comboBox1.Items.Add(new Product("Кафе", 50));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            order = new Order();
            order.product = (Product)comboBox1.SelectedItem;
            order.kolicina = (int)numericUpDown1.Value;
            order.zabeleska = textBox1.Text;
            DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();

        }
    }
}

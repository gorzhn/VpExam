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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewOrder no = new NewOrder();
            DialogResult result = no.ShowDialog();

            if (result == System.Windows.Forms.DialogResult.OK) {
                listBox1.Items.Add(no.order);
            }
        }
    }

}

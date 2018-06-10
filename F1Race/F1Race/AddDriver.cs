using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F1Race
{
    public partial class AddDriver : Form
    {
        public Driver dr;
        public AddDriver()
        {
            dr = new Driver();
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
          
            dr.ime = textIme.Text;
            dr.age = (int)numericUpDown1.Value;
            if (checkBox1.Checked)
            {
                dr.prv = true;
            }
            else
                dr.prv = false;
            this.DialogResult = DialogResult.OK;

        }

        private void AddDriver_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void textIme_Validating(object sender, CancelEventArgs e)
        {
            if (textIme.Text == "")
            {

                errorProvider1.SetError(textIme, "Invalid name");
                e.Cancel = true;
            }
            else
                e.Cancel = false;
            errorProvider1.SetError(textIme, "");
        }
    }
}

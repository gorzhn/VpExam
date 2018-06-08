using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerKolokvium
{
    public partial class NewDestination : Form
    {
       public  Destinacija destination;
        public NewDestination()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            destination = new Destinacija(textIme.Text,Convert.ToInt32(numericUpDown1.Value),Convert.ToInt32(numericUpDown2.Value));
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}

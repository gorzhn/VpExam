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
    public partial class AddAerodrom : Form
    {
        public Aerodrom aerodrom { get; set; }  
        public AddAerodrom()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            aerodrom = new Aerodrom(textIme.Text, textGrad.Text, textKratenka.Text);
            DialogResult = System.Windows.Forms.DialogResult.OK;

        }

        private void textIme_Validating(object sender, CancelEventArgs e)
        {
            if (textIme.Text.Length <= 0)
            {
                errorProvider1.SetError(textIme, "Nevalidno ime");
                e.Cancel = true;
               

            }
            else
            errorProvider1.SetError(textIme, "");
        }
        private void textGrad_Validating(object sender, CancelEventArgs e)
        {
            if (textGrad.Text.Length <= 0)
            {
                errorProvider2.SetError(textGrad, "Nevaliden grad");
                e.Cancel = true;


            }
            else
                errorProvider2.SetError(textGrad, "");
        }
        private void textKratenka_Validating(object sender, CancelEventArgs e)
        {
            if (textKratenka.Text.Length <= 0)

            {
                errorProvider3.SetError(textKratenka, "Nevalidna kratenka");
                e.Cancel = true;
            }
            else
            errorProvider3.SetError(textKratenka, "");
        }
    }
}

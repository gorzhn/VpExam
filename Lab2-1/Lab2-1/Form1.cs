using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Web;

namespace Lab2_1
{
    public partial class Form1 : Form
    {
    static int vkupno = 0;    
    
        public Form1()
        {

          
            InitializeComponent();

        }
        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }

        public void CalculateTotal() {
            if (radioMala.Checked)
            {
                vkupno = 200;
                textVkupno.Text = vkupno.ToString();
            }
            else if (radioSredna.Checked)
            {
                vkupno = 300;
                textVkupno.Text = vkupno.ToString();
            }
            else if (radioGolema.Checked) {
                vkupno = 500;
                textVkupno.Text = vkupno.ToString();
            }
            if (checkFeferonki.Checked)
            {
                vkupno += Convert.ToInt16(textFeferonki.Text);
                textVkupno.Text = vkupno.ToString();
            }
            if (checkEkstraSirenje.Checked) {
                vkupno += Convert.ToInt16(textEkstrasirenje.Text);
                textVkupno.Text = vkupno.ToString();

            }
            if (checkKecap.Checked) {
                vkupno += Convert.ToInt16(textKecap.Text);
                textVkupno.Text = vkupno.ToString();
            }
           int kk = Convert.ToInt16(cenaKokaKola.Text);
           int vkk = Convert.ToInt16(textKokaKola.Text);
            int p = Convert.ToInt16(cenaPivo.Text);
            int vp = Convert.ToInt16(textPivo.Text);
            int sok = Convert.ToInt16(cenaSokOdJabolko.Text);
            int vsok = Convert.ToInt16(textSokOdJabolko.Text);
            vkupno += (kk * vkk) + ( p * vp) + ( sok * vsok);
            textVkupno.Text = vkupno.ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

  

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void radio_CheckedChanged(object sender, EventArgs e)
        {
            CalculateTotal();

        }
        private void text_TextChanged(object sender, EventArgs e) {

            CalculateTotal();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
       DialogResult result = MessageBox.Show("Dolga poraka", "Naslov na dijalogot", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
    
    }
}

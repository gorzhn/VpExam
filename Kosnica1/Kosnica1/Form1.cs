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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Product p = new Product();
            p.Ime = "Gorjan";
            p.Cena = 50;
            p.Kategorija = "sapun";
            levo.Items.Add(p);
            p = new Product();
            p.Ime = "Najrog";
            p.Cena = -50;
            p.Kategorija = "nupas";
            levo.Items.Add(p);
            List<Product> lista = new List<Product>();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Add(Product p) {
            levo.Items.Add(p);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Product p in levo.SelectedItems) {
                desno.Items.Add(p);

            }
        }

        private void levo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int counter = 0;
            foreach (Product p in levo.SelectedItems) {
                
                    counter++;
            }

          if ( counter > 0)
            { Product p = (Product)levo.SelectedItem;

                textCena.Text = p.Cena.ToString();
                textIme.Text = p.Ime;
                textKategorija.Text = p.Kategorija;

            }

        }

        


        private void button2_Click(object sender, EventArgs e)
        {
            levo.Items.Remove(levo.SelectedItem);
            

        }
    }
}

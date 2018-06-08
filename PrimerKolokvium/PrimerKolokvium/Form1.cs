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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddAerodrom form2 = new AddAerodrom();
            DialogResult result = form2.ShowDialog();

            if (result == System.Windows.Forms.DialogResult.OK)
            {

                listAerodrom.Items.Add(form2.aerodrom);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Dali ste sigurni deka sakate da go izbrisete aerodromot", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                listAerodrom.Items.RemoveAt(listAerodrom.SelectedIndex);



            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NewDestination dest = new NewDestination();
            DialogResult result = dest.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                Aerodrom item = (Aerodrom)listAerodrom.SelectedItem;
                item.destinacii.Add(dest.destination);
            }

        }

        private void listAerodrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadDestinations();

        }

        void loadDestinations()
        {
            listaDestinacii.Items.Clear();
            Aerodrom airport = listAerodrom.SelectedItem as Aerodrom;
            if (airport != null && airport.destinacii.Count > 0)
            {
                foreach (Destinacija destination in airport.destinacii)
                {
                    listaDestinacii.Items.Add(destination);
                }
                 }

        }
    }
}


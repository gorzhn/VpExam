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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddDriver form = new AddDriver();
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                listBox1.Items.Add(form.dr);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }
        private void btnMinuti_Click(object sender, EventArgs e) {
            var dr = (Driver)listBox1.SelectedItem;
            dr.laps.Add(new Lap((int)minuti.Value, (int)sekundi.Value));
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var dr = (Driver)listBox1.SelectedItem;
            foreach (object l in listBox2.Items) {
                listBox2.Items.Remove(l);

            }
            for (int i = 0; i < dr.laps.Count; i++)
            {


                listBox2.Items.Add(dr.laps[i]);
            }
        }

        private void sekundi_ValueChanged(object sender, EventArgs e)
        {
            if ((int)sekundi.Value >= 60) {
                sekundi.Value = 0;
                minuti.Value++;
            }
        }
    }
}

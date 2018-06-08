using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConferencePapers
{
    public partial class Form1 : Form
    {
        public List<Konferencija> konferencii = new List<Konferencija>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddConference add = new AddConference();
            
            DialogResult result = add.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK) {
                listBox1.Items.Add(add.konf);
                konferencii.Add(add.konf);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sigurno", "Delete", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes) {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach(Konferencija kon in konferencii)
                
            {
                if (kon.godina == Convert.ToInt16(comboBox1.SelectedItem)) {
                    listBox1.Items.Add(kon);
                }

            }
        }
    }
}

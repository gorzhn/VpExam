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
    public partial class AddConference : Form
    {
        public Konferencija konf;
        public AddConference()
        {
            InitializeComponent();
        }

        private void AddConference_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            konf = new Konferencija();
            konf.godina = (int)numGodina.Value;
            konf.ime = textIme.Text;
            this.DialogResult =  System.Windows.Forms.DialogResult.OK;

        }

        private void numGodina_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

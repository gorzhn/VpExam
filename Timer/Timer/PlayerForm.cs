using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class PlayerForm : Form
    {
        public Player p { get; set; }
        public PlayerForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
           
            p = new Player();
            p.Ime = textIme.Text;
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

    }
}

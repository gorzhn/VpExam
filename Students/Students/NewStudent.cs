using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Students
{
    public partial class NewStudent : Form
    {
        public Student student;
        public NewStudent()
        {

            InitializeComponent();
        }

        private void NewStudent_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            student = new Student();
            student.ime = textIme.Text;
            student.prezime = textPrezime.Text;
            student.indeks = Convert.ToInt32(textIndeks.Text);

            DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
    }
}

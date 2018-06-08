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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewStudent ns = new NewStudent();
            DialogResult result = ns.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK) {
                listBox1.Items.Add(ns.student);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add((int)numericUpDown1.Value);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Student selected = listBox1.SelectedItem as Student;
            int count = (int)numericUpDown1.Value;
            Random random = new Random();
            selected.courses.Clear();
            for (int i = 0; i < count; ++i)
            {
                Courses course = new Courses();
                course.Name = string.Format("Предмет {0}", i + 1);
                course.Grade = random.Next(6, 11);
                selected.courses.Add(course);
            }
          

        }
    }
}

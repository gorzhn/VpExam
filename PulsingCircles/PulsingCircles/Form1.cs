using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PulsingCircles
{
    public partial class Form1 : Form
    {
        BallDoc bdoc;
        public Color currentColor;
        public Form1()
        {
            currentColor = Color.Red;
            bdoc = new BallDoc();
            timer1 = new Timer();
            timer1.Start();
            InitializeComponent();
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) {
                Ball b = new Ball(e.Location,currentColor);
                bdoc.AddBall(b);
            }
            Invalidate();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                currentColor = color.Color;
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            bdoc.Draw(e.Graphics);
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bdoc.Pulse();
            Invalidate();
        }

        private void стопToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}

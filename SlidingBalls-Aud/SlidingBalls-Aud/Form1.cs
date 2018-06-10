using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlidingBalls_Aud
{
    public partial class Form1 : Form

    {  
        Random r;
        BallDoc bdoc;

        public Form1()
        {
            timer1 = new Timer();
            bdoc = new BallDoc();
            timer1.Start();
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            r = new Random();
            int height = r.Next(0, this.Height);
            Ball b = new Ball(this.Width,height);
            bdoc.AddBall(b);
            bdoc.Move(this.Width);
            Invalidate();


        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            bdoc.Draw(e.Graphics);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < bdoc.balls.Count; i++) {
                if(bdoc.balls[i].Hit(e.Location))
                {
                    bdoc.balls[i].State++;
                    if (bdoc.balls[i].State == 4) {
                        bdoc.balls.Remove(bdoc.balls[i]);
                    }

                }

            }
        }
    }
}

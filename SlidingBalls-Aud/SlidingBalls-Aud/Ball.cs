using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlidingBalls_Aud
{
    public class Ball
    {
        public Point center;
        public static readonly int radius = 30;
        public Color color { get; set; }
        public int State { get; set; }
        public static readonly int Velocity = 40;
        public int velocityX;
        public int velocityY;
        public int Angle;
        public bool IsHit { get; set; }






        public Ball(int w, int h) {

            center.X = w - w + 10;
            center.Y = h;
            State = 1;
            IsHit = false;
           


        }


        public void Draw(Graphics g) {
            if (State == 1) {
                color = Color.Blue;

            }
            if (State == 2) {
                color = Color.Green;
            }
            if (State == 3) {
                color = Color.Red;
            }
            Brush b = new SolidBrush(color);
            g.FillEllipse(b,center.X - radius,center.Y-radius,radius*2,radius*2);

        }

        public void Move() {
            center.X = center.X + Velocity;
            

        }
        public bool Hit(Point p) {

            return ((p.X - center.X) * (p.X - center.X) + (p.Y - center.Y) * (p.Y - center.Y)) <= radius * radius;


        }





    }

    
}

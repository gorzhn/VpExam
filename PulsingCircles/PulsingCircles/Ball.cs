using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PulsingCircles
{
    public class Ball
    {
        
        public Point center { get; set; }
        public int  radius = 30;
        public Color color;
        public int OriginalRadius = 30;
        public bool isfull;



        public Ball(Point Center, Color color) {
            center = Center;
            radius = 30;
            OriginalRadius = 30;
            this.color = color;
            isfull = false;
        }



        public void Draw(Graphics g) {

            Brush b = new SolidBrush(color);
            g.FillEllipse(b, center.X - radius, center.Y - radius, (int)radius * 2, (int)radius * 2);

        }

        public void Pulse() {
            radius += (int)(OriginalRadius * 0.1);
            if (radius == 2 * OriginalRadius) {
                isfull = true;
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlowingBalloons
{
    [Serializable]
    public class Baloon
    {
        public Point center { get; set; }
        public int radius { get; set; }
        public bool flag { get; set; }

        public Baloon(Point center) {
            this.center = center;
            radius = 20;

        }


        public void Draw(Graphics g) {

            Brush b = new SolidBrush(Color.Red);
            g.FillEllipse(b, center.X - radius, center.Y - radius, radius * 2, radius * 2);

        }
        public bool IsTouching(Baloon ballon)
        {
            double distance = (center.X - ballon.center.X) * (center.X - ballon.center.X) + (center.Y - ballon.center.Y) * (center.Y - ballon.center.Y);
            return distance <= ((radius + ballon.radius) * (radius + ballon.radius));
        }



    }
}

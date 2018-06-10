using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TickingPies
{
    [Serializable]
    public class Pie
    {
        public static int radius = 25;
        public Point center { get; set; }
        public Color Color { get; set; }
        public int Tick { get; set; }
        public bool flag { get; set; }


        public Pie(Point center, Color Color) {

            this.center = center;
            this.Color = Color;
            Tick = 0;
            flag = false;
        }

        public void Draw(Graphics g) {
            Brush b = new SolidBrush(Color);
            g.FillPie(b,center.X, center.Y, radius * 2, radius * 2, 0,(4 - Tick)*90);
            b.Dispose();

        }
    }
}

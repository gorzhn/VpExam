using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PulsingCircles
{
    public class BallDoc
    {
        public List<Ball> balls;


        public BallDoc() {
            balls = new List<Ball>();
        }

        public void AddBall(Ball b) {
            balls.Add(b);
        }

        public void Draw(Graphics g) {
            foreach (Ball b in balls) {
                b.Draw(g);
            }
        }
        public void Pulse() {
            for (int i = 0; i < balls.Count; i++) {
                balls[i].Pulse();
            }
            for (int i = 0; i < balls.Count; i++)
            {
                if (balls[i].isfull) {
                    balls.Remove(balls[i]);
                }
            
            }
        }
    }
}

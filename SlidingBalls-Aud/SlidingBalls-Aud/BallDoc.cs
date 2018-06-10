using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlidingBalls_Aud
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
            for (int i = 0; i < balls.Count; i++) {
                balls[i].Draw(g);

            }

        }

        public void Move(int w) {
            for (int i = 0; i < balls.Count; i++) {
                balls[i].Move();
            }

            for (int i = 0; i < balls.Count; i++)
            {
                if (balls[i].center.X >= w-100) {
                    balls.Remove(balls[i]);
                }
            }

        }
    }
}

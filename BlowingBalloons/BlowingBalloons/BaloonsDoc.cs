using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlowingBalloons
{
    [Serializable]
   public class BaloonsDoc
    {
        public List<Baloon> baloons;

        public int x = 10;
        public int y = 10;
        Point center;


        public BaloonsDoc()
        {
            center.X = x;
            center.Y = y;
           baloons = new List<Baloon>();
        }

        public void AddBaloon(Baloon b) {
            baloons.Add(b);

        }

        public void Draw(Graphics g) {

            foreach (Baloon b in baloons) {

                b.Draw(g);
            }


        }
        public void BlowBalloons()
        {
            foreach (Baloon balloon in baloons)
            {
                balloon.radius += 5;
            }
        }

        public void CheckExplosions() {

            for (int i = 0; i < baloons.Count; i++) {
                for (int j = i + 1; j < baloons.Count; j++) {
                    if (baloons[i].IsTouching(baloons[j])){
                        baloons[i].flag = true;
                        baloons[j].flag = true;
                    }

                }

            }
            for (int i = 0; i < baloons.Count; i++) {
                if (baloons[i].flag) {

                    baloons.Remove(baloons[i]);
                }
            }

        }



    }
}

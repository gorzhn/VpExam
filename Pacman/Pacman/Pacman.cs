using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    enum Direction
    {
        left, right, up, down
    }
    public class Pacman
    {
        float positionX { get; set; }
        float positionY { get; set; }
        bool  Up { get; set; }
        bool  Down { get; set; }
        bool  Left { get; set; }
        bool  Right { get; set; }
        public static int RADIUS { get; internal set; }

        const float radius = 20;
        float velocity;
        bool IsOpen;
        Direction dir;
        Brush br = new SolidBrush(Color.Yellow);


        public Pacman()
        {
            IsOpen = false;
            positionX = 7;
            positionY = 5;
            dir = Direction.right;
            velocity = radius;
            Right = true;
            Up = false;
            Down = false;
            Left = false;
        }
       
        public void Move(int x,int y)
        {
            
        }
        public void Draw(Graphics g)
        {
            // vasiot kod ovde
        }
    }
}

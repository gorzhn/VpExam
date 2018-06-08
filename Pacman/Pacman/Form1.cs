using Pacman.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pacman
{
    public partial class Form1 : Form
    {
        Timer timer;
        Pacman pacman;
        static readonly int TIMER_INTERVAL = 250;
        static readonly int WORLD_WIDTH = 15;
        static readonly int WORLD_HEIGHT = 10;
        Image foodImage;
        bool[][] foodWorld;


        public Form1()
        {
            InitializeComponent();
            // Vcituvanje na slika od resursi
            foodImage = Resources.food;
            DoubleBuffered = true;
            newGame();
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            // не заборавајте да го додадете настанот на самата форма
            // вашиот код овде

            Invalidate();
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);
            for (int i = 0; i < foodWorld.Length; i++)
            {
                for (int j = 0; j < foodWorld[i].Length; j++)
                {
                    
                }
            }
          
        }
       

        void timer_Tick(object sender, EventArgs e)
        {
            // овде вашиот код


            pacman.Move(WORLD_WIDTH, WORLD_HEIGHT);
            Invalidate();
        }
        private void Form1_PaddingChanged(object sender, EventArgs e)
        {

        }

      
    }
}

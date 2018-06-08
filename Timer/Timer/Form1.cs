using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        public List<Player> players = new List<Player>();
        Random r = new Random();
       public  char[] op = { '-', '*', '+' , '/'};
        static int prv = 0;
        static int vtor = 0;
        static int poeni = 0;



        public Form1()
        {
            InitializeComponent();
           

        }
        private void SetupGame() {
            progressBar1.Value = 0;
            progressBar2.Value = 0;
            progressBar2.Maximum = 60;
            GenerateNumbers();
            textGuess.Enabled = true;
            broj1.Enabled = true;
            broj2.Enabled = true;
            poeni = 0;


        }
        private void GenerateNumbers() {
             prv = r.Next(1, 10);
             vtor = r.Next(1, 10);
            broj1.Text = prv.ToString();
            broj2.Text = vtor.ToString();
            int rOperacija = r.Next(0, 3);
            char oper = op[rOperacija];
            operacija.Text = oper.ToString();




        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void newGame_Click(object sender, EventArgs e)
        {
            PlayerForm form = new PlayerForm();
            DialogResult result = form.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK) {
                textIme.Text = form.p.Ime;
                lblPoeni.Text = form.p.Poeni.ToString();
                SetupGame();
                timer1.Start();

            }
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            int userInput = Convert.ToInt16(textGuess.Text);
            int tocenRez = 0;
            if (operacija.Text == "+") {
                 tocenRez = prv + vtor;
            }
            if (operacija.Text == "-")
            {
                 tocenRez = prv - vtor;

            }
            if (operacija.Text == "*")
            {
                 tocenRez = prv * vtor;
            }
            if (operacija.Text == "/")
            {
                 tocenRez = prv / vtor;
            }
            if (userInput == tocenRez) {
                progressBar1.Value += 1;
                if (progressBar2.Value > 2) {
                    progressBar2.Value -= 2;
                    poeni++;
                }
            }
        
            GenerateNumbers();
        }
        private void GameStop() {
            progressBar1.Value = 0;
            progressBar2.Value = 0;
            textGuess.Enabled = false;
            broj1.Enabled = false;
            broj2.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (progressBar2.Value == 60) {
                timer1.Stop();
                GameStop();
                Player p = new Player();
                p.Ime = textIme.Text;
                p.Poeni = poeni;
                players.Add(p);
            }
            progressBar2.Value += 1;
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            BestPlayer bp  = new BestPlayer();
            DialogResult result = bp.ShowDialog();
           

        }
    }
}

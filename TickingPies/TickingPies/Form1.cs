using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TickingPies
{
    public partial class Form1 : Form
    {
        Pie pie;
        
        public List<Pie> pies;
        public Color currentColor;
        public int Counter = 0;
        public string FileName;
       
        public Form1()
        {
            FileName = null;
            Timer timer1 = new Timer();
            pies = new List<Pie>();
            currentColor = Color.Red;
            timer1.Start();
            InitializeComponent();

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) {
                pie = new Pie(e.Location, currentColor);
                pies.Add(pie);
            }
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Pie p in pies) {
                p.Draw(e.Graphics);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < pies.Count; i++)
            {
                pies[i].Tick++;
            


                if (pies[i].Tick == 4)
                {
                    pies[i].flag = true;
                    
                }
            }
                for (int i = 0; i < pies.Count; i++) {
                    if (pies[i].flag == true) {
                        pies.Remove(pies[i]);
                    }
                }
            lblText.Text = pies.Count.ToString();
            
            Invalidate();
        }

        private void SaveFile()
        {
            SaveFileDialog save = new SaveFileDialog();
            if (FileName == null) {
                if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    FileName = save.FileName;

                }
            if (FileName != null) {
                try
                {
                    IFormatter ifr = new BinaryFormatter();
                    FileStream fs = new FileStream(FileName,FileMode.Create);
                    ifr.Serialize(fs, pies);



                }
                catch (Exception ex) {

                }

            }



            }
        private void OpenFile() {

            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK) {

                FileName = open.FileName;

                IFormatter ifs = new BinaryFormatter();
                FileStream fs = new FileStream(open.FileName, FileMode.Open);
                ifs.Deserialize(fs);

            }

        }

        

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            SaveFile();
        }
    }

}


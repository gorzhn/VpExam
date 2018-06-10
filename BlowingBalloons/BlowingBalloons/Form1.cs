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

namespace BlowingBalloons
{
    public partial class Form1 : Form
    {
        BaloonsDoc bdoc;
        private string FileName;
        public Form1()
        {
            bdoc = new BaloonsDoc();
            InitializeComponent();
            timer1.Start();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Baloon b = new Baloon(e.Location);
            bdoc.AddBaloon(b);
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            bdoc.Draw(e.Graphics);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bdoc.BlowBalloons();
            bdoc.CheckExplosions();
            Invalidate();

        }



        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

  
        private void saveFile()
        {
            if (FileName == null) // Has not been saved yet
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
             
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileName = saveFileDialog.FileName;
                }
            }
            if (FileName != null)
            {
                using (FileStream fileStream = new FileStream(FileName, FileMode.Create))
                {
                    IFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fileStream, bdoc);
                }
            }
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFile();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void openFile()
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FileName = open.FileName;
                IFormatter formatter = new BinaryFormatter();
                FileStream fs = new FileStream(FileName, FileMode.Open);
                bdoc = (BaloonsDoc)formatter.Deserialize(fs);

            }
        }



        }
    }


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace RacunarskaGrafika
{
    public partial class Form1 : Form
    {
        string SecretWord;
        int LivesLeft;
        bool c1Guessed, c2Guessed, c3Guessed, c4Guessed, c5Guessed, c6Guessed, Won;
        char c1, c2, c3, c4, c5, c6;
        
        public Form1()
        {
            InitializeComponent();
        }

        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = pnlVesalica.CreateGraphics();
            Pen pn = new Pen(Color.Brown, 5);
            Bitmap bitmap = new Bitmap(Properties.Resources.vesalica);
            g.DrawImage(bitmap, 0, 17, 250, 500);
            
            g.DrawLine(pn, 220,110, 220,150);
          }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            c1Guessed = false;
            SecretWord = txtNovaRec.Text;
            c1 = SecretWord[0];
            c2 = SecretWord[1];
            c3 = SecretWord[2];
            c4 = SecretWord[3];
            c5 = SecretWord[4];
            c6 = SecretWord[5];
           
            LivesLeft = 6;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (SecretWord.Contains(txtSlovo.Text.ToLower()))
            {
                if(txtSlovo.Text==c1.ToString())
                {
                    txtC1.Text = c1.ToString();
                    c1Guessed = true;
                }
                if (txtSlovo.Text == c2.ToString())
                   
                {
                    txtC2.Text = c2.ToString();
                    c2Guessed = true;
                }
                if (txtSlovo.Text == c3.ToString())
                   
                {
                    txtC3.Text = c3.ToString();
                    c3Guessed = true;
                }
                if (txtSlovo.Text == c4.ToString())
                   
                {
                    txtC4.Text = c4.ToString();
                    c4Guessed = true;
                }
                if (txtSlovo.Text == c5.ToString())
                    
                {
                    txtC5.Text = c5.ToString();
                    c5Guessed = true;
                }

                if (txtSlovo.Text == c6.ToString())
                {
                    txtC6.Text = c6.ToString();
                    c6Guessed = true;
                }
                if (c1Guessed && c2Guessed && c3Guessed && c4Guessed && c5Guessed && c6Guessed)
                {
                    Won = true;
                }
                if (Won)
                {
                    MessageBox.Show("Pobedili ste!!");
                }
            }
            else
            {
                Graphics g = pnlVesalica.CreateGraphics();
                Pen pn = new Pen(Color.Black, 5);
                
                LivesLeft--;
                lblBrojPokusaja.Text = LivesLeft.ToString();
                txtMissed.Text += txtSlovo.Text;
                if (LivesLeft == 5)
                {
                    
                    Rectangle rect = new Rectangle(195, 150, 50, 50);
                    g.DrawEllipse(pn, rect);
                }
                if(LivesLeft==4)
                {
                    g.DrawLine(pn, 220, 200, 220, 350);
                }
                if(LivesLeft==3)
                {
                    g.DrawLine(pn, 220, 240, 180, 270);
                }
                if(LivesLeft==2)
                {
                    g.DrawLine(pn, 220, 240, 260, 270);
                }
                if(LivesLeft==1)
                {
                    g.DrawLine(pn, 220, 350, 180, 390);
                }
                if (LivesLeft== 0)
                {
                    g.DrawLine(pn, 220, 350, 260, 390);
                    g.DrawLine(new Pen(Color.Black,2), 210, 170, 205, 175);
                    g.DrawLine(new Pen(Color.Black, 2), 237, 170, 232, 175);
                    g.DrawLine(new Pen(Color.Black, 2), 205, 170, 210, 175);
                    g.DrawLine(new Pen(Color.Black, 2), 232, 170, 237, 175);
                    g.DrawLine(new Pen(Color.Black, 2), 205, 190, 237, 190);
                    MessageBox.Show("Izgubili ste :(");
                    Won = false;
                }

            }
           
            

        }
    }
}

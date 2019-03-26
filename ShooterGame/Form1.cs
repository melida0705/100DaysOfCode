using ShooterGame.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShooterGame
{
    public partial class Form1 : Form
    {
        CMole mole;
        CSplat splash;
        bool splat = false;
        Random rnd = new Random();
        int splatTime = 0;

        public Form1()
        {
            InitializeComponent();
            Bitmap b = new Bitmap(Resources.shooting);
            this.Cursor = CustomCursor.CreateCursor(b, b.Height / 2, b.Width / 2);
            mole = new CMole() { Left = 10, Top = 200 };
            splash = new CSplat();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateMole();
            if(splat)
            {
             if(splatTime>=3)
                {
                    splat = false;
                    splatTime = 0;
                    UpdateMole();
                }
                splatTime++;
                
            }
            this.Refresh();

        }
        private void UpdateMole()
        {
            mole.Update(rnd.Next(Resources.mole.Width,this.Width-Resources.mole.Width),rnd.Next(this.Height/2,this.Height-Resources.mole.Height*2) );
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics dc = e.Graphics;
            if (splat==true)
            {
                splash.DrawImage(dc);
            }
            else
            {
                mole.DrawImage(dc);
            }
            
            
            base.OnPaint(e);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            
          

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.X > 10 && e.X < 40 && e.Y > 0 && e.Y < 20)
            {
                timer1.Start();
            }
            else
            {
                if (mole.Hit(e.X, e.Y))
                {
                    splat = true;
                    splash.Left = mole.Left - Resources.splash.Width / 3;
                    splash.Top = mole.Top - Resources.splash.Height / 3;

                }
            }
            
        }
        private void FireGun()
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}

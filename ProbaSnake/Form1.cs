using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProbaSnake
{
    public partial class Form1 : Form
    {
        private Food food;
        private int score = 0;
        private Graphics ScreenGraph;
        private Snake snake;
        private Point lastsegment;
        private Graphics bitmapgraph;
        private Bitmap offscreenbitmap;
        
        private int btnClicked = 0;
        public Form1()
        {
            InitializeComponent();
            
            offscreenbitmap = new Bitmap(250, 250);
            snake = new Snake();
            food = new Food();
            lastsegment = snake.Location[snake.Length - 1];


        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lastsegment = snake.Location[snake.Length - 1];
           
                switch (btnClicked)
            {
                case 1:snake.Left();
                    break;
                case 2:snake.Up();
                    break;
                case 3:snake.Down();
                    break;
                case 4: snake.Right();
                    break;
                
            }
            bitmapgraph.Clear(Color.White);
            bitmapgraph.FillEllipse(new SolidBrush(Color.Red), (food.Location.X * 10), (food.Location.Y * 10), 10, 10);
            bool gameover = false;
            for (int i = 0; i < snake.Length; i++)
            {
                bitmapgraph.FillEllipse(new SolidBrush(Color.Black), (snake.Location[i].X * 10), (snake.Location[i].Y * 10), 10, 10);
                if ((snake.Location[i] == snake.Location[0]) && (i > 0))
                    gameover = true;
            }
            ScreenGraph.DrawImage(offscreenbitmap, 0, 0);
            Check();
            if (gameover == true)
            {
                GameOver();
            }
               
        }
        private void StartGame()
        {
            CreateFood();
            timer1.Interval = 100;
            score = 0;
            bitmapgraph = Graphics.FromImage(offscreenbitmap);
            ScreenGraph = panel1.CreateGraphics();
            timer1.Enabled = true;
            
        }
        private void Check()
        {
            if (snake.Location[0] == food.Location)
            {
                snake.incLength();
                snake.Location[snake.Length - 1] = lastsegment;
                score += 10;
                lblScore.Text = score.ToString();
                CreateFood();
            }
        }



        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if((e.KeyCode==Keys.Up) || e.KeyCode == Keys.Down|| e.KeyCode == Keys.Left|| e.KeyCode == Keys.Right)
            {
                //arrow = e.KeyCode;
                //MessageBox.Show(arrow.ToString());
            }
        }
        private void CreateFood()
        {
            bool occupied;
            do
            {
                food.CreateFood();
                occupied = false;
                for (int i = 0; i < snake.Length; i++)
                {
                    if (food.Location == snake.Location[i])
                    {
                        occupied = true;
                        break;
                    }
                }
            } while (occupied == true);
        }
        public void GameOver()
        {
            timer1.Enabled = false;
            bitmapgraph.Dispose();
            ScreenGraph.Dispose();

        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            btnClicked = 1;
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            btnClicked = 2;
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            btnClicked = 3;
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            btnClicked = 4;
        }
    }
}

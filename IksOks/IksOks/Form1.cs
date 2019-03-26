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

namespace IksOks
{
    public partial class Form1 : Form
    {
        bool pobeda;
        bool nemapobede;
        int red;
       
        public Form1()
        {
            InitializeComponent();
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPrvi.Text == "")
                MessageBox.Show("Unesite ime prvog igraca");
            if (txtDrugi.Text == "")
                MessageBox.Show("Unesite ime drugog igraca");
            if (txtC1.Text == "" && txtC2.Text == "" && txtC3.Text == "" && txtC4.Text == "" && txtC5.Text == "" && txtC6.Text == "" && txtC7.Text == "" && txtC8.Text == "" && txtC9.Text == "")
            {
                MessageBox.Show("Niste odigrali");
            }


            else
            {
                if (red == 1)
                {
                    lblRed.Text = txtPrvi.Text + " je na redu";
                    red = 0;





                    proveraPobede();
                    if (pobeda)
                    {
                        txtC1.Text = "";
                        txtC2.Text = "";
                        txtC3.Text = "";
                        txtC4.Text = "";
                        txtC5.Text = "";
                        txtC6.Text = "";
                        txtC7.Text = "";
                        txtC8.Text = "";
                        txtC9.Text = "";

                    }
                    if (nemapobede)
                    {
                        txtC1.Text = "";
                        txtC2.Text = "";
                        txtC3.Text = "";
                        txtC4.Text = "";
                        txtC5.Text = "";
                        txtC6.Text = "";
                        txtC7.Text = "";
                        txtC8.Text = "";
                        txtC9.Text = "";

                    }
                    red = 0;
                }
                else if (red == 0)
                {
                    lblRed.Text = txtDrugi.Text + " je na redu";
                    red = 0;





                    proveraPobede();
                    if (pobeda)
                    {
                        txtC1.Text = "";
                        txtC2.Text = "";
                        txtC3.Text = "";
                        txtC4.Text = "";
                        txtC5.Text = "";
                        txtC6.Text = "";
                        txtC7.Text = "";
                        txtC8.Text = "";
                        txtC9.Text = "";

                    }
                    if (nemapobede)
                    {
                        txtC1.Text = "";
                        txtC2.Text = "";
                        txtC3.Text = "";
                        txtC4.Text = "";
                        txtC5.Text = "";
                        txtC6.Text = "";
                        txtC7.Text = "";
                        txtC8.Text = "";
                        txtC9.Text = "";

                    }
                    red = 1;

                }

            }
        }
        private void proveraPobede()
        {
            
            if((txtC1.Text=="X" && txtC2.Text=="X" && txtC3.Text=="X")|| (txtC1.Text == "X" && txtC2.Text == "X" && txtC3.Text == "X"))

            {
                Graphics g = panel1.CreateGraphics();
                Pen p = new Pen(Color.Black, 2);
                g.DrawLine(p, 10, 80, 154, 80);
                pobeda = true;
                MessageBox.Show("Pobedio je igrac "+txtPrvi.Text);
            }
            if ((txtC1.Text == "O" && txtC2.Text == "O" && txtC3.Text == "O") || (txtC1.Text == "o" && txtC2.Text == "o" && txtC3.Text == "o"))
            {
                Graphics g = panel1.CreateGraphics();
                Pen p = new Pen(Color.Black, 2);
                g.DrawLine(p, 10, 80, 154, 80);
                pobeda = true;
                MessageBox.Show("Pobedio je igrac " + txtDrugi.Text);
            }
            if ((txtC1.Text == "O" && txtC5.Text == "O" && txtC9.Text == "O") || (txtC1.Text == "o" && txtC5.Text == "o" && txtC9.Text == "o"))
            {
                Graphics g = panel1.CreateGraphics();
                Pen p = new Pen(Color.Black, 2);
                g.DrawLine(p, 10, 50, 140, 200);
                pobeda = true;
                MessageBox.Show("Pobedio je igrac " + txtDrugi.Text);
            }
            if ((txtC1.Text == "X" && txtC5.Text == "X" && txtC9.Text == "X") || (txtC1.Text == "x" && txtC5.Text == "x" && txtC9.Text == "x"))
            {
                Graphics g = panel1.CreateGraphics();
                Pen p = new Pen(Color.Black, 2);
                g.DrawLine(p, 10, 50, 140, 200);
                pobeda = true;
                MessageBox.Show("Pobedio je igrac " + txtPrvi.Text);
            }
            if ((txtC1.Text == "X" && txtC4.Text == "X" && txtC7.Text == "X") || (txtC1.Text == "x" && txtC4.Text == "x" && txtC7.Text == "x"))
            {
                pobeda = true;
                MessageBox.Show("Pobedio je igrac 1" + txtPrvi.Text);
            }
            if ((txtC4.Text == "X" && txtC5.Text == "X" && txtC6.Text == "X") || (txtC4.Text == "x" && txtC5.Text == "x" && txtC6.Text == "x"))
            {
                pobeda = true;
                MessageBox.Show("Pobedio je igrac 1" + txtPrvi.Text);
            }
            if ((txtC7.Text == "X" && txtC8.Text == "X" && txtC9.Text == "X") || (txtC7.Text == "x" && txtC8.Text == "x" && txtC9.Text == "x"))
            {
                pobeda = true;
                MessageBox.Show("Pobedio je igrac 1" + txtPrvi.Text);
            }
            if ((txtC2.Text == "X" && txtC5.Text == "X" && txtC8.Text == "X") || (txtC2.Text == "x" && txtC5.Text == "x" && txtC8.Text == "x"))
            {
                pobeda = true;
                MessageBox.Show("Pobedio je igrac 1" + txtPrvi.Text);
            }
            if ((txtC3.Text == "X" && txtC6.Text == "X" && txtC9.Text == "X") || (txtC3.Text == "x" && txtC6.Text == "x" && txtC9.Text == "x"))
            {
                pobeda = true;
                MessageBox.Show("Pobedio je igrac 1" + txtPrvi.Text);
            }
            if ((txtC3.Text == "X" && txtC5.Text == "X" && txtC7.Text == "X") || (txtC3.Text == "x" && txtC5.Text == "x" && txtC7.Text == "x"))
            {
                pobeda = true;
                MessageBox.Show("Pobedio je igrac 1" + txtPrvi.Text);
            }

            //Drugi igrac

            if (txtC1.Text == "O" && txtC4.Text == "O" && txtC7.Text == "O")
            {
                pobeda = true;
                MessageBox.Show("Pobedio je igrac 2" + txtDrugi.Text);
            }
            if (txtC4.Text == "O" && txtC5.Text == "O" && txtC6.Text == "O") 
            {
                pobeda = true;
                MessageBox.Show("Pobedio je igrac 2" + txtDrugi.Text);
            }
            if (txtC7.Text == "O" && txtC8.Text == "O" && txtC9.Text == "O") 
            {
                pobeda = true;
                MessageBox.Show("Pobedio je igrac 2" + txtDrugi.Text);
            }
            if (txtC2.Text == "O" && txtC5.Text == "O" && txtC8.Text == "O") 
            {
                pobeda = true;
                MessageBox.Show("Pobedio je igrac 2" + txtDrugi.Text);
            }
            if (txtC3.Text == "O" && txtC6.Text == "O" && txtC9.Text == "O")
            {
                pobeda = true;
                MessageBox.Show("Pobedio je igrac 2" + txtDrugi.Text);
            }
            if (txtC3.Text == "O" && txtC5.Text == "O" && txtC7.Text == "O")
            {
                pobeda = true;
                MessageBox.Show("Pobedio je igrac 2" + txtDrugi.Text);
            }




            if(txtC1.Text!=" " && txtC2.Text!="" && txtC3.Text != "" && txtC4.Text != "" && txtC5.Text != "" && txtC6.Text != "" && txtC7.Text != "" && txtC8.Text != "" && txtC9.Text != "")
            {
                MessageBox.Show("Nema pobednika");
                nemapobede = true;
                
            }



        }
        

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

            Graphics g = panel1.CreateGraphics();
            Pen pen = new Pen(Color.Black, 6);
            g.DrawLine(pen, 50, 50, 50, 200);
            g.DrawLine(pen, 100, 50, 100, 200);
            g.DrawLine(pen, 10, 100, 154, 100);
            g.DrawLine(pen, 10, 150, 154, 150);
        }
    }
}

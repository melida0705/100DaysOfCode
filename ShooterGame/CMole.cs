using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using ShooterGame.Properties;

namespace ShooterGame
{
    class CMole:CImage
    {
        private Rectangle moleHotSpot = new Rectangle();
        public CMole():base(Resources.mole)
        {
            moleHotSpot.X = Left + 20;
            moleHotSpot.Y = Top - 1;
            moleHotSpot.Width = 30;
            moleHotSpot.Height = 40;
        }
        public void Update(int X,int Y)
        {
            Left = X;
            Top = Y;
            moleHotSpot.X = Left + 20;
            moleHotSpot.Y = Top - 1;
        }
        public bool Hit(int X,int Y)
        {
            Rectangle c = new Rectangle(X, Y, 1, 1);
            if(moleHotSpot.Contains(c))
            {
                return true;
            }
            return false;
        }
    }
}

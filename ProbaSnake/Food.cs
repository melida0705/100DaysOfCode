using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace ProbaSnake
{
    class Food
    {
        private Point location;
        public Point Location { get { return location; } }
        public Food()
        {
            location = new Point();
        }
        public void CreateFood()
        {
            Random rand = new Random();
            location = new Point(rand.Next(0, 25), rand.Next(0, 25));
        }
    }
}

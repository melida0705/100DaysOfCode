using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ProbaSnake
{
    class Snake
    {
        private int length;

        private Point[] location;
        public Point[] Location { get { return location; } }
        public int Length
        {
            get { return length; }
            set { length = value; }
        }
        public Snake()
        {
            location = new Point[25 * 25];
            Reset();
        }
        public void Reset()
        {
            length = 5;
            for (int i = 0; i < length; i++)
            {
                location[i].X = 12;
                location[i].Y = 12;
            }
        }
        public void Relocate()
        {
            for (int i = length - 1; i > 0; i--)
            {
                location[i] = location[i - 1];
            }
        }
        public void Up()
        {
            Relocate();
            location[0].Y--;
            if (location[0].Y < 0)
            {
                location[0].Y += 25;
            }
        }
        public void Down()
        {
            Relocate();
            location[0].Y++;
            if (location[0].Y > 24)
            {
                location[0].Y -= 25;
            }
        }
        public void Left()
        {
            Relocate();
            location[0].X--;
            if (location[0].X < 0)
            {
                location[0].X += 25;
            }
        }
        public void Right()
        {
            Relocate();
            location[0].X++;
            if (location[0].X > 24)
            {
                location[0].X -= 25;
            }
        }
        public void incLength()
        {
            length++;
        }
    }
}


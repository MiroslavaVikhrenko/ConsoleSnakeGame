using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSnakeGame
{
    public struct Location
    {
        public int X;
        public int Y;

        public Location(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1._4
{
    internal class Point
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public string Name { get; private set; }

        public Point(int x, int y, string name)
        {
            this.X = x;
            this.Y = y;
            this.Name = name;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11._2
{
    public class Car
    {
        public string Name { get; }
        public int Year { get; }
        public string Color {  get; }

        public Car (string name, int year, string color)
        {
            Name = name;
            Year = year;
            Color = color;
        }
        public override string ToString()
        {
            return $"{Name}, {Year}, {Color}";
        }
    }
}

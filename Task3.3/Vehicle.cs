using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._3
{
    internal class Vehicle
    {
        public double X { get; set; } 
        public double Y { get; set; } 
        public double Price { get; set; }
        public double Speed { get; set; }
        public int Year { get; set; }
        public Vehicle(double x, double y, double price, double speed, int year)
        {
            this.X = x;
            this.Y = y;
            this.Price = price;
            this.Speed = speed;
            this.Year = year;
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Coordinates: ({X}, {Y})\nPrice: ${Price}\nSpeed: {Speed} km/h\nYear: {Year}");
        }
    }
}

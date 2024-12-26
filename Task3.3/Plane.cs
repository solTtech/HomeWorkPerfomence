using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._3
{
    internal class Plane : Vehicle
    {
        public double Altitude { get; set; }
        public int Passengers { get; set; }

        public Plane(double x, double y, double price, double speed, int year, double altitude, int passengers)
            : base(x, y, price, speed, year)
        {
            Altitude = altitude;
            Passengers = passengers;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Altitude: {Altitude} meters\nPassengers: {Passengers}");
        }

    }
}

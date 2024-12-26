using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._3
{
    internal class Ship : Vehicle
    {
        public int Passengers { get; set; }
        public string Port { get; set; }

        public Ship(double x, double y, double price, double speed, int year, int passengers, string port)
            : base(x, y, price, speed, year)
        {
            Passengers = passengers;
            Port = port;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Passengers: {Passengers}\nPort: {Port}");
        }
    }
}

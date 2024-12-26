using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._3
{
    internal class Car: Vehicle
    {
        public Car(double x, double y, double price, double speed, int year)
            : base(x, y, price, speed, year)
        {
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11._2
{
    public class CarCollection
    {
        private List<Car> cars = new List<Car>();

        public void AddCar(string name, int year, string color)
        {
            cars.Add(new Car(name, year, color));
        }

        public Car this[int index]
        {
            get
            {
                if (index < 0 || index >= cars.Count)
                {
                    throw new IndexOutOfRangeException("index out");
                }
                return cars[index];
            }
        }

        public int Count => cars.Count;

        public void Clear()
        { 
            cars.Clear(); 
        }
    }
}

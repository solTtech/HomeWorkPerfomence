using System;
using System.Text;

namespace Task17._2
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            var cars = new List<Car>
        {
            new Car { Brand = "Toyota", Model = "Camry", Year = 2020, Color = "Чорний" },
            new Car { Brand = "Honda", Model = "Civic", Year = 2019, Color = "Червоний" },
            new Car { Brand = "Ford", Model = "Focus", Year = 2021, Color = "Синій" }
        };

            var buyers = new List<Buyer>
            {
            new Buyer { Model = "Camry", Name = "Олександр Іванов", Phone = "+380971234567" },
            new Buyer { Model = "Civic", Name = "Марія Петрівна", Phone = "+380631234567" }
        };

            var query = from car in cars
                        join buyer in buyers on car.Model equals buyer.Model
                        select new
                        {
                            BuyerName = buyer.Name,
                            BuyerPhone = buyer.Phone,
                            CarBrand = car.Brand,
                            CarModel = car.Model,
                            CarYear = car.Year,
                            CarColor = car.Color
                        };

            foreach (var item in query)
            {
                Console.WriteLine($"Покупець: {item.BuyerName}, Телефон: {item.BuyerPhone}");
                Console.WriteLine($"Автомобіль: {item.CarBrand} {item.CarModel}, Рік: {item.CarYear}, Колір: {item.CarColor}");
                Console.WriteLine("----------------------------------------------------");
            }
        }
    }
}

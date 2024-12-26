namespace Task3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Створюємо екземпляри транспортних засобів
            Plane plane = new Plane(5, 15, 300000, 900, 2024, 10000, 150);
            Car car = new Car(25, 40, 30000, 120, 2020);
            Ship ship = new Ship(65, 60, 99900, 100, 2012, 200, "Odessa");

            // Виводимо інформацію про кожен засіб пересування
            Console.WriteLine("Plane:");
            plane.DisplayInfo();

            Console.WriteLine("\nCar:");
            car.DisplayInfo();

            Console.WriteLine("\nShip:");
            ship.DisplayInfo();
        }
    }
}

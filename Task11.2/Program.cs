namespace Task11._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarCollection carPark = new CarCollection();

            carPark.AddCar("Hyundai Ioniq", 2017, "Black");
            carPark.AddCar("Toyota Camry", 2015, "Red");
            carPark.AddCar("Ford Focus", 2018, "Blue");
            carPark.AddCar("Honda Accord", 2020, "Silver");

            for (int i = 0; i < carPark.Count; i++)
            {
                Console.WriteLine(carPark[i]);
            }

            carPark.Clear();
            Console.WriteLine($"Count of cars after cleaning: {carPark.Count}");
        }
    }
}

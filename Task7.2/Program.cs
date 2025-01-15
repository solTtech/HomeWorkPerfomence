using System.Text;

namespace Task7._2
{
    internal class Program
    {
        struct Train
        {
            public string Destination { get; set; }
            public int Number { get; set; }
            public DateTime Time { get; set; }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            const int trainCount = 1;
            Train[] trains = new Train[trainCount];

            for (int i = 0; i < trainCount; i++)
            {
                Console.WriteLine($"Введіть дані для поїзда #{i + 1}:");
                string destination;
                do
                {
                    Console.Write("Назва пункту призначення: ");
                    destination = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(destination))
                    {
                        Console.WriteLine("Назва пункту призначення не може бути порожньою! Спробуйте ще раз.");
                    }
                } while (string.IsNullOrWhiteSpace(destination));

                Console.Write("Номер поїзда: ");
                int Number;
                while (!int.TryParse(Console.ReadLine(), out Number))
                {
                    Console.WriteLine("Номер поїзда має бути числом. Спробуйте ще раз:");
                }

                Console.Write("Час відправлення (у форматі hh:mm): ");
                DateTime Time;
                while (!DateTime.TryParse(Console.ReadLine(), out Time))
                {
                    Console.WriteLine("Некоректний формат часу. Спробуйте ще раз:");
                }
                trains[i] = new Train
                {
                    Destination = destination,
                    Number = Number,
                    Time = Time
                };
            }
            Array.Sort(trains, (train1, train2) => train1.Number.CompareTo(train2.Number));

            Console.Write("Введіть номер поїзда для пошуку: ");
            int searchNumber;
            if (int.TryParse(Console.ReadLine(), out searchNumber));
            else 
                Console.WriteLine("Номер поїзда має бути числом. Спробуйте ще раз:");

            Train? foundTrain = null;
            foreach (var train in trains)
            {
                if (train.Number == searchNumber)
                {
                    foundTrain = train;
                    break;
                }
            }
                
            if (foundTrain != null)
            {
                var train = foundTrain.Value;
                Console.WriteLine($"Інформація про поїзд #{searchNumber}:");
                Console.WriteLine($"Пункт призначення: {train.Destination}");
                Console.WriteLine($"Час відправлення: {train.Time:hh:mm}");
            }
            else
            {
                Console.WriteLine($"Поїзд із номером {searchNumber} не знайдено.");
            }
            
        }
    }
}

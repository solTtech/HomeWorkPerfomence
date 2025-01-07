namespace Task7._2
{
    internal class Program
    {
        struct Train
        {
            public string Destination { get; set; }
            public int TrainNumber { get; set; }
            public DateTime ArrivalTime { get; set; }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
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
                int trainNumber;
                while (!int.TryParse(Console.ReadLine(), out trainNumber))
                {
                    Console.WriteLine("Номер поїзда має бути числом. Спробуйте ще раз:");
                }

                Console.Write("Час відправлення (у форматі hh:mm): ");
                DateTime arrivalTime;
                while (!DateTime.TryParse(Console.ReadLine(), out arrivalTime))
                {
                    Console.WriteLine("Некоректний формат часу. Спробуйте ще раз:");
                }
                trains[i] = new Train
                {
                    Destination = destination,
                    TrainNumber = trainNumber,
                    ArrivalTime = arrivalTime
                };
            }
            Array.Sort(trains, (train1, train2) => train1.TrainNumber.CompareTo(train2.TrainNumber));

            Console.Write("Введіть номер поїзда для пошуку: ");
            int searchNumber;
            if (int.TryParse(Console.ReadLine(), out searchNumber));
            else Console.WriteLine("Номер поїзда має бути числом. Спробуйте ще раз:");

            Train? foundTrain = null;
            foreach (var train in trains)
            {
                if (train.TrainNumber == searchNumber)
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
                Console.WriteLine($"Час відправлення: {train.ArrivalTime:hh:mm}");
            }
            else
            {
                Console.WriteLine($"Поїзд із номером {searchNumber} не знайдено.");
            }
            
        }
    }
}

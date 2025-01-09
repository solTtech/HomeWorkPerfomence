namespace Task8._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a line");
            string inputString = Console.ReadLine();

            Console.WriteLine("Choose a color");
            foreach (var color in Enum.GetValues(typeof(Colors)))
            {
                Console.WriteLine($"{(int)color} - {color}");
            }
            if (int.TryParse(Console.ReadLine(), out int colorChoice))
            {
                Printer.Print(inputString, colorChoice);
            }
            else
            {
                Console.WriteLine("Error: Invalid value");
            }

        }
    }
}

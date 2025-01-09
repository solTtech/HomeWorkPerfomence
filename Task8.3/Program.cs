namespace Task8._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Accountant accountan = new Accountant();

            Console.WriteLine("Choose an employee");
            foreach (var post in Enum.GetValues(typeof(Post)))
            {
                Console.WriteLine($"{(int)post} hours - {post}");
            }
            Console.WriteLine("Enter position:");
            if (Enum.TryParse<Post>(Console.ReadLine(), true, out Post worker))
            {
                Console.WriteLine("Amount of hours worked:");
                if (int.TryParse(Console.ReadLine(), out int hours))
                {
                    bool bonus = accountan.AskForBonus(worker, hours);
                    if (bonus)
                    {
                        Console.WriteLine($"The employee {worker} deserves a bonus!");
                    }
                    else
                    {
                        Console.WriteLine($"The employee {worker} does not deserves a bonus.");
                    }
                }
                else
                {
                    Console.WriteLine("Error: Incorrect account of hours.");
                }
            }
            else
            {
                Console.WriteLine("Error: Incorrect position specified");
            }
        }
    }
}

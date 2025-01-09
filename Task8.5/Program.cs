namespace Task8._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
    
            Console.WriteLine("Input date of Birth (format mm.dd.yyyy)");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime birthDate))
            {
                
                DateTime today = DateTime.Now;
                DateTime nextBirthday = new DateTime(today.Year, birthDate.Month, birthDate.Day);

                if (nextBirthday < today)
                {
                    nextBirthday = nextBirthday.AddYears(1);
                }
                
                int daysUntilBirthday = (nextBirthday - today).Days;

                Console.WriteLine($"{daysUntilBirthday} days left until your next birthdayleft until your next birthday.");
            }
            else
            {
                Console.WriteLine("Incorrect time format.");
            }
        }
    }
}

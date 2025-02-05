namespace Professional.Task2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> numbers = new HashSet<int> { 1, 2, 3, 4, 5 };

            numbers.Add(3); // Дублікати не додаються
            numbers.Add(6); // Додасться успішно

            Console.WriteLine("Елементи HashSet:");
            foreach (var num in numbers)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine("\nЧи містить 4? " + numbers.Contains(4)); // true
            numbers.Remove(2); // Видаляє 2

            Console.WriteLine("Після видалення 2: " + string.Join(", ", numbers));
        }
    }
}

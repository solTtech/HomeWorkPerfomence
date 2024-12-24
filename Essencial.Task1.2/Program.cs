namespace Essencial.Task1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            
            Console.WriteLine("Введіть довжину прямокутника:");
            var side1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введіть ширину прямокутника:");
            var side2 = double.Parse(Console.ReadLine());
            
            var rec = new Rectangle(side1, side2);
            
            Console.WriteLine($"Розрагунки прямокутника: \nПлоща = {rec.Area}; \nПериметр = {rec.Perimeter}.");
            Console.ReadKey();
        }
    }
}

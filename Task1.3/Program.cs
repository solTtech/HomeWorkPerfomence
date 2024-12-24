using System.Reflection.Metadata;
using System.Text;

namespace Task1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            
            Book document = new Book("Мова програмування C#");
            document.Content = "Зміст книги...";
            document.Author = "Автор: Ендрю Троелсон";

            document.Show();

            // Delay.
            Console.ReadKey();
        }
    }
}

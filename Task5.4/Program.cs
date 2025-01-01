namespace Task5._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store(3);

            store.AddArticle(0, new Article("Car", "AvtoWorld", 505000));
            store.AddArticle(1, new Article("Smartphone", "MobileShop", 15000));
            store.AddArticle(2, new Article("SSD", "MultiStore", 3000));

            Console.WriteLine("Enter article index (0-2):");
            if (int.TryParse(Console.ReadLine(), out int index))
            {
                store.DisplayArticleByIndex(index);
            }
            else
            {
                Console.WriteLine("Invalid index input.");
            }

            Console.WriteLine("\nEnter article name:");
            string name = Console.ReadLine();
            store.DisplayArticleByName(name);
        }
    }
}

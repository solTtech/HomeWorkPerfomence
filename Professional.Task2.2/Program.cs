namespace Professional.Task2._2
{
    internal class Program
    {
        static void Main()
        {
            var collection = new CustomerProductCollection();

            collection.AddPurchase("Alice", "Electronics");
            collection.AddPurchase("Alice", "Books");
            collection.AddPurchase("Bob", "Books");
            collection.AddPurchase("Charlie", "Clothing");

            Console.WriteLine("Categories bought by Alice: " + string.Join(", ", collection.GetCategoriesByCustomer("Alice")));
            Console.WriteLine("Customers who bought Books: " + string.Join(", ", collection.GetCustomersByCategory("Books")));
        }
    }
}

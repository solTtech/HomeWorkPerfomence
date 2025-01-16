namespace Task11._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new Dictionary<string, int>();

            dictionary.Add("one", 1);
            dictionary.Add("two", 2);

            Console.WriteLine("Value for 'one': " + dictionary["one"]);
            Console.WriteLine("Total count: " + dictionary.Count);

            dictionary["three"] = 3;
            Console.WriteLine("Value for 'three': " + dictionary["three"]);

            Console.WriteLine("Updated total count: " + dictionary.Count);
        }
    }
}

namespace Task10._2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            MyList<int> myList = new MyList<int>();
            myList.Add(10);
            myList.Add(20);
            myList.Add(30);

            Console.WriteLine($"Кількість елементів: {myList.Count}");

            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine($"Елемент {i}: {myList[i]}");
            }

            // Використання розширюючого методу
            int[] array = myList.GetArray();
            Console.WriteLine("Елементи масиву:");
            foreach (int item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}

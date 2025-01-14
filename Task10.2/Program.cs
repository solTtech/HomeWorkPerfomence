namespace Task10._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<string> myList = new MyList<string>();
            myList.Add("BMW");
            myList.Add("AUDI");
            myList.Add("VW");
            myList.Add("HYUNDAI");
            myList.Add("KIA");


            Console.WriteLine(myList[4]);
            Console.WriteLine(myList.LengthList);
        }
    }
}

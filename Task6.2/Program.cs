using System.Text.Json.Serialization;

namespace Task6._2
{
    class Dog()
    {
        private string name;
        public void SetDogName(string name)
        {
           this.name = name;
        }
        public string GetNameDog()
        {
            return name;
        }
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            var dog1 = new Dog();
            var dog2 = new Dog();
            dog1.SetDogName("Koll");
            dog2.SetDogName("Lol");
            Console.WriteLine($"{dog1.GetNameDog()}, {dog2.GetNameDog()}");

        }
    }
}

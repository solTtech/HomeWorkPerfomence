namespace Task10._3
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            
            // Функція генерації подарунків
            var bag = new MagicBag<ICreature>(creature =>
            {
                return $"{Guid.NewGuid()}";
            });

            var human = new Human();
            var elf = new Elf();
            var mermaid = new Mermaid();
            var troll = new Troll();

            Console.WriteLine(bag.GetGift(human)); // Людина отримує унікальний подарунок
            Console.WriteLine(bag.GetGift(elf));   
            Console.WriteLine(bag.GetGift(human)); // Той самий подарунок для людини (того ж дня)
            Console.WriteLine(bag.GetGift(mermaid)); 
            Console.WriteLine(bag.GetGift(elf));
            Console.WriteLine(bag.GetGift(troll));

            Console.ReadKey();
        }
    }
    
}

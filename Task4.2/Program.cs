namespace Task4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Введіть тип документа (XML, TXT, DOC):");
            string docType = Console.ReadLine().ToUpper();

            AbstractHandler handler;

            switch (docType)
            {
                case "XML":
                    handler = new XMLHandler();
                    break;
                case "TXT":
                    handler = new TXTHandler();
                    break;
                case "DOC":
                    handler = new DOCHandler();
                    break;
                default:
                    Console.WriteLine("Невідомий тип документа");
                    return;
            }

            handler.Open();
            handler.Create();
            handler.Change();
            handler.Save();
        }
    }
}

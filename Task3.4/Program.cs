namespace Task3._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Введіть ключ доступу (pro/exp) або натисніть Enter для безкоштовної версії:");
            string key = Console.ReadLine();

            DocumentWorker documentWorker;

            if (key == "pro")
            {
                documentWorker = new ProDocumentWorker();
            }
            else if (key == "exp")
            {
                documentWorker = new ExpertDocumentWorker();
            }
            else
            {
                documentWorker = new DocumentWorker();
            }

            documentWorker.OpenDocument();
            documentWorker.EditDocument();
            documentWorker.SaveDocument();
        }
    }
}

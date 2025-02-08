namespace Professional.Task3._6
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введіть шлях до директорії для створення папок: ");
            string basePath = Console.ReadLine();

            if (!Directory.Exists(basePath))
            {
                Console.WriteLine("Помилка: Вказаний шлях не існує.");
                return;
            }

            CreateDirectories(basePath);
            DeleteDirectories(basePath);
        }
        static void CreateDirectories(string path)
        {
            for (int i = 0; i < 100; i++)
            {
                string dirName = Path.Combine(path, $"Folder_{i}");
                Directory.CreateDirectory(dirName);
            }
            Console.WriteLine("100 директорій створено.");
        }

        static void DeleteDirectories(string path)
        {
            for (int i = 0; i < 100; i++)
            {
                string dirName = Path.Combine(path, $"Folder_{i}");
                if (Directory.Exists(dirName))
                {
                    Directory.Delete(dirName);
                }
            }
            Console.WriteLine("100 директорій видалено.");
        }
    }
}

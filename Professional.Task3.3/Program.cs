using System.IO.Compression;

namespace Professional.Task3._3
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введіть назву файлу для пошуку: ");
            string fileName = Console.ReadLine();
            Console.Write("Введіть диск для пошуку (наприклад, C:\\): ");
            string drive = Console.ReadLine();

            string foundFile = FindFile(drive, fileName);
            if (foundFile != null)
            {
                Console.WriteLine($"Файл знайдено: {foundFile}");
                ShowFileContent(foundFile);
                CompressFile(foundFile);
            }
            else
            {
                Console.WriteLine("Файл не знайдено.");
            }

            static string FindFile(string directory, string fileName)
            {
                try
                {
                    foreach (var file in Directory.GetFiles(directory, fileName, SearchOption.TopDirectoryOnly))
                    {
                        return file;
                    }

                    foreach (var dir in Directory.GetDirectories(directory))
                    {
                        try
                        {
                            string found = FindFile(dir, fileName);
                            if (found != null)
                                return found;
                        }
                        catch (UnauthorizedAccessException) { }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Помилка: " + ex.Message);
                        }
                    }
                }
                catch (UnauthorizedAccessException) { }
                catch (Exception ex)
                {
                    Console.WriteLine("Помилка: " + ex.Message);
                }
                return null;
            }

            static void ShowFileContent(string filePath)
            {
                try
                {
                    using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        Console.WriteLine("Вміст файлу:");
                        Console.WriteLine(sr.ReadToEnd());
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Не вдалося прочитати файл: " + ex.Message);
                }
            }

            static void CompressFile(string filePath)
            {
                try
                {
                    string compressedFile = filePath + ".gz";
                    using (FileStream originalFileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                    using (FileStream compressedFileStream = new FileStream(compressedFile, FileMode.Create))
                    using (GZipStream compressionStream = new GZipStream(compressedFileStream, CompressionMode.Compress))
                    {
                        originalFileStream.CopyTo(compressionStream);
                    }
                    Console.WriteLine("Файл стиснуто: " + compressedFile);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Помилка стиснення: " + ex.Message);
                }
            }
        }
    }
}

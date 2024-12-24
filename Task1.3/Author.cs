using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1._3
{
    internal class Author
    {
        string author;
        public string Author1
        {
            private get
            {
                if (author != null)
                    return author;
                else
                    return "Автор відсутній.";
            }
            set
            {
                author = value;
            }
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Author1);
        }
    }
}

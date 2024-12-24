using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Task1._3
{
    internal class Title
    {
        string title;
        public string Title1
        {
            private get
            {
                if (title != null)
                    return title;
                else
                    return "Назва книги відсутня.";
            }
            set
            {
                title = value;
            }
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Title1);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}

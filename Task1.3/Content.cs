using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1._3
{
    internal class Content
    {
        public string content;
        public string Content1
        {
            private get
            {
                if (content != null)
                    return content;
                else
                    return "Зміст відсутній.";
            }
            set
            {
                content = value;
            }
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(Content1);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8._2
{
    public static class Printer
    {
        
        public static void Print(string stroka, int color)
        {
            if (Enum.IsDefined(typeof(Colors), color))
            {
                ConsoleColor consoleColor = ConvertToConsoleColor(color);
                Console.ForegroundColor = consoleColor;
                Console.WriteLine(stroka);
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Error: Incorrect color selected.");
                Console.ResetColor();
            }
        }

        private static ConsoleColor ConvertToConsoleColor(int color)
        {
            switch ((Colors)color)
            {
                case Colors.Red: return ConsoleColor.Red;
                case Colors.Blue: return ConsoleColor.Blue;
                case Colors.Green: return ConsoleColor.Green;
                case Colors.Magenta: return ConsoleColor.Magenta;
                case Colors.Yellow: return ConsoleColor.Yellow;
                case Colors.Cyan: return ConsoleColor.Cyan;
                case Colors.Purple: return ConsoleColor.DarkMagenta;
                case Colors.White: return ConsoleColor.White;
                default: return ConsoleColor.White;

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1._4
{
    internal class Figure
    {
        private Point[] points;

        // Конструктор, що приймає від 3 до 5 точок
        public Figure(params Point[] points)
        {
            if (points.Length < 3 || points.Length > 5)
            {
                throw new ArgumentException("Фігура повинна мати від 3 до 5 вершин.");
            }
            this.points = points;
        }
        // Метод для розрахунку довжини сторони між двома точками
        public double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
        }

        // Метод для розрахунку периметру багатокутника
        public void PerimeterCalculator()
        {
            double perimeter = 0;
            for (int i = 0; i < points.Length; i++)
            {
                Point current = points[i];
                Point next = points[(i + 1) % points.Length]; // З'єднуємо останню точку з першою
                perimeter += LengthSide(current, next);
            }
            Console.WriteLine($"Назва багатокутника: {points[0].Name}");
            Console.WriteLine($"Периметр багатокутника: {perimeter}");
        }
    }
}

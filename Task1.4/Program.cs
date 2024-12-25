namespace Task1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Створення точок
            Point A = new Point(0, 0, "Трикутник");
            Point B = new Point(4, 0, "Трикутник");
            Point C = new Point(4, 3, "Трикутник");

            // Створення фігури
            Figure triangle = new Figure(A, B, C);

            // Розрахунок і вивід периметра
            triangle.PerimeterCalculator();

            // Приклад для п'ятикутника
            //Point A = new Point(0, 0, "П'ятикутник");
            //Point B = new Point(4, 0, "П'ятикутник");
            //Point C = new Point(4, 3, "П'ятикутник");
            //Point D = new Point(2, 5, "П'ятикутник");
            //Point E = new Point(0, 3, "П'ятикутник");
            //Figure pentagon = new Figure(A, B, C, D, E);
            //pentagon.PerimeterCalculator();
        }
    }
}

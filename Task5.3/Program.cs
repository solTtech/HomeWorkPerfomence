namespace Task5._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            MyMatrix myMatrix = new MyMatrix(3, 3);

            Console.WriteLine("Початкова матриця");
            myMatrix.PrintMatrix();

            //Зміна розміру матнриці
            myMatrix.ResizeMatrix(4, 6);
            Console.WriteLine("Змінена матриця");
            myMatrix.PrintMatrix();

            // Отриання похідної матриці та її виведення
            Console.WriteLine("Отримуємо матрицю 4 х 4");
            MyMatrix subMatrix = myMatrix.GetSubMatrix(4);
            subMatrix.PrintMatrix();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._3
{
    internal class MyMatrix
    {
        private int[,] matrix;

        // Конструктор для заповнення матриці
        public MyMatrix(int rows, int colums)
        {
            matrix = new int[rows, colums];
            FillMatrix();
        }
        // Метод для заповнення матриці рандомними значеннями
        private void FillMatrix()
        {
            Random random = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(5, 20);
                }
            }
        }
    }
}

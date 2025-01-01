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
        // Метод для зміни розміру матриці
        public void ResizeMatrix(int newRows, int newColums)
        {
            int[,] newMatrix = new int[newRows, newColums];
            for (int i = 0; i < newRows; i++)
            {
                for (int j = 0; j < newColums; j++)
                {
                    if (i < matrix.GetLength(0) && j < matrix.GetLength(1))
                    {
                        newMatrix[i, j] = matrix[i, j];
                    }
                    else
                    {
                        newMatrix[i, j] = 0;
                    }
                }
            }
            matrix = newMatrix;
        }

        // Виведення матриці на екран
        public void PrintMatrix()
        {
            for (int i = 0;i < matrix.GetLength(0); i++)
            {
                for(int j = 0;j < matrix.GetLength(1); j++)
                {
                    Console.WriteLine(matrix[i, j] + " ");
                }
            }
            Console.WriteLine();
        }

        // Метод отримання похідної матриці

        public MyMatrix GetSubMatrix(int order)
        {
            if ( order > matrix.GetLength(0) || order > matrix.GetLength(1))
            {
                throw new ArgumentException("Порядок більше розмірів матриці.");
            }
            MyMatrix subMatrix = new MyMatrix(order, order);

            for (int i = 0; i < order; i++)
            {
                for ( int j = 0; j < order; j++)
                    subMatrix.matrix[i, j] = matrix[i, j];
            }
            return subMatrix;
        }
    }
}

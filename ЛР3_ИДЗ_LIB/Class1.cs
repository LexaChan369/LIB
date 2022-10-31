using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIB
{
    public class Matrix
    {
        private int m;
        private int n;
        public int[,] numbers;
        public Matrix(int pM, int pN)
        {
            m = pM;
            n = pN;
            numbers = new int[n,m];
            Console.WriteLine("Введите значение матрицы");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("Matrix[" + (i+1) + "," + (j+1) + "]: ");
                    numbers[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        public static void PrintMatrix(Matrix matrix)
        {
            for (int i = 0; i < matrix.n; i++)
            {
                for (int j = 0; j < matrix.m; j++)
                {
                    Console.Write(matrix.numbers[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static float GetSrArif(Matrix matrix)
        {
            float arif = 0;
            int count = 0;
            for (int i = 0; i < matrix.n; i++)
            {
                for (int j = 0; j < matrix.m; j++)
                {
                    arif += matrix.numbers[i,j];
                    count++;
                }
            }
            return arif/count;
        }

        public static void PrintResultMatrix(Matrix matrix)
        {
            var arif = GetSrArif(matrix);
            for (int i = 0; i < matrix.n; i++)
            {
                for (int j = 0; j < matrix.m; j++)
                {
                    if (matrix.numbers[i,j] > arif)
                    {
                        matrix.numbers[i, j] = -1;
                    }
                    Console.Write(matrix.numbers[i, j]+" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}

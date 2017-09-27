using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace Arrays3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m, N=0, indx=0;
            bool f;
            int minRange = -128, maxRange = 127;
            do
            {
                Console.WriteLine("Введите количество строк : ");
                f = int.TryParse(Console.ReadLine(), out n);
            } while (f == false);
            do
            {
                Console.WriteLine("Введите количество столбцов : ");
                f = int.TryParse(Console.ReadLine(), out m);
            } while (f == false);
            int[,] matr1 = new int[n, m];
            int[] arr = new int[n * m];
            int[,] resultMatr = new int[m, n];
            Random rnd = new Random();
            for (int i = 0; i < matr1.GetLength(0); i++)
            {
                for (int j = 0; j < matr1.GetLength(1); j++)
                {
                    matr1[i, j] = rnd.Next(minRange, maxRange + 1);
                    Console.Write($"{matr1[i, j],4}");
                }
                Console.WriteLine();
            }
            N = Matrix.PositiveElements(matr1);
            Console.WriteLine($"Количество положительных еллементов : {N}");
            int max = minRange;
            int x = m * n;
            int[] arrx = new int[x];
            x = 0;
            max = Matrix.MaxElement(matr1);
            Console.WriteLine($"Максимальное число, повторяющееся больше одного раза max = {max}");
            int zero = 0;
            zero = Matrix.NotZeroRows(matr1);
            Console.WriteLine($"Количество строчек не имеющих еллементов равных 0: {zero}");
            int zero2 = 0;
            zero2 = Matrix.NotZero(matr1);
            Console.WriteLine($"Количество столбцов не имеющих еллементов равных 0: {zero}");
            int maxr = 0;
            maxr = Matrix.RowSeria(matr1);
            Console.Write($" Строка с самой длинной серией: {indx}\n");
            int d=0;
            Matrix.PositiveMultiplicate(matr1);
            int s;
            Matrix.PositiveSum(matr1);
            int k;
            for (int i = 0; i < matr1.GetLength(0); i++)
            {
                k = 0;
                int s2 = 0;
                for (int j = 0; j < matr1.GetLength(1); j++)
                {
                    s2 = s2 + matr1[j, i];
                    if (matr1[j, i] < 0)
                        k = 1;
                }
                if (k==1)
                    Console.WriteLine("Сумма {0}", s2);           
            }
            Console.WriteLine("Транспонированая матрица:");
            Matrix.Tranpouse(matr1);
            int[] arr3 = new int[n - 1];
            int x1 = 1;
            int q = 0;
            for (int i=0; i<matr1.GetLength(0); i++)
            {               
                for (int j = 0; j < resultMatr.GetLength(1); j++)
                {
                    while (q <= n - 2)
                    {
                        arr3[q] = arr3[q] + matr1[i, j];
                        q++;
                    }  
                }
                x1++;
            }
            int[] arr2 = new int[n - 1];
            int maxd = 0;
            Matrix.DiagonalSum(matr1);
            Console.WriteLine($"Самая большая сумма чисел диагоналей паралельных главной: {maxd}");
            int kq;
            Matrix.SumNegative(matr1);
        }
    }
}

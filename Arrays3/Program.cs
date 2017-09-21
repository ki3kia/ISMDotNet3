using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            for(int i=0; i < matr1.GetLength(0); i++)
            {
                for (int j = 0; j < matr1.GetLength(1); j++)
                {
                    if (matr1[i, j] > 0)
                        N = N + 1;
                }
            }
            Console.WriteLine($"Количество положительных еллементов : {N}");
            int max = minRange;
            int x = m * n;
            int[] arrx = new int[x];
            x = 0;
            for (int i = 0; i < matr1.GetLength(0); i++)
            {
                for (int j = 0; j < matr1.GetLength(1); j++)
                {
                    arrx[x] = matr1[i, j];
                    x++;
                }
            }
            int a = 0;
            for (int i = 0; i < n * n; i++)
            {
                for (int j = 0; j < arrx.GetLength(0) - 1; j++)
                {
                    if (arrx[j] < arrx[j + 1])
                    {
                        a = arrx[j];
                        arrx[j] = arrx[j + 1];
                        arrx[j + 1] = a;
                    }
                }
            }
            for (int i = 0; i < arrx.Length; i++)
            {
                if (arrx[i] == arrx[i + 1])
                {
                    max = arrx[i];
                    break;
                }
            }
            Console.WriteLine("Максимальное число, повторяющееся больше одного раза max={0}", max);
            int zero = 0;
            for (int i = 0; i < n * n; i++)
            {
                for (int j = 0; j < arrx.GetLength(0); j++)
                {
                    if (arrx[j] == 0)
                    {
                        zero = zero + 1;
                        break;
                    }
                }
            }
            zero = n - zero;
            Console.WriteLine($"Количество строчек не имеющих еллементов равных 0: {zero}");
            int zero2 = 0;
            for (int i = 0; i < matr1.GetLength(0); i++)
            {
                for (int j = 0; j < matr1.GetLength(1); j++)
                {
                    if (matr1[j,i] == 0)
                    {
                        zero2 = zero2 + 1;
                        break;
                    }
                }
            }
            zero2 = m + zero2;
            Console.WriteLine($"Количество столбцов не имеющих еллементов равных 0: {zero}");
            int maxr = 0;
            for (int i = 0; i < matr1.GetLength(0); i++)
            {
                for (int j = 0; j < matr1.GetLength(1)-1; j++)
                {
                    int b = 0;
                    if (matr1[i, j] == matr1[i, j + 1]) 
                    {
                        b++;
                        if (b > maxr)
                        {
                            maxr = b;
                            indx = 1+i;
                        }
                    }
                }
            }
            Console.Write($" Строка с самой длинной серией: {indx}\n");
            int d=0;
            for (int i = 0; i < matr1.GetLength(0); i++)
            {
                d = 1;
                for (int j = 0; j < matr1.GetLength(1); j++)
                {
                    if (matr1[i, j] >= 0)
                    {
                        d = matr1[i, j] * d;
                    }
                }
                Console.WriteLine("Произведение {0}", d);
            }
            int s;
            for (int i = 0; i < matr1.GetLength(0); i++)
            {
                s = 0;
                for (int j = 0; j < matr1.GetLength(1); j++)
                {
                    if (matr1[j, i] >= 0)
                    {
                        s = matr1[j, i] + s;
                    } else
                    if (s >= 0)
                        Console.WriteLine($"Сумма столбцов с елементами > 0 равна: {s}");
                }
                Console.WriteLine("Сумма {0}", s);
            }
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
            for (int i = 0; i < matr1.GetLength(0); i++)
                for (int j = 0; j < matr1.GetLength(1); j++)
                    resultMatr[j, i] = matr1[i, j];
            Console.WriteLine("Новая матрица (Транспонированая)");
            for (int i = 0; i < resultMatr.GetLength(0); i++)
            {
                for (int j = 0; j < resultMatr.GetLength(1); j++)
                {
                    Console.Write($"{resultMatr[i, j],4}");
                }
                Console.WriteLine();
            }
            int[] arr3 = new int[n - 1];
            int x1 = 1;
            int q = 0;
            for (int i=0; i<matr1.GetLength(0); i++)
            {               
                for (int j = 0; j < resultMatr.GetLength(1); j++)
                {
                    arr3[q] = arr3[q] + matr1[i, j];
                    q++;
                    if (q == n - 2)
                        break;
                }
                x1++;
            }
            int[] arr2 = new int[n - 1];
            for (int i = 0; i < matr1.GetLength(0); i++)
            {
                int xn = i - 1;
                for (int j = 0; j < resultMatr.GetLength(1); j++)
                {
                    arr2[xn] = arr2[xn] + matr1[i, j];
                    if (xn == 0)
                        break;
                    xn--;
                }                
            }
            int maxd = 0;
            for (int i = 0; i < arr3.GetLength(0); i++)
            {
                    if (arr3[i] > maxd)
                        maxd = arr2[i];                
            }
            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                if (arr2[i] > maxd)
                    maxd = arr2[i];
            }
            Console.WriteLine($"Самая большая сумма чисел диагоналей паралельных главной: {maxd}");
            int kq;
            for (int i = 0; i < matr1.GetLength(0); i++)
            {
                kq = 0;
                int suma = 0;
                for (int j = 0; j < resultMatr.GetLength(1); j++)
                {
                    suma = suma + matr1[j, i];
                    if (matr1[j, i] < 0)
                        kq = 1;
                }
                if (kq == 1)
                    Console.WriteLine($"Сума чисел в столбцах с отрицательніми єлементами: {suma}");
            }
        }
    }
}

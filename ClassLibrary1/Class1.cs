using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Matrix
    {
        public static int PositiveElements(double [,] integers)
        {
            int N = 0;
            for (int i = 0; i < integers.GetLength(0); i++)
            {
                for (int j = 0; j < integers.GetLength(1); j++)
                {
                    if (integers[i, j] > 0)
                        N = N + 1;
                }
            }
            return N;
        }
        public static double MaxElement (double[,] integers)
        {
            double max = 0;
            double a = 0;
            int x = 0;
            double[] arr = new double[x];
            for (int i = 0; i < integers.GetLength(0); i++)
            {
                for (int j = 0; j < integers.GetLength(1); j++)
                {
                    arr[x] = integers[i, j];
                    x++;
                }
            }
            for (int i = 0; i < integers.GetLength(0) * integers.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(0) - 1; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        a = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = a;
                    }
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    max = arr[i];
                    break;
                }
            }
            return max;
        }
        public static int NotZeroRows (double[,] integers)
        {
            int zero = 0;
            int x = 0;
            double[] arr = new double[x];
            for (int i = 0; i < integers.GetLength(0); i++)
            {
                for (int j = 0; j < integers.GetLength(1); j++)
                {
                    arr[x] = integers[i, j];
                    x++;
                }
            }
            for (int i = 0; i < integers.GetLength(0) * integers.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    if (arr[j] == 0)
                    {
                        zero = zero + 1;
                        break;
                    }
                }
            }
            zero = integers.GetLength(0) - zero;
            return zero;
        }
        public static int NotZero (double[,] integers)
        {
            int zero2 = 0;
            for (int i = 0; i < integers.GetLength(0); i++)
            {
                for (int j = 0; j < integers.GetLength(1); j++)
                {
                    if (integers[j, i] == 0)
                    {
                        zero2 = zero2 + 1;
                        break;
                    }
                }
            }
            zero2 = integers.GetLength(1) + zero2;
            return zero2;
        }
        public static int RowSeria(double[,] integers)
        {
            int maxr = 0, indx =0;
            for (int i = 0; i < integers.GetLength(0); i++)
            {
                for (int j = 0; j < integers.GetLength(1) - 1; j++)
                {
                    int b = 0;
                    if (integers[i, j] == integers[i, j + 1])
                    {
                        b++;
                        if (b > maxr)
                        {
                            maxr = b;
                            indx = 1 + i;
                        }
                    }
                }
            }
            return indx;
        }
        public static void PositiveMultiplicate(double[,] integers)
        {
            double d;
            for (int i = 0; i < integers.GetLength(0); i++)
            {
                d = 1;
                for (int j = 0; j < integers.GetLength(1); j++)
                {
                    if (integers[i, j] >= 0)
                    {
                        d = integers[i, j] * d;
                    }
                }
                Console.WriteLine("Произведение {0}", d);
            }
        }
        public static void PositiveSum(double[,] integers)
        {
            double s;
            for (int i = 0; i < integers.GetLength(0); i++)
            {
                s = 0;
                for (int j = 0; j < integers.GetLength(1); j++)
                {
                    if (integers[j, i] >= 0)
                    {
                        s = integers[j, i] + s;
                    }
                    else
                    if (s >= 0)
                        Console.WriteLine($"Сумма столбцов с елементами > 0 равна: {s}");
                }
                Console.WriteLine("Сумма {0}", s);
            }
        }
        public static double Tranpouse(double[,] integers)
        {
            double[,] resultMatr = new double [integers.GetLength(1), integers.GetLength(0)];
            for (int i = 0; i < integers.GetLength(0); i++)
                for (int j = 0; j < integers.GetLength(1); j++)
                    resultMatr[j, i] = integers[i, j];
            return resultMatr[integers.GetLength(1), integers.GetLength(0)];
        }
        public static void DiagonalSum (double[,] integers)
        {
            int[,] resultMatr = new int[integers.GetLength(1), integers.GetLength(0)];
            for (int i = 0; i < resultMatr.GetLength(0); i++)
            {
                for (int j = 0; j < resultMatr.GetLength(1); j++)
                {
                    Console.Write($"{resultMatr[i, j],4}");
                }
                Console.WriteLine();
            }
            double[] arr3 = new double[integers.GetLength(0) - 1];
            int x1 = 1;
            int q = 0;
            for (int i = 0; i < integers.GetLength(0); i++)
            {
                for (int j = 0; j < resultMatr.GetLength(1); j++)
                {
                    arr3[q] = arr3[q] + integers[i, j];
                    q++;
                    if (q == integers.GetLength(0) - 2)
                        break;
                }
                x1++;
            }
            double[] arr2 = new double[integers.GetLength(0) - 1];
            for (int i = 0; i < integers.GetLength(0); i++)
            {
                int xn = i - 1;
                for (int j = 0; j < resultMatr.GetLength(1); j++)
                {
                    arr2[xn] = arr2[xn] + integers[i, j];
                    if (xn == 0)
                        break;
                    xn--;
                }
            }
            double maxd = 0;
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
        }
        public static void SumNegative (double[,] integers)
        {
            int k;
            int[,] resultMatr = new int[integers.GetLength(1), integers.GetLength(0)];
            for (int i = 0; i < integers.GetLength(0); i++)
            {
                k = 0;
                double suma = 0;
                for (int j = 0; j < resultMatr.GetLength(1); j++)
                {
                    suma = suma + integers[j, i];
                    if (integers[j, i] < 0)
                        k = 1;
                }
                if (k == 1)
                    Console.WriteLine($"Сума чисел в столбцах с отрицательными єлементами: {suma}");
            }
        }
    }
    public class Arrays
    {
        public static double ProductNeg(double[] integers)
        {
            double d = 0, min = integers[0];
            int index=0;
            for (int i = 0; i < integers.Length; i++)
            {
                if (min > integers[i])
                    index = i;
            }
            for (int i = index + 1; i < integers.Length; i++)
            {
                d = 1;
                d = d * integers[i];
            }
            return d;
        }
        public static double SumBetweenPandN(int[] integers)
        {
            int Modmax = Math.Abs(integers[0]), Modmin = Math.Abs(integers[0]), b = 0, s = 0, a = 0;
            for (int i = 0; i < integers.Length; i++)
            {
                if (Modmax < Math.Abs(integers[i]))
                    Modmax = i;
            }
            for (int i = 0; i < integers.Length; i++)
            {
                if (Modmin > Math.Abs(integers[i]))
                    Modmin = i;
            }
            for (int i = 0; i < integers.Length; i++)
            {
                if (integers[i] < b)
                {
                    b = i;
                    break;
                }
            }
            for (int i = b; i < integers.Length; i++)
            {
                if (integers[i] > 0)
                {
                    a = i;
                    break;
                }
            }
            Console.WriteLine($"index: {a}");
            for (int i = b + 1; i < a; i++)
            {
                s = s + integers[i];
            }
            return s;
        }
        public static double SumBetweenZeros(int[] integers)
        {
            int zero1 = 0, zero2 = 0, s2 = 0;
            for (int i = 0; i < integers.Length; i++)
            {
                if (integers[i] == 0)
                {
                    zero1 = i;
                    break;
                }
            }
            for (int i = 0; i < integers.Length; i++)
            {
                if (integers[i] == 0)
                    zero2 = i;
            }
            for (int i = zero1 + 1; i < zero2; i++)
            {
                s2 = s2 + integers[i];
            }
            return s2; 
        }
        public static double ProductBetweenMaxMin(int[] integers)
        {
            int Modmax = Math.Abs(integers[0]), Modmin = Math.Abs(integers[0]), d2 = 0;
            for (int i = 0; i < integers.Length; i++)
            {
                if (Modmax < Math.Abs(integers[i]))
                    Modmax = i;
            }
            for (int i = 0; i < integers.Length; i++)
            {
                if (Modmin > Math.Abs(integers[i]))
                    Modmin = i;
            }
            if (Modmax > Modmin)
            {
                Modmin = Modmin + Modmax;
                Modmax = Modmin - Modmax;
                Modmin = Modmin - Modmax;
            }
            Console.WriteLine($"modmin modmax {Modmin}, {Modmax}");
            for (int i = Modmax; i < Modmin; i++)
            {
                d2 = d2 * integers[i];
            }
            return d2;
        }
        public static double SumBetweenMaxMin(int[] integers)
        {
            int s = 0;
            for (int i = 0; i < integers.Length; i++)
            {
                if (integers[i] < 0)
                    s = integers[i] + s;
            }
            return s;
        }
        public static double Max(int[] integers)
        {
            int max = integers[0];
            for (int i = 0; i < integers.Length; i++)
            {
                if (max < integers[i])
                {
                    max = integers[i];
                }
            }
            return max;
        }
        public static int MaxIndex(int[] integers)
        {
            int max = integers[0], index = 0;
            for (int i = 0; i < integers.Length; i++)
            {
                if (max < integers[i])
                {
                    index = i;
                }
            }
            return index;
        }
        public static double MaxMod(double[] integers)
        {
            double maxMod = integers[0];
            for (int i = 0; i < integers.Length; i++)
            {
                if (Math.Abs(maxMod) < Math.Abs(integers[i]))
                {
                    maxMod = integers[i];                   
                }
            }
            return maxMod;
        }
        public static double SumPositive (double[] integers)
        {
            double sInx = 0;
            for (int i = 0; i < integers.Length; i++)
            {
                if (integers[i] > 0)
                    sInx = sInx + i;
            }
            return sInx;
        }
        public static int NumbIntegers(double[] integers)
        {
           int c = 0;
            for (int i = 0; i < integers.Length; i++)
            {
                if (integers[i] == (long)integers[i])
                {
                    c ++;
                }
            }
            return c;
        }
    }
}

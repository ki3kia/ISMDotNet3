using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, c = 0;
            bool f;
            do
            {
                Console.WriteLine("Введите длинну масива : ");
                f = int.TryParse(Console.ReadLine(), out n);
            } while (f == false);
            double[] arr1 = new double[n];
            Random rnd = new Random();
            Console.WriteLine("Масив : ");
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = rnd.NextDouble();
                Console.WriteLine($"arr1[{i}] = {arr1[i]}");
            }
            double max = arr1[0], index = 0, maxMod= arr1[0], indexMod=0, sInx=0, s=0;
            for (int i=0; i<arr1.Length; i++)
            {
                if (arr1[i]<0)          
                    s = arr1[i] + s;                       
            }
            Console.WriteLine($"Сума отрицательних еллементов массива : {s}");
            for (int i = 0; i < arr1.Length; i++)
            {
                if (max < arr1[i])
                {
                    max = arr1[i];
                    index = i;
                }
            }
            Console.WriteLine($"Максимальное значение : {max} [{index}]");
            for (int i = 0; i < arr1.Length; i++)
            {
                if (Math.Abs(maxMod) < Math.Abs(arr1[i]))
                {
                    maxMod = arr1[i];
                    indexMod = i;
                }
            }
            Console.WriteLine($"Максимальное по модулю значение : {maxMod} [{indexMod}]");
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] > 0)
                    sInx = sInx + i;
            }
            Console.WriteLine($"Сума индексов положительных елементов: {sInx}");
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] == (long)arr1[i])
                {
                    c = c + 1;
                }
            }
            Console.WriteLine($"Количество целых чисел: {c}");
        } 
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

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
            s = Arrays.SumNeg(arr1); 
            Console.WriteLine($"Сума отрицательних еллементов массива : {s}");
            max = Arrays.Max(arr1);
            index = Arrays.MaxIndex(arr1);
            Console.WriteLine($"Максимальное значение : {max} [{index}]");
            maxMod = Arrays.MaxMod(arr1);
            Console.WriteLine($"Максимальное по модулю значение : {maxMod}");
            sInx = Arrays.SumPositive(arr1);
            Console.WriteLine($"Сума индексов положительных елементов: {sInx}");
            c = Arrays.NumbIntegers(arr1);
            Console.WriteLine($"Количество целых чисел: {c}");
        } 
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace Arrays2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, minRange = -128, maxRange = 127;
            bool f;
            do
            {
                Console.WriteLine("Введите длинну масива : ");
                f = int.TryParse(Console.ReadLine(), out n);
            } while (f == false);

            int[] arr1 = new int[n];
            Random rnd = new Random();
            Console.WriteLine("Масив : ");

            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = rnd.Next(minRange, maxRange);
                Console.WriteLine($"arr1[{i}] = {arr1[i]}");
            }
            int d = 0, s=0, min = arr1[0], Modmax = Math.Abs(arr1[0]), Modmin = Math.Abs(arr1[0]), s2 = 0, d2 = 1;
            
            for (int i = 0; i < arr1.Length; i++)
            {
                if (Modmax < Math.Abs(arr1[i]))                
                    Modmax = i;
            }
            for (int i = 0; i < arr1.Length; i++)
            {
                if (Modmin > Math.Abs(arr1[i]))
                    Modmin = i;
            }
            d = Arrays.ProductNeg(arr1);
            Console.WriteLine(d);
            s = Arrays.SumBetweenPandN(arr1);
            Console.WriteLine($"Summa 1: {s}");
            s2 = Arrays.SumBetweenZeros(arr1);
            Console.WriteLine($"Сумма между первым и последним нулем {s2}");
            d2 = Arrays.SumBetweenMaxMin(arr1);
            Console.WriteLine($"Произведение чисел  между минимальным и максимальным по модулю: {d2}");       
        } 
    }
}

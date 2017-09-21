using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            int min = arr1[0], index = 0, Modmax = Math.Abs(arr1[0]), Modmin = Math.Abs(arr1[0]), d = 0, d2 = 1, b = 0, a = 0, s=0, zero1=0, zero2=0, s2=0;
            for (int i = 0; i < arr1.Length; i++)
            {
                if (min > arr1[i])
                    index = i;                                                
            }
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
            for (int i=index+1; i < arr1.Length; i++)
            {
                d = 1;
                d = d * arr1[i];
            }
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] < b)
                {
                    b = i;
                    break;
                }                   
            }
            for (int i=b; i < arr1.Length; i++)
            {
                if (arr1[i]>0)
                {
                    a = i;
                    break;
                }
            }
            Console.WriteLine($"index: {a}");
            for (int i = b + 1; i < a; i++)
            {
                s = s + arr1[i];
            }
            Console.WriteLine($"Summa 1: {s}");
            for (int i=0; i < arr1.Length; i++)
            {
                if (arr1[i] == 0)
                {
                    zero1 = i;
                        break;
                }                
            }
            for (int i=0; i < arr1.Length; i++)
            {
                if (arr1[i] == 0)
                    zero2 = i;
            }
            for (int i=zero1+1; i<zero2; i++)
            {
                s2 = s2 + arr1[i];
            }
            Console.WriteLine($"Сумма между первым и последним нулем {s2}");
            if (Modmax > Modmin)
            {
                Modmin = Modmin + Modmax;
                Modmax = Modmin - Modmax;
                Modmin = Modmin - Modmax;
            }
            Console.WriteLine($"modmin modmax {Modmin}, {Modmax}");
            for (int i = Modmax; i < Modmin; i++)
            {
                d2 = d2 * arr1[i];
            }
            Console.WriteLine($"Произведение чисел  между минимальным и максимальным по модулю: {d2}");       
        } 
    }
}

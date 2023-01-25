using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[15];
            Random random = new Random();
            for (int i = 0; i < 15; i++)
            {
                array[i] = random.Next(0, 50);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            int max = array[0];
            int min = array[0];
            int s = 0;
            foreach (int a in array)
            {
                if (a > max)
                    max = a;
                else if (a < min)
                    min = a;
                s = min + max;
            }
            Console.WriteLine("Значение максимального элемента {0}", max);
            Console.WriteLine("Значение минимального элемента {0}", min);
            Console.WriteLine("Сумма={0}", s);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];
            Random random = new Random();
            for (int i = 0; i < 20; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            int count = 0;
            for (int i = 0; i < 20; i++)
            {
                if ((i % 2) == 0)
                    continue;
                else if ((array[i] > 0) && (array[i] % 2 == 1))
                    count++;
            }
            Console.WriteLine("Количество нечетных положительных элементов в чётных ячейках {0}", count);
            Console.ReadKey();
        }
    }
}

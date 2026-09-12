using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main()
        {
            long n = Vvod();
            Obratnoe(n);
        }
        static long Vvod()
        {
            long n;

            do
            {
                Console.WriteLine("Введите натуральное число:");
            }
            while (!long.TryParse(Console.ReadLine(), out n) || n <= 0);

            return n;
        }
        static void Obratnoe(long n)
        {
            Console.Write("Число с цифрами в обратом порядке:");

            while (n > 0)
            {
                Console.Write(n % 10);
                n /= 10;
            }

        }
    }
}

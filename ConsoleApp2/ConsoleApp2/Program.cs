using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static long ReadNaturalNumber()
        {
            while (true)
            {
                Console.Write("Введите натуральное число:");
                string input = Console.ReadLine();

                if (long.TryParse(input, out long number) && number > 0)
                {
                    return number;
                }
                Console.WriteLine("Ошибка, введите число больше нуля!");
            }

        
        }
        static int SumDigits(long number)
        {
            int sum = 0;

            while(number > 0)
            {
                sum += (int)(number % 10);
                number /= 10;
            }
            return sum;
        }
        static void Main()
        {
            long number = ReadNaturalNumber();
            int sum = SumDigits(number);

            Console.WriteLine($"Сумма цифр числа {number} равна {sum}."); 
        }
    }
}


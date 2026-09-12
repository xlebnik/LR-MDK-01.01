using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
       /// 1 Задание.
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
/// 2 Задание.
class Program
{
    static void Main()
    {
        long number = ReadNumber();
        long reversed = ReverseNumber(number);
        Printresult(reversed);
    }
    static long ReadNumber()
    {
        long number;
        while (true)
        {
            Console.Write("Введите натуральное число:");
            if (long.TryParse(Console.ReadLine(), out number) && number > 0)
            {
                return number;
            }
            Console.WriteLine("Ошибка, введите натуральное число больше нуля!")
        }
    }
}
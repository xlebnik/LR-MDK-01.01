using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
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
            Console.WriteLine("Ошибка, введите натуральное число больше нуля!");
        }
    }



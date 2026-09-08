using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое чиcло");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите вторе число");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Введите третье число");
            int c = int.Parse(Console.ReadLine());

            int max = a;

            if (b > max)
                b = max;

            if (c > max) 
                c = max;

            Console.WriteLine("Максимальное значение:" + max);
        }
    }
}

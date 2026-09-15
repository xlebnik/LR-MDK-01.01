using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace LR1
{
    class Program
    {
        static double GetWeight()
        {
            double weight;

            while (true)
            {
                Console.Write("Напишите вес билья(кг):");
                if (double.TryParse(Console.ReadLine(), out weight) && weight > 0)
                {
                    return weight;

                }
                Console.WriteLine("Ошибочка! Данный вес должен быть больше нуля.");
            }
        }
       
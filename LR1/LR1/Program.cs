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
        static long GetFabricType()
        {
            int type;

            while (true)
            {
                Console.Write("Введите тип ткани:(1-хлопок, 2-синтетика, 3-шерсть.)");
                if (int.TryParse(Console.ReadLine(), out type) &&
                    type >= 1 && type <= 3)
                {
                    return type;

                }

            }
        }
        static int GetWashTime(int fabricType)
        {
            switch (fabricType)
            {
                case 1:
                    return 90;
                case 2:
                    return 60;
                case 3:
                    return 45;
                default:
                    return 0;

            }
        }
        static int GetTemperature(int fabricType)
        {
            switch (fabricType)
            {
                case 1:
                    return 40;
                case 2:
                    return 30;
                case 3:
                    return 20;
                default:
                    return 0;

            }
        }
        
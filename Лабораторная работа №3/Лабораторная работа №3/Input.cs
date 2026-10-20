using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа__3
{

        class Input
        {
            public static int ReadBookNumber(int booksCount)
            {
                while (true)
                {
                    Console.Write("Введите номер книги (0 - закончить): ");

                    if (int.TryParse(Console.ReadLine(), out int number))
                    {
                        if (number >= (int)MenuChoice.Finish &&
                            number <= booksCount)
                        {
                            return number;
                        }
                    }

                    Console.WriteLine(
                        $"Ошибка! Введите число от 0 до {booksCount}.");
                }
            }

            public static int ReadQuantity()
            {
                while (true)
                {
                    Console.Write("Введите количество экземпляров: ");

                    if (int.TryParse(Console.ReadLine(), out int quantity)
                        && quantity > 0)
                    {
                        return quantity;
                    }

                    Console.WriteLine(
                        "Ошибка! Количество должно быть больше 0.");
                }
            }

            public static Dictionary<int, int> ReadOrder(int booksCount)
            {
                Dictionary<int, int> order =
                    new Dictionary<int, int>();

                while (true)
                {
                    int number = ReadBookNumber(booksCount);

                    if (number == (int)MenuChoice.Finish)
                    {
                        break;
                    }

                    int quantity = ReadQuantity();
                    int index = number - 1;

                    if (order.ContainsKey(index))
                    {
                        order[index] += quantity;
                    }
                    else
                    {
                        order.Add(index, quantity);
                    }
                }

                return order;
            }
        }
    }

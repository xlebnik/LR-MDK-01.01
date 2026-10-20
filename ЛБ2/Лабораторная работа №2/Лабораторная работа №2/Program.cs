
using System;
using System.Collections.Generic;

namespace LR2
{
    class Program
    {
        static List<string> names = new List<string>
        {
            "Война и мир",
            "Анна Каренина",
            "Гарри Поттер",
            "Братья Карамазовы",
            "Мастер и Маргарита"
        };

        static List<int> prices = new List<int>
        {
            500, 400, 350, 450, 600
        };

        static List<int> quantities = new List<int>
        {
            10, 8, 12, 7, 6
        };

        static void PrintBooks()
        {
            Console.WriteLine("Книги в библиотеке:");

            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(
                    $"{i + 1}. {names[i]} - {prices[i]} руб. - {quantities[i]} экз.");
            }
        }

        static int ReadBookNumber()
        {
            while (true)
            {
                Console.Write("Введите номер книги (0 - закончить): ");

                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    if (number >= 0 && number <= names.Count)
                    {
                        return number;
                    }
                }

                Console.WriteLine(
                    $"Ошибка! Введите число от 0 до {names.Count}.");
            }
        }

        static int ReadQuantity()
        {
            while (true)
            {
                Console.Write("Введите количество экземпляров: ");

                if (int.TryParse(Console.ReadLine(), out int quantity))
                {
                    if (quantity > 0)
                    {
                        return quantity;
                    }
                }

                Console.WriteLine(
                    "Ошибка! Количество должно быть больше 0.");
            }
        }

        static Dictionary<int, int> ReadOrder()
        {
            Dictionary<int, int> order = new Dictionary<int, int>();

            while (true)
            {
                int number = ReadBookNumber();

                if (number == 0)
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

        static bool TryIssueBooks(
            Dictionary<int, int> order,
            out int totalCost,
            out int missingBook)
        {
            totalCost = 0;
            missingBook = -1;

            foreach (KeyValuePair<int, int> item in order)
            {
                int index = item.Key;
                int quantity = item.Value;

                if (quantities[index] < quantity)
                {
                    missingBook = index;
                    return false;
                }
            }

            foreach (KeyValuePair<int, int> item in order)
            {
                int index = item.Key;
                int quantity = item.Value;

                quantities[index] -= quantity;
                totalCost += prices[index] * quantity;
            }

            return true;
        }

        static void PrintRemaining()
        {
            Console.WriteLine();
            Console.WriteLine("Оставшиеся книги:");

            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(
                    $"{i + 1}. {names[i]} - осталось {quantities[i]} экз.");
            }
        }

        static void Main(string[] args)
        {
            PrintBooks();

            Dictionary<int, int> order = ReadOrder();

            if (TryIssueBooks(
                order,
                out int totalCost,
                out int missingBook))
            {
                Console.WriteLine();
                Console.WriteLine("Выдача успешно оформлена.");
                Console.WriteLine(
                    $"Стоимость выдачи: {totalCost} руб.");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine(
                    $"Недостаточно экземпляров книги: {names[missingBook]}");
            }

            PrintRemaining();

            Console.ReadKey();
        }
    }
}





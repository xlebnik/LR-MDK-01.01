using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛБ2
{

    class Program
    {
        static string[] bookNames =
        {
        "Война и мир",
        "Анна Каренина",
        "Гарри Поттер",
        "Братья Карамазовы",
        "Мастер и Маргарита"
    };

        static int[] bookPrices = { 500, 400, 350, 450, 600 };
        static int[] bookCopies = { 10, 8, 12, 7, 6 };

        static int[] requestedCopies = new int[5];
        static void Main()
        {
            PrintBooks();
            ReadOrders();
            ProcessOrders();
            PrintRemainingBooks();
        }
        static void PrintBooks()
        {
            Console.WriteLine("Книги в фонде:");

            for (int i = 0; i < bookNames.Length; i++)
            {
                Console.WriteLine(
                    $"{i + 1}. {bookNames[i]} — {bookPrices[i]} руб., {bookCopies[i]} экз.");
            }

            Console.WriteLine();
        }
        static void ReadOrders()
        {
            while (true)
            {
                int bookNumber = ReadBookNumber();

                if (bookNumber == 0)
                    break;

                int quantity = ReadQuantity();

                requestedCopies[bookNumber - 1] += quantity;
            }
        }
        static int ReadBookNumber()
        {
            while (true)
            {
                Console.Write("Введите номер книги (0 — конец выдачи): ");

                if (int.TryParse(Console.ReadLine(), out int number) &&
                    number >= 0 && number <= 5)
                {
                    return number;
                }

                Console.WriteLine("Ошибка: введите число от 0 до 5.");
            }
        }
        static int ReadQuantity()
        {
            while (true)
            {
                Console.Write("Введите количество: ");

                if (int.TryParse(Console.ReadLine(), out int quantity) &&
                    quantity > 0)
                {
                    return quantity;
                }

                Console.WriteLine("Ошибка: количество должно быть больше нуля.");
            }
        }
        static void ProcessOrders()
        {
            int insufficientBook = FindInsufficientBook();

            if (insufficientBook != -1)
            {
                Console.WriteLine(
                    $"Не хватает книги: {bookNames[insufficientBook]}");
                return;
            }

            int totalCost = CalculateTotalCost();

            for (int i = 0; i < bookNames.Length; i++)
            {
                bookCopies[i] -= requestedCopies[i];
            }

            Console.WriteLine($"Стоимость выдачи: {totalCost} руб.");
        }
        static int FindInsufficientBook()
        {
            for (int i = 0; i < bookNames.Length; i++)
            {
                if (requestedCopies[i] > bookCopies[i])
                    return i;
            }

            return -1;
        }
        static int CalculateTotalCost()
        {
            int totalCost = 0;

            for (int i = 0; i < bookNames.Length; i++)
            {
                totalCost += requestedCopies[i] * bookPrices[i];
            }

            return totalCost;
        }
        static void PrintRemainingBooks()
        {
            Console.WriteLine("Осталось экземпляров:");

            for (int i = 0; i < bookNames.Length; i++)
            {
                Console.WriteLine(
                    $"{bookNames[i]} — {bookCopies[i]}");
            }
        }
    }
}


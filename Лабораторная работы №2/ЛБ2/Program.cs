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


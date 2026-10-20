using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа__3
{
    
        class Program
        {
            static void Main(string[] args)
            {
                Library library = new Library();

                library.PrintBooks();

                Dictionary<int, int> order =
                    Input.ReadOrder(library.Books.Length);

                if (library.HasEnoughBooks(order, out int missingBook))
                {
                    int totalCost = library.IssueBooks(order);

                    Console.WriteLine("\nВыдача успешно оформлена.");
                    Console.WriteLine(
                        $"Стоимость выдачи: {totalCost} руб.");
                }
                else
                {
                    Console.WriteLine(
                        "\nНедостаточно экземпляров книги: " +
                        library.Books[missingBook].Name);
                }

                library.PrintRemaining();

                Console.ReadKey();
            }
        }
    }
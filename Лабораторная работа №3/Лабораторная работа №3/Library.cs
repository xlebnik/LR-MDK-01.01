using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа__3
{

        class Library
        {
            public Book[] Books;

            public Library()
            {
                Books = new Book[]
                {
                new Book("Война и мир", 500, 10),
                new Book("Анна Каренина", 400, 8),
                new Book("Гарри Поттер", 350, 12),
                new Book("Братья Карамазовы", 450, 7),
                new Book("Мастер и Маргарита", 600, 6)
                };
            }

            public void PrintBooks()
            {
                Console.WriteLine("Книги в библиотеке:");

                for (int i = 0; i < Books.Length; i++)
                {
                    Books[i].PrintInfo(i + 1);
                }
            }

            public void PrintRemaining()
            {
                Console.WriteLine("\nОставшиеся книги:");

                for (int i = 0; i < Books.Length; i++)
                {
                    Books[i].PrintRemaining(i + 1);
                }
            }

            public bool HasEnoughBooks(
                Dictionary<int, int> order,
                out int missingBook)
            {
                missingBook = -1;

                foreach (var item in order)
                {
                    int index = item.Key;
                    int quantity = item.Value;

                    if (Books[index].Quantity < quantity)
                    {
                        missingBook = index;
                        return false;
                    }
                }

                return true;
            }

            public int IssueBooks(Dictionary<int, int> order)
            {
                int totalCost = 0;

                foreach (var item in order)
                {
                    int index = item.Key;
                    int quantity = item.Value;

                    Books[index].Quantity -= quantity;
                    totalCost += Books[index].Price * quantity;
                }

                return totalCost;
            }
        }
    }
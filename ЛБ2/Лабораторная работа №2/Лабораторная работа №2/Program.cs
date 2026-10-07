using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace LR2
{
    class Book
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }

        public Book(string name, int price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }
        static Book[] books =
{
    new Book("Война и мир", 500, 10),
    new Book("Анна Каренина", 400, 8),
    new Book("Гарри Поттер", 350, 12),
    new Book("Братья Карамазовы", 450, 7),
    new Book("Мастер и Маргарита", 600, 6)
};
        static void PrintBooks()
        {
            Console.WriteLine("Книги в библиотеке:");

            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine(
                    $"{i + 1}. {books[i].Name} - {books[i].Price} руб. - {books[i].Quantity} экз.");
            }
        }
        static int ReadBookNumber()
        {
            while (true)
            {
                Console.Write("Введите номер книги (0 - закончить): ");

                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    if (number >= 0 && number <= books.Length)
                    {
                        return number;
                    }
                }

                Console.WriteLine("Ошибка! Введите число от 0 до 5.");
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

                Console.WriteLine("Ошибка! Количество должно быть больше 0.");
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

            foreach (var item in order)
            {
                int index = item.Key;
                int quantity = item.Value;

                if (books[index].Quantity < quantity)
                {
                    missingBook = index;
                    return false;
                }
            }
            foreach (var item in order)
            {
                int index = item.Key;
                int quantity = item.Value;

                books[index].Quantity -= quantity;

                totalCost += books[index].Price * quantity;
            }
            return true;
        }
    }
}

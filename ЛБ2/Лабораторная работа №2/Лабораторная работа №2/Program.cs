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
    }
}

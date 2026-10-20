using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа__3
    {
        class Book
        {
            public string Name;
            public int Price;
            public int Quantity;

            public Book(string name, int price, int quantity)
            {
                Name = name;
                Price = price;
                Quantity = quantity;
            }

            public void PrintInfo(int number)
            {
                Console.WriteLine(
                    $"{number}. {Name} - {Price} руб. - {Quantity} экз.");
            }

            public void PrintRemaining(int number)
            {
                Console.WriteLine(
                    $"{number}. {Name} - осталось {Quantity} экз.");
            }
        }
    }
}
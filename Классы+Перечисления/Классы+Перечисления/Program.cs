using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Классы_Перечисления
{
   internal class Program
    {
        static void Main()
        {
            Product p1 = new Product("Хлеб", ProductGroup.Food, 50, 30);

            Product p2 = new Product("Телевизор", ProductGroup.Electronics, 60000, 30000);

            Product p3 = new Product("Юбка", ProductGroup.Clothes, 1000, 700);

            Product p4 = new Product("Венерина Мухоловка", ProductGroup.Other, 1700, 1500);

            Product[] products = { p1, p2, p3, p4 };

            SellHistory history = new SellHistory();

            DateTime day1 = new DateTime(2026, 06, 26);
            DateTime day2 = new DateTime(2026, 08, 15);

            for (int i = 0; i < 20; i++)
            {
                Product product = products[i % 4];

                DateTime date;

                if (i < 10)
                    date = day1;
                else
                    date = day2;

                history.Add(new SellItem(product, 1, date));
            }
            Console.WriteLine("История продаж");
            history.Show();

            Console.WriteLine();

            ProductPeriodReport report1 = new ProductPeriodReport();
            report1.Show(history, day1, day2);
            Console.WriteLine();
            ProductPeriodReport report2 = new ProductPeriodReport();
            report2.Show(history);
            Console.ReadKey();
        }
    }

  } 


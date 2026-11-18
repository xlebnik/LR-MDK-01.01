using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР2
{
    internal class Program
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
        static int PrintBooks()
        {
            Console.WriteLine("Книги в библиотеке:");

            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(
                    $"{i + 1}. {names[i]} - {prices[i]} руб. - {quantities[i]} экз.");
            }

            return 0;
        }
    }
}

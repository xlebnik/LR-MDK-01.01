using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Перечисления
{
    enum Clothing
    {
        Jacket = 1,
        TShirt = 2,
        Cap = 3,
        Coat = 4,
        Sweater = 5

    }
    class Program
    {
        static void Main()
        {
          Console.WriteLine("Выберите себе одежду:");
          Console.WriteLine("1 - Jacket ");
          Console.WriteLine("2 - TShirt");
          Console.WriteLine("3 - Cap:");
          Console.WriteLine("4 - Coat");
          Console.WriteLine("5 - Sweater");

            int choice = Convert.ToInt32(Console.ReadLine());
            Clothing clothes = (Clothing)choice;

            switch(clothes)
            {
                case Clothing.Jacket:
                    Console.WriteLine("Вы выбрали КУРТКУ!");
                    break;
                case Clothing.TShirt:
                    Console.WriteLine("Вы выбрали ФУТБОЛКУ!");
                    break;
                case Clothing.Cap:
                    Console.WriteLine("Вы выбрали КЕПКУ!");
                    break;
                case Clothing.Coat:
                    Console.WriteLine("Вы выбрали КОФТУ!");
                    break;
                case Clothing.Sweater:
                    Console.WriteLine("Вы выбрали СВИТЕР!");
                    break;
                default:
                    Console.WriteLine("ЭЭЭ, КУДА ПИШЕМ?!");
                    break;
             }
            Console.WriteLine("Нажмите любую кнопку для выхода...");
            Console.ReadKey();
        }
    }
}


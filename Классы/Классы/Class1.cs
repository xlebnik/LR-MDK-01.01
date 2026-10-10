using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Классы
{
    class Program
    {
        static void Main()
        {
            Ships ship = new Ships();
            Ships1 ship1 = new Ships1();

            ship.SetBrand("Oceanco");
            ship.SetYear(2020);

            ship1.SetBrand("Heesen");
            ship1.SetYear(2006);

            string brand = ship.GetBrand();
            int year = ship.GetYear();

            Console.WriteLine(brand);
            Console.WriteLine(year);
        }
    }
}

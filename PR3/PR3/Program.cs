using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            Product product1 = new Product();
            product1.SetName("Клей Момент");
            product1.SetPrice(350);
            product1.SetQuantity(200);
            products.Add(product1);

            Derived product2 = new Derived();
            product2.SetName("Цветные карандаши Каляка-Маляка");
            product2.SetPrice(400);
            product2.SetQuantity(20);
            products.Add(product2);

            Derived product3 = new Derived();
            product3.SetName("Краски акриловые");
            product3.SetPrice(600);
            product3.SetQuantity(150);
            products.Add(product3);

            Derived product4 = new Derived();
            product4.SetName("Бумага цветная");
            product4.SetPrice(250);
            product4.SetQuantity(350);
            products.Add(product4);

            Derived2 product5 = new Derived2();
            product5.SetName("Простой карандаш Berlingo");
            product5.SetPrice(50);
            product5.SetQuantity(120);
            products.Add(product5);

            Derived2 product6 = new Derived2();
            product6.SetName("Блокнот А5");
            product6.SetPrice(160);
            product6.SetQuantity(80);
            products.Add(product6);
        }
    }
}

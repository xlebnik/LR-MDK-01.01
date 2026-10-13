using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Классы_Перечисления
{
    public class SellHistory
    {
        public List<SellItem> sales = new List<SellItem>();

        public void Add(SellItem item)
        {
            sales.Add(item);
        }
        public void Show()
        {
            foreach (SellItem item in sales)
            {
                Console.WriteLine(item.date.ToShortDateString() + "" + item.product.name_ + "" + item.count + "шт.");
            }
        }
    }
}

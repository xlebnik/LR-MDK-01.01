using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Классы_Перечисления
{
   public class ProductPeriodReport
    {
        public void Show(SellHistory history, DateTime start, DateTime end)
        {
            double sum = 0;
            int count = 0;

            foreach (SellItem item in history.sales)
            { 
            if (item.date >= start && item.date <= end)
                {
                    sum += item.GetSum();
                    count += item.count;
                }
            }

            Console.WriteLine("Отчёт за период");
            Console.WriteLine("Кол-во товаров:" + count);
            Console.WriteLine("Сумма продаж" + sum);
        }
    }
}

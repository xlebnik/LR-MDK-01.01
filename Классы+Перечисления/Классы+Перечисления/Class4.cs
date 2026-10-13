using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Классы_Перечисления
{
    public class ProductGroupReport
    {
        public void Show(SellHistory history)
        {
            double maxProfit = double.MinValue;
            ProductGroup bestGroup = ProductGroup.Food;

            foreach (ProductGroup group in Enum.GetValues(typeof(ProductGroup)))
                {
                double profit = 0;

                foreach(SellItem item in history.sales)
                {
                    if (item.product.group_ == group)
                    {
                        profit += item.GetProfit();
                    }
                }
                if (profit > maxProfit)
                {
                    maxProfit = profit;
                    bestGroup = group;
                }
            }

            Console.WriteLine("Самая прибыльная группа:" + bestGroup);
            Console.WriteLine("Прибыль:" + maxProfit);
        }
    }
}

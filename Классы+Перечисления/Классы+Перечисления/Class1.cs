using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Классы_Перечисления
{
    public class SellItem
    {
        public Product product;
        public int count;
        public DateTime date;

        public SellItem(Product product, int count, DateTime date)
        {
            this.product = product;
            this.count = count;
            this.date = date;
        }

        public double GetSum()
        {
            return product.price_ * count;
        }
        public double GetProfit()
        {
            return (product.price_ - product.cost_) * count;
        }
    }
}

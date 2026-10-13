using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Классы_Перечисления
{
    public enum ProductGroup
    {
        Food,
        Electronics,
        Clothes,
        Other
    }
    public class Product
    {
        public string name_;
        public ProductGroup group_;
        public double price_;
        public double cost_;

        public Product(string name, ProductGroup group, double price, double cost)
        {
            this.name_ = name;
            this.group_ = group;
            this.price_ = price;
            this.cost_ = cost;
        }
    }
}

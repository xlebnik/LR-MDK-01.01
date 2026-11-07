using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR3
{
    public class Derived2 : Product
    {
        public override double GetDiscount()
        {
            if  (Quantity_ >= 5 && Quantity_ <= 10)
            {
                return 15;
            }

            else if (Quantity_ > 10)
            {
                return 25;
            }

            return 0;
        }
    }
}

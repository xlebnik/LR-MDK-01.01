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
            return 5;
        }
    }
}

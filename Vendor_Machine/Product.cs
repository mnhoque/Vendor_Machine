using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendor_Machine
{
    abstract class Product
    {
        
        public abstract double Show_price();
        public abstract double BuyProduct();
        public abstract void put();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendor_Machine
{
    class Snacks : Product
    {
        double price_per_item = 20.00;
        public int amount_Of_Product { get; set; }
        double total_Sum = 0;

        public Snacks()
        {
            amount_Of_Product = 1;
            Console.WriteLine($"The price of per unit of the product is {price_per_item * amount_Of_Product }");
        }
        public Snacks(int _amount) : this()
        {
            this.amount_Of_Product = _amount;
        }

        public override double Show_price()
        {
            //Console.WriteLine($"The price of per unit of the product is {price_per_item }");
            total_Sum = amount_Of_Product * price_per_item;
            Console.WriteLine($"The total price is {total_Sum}");
            return total_Sum;

        }

        public override void put()
        {
            if (ready == true)
            {
                Console.WriteLine("Now you can drink ");
            }
        }
        bool ready = false;
        public override double BuyProduct()
        {

            Console.WriteLine("You can buy the product ");
            Program.RestOFMoney = Program.RestOFMoney - total_Sum;
            Console.WriteLine("Now the rest of money is " + Program.RestOFMoney);

            return Program.RestOFMoney;
        }

        public bool ability_buy()
        {
            bool abilityToBuy = false;

            if (Program.RestOFMoney >= total_Sum)
            {
                abilityToBuy = true;
            }
            Console.WriteLine("Can he buy the product " + abilityToBuy);
            return abilityToBuy;
        }
    }
}

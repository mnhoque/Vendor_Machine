using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendor_Machine
{
    class Food : Product
    {

        double price_per_item = 15.00;
        public int amount_Of_Product { get; set; }
        double totalSum = 0;

        public Food()
        {
            amount_Of_Product = 1;
            Console.WriteLine($"The price of per unit of the product is {price_per_item * amount_Of_Product }");
        }
        public Food(int _amount) : this()
        {
            this.amount_Of_Product = _amount;
        }

        public override double Show_price()
        {
            //Console.WriteLine($"The price of per unit of the product is {price_per_item }");
            totalSum = amount_Of_Product * price_per_item;
            Console.WriteLine($"The total price is {totalSum}");
            return totalSum;
        }

        public override void put()
        {
            throw new NotImplementedException();
        }

        public override double BuyProduct()
        {

            Console.WriteLine("You can buy the product ");
            Program.RestOFMoney = Program.RestOFMoney - totalSum;
            Console.WriteLine("Now the rest of money is " + Program.RestOFMoney);

            return Program.RestOFMoney;
        }

        public bool ability_buy()
        {
            bool abilityToBuy = false;

            if (Program.RestOFMoney >= totalSum)
            {
                abilityToBuy = true;
            }
            Console.WriteLine("Can he buy the product " + abilityToBuy);
            return abilityToBuy;
        }

    }
}

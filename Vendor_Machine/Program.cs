using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Vendor_Machine
{
    class Program
    {
        static double totalMoney = 0;
        static int CountProduct = 0;
        public static double RestOFMoney = 0;
        //static List<Product> list = new List<Product>();
        static void Main(string[] args)
        {
            int[] Types_Of_Money = { 1, 5, 10, 20, 50,100,500,1000 };
            Console.WriteLine("How much money do you enter ");
            
            double.TryParse(Console.ReadLine(), out  totalMoney);
            bool checkMoney = false;
            bool check = false;
            double enteredTotalMoney = 0;
            bool continueShopping = true;
            Console.WriteLine("Please enter the money in forms of 1,5,10,20,50,100,500,1000");
            while (check==false)
            {
                double.TryParse(Console.ReadLine(), out double entered_Money);
                for (int i = 0; i < Types_Of_Money.Length; i++)
                {
                    if (entered_Money == Types_Of_Money[i])
                    {
                        enteredTotalMoney = enteredTotalMoney + entered_Money;
                        checkMoney = true;
                        break;
                        
                    }
                    
                }
                if (checkMoney == false)
                {
                    Console.WriteLine("Enter the right amount money mentioed before");
                    continue;
                }
                //enteredTotalMoney = enteredTotalMoney + entered_Money;
                if (enteredTotalMoney >= totalMoney)
                {
                    check = true;
                    RestOFMoney = enteredTotalMoney;
                    break;
                }
            }

            Console.WriteLine("Now the total entered money is {0}", RestOFMoney);

            Console.WriteLine("What are you want to buy");

            while (continueShopping == true)
            {
                string x = Console.ReadLine();

                if (x.ToUpper() == "DRINKS")
                {
                    Console.WriteLine("How many you want to buy ");
                    int amount = int.Parse(Console.ReadLine());
                    Drinks drink = new Drinks(amount);
                    double price = drink.Show_price();
                    if (drink.ability_buy() == true)
                    {
                        drink.BuyProduct();
                        CountProduct = CountProduct+amount;
                    }
                    else
                    {
                        double missing_Money = price - RestOFMoney;
                        Console.WriteLine($"Please enter the {missing_Money} money by writting yes  of to buy product or write cancel to cancel the order ");
                        string word = Console.ReadLine();
                        if (word.ToUpper() == "YES")
                        {
                            while (RestOFMoney < price)
                            {
                                Console.WriteLine("Enter the money in the mentioned form ");
                                double.TryParse(Console.ReadLine(), out double entered_New_Money);
                                RestOFMoney = RestOFMoney + entered_New_Money;
                                if (RestOFMoney >= price)
                                {
                                    drink.BuyProduct();
                                    CountProduct = CountProduct + amount;
                                    break;
                                }
                            }
                            //bool check= 
                            //while (drink.ability_buy() == false)
                            //{
                            //    double.TryParse(Console.ReadLine(), out double new_entered_money);
                            //    RestOFMoney = RestOFMoney + new_entered_money;
                            //    if (drink.ability_buy() == true)
                            //    {
                            //        drink.BuyProduct();
                            //        CountProduct = CountProduct + amount;
                            //        break;
                            //    }
                            //}
                        }
                        else
                        {
                            Console.WriteLine($"Collect {RestOFMoney} from the box");
                            continueShopping = false;
                            break;
                        }
                    }
                    
                    Console.WriteLine("Do you want to buy more or finish ");
                    string continue_Shopping = Console.ReadLine();
                    if (continue_Shopping.ToUpper() == "YES")
                    {
                        continue;
                    }
                    else
                    {
                        drink.put();
                        continueShopping = false;
                        break;
                    }
                }
                else if (x.ToUpper() == "SNACKS")
                {
                    Console.WriteLine("How many you want to buy ");
                    int amount = int.Parse(Console.ReadLine());
                    Snacks drink = new Snacks(amount);
                    drink.Show_price();
                    if (drink.ability_buy() == true)
                    {
                        drink.BuyProduct();
                    }
                    else
                    {
                        Console.WriteLine("Please enter the rest of money of the order or cancel the order ");
                        string word = Console.ReadLine();
                        if (word.ToUpper() == "YES")
                        {
                            while (drink.ability_buy() == false)
                            {
                                double.TryParse(Console.ReadLine(), out double new_entered_money);
                                RestOFMoney = RestOFMoney + new_entered_money;
                                if (drink.ability_buy() == true)
                                {
                                    drink.BuyProduct();
                                    break;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Collect {RestOFMoney} from the box");
                            break;
                        }
                    }

                    Console.WriteLine("Do you want to buy more or finish ");
                    string continue_Shopping = Console.ReadLine();
                    if (continue_Shopping.ToUpper() == "YES")
                    {
                        continue;
                    }
                    else
                    {
                        continueShopping = false;
                        break;
                    }
                }
                else if (x.ToUpper() == "FOOD")
                {
                    Console.WriteLine("How many you want to buy ");
                    int amount = int.Parse(Console.ReadLine());
                    Food drink = new Food(amount);
                    drink.Show_price();
                    if (drink.ability_buy() == true)
                    {
                        drink.BuyProduct();
                        CountProduct = amount;
                    }
                    else
                    {
                        Console.WriteLine("Please enter the rest of money of the order or cancel the order ");
                        string word = Console.ReadLine();
                        if (word.ToUpper() == "YES")
                        {
                            
                        }
                        else
                        {
                            Console.WriteLine($"Collect {RestOFMoney} from the box");
                            continueShopping = false;
                            break;
                        }
                    }

                    Console.WriteLine("Do you want to buy more or finish ");
                    string continue_Shopping = Console.ReadLine();
                    if (continue_Shopping.ToUpper() == "YES")
                    {
                        continue;
                    }
                    else
                    {
                        continueShopping = false;
                        break;
                    }
                }



            }
            Console.ReadLine();
        }

        
        
    }
}

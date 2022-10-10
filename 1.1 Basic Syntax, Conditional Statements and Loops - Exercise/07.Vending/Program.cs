using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace _07.Vending
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            double coinsSum = 0;

            while (command != "Start")
            {
                double coins = double.Parse(command);

                if (coins == 0.1 || coins == 0.2 || coins == 0.5 || coins == 1 || coins == 2)
                {
                    coinsSum += coins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }

                command = Console.ReadLine();
            }

            string product = Console.ReadLine();

            while (product != "End")
            {
                double productPrice = 0;

                if (product == "Nuts")
                {
                    productPrice = 2;
                }
                else if (product == "Water")
                {
                    productPrice = 0.7;
                }
                else if (product == "Crisps")
                {
                    productPrice = 1.5;
                }
                else if (product == "Soda")
                {
                    productPrice = 0.8;
                }
                else if (product == "Coke")
                {
                    productPrice = 1;
                }
                else
                {
                    productPrice = 0;
                }

                if (productPrice == 0)
                {
                    Console.WriteLine("Invalid product");
                }
                else if (productPrice > coinsSum)
                {
                    Console.WriteLine("Sorry, not enough money");
                }
                else
                {
                    Console.WriteLine($"Purchased {product.ToLower()}");
                    coinsSum -= productPrice;
                }

                product = Console.ReadLine();
            }

            Console.WriteLine($"Change: {coinsSum:F2}");
        }
    }
}

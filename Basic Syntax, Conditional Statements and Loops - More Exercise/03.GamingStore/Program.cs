using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _03.GamingStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double moneyBalance = double.Parse(Console.ReadLine());

            double totalSpend = 0;

            string command = Console.ReadLine();

            while (command != "Game Time")
            {
                double gamePrice = 0;

                if (command == "OutFall 4")
                {
                    gamePrice = 39.99;
                }
                else if (command == "CS: OG")
                {
                    gamePrice = 15.99;
                }
                else if (command == "Zplinter Zell")
                {
                    gamePrice = 19.99;
                }
                else if (command == "Honored 2")
                {
                    gamePrice = 59.99;
                }
                else if (command == "RoverWatch")
                {
                    gamePrice = 29.99;
                }
                else if (command == "RoverWatch Origins Edition")
                {
                    gamePrice = 39.99;
                }
                else
                {
                    Console.WriteLine("Not Found");
                }

                if (gamePrice > moneyBalance)
                {
                    Console.WriteLine("Too Expensive");
                }
                else if (gamePrice != 0)
                {
                    Console.WriteLine($"Bought {command}");
                    totalSpend += gamePrice;
                    moneyBalance -= gamePrice;
                }

                if (moneyBalance <= 0)
                {
                    break;
                }

                command = Console.ReadLine();
            }

            if (moneyBalance <= 0)
            {
                Console.WriteLine("Out of money!");
            }
            else
            {
                Console.WriteLine($"Total spent: ${totalSpend:F2}. Remaining: ${moneyBalance:F2}");
            }
        }
    }
}

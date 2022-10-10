using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOrders = int.Parse(Console.ReadLine());

            double finalPrice = 0;

            for (int i = 1; i <= countOrders; i++)
            {
                double totalPrice = 0;

                double capsulePrice = double.Parse(Console.ReadLine());
                int daysInMonth = int.Parse(Console.ReadLine());
                int capsuleCount = int.Parse(Console.ReadLine());

                totalPrice = (daysInMonth * capsuleCount) * capsulePrice;
                finalPrice += totalPrice;

                Console.WriteLine($"The price for the coffee is: ${totalPrice:F2}");
            }

            Console.WriteLine($"Total: ${finalPrice:F2}");
        }
    }
}

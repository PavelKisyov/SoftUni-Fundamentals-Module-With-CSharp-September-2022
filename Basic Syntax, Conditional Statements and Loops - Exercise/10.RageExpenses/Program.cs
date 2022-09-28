using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.RageExpenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double totalExpenses = 0;
            
            for (int i = 1; i <= lostGames; i++)
            {
                
                if (i % 2 == 0)
                {
                    totalExpenses += headsetPrice;
                }
                if (i % 3 == 0)
                {
                    totalExpenses += mousePrice;
                }
                if (i % 6 == 0)
                {
                    totalExpenses += keyboardPrice;
                }
                if (i % 12 == 0)
                {
                    totalExpenses += displayPrice; 
                }
            }

            Console.WriteLine($"Rage expenses: {totalExpenses:F2} lv.");
        }
    }
}

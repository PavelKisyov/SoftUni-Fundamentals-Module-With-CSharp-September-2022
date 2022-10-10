using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.SpiceMustFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());

            int daysCounter = 0;
            int totalSpices = 0;

            while (startingYield >= 100)
            {
                daysCounter++;
                totalSpices += startingYield;

                if (totalSpices <= 26)
                {
                    totalSpices = 0;
                }
                else
                {
                    totalSpices -= 26;
                }

                startingYield -= 10;
            }

            if (totalSpices <= 26)
            {
                totalSpices = 0;
            }
            else
            {
                totalSpices -= 26;
            }

            Console.WriteLine(daysCounter);
            Console.WriteLine(totalSpices);

        }
    }
}

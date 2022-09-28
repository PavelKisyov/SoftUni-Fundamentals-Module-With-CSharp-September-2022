using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.WaterOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());
            int maxCapacity = 255;
            int currCapacity = 0;

            for (int i = 0; i < counter; i++)
            {
                int liters = int.Parse(Console.ReadLine());

                if ((currCapacity + liters) > maxCapacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    currCapacity += liters;
                }
            }

            Console.WriteLine(currCapacity);
        }
    }
}

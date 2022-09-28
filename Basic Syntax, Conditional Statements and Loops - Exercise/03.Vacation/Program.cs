using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();

            double totalPrice = 0;

            if (groupType == "Students")
            {
                if (dayOfWeek == "Friday")
                {
                    totalPrice = peopleCount * 8.45;
                }
                else if (dayOfWeek == "Saturday")
                {
                    totalPrice = peopleCount * 9.80;
                }
                else if (dayOfWeek == "Sunday")
                {
                    totalPrice = peopleCount * 10.46;
                }

                if (peopleCount >= 30)
                {
                    totalPrice -= (totalPrice * 0.15);
                }
            }
            else if (groupType == "Business")
            {

                if (peopleCount >= 100)
                {
                    peopleCount -= 10;
                }

                if (dayOfWeek == "Friday")
                {
                    totalPrice = peopleCount * 10.90;
                }
                else if (dayOfWeek == "Saturday")
                {
                    totalPrice = peopleCount * 15.60;
                }
                else if (dayOfWeek == "Sunday")
                {
                    totalPrice = peopleCount * 16;
                }
            }
            else if (groupType == "Regular")
            {
                if (dayOfWeek == "Friday")
                {
                    totalPrice = peopleCount * 15;
                }
                else if (dayOfWeek == "Saturday")
                {
                    totalPrice = peopleCount * 20;
                }
                else if (dayOfWeek == "Sunday")
                {
                    totalPrice = peopleCount * 22.50;
                }

                if (peopleCount >= 10 && peopleCount <= 20)
                {
                    totalPrice -= (totalPrice * 0.05);
                }
            }

            Console.WriteLine($"Total price: {totalPrice:F2} ");
        }
    }
}

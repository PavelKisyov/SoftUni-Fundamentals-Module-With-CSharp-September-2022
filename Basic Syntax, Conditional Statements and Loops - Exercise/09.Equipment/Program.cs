using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double amountMoney = double.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            double lightsaberPrice = double.Parse(Console.ReadLine());
            double robesPrice = double.Parse(Console.ReadLine());
            double beltsPrice = double.Parse(Console.ReadLine());

            double totalMoneyNeeded = 0;
            int belts = studentsCount / 6;
            double studentsPercent = Math.Ceiling(studentsCount * 0.1 + studentsCount);

            totalMoneyNeeded = (lightsaberPrice * studentsPercent) + robesPrice * studentsCount + (beltsPrice * (studentsCount - belts));

            if (totalMoneyNeeded <= amountMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {totalMoneyNeeded:F2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {totalMoneyNeeded - amountMoney:F2}lv more.");
            }
        }
    }
}

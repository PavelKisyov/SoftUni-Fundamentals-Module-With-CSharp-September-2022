﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.EnglishNameOfTheLastDigi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int lastDigit = num % 10;

            if (lastDigit == 0)
            {
                Console.WriteLine("zero");
            }
            else if (lastDigit == 1)
            {
                Console.WriteLine("one");
            }
            else if (lastDigit == 2)
            {
                Console.WriteLine("two");
            }
            else if (lastDigit == 3)
            {
                Console.WriteLine("three");
            }
            else if (lastDigit == 4)
            {
                Console.WriteLine("four");
            }
            else if (lastDigit == 5)
            {
                Console.WriteLine("five");
            }
            else if (lastDigit == 6)
            {
                Console.WriteLine("six");
            }
            else if (lastDigit == 7)
            {
                Console.WriteLine("seven");
            }
            else if (lastDigit == 8)
            {
                Console.WriteLine("eight");
            }
            else if (lastDigit == 9)
            {
                Console.WriteLine("nine");
            }
        }
    }
}

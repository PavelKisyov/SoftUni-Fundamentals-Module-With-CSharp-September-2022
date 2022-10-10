using System;
using System.Runtime.ExceptionServices;

namespace _02.FromLeftToTheRight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < countNumber; i++)
            {
                string input = Console.ReadLine();
                string leftNumber = string.Empty;
                string rightNumber = string.Empty;
                int counter = 0;

                for (int j = 0; j <= input.Length; j++)
                {
                    char symbol = input[j];

                    if (symbol != ' ')
                    {
                        leftNumber += symbol;
                        counter++;
                    }
                    else
                    {
                        break;
                    }
                }

                for (int k = counter + 1; k < input.Length; k++)
                {
                    char symbol = input[k];
                    rightNumber += symbol;
                }

                long left = long.Parse(leftNumber);
                long right = long.Parse(rightNumber);
                long biggerNumber = 0;

                if (left > right)
                {
                    biggerNumber = left;
                }
                else
                {
                    biggerNumber = right;
                }

                long sum = 0;

                while (Math.Abs(biggerNumber) > 0)
                {
                    sum += biggerNumber % 10;
                    biggerNumber /= 10;
                }

                Console.WriteLine(Math.Abs(sum));
            }
        }
    }
}

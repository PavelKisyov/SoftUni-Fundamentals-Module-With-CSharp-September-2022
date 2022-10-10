using System;
using System.Linq;

namespace _05.TopIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < number.Length; i++)
            {
                int currNum = number[i];

                bool topInteger = true;

                for (int j = i + 1; j < number.Length; j++)
                {
                    int nextNum = number[j];

                    if (nextNum >= currNum)
                    {
                        topInteger = false;
                        break;
                    }
                }

                if (topInteger)
                {
                    Console.Write(currNum + " ");
                }
            }
        }
    }
}

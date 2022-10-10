using System;
using System.Linq;

namespace _03.ZigZagArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int[] firstLine = new int[num];
            int[] secondLine = new int[num];

            for (int i = 1; i <= num; i++)
            {
                int[] numbers = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();

                int firstNum = numbers[0];
                int secondNum = numbers[1];

                if (i % 2 == 1)
                {
                    firstLine[i - 1] = firstNum;
                    secondLine[i - 1] = secondNum;
                }
                else
                {
                    firstLine[i - 1] = secondNum;
                    secondLine[i - 1] = firstNum;
                }
            }

            Console.WriteLine(String.Join(" ", firstLine));
            Console.WriteLine(String.Join(" ", secondLine));
        }
    }
}

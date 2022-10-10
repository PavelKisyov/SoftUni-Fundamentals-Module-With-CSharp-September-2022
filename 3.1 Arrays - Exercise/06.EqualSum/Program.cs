using System;
using System.Linq;
using System.Runtime.ExceptionServices;

namespace _06.EqualSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            bool isFound = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                int leftSum = 0;

                for (int j = 0; j < i; j++)
                {
                    leftSum += numbers[j];
                }

                int rightSum = 0;

                for (int k = numbers.Length - 1; k > i; k--)
                {
                    rightSum += numbers[k];
                }

                if (leftSum == rightSum && isFound == false)
                {
                    Console.WriteLine(i);
                    isFound = true;
                }
            }

            if (isFound == false)
            {
                Console.WriteLine("no");
            }
        }
    }
}
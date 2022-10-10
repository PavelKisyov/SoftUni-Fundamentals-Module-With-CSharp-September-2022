using System;
using System.Linq;

namespace _07.MaxSequenceOfEqualElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int number = 0;
            int sequenceLenght = 1;
            int longestSequence = 0;

            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] == input[i + 1])
                {
                    sequenceLenght++;
                }
                else
                {
                    sequenceLenght = 1;
                }

                if (sequenceLenght > longestSequence)
                {
                    number = input[i];
                    longestSequence = sequenceLenght;
                }
            }

            for (int j = 0; j < longestSequence; j++)
            {
                Console.Write($"{number} ");
            }
        }
    }
}

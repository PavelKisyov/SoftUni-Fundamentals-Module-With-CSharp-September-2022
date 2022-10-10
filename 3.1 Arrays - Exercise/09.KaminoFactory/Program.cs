using System;
using System.Linq;

namespace _09.KaminoFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int[] bestSequance = new int[lenght];
            string command = string.Empty;

            int bestSequanceLenght = 1;
            int bestStartIndex = 0;
            int bestSequanceSum = 0;
            int bestSequanceIndex = 0;

            int indexCounter = 0;

            while ((command = Console.ReadLine()) != "Clone them!")
            {
                indexCounter++;

                int[] currentSequance = command
                    .Split("!", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int longestSequance = 1;
                int bestCurrentSequanceLenght = 1;
                int startIndex = 0;
                int currentSequanceSum = 0;

                for (int i = 0; i < currentSequance.Length - 1; i++)
                {
                    if (currentSequance[i] == currentSequance[i + 1])
                    {
                        longestSequance++;
                    }
                    else
                    {
                        longestSequance = 1;
                    }

                    if (longestSequance > bestCurrentSequanceLenght)
                    {
                        bestCurrentSequanceLenght = longestSequance;
                        startIndex = i;
                    }

                    currentSequanceSum += currentSequance[i];
                }

                currentSequanceSum += currentSequance[lenght - 1];

                if (bestCurrentSequanceLenght > bestSequanceLenght)
                {
                    bestSequanceLenght = bestCurrentSequanceLenght;
                    bestStartIndex = startIndex;
                    bestSequanceSum = currentSequanceSum;
                    bestSequanceIndex = indexCounter;
                    bestSequance = currentSequance.ToArray();
                }
                else if (bestCurrentSequanceLenght == bestSequanceLenght)
                {
                    if (startIndex < bestStartIndex)
                    {
                        bestSequanceLenght = bestCurrentSequanceLenght;
                        bestStartIndex = startIndex;
                        bestSequanceSum = currentSequanceSum;
                        bestSequanceIndex = indexCounter;
                        bestSequance = currentSequance.ToArray();
                    }
                    else if (startIndex == bestStartIndex)
                    {
                        if (currentSequanceSum > bestSequanceSum)
                        {
                            bestSequanceLenght = bestCurrentSequanceLenght;
                            bestStartIndex = startIndex;
                            bestSequanceSum = currentSequanceSum;
                            bestSequanceIndex = indexCounter;
                            bestSequance = currentSequance.ToArray();
                        }
                    }
                }
            }

            Console.WriteLine($"Best DNA sample {bestSequanceIndex} with sum: {bestSequanceSum}.");
            Console.WriteLine(string.Join(' ', bestSequance));
        }
    }
}

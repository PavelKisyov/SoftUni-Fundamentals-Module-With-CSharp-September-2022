using System;
using System.Linq;

namespace _10.LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine()); // 3
            int[] ladybugPosition = Console.ReadLine() // 0 1
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] field = new int[fieldSize];

            for (int i = 0; i < ladybugPosition.Length; i++)
            {
                int currentPosition = ladybugPosition[i];

                if (currentPosition >= 0 && currentPosition < field.Length)
                {
                    field[currentPosition] = 1;
                }
            }
            
            string command = string.Empty;

            while ((command = Console.ReadLine()) != "end") // 0 right 1
            {
                string[] elements = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int ladybug = int.Parse(elements[0]); // 0
                string direction = elements[1]; // right
                int flyLenght = int.Parse(elements[2]); // 1

                if (ladybug < 0 || ladybug > field.Length - 1 || field[ladybug] == 0)
                {
                    continue;
                }

                field[ladybug] = 0;

                if (direction == "right")
                {
                    int landIndex = ladybug + flyLenght;

                    if (landIndex > field.Length - 1)
                    {
                        continue;
                    }

                    if (field[landIndex] == 1)
                    {
                        while (field[landIndex] == 1)
                        {
                            landIndex += flyLenght;

                            if (landIndex > field.Length - 1)
                            {
                                break;
                            }
                        }
                    }

                    if (landIndex >= 0 && landIndex <= field.Length - 1)
                    {
                        field[landIndex] = 1;
                    }

                }
                else if (direction == "left")
                {
                    int landIndex = ladybug - flyLenght;

                    if (landIndex < 0)
                    {
                        continue;
                    }

                    if (field[landIndex] == 1)
                    {
                        while (field[landIndex] == 1)
                        {
                            landIndex -= flyLenght;

                            if (landIndex < 0)
                            {
                                break;
                            }
                        }
                    }

                    if (landIndex >= 0 && landIndex <= field.Length - 1)
                    {
                        field[landIndex] = 1;
                    }

                }
                
            }

            Console.WriteLine(String.Join(" ", field));
        }
    }
}

using System;
using System.Linq;

namespace _04.ArrayRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int rotations = int.Parse(Console.ReadLine());
            int optimisedRotations = rotations % arr.Length;

            for (int i = 0; i < optimisedRotations; i++)
            {
                int firstNum = arr[0];

                for (int j = 1; j < arr.Length; j++)
                {
                    arr[j - 1] = arr[j];
                }

                arr[arr.Length - 1] = firstNum;
            }

            Console.WriteLine(String.Join(" ", arr));
        }
    }
}

using System;

namespace _01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int[] wagons = new int[num];
            int sum = 0;

            for (int i = 0; i < wagons.Length; i++)
            {
                wagons[i] = int.Parse(Console.ReadLine());

                Console.Write($"{wagons[i]} ");

                sum += wagons[i];
            }
            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}

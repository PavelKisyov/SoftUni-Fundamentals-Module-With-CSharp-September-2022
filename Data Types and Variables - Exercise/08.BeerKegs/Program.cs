using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.BeerKegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfKegs = int.Parse(Console.ReadLine());
            
            string biggestKeg = string.Empty;
            float currentBiggest = float.MinValue;

            for (int i = 0; i < countOfKegs; i++)
            {
                string model = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                float volume = (float)(Math.PI * Math.Pow(radius, 2) * height);

                if (volume > currentBiggest)
                {
                    currentBiggest = volume;
                    biggestKeg = model;
                }
            }

            Console.WriteLine(biggestKeg);
        }
    }
}

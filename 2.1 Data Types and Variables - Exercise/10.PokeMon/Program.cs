using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.PokeMon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int power = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhautionFactor = int.Parse(Console.ReadLine());

            double halfPower = power * 0.5;
            int pokeCount = 0;

            while (power >= distance)
            {
                pokeCount++;
                power -= distance;

                if (power == halfPower && exhautionFactor != 0)
                {
                    power /= exhautionFactor;
                }
             
            }

            Console.WriteLine(power);
            Console.WriteLine(pokeCount);
        }
    }
}

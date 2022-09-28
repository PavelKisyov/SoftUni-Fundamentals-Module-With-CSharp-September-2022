using System;

namespace _04.Refactoring_PrimeChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 2; i <= number; i++)
            {
                string isValid = "true";
                
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isValid = "false";
                        break;
                    }
                }

                Console.WriteLine($"{i} -> {isValid}");

            }
        }
        }
}

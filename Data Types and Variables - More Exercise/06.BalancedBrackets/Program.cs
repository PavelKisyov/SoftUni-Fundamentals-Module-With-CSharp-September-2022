using System;

namespace _06.BalancedBrackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int linesCount = int.Parse(Console.ReadLine());

            int openBracets = 0;
            int closedBracets = 0;

            for (int i = 0; i < linesCount; i++)
            {
                if (closedBracets > openBracets)
                {
                    break;
                }

                string calculation = Console.ReadLine();

                for (int j = 0; j < calculation.Length; j++)
                {
                    char currentSymbol = calculation[j];
                    
                    if (currentSymbol == '(')
                    {
                        openBracets++;
                    }
                    else if (currentSymbol == ')')
                    {
                        closedBracets++;
                    }

                    if (closedBracets > openBracets)
                    {
                        break;
                    }
                }
            }

            if (openBracets == closedBracets)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}

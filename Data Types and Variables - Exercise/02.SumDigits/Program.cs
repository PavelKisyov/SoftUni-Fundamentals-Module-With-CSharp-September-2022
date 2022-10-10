using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace _02.SumDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int sum = 0;

            while (num != 0)
            {
                int currentNum = num % 10;

                sum += currentNum;

                num /= 10;
            }

            Console.WriteLine(sum);
        }
    }
}

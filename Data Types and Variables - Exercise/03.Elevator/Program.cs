using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfPeople = int.Parse(Console.ReadLine());
            int maxCapacity = int.Parse(Console.ReadLine());

            int courses = (int)Math.Ceiling((double)numOfPeople / maxCapacity);

            Console.WriteLine(courses);
        }
    }
}

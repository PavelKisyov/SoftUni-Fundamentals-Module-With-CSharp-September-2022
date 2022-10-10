using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace _05.Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = string.Empty;

            for (int i = username.Length - 1; i >= 0; i--)
            {
                char currentChar = username[i];
                password += currentChar;
            }

            string inputPassword = Console.ReadLine();
            int counter = 0;

            while (inputPassword != password)
            {
                counter++;

                if (counter == 4)
                {
                    break;
                }

                Console.WriteLine("Incorrect password. Try again.");
                
                inputPassword = Console.ReadLine();
            }

            if (inputPassword == password )
            {
                Console.WriteLine($"User {username} logged in.");
            }
            else
            {
                Console.WriteLine($"User {username} blocked!");
            }
        }
    }
}

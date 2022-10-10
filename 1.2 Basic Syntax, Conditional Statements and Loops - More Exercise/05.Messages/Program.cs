using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Messages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int clicks = int.Parse(Console.ReadLine());

            string word = string.Empty;

            for (int i = 1; i <= clicks; i++)
            {
                int num = int.Parse(Console.ReadLine());

                int digit = num % 10;

                if (digit == 2)
                {
                    if (num == 2)
                    {
                        word += 'a';
                    }
                    else if (num == 22)
                    {
                        word += 'b';
                    }
                    else if (num == 222)
                    {
                        word += 'c';
                    }
                }
                else if (digit == 3)
                {
                    if (num == 3)
                    {
                        word += 'd';
                    }
                    else if (num == 33)
                    {
                        word += 'e';
                    }
                    else if (num == 333)
                    {
                        word += 'f';
                    }
                }
                else if (digit == 4)
                {
                    if (num == 4)
                    {
                        word += 'g';
                    }
                    else if (num == 44)
                    {
                        word += 'h';
                    }
                    else if (num == 444)
                    {
                        word += 'i';
                    }
                }
                else if (digit == 5)
                {
                    if (num == 5)
                    {
                        word += 'j';
                    }
                    else if (num == 55)
                    {
                        word += 'k';
                    }
                    else if (num == 555)
                    {
                        word += 'l';
                    }
                }
                else if (digit == 6)
                {
                    if (num == 6)
                    {
                        word += 'm';
                    }
                    else if (num == 66)
                    {
                        word += 'n';
                    }
                    else if (num == 666)
                    {
                        word += 'o';
                    }
                }
                else if (digit == 7)
                {
                    if (num == 7)
                    {
                        word += 'p';
                    }
                    else if (num == 77)
                    {
                        word += 'q';
                    }
                    else if (num == 777)
                    {
                        word += 'r';
                    }
                    else if (num == 7777)
                    {
                        word += 's';
                    }
                }
                else if (digit == 8)
                {
                    if (num == 8)
                    {
                        word += 't';
                    }
                    else if (num == 88)
                    {
                        word += 'u';
                    }
                    else if (num == 888)
                    {
                        word += 'v';
                    }
                }
                else if (digit == 9)
                {
                    if (num == 9)
                    {
                        word += 'w';
                    }
                    else if (num == 99)
                    {
                        word += 'x';
                    }
                    else if (num == 999)
                    {
                        word += 'y';
                    }
                    else if (num == 9999)
                    {
                        word += 'z';
                    }
                }
                else if (digit == 0)
                {
                    word += ' ';
                }

            }

            Console.WriteLine(word);

        }
    }
}

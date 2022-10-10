using System;

namespace _05.DecryptingMessage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int counter = int.Parse(Console.ReadLine());

            string decryptedWord = string.Empty;

            for (int i = 0; i < counter; i++)
            {
                char symbol = char.Parse(Console.ReadLine());
                decryptedWord += (char)(symbol + key);
            }

            Console.WriteLine(decryptedWord);
        }
    }
}

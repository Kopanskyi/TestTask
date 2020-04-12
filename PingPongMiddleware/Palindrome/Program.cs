using System;
using System.Linq;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = string.Empty;
            while (true)
            {
                Console.WriteLine("Write your word: ");
                word = Console.ReadLine();

                if (!string.IsNullOrEmpty(word))
                {
                    break;
                }

                Console.WriteLine("Try again.");
            }

            if (word.Any(c => !char.IsLetter(c)))
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (char.IsLetter(word[i]))
                    {
                        continue;
                    }

                    word = word.Remove(i, 1);
                    i--;
                }
            }

            var word2 = new string (word.Reverse().ToArray());

            Console.WriteLine(!string.IsNullOrEmpty(word) && word.Equals(word2) 
                ? $"The word \"{word}\" is a palindrome."
                : $"The word \"{word}\" is not a palindrome.");

            Console.ReadKey();
        }
    }
}

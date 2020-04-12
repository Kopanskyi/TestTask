using System;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[10];
            for (var i = 0; i < array.Length; i++)
            {
                var random = new Random();
                array[i] = random.Next(1, 10);
            }

            int value;
            while (true)
            {
                Console.WriteLine("Enter a number: ");
                var num = Console.ReadLine();

                if (int.TryParse(num, out value))
                {
                    break;
                }

                Console.WriteLine("Try again.");
            }

            Console.WriteLine("Array: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }

            Console.WriteLine();
            var elementsFound = false;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] + array[j] == value)
                    {
                        Console.WriteLine($"Sum of elements {array[i]} and {array[j]} by indexes {i} and {j} equals {value}."); 
                        elementsFound = true;
                    }
                }
            }

            if (!elementsFound)
            {
                Console.WriteLine($"There are no elements in the array sum of which equals {value}.");
            }

            Console.ReadKey();
        }
    }
}

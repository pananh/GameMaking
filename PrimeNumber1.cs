using System;

namespace PrimeNumberFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");

            DateTime dateTimeStart = DateTime.Now;

            if (int.TryParse(Console.ReadLine(), out int n))
            {
                Console.WriteLine($"Prime numbers up to {n}:");
                for (int i = 2; i <= n; i++)
                {
                    if (IsPrime(i))
                    {
                        Console.Write(i + " ");
                    }
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }

            DateTime dateTimeEnd = DateTime.Now;
            TimeSpan timeSpan = dateTimeEnd - dateTimeStart;
            Console.WriteLine($"Time taken: {timeSpan.TotalMilliseconds} ms");

        }

        static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            for (int i = 3; i <= Math.Sqrt(number); i += 2)
            {
                if (number % i == 0) return false;
            }

            return true;
        }
    }
}
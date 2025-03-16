using System;
using System.Globalization;

/* Thuat toan tim so nguyen to theo Mang
Cac so nguyen to se duoc luu vao mot mang
Neu so i ma khong chia het cho cac so nguyen to truoc do thi i la so nguyen to
Luu y, cung chi can cac so nguyen to den can bac 2 cua i la du
*/
namespace PrimeNumberFinder_ArraySolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            // Tinh thoi gian chay
            DateTime dateTimeStart = DateTime.Now;

            int totalPrimeNumbers = 1;
            int[] primeNumberArray = new int[2000000];
            primeNumberArray[0] = 2;
            // Mang dau tien co 1 so nguyen to la 2

            if (int.TryParse(Console.ReadLine(), out int n))
            {
                if (n <= 1)
                {
                    Console.WriteLine("No prime numbers found");
                    goto EndLabel;
                }
                Console.WriteLine($"Prime numbers up to {n}:");
                Console.Write("2 ");
                if (n == 2)
                {
                    goto EndFind;
                }

                for (int i = 3; i <= n; i++)
                {
                    bool isPrime = true;
                    float sqrtI = (float)Math.Sqrt(i);
                    for (int j = 1; j <= totalPrimeNumbers; j++)
                    {
                        if (primeNumberArray[j - 1] > sqrtI)
                        {
                            break;
                        }
                        if (i % primeNumberArray[j - 1] == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    if (isPrime)
                    {
                        primeNumberArray[totalPrimeNumbers] = i;
                        totalPrimeNumbers++;
                        Console.Write(i + " ");
                    }

                }

            EndFind:
                Console.WriteLine();
                Console.WriteLine($"Total prime numbers found: {totalPrimeNumbers}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }

        EndLabel:
            DateTime dateTimeEnd = DateTime.Now;
            TimeSpan timeSpan = dateTimeEnd - dateTimeStart;
            Console.WriteLine($"Time taken: {timeSpan.TotalMilliseconds} ms");

        }

    }


}

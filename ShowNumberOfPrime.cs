using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;


namespace CodeGym
{
    public class ShowNumberOfPrimeFactor
    {
        public static void Main(string[] args)
        {
            int n = Get_Int("Enter the number of prime factor to be shown: ");

            /* Thuat toan tim so luong nguyen to theo Mang Arrray nen chi tim so luong nguyen
             * to toi da la 3000000 lon nhat cho nhanh */

            if (n < 1 || n > 10000000)
            {
                Console.WriteLine("Invalid input. Please enter a number greater than 0 and less than 10.000.000");
                return;
            }

            Console.WriteLine($"Prime numbers up to {n}:");


            int[] primeNumberArray = new int[10000000];
            primeNumberArray[0] = 2;
            int totalPrimeNumbers = 1;
            // Mang dau tien co 1 so nguyen to la 2

            int nCheck = 3;
            Console.Write(primeNumberArray[totalPrimeNumbers - 1] + " ");
            do
            {
                bool isPrime = true;
                float sqrtnCheck = (float)Math.Sqrt(nCheck);
                for (int j = 1; j <= totalPrimeNumbers; j++)
                {
                    if (primeNumberArray[j - 1] > sqrtnCheck)
                    {
                        break;
                    }
                    if (nCheck % primeNumberArray[j - 1] == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primeNumberArray[totalPrimeNumbers] = nCheck;
                    totalPrimeNumbers++;
                    Console.Write(nCheck + " ");
                }
                nCheck += 2;
            }
            while (totalPrimeNumbers < n);

        }



        static double Get_Double(string showString)
        {
            double number;
            bool isNumber;
            Console.Write(showString);
            do
            {
                isNumber = double.TryParse(Console.ReadLine(), out number);
                if (!isNumber)
                {
                    Console.Write("Invalid input. Please enter a number again. " + showString);
                }
            } while (!isNumber);
            return number;
        }
        static double Get_UDouble(string showString)
        {
            double number;
            bool isNumber;
            Console.Write(showString);
            do
            {
                isNumber = double.TryParse(Console.ReadLine(), out number);
                if (!isNumber || number < 0)
                {
                    Console.Write("Invalid input. Please enter a number again. " + showString);
                }
            } while (!isNumber || number < 0);
            return number;
        }
        static int Get_Int(string showString)
        {
            int number;
            bool isNumber;
            Console.Write(showString);
            do
            {
                isNumber = int.TryParse(Console.ReadLine(), out number);
                if (!isNumber)
                {
                    Console.Write("Invalid input. Please enter a number again. " + showString);
                }
            } while (!isNumber);
            return number;
        }
        static uint Get_UInt(string showString)
        {
            uint number;
            bool isNumber;
            Console.Write(showString);
            do
            {
                isNumber = uint.TryParse(Console.ReadLine(), out number);
                if (!isNumber)
                {
                    Console.Write("Invalid input. Please enter a number again. " + showString);
                }
            } while (!isNumber);
            return number;
        }
    }
}


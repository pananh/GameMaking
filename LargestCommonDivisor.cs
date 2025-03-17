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
    public class CodeGymExercise_LargestCommonDivisor
    {
        public static void Main(string[] args)
        {
            int a = Get_Int("Enter the first integer: ");
            int b = Get_Int("Enter the second integer: ");

            if (a == 0 || b == 0)
            {
                Console.WriteLine("There is zero number. So, no greatest common divisor");
            }
            else
            {
                Console.WriteLine("The greatest common divisor of " + a + " and " + b + " is " + LargestCommonDivisor(a, b));
            }

        }

        static int LargestCommonDivisor(int a, int b)
        {
            int aMax = Math.Max(Math.Abs(a), Math.Abs(b));
            int bMin = Math.Min(Math.Abs(a), Math.Abs(b));

            do
            {
                int remainder = aMax % bMin;
                aMax = bMin;
                bMin = remainder;
            } while (bMin != 0);

            return aMax;

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


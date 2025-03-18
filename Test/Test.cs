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
    public class Test
    {
        public static void Main(string[] args)
        {
            int[] arrayInt = new int[10000000];

            int n = Get_Int("Enter the number of elements in the array: ");
            for (int i = 0; i < n; i++)
            {
                arrayInt[i] = Get_Int("Enter the element " + i + " : ");
            }

            int getNumber = Get_Int("Enter the number you want to add: ");
            int index = Get_Int("Enter the index you want to add: ");

            if (index < 0 || index > n)
            {
                Console.WriteLine("Invalid index. Can not add");
            }
            else
            {
                for (int i = n; i > index; i--)
                {
                    arrayInt[i] = arrayInt[i - 1];
                }
                arrayInt[index] = getNumber;
                n++;
            }

            PrintArrayInt(arrayInt, n);


        }


        static void PrintArrayInt(int[] arrayInt, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(arrayInt[i] + " ");
            }
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


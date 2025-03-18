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
    public class FindTotalMainDiagonal
    {
        public static void Main(string[] args)
        {
            int row = Get_Int("Enter the matrix size: ");
            int[,] arrayInt = new int[row, row];
            int total = 0;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    arrayInt[i, j] = Get_Int("Enter the element at position [" + (i + 1) + "," + (j + 1) + "]: ");
                    if (i == j)
                    {
                        total += arrayInt[i, j];
                    }

                }
            }
            Console.WriteLine("The matrix is: ");
            PrintArrayInt2(arrayInt, 0, row - 1, 0, row - 1);
            Console.WriteLine("The total of the main diagonal is: " + total);
        }



        static void PrintArrayDouble2(double[,] arrayDouble, int startRow, int endRow, int startCol, int endCol)
        {
            for (int i = startRow; i <= endRow; i++)
            {
                for (int j = startCol; j <= endCol; j++)
                {
                    Console.Write(arrayDouble[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void PrintArrayInt2(int[,] arrayInt, int startRow, int endRow, int startCol, int endCol)
        {
            for (int i = startRow; i <= endRow; i++)
            {
                for (int j = startCol; j <= endCol; j++)
                {
                    Console.Write(arrayInt[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void PrintArrayChar2(char[,] arrayChar, int startRow, int endRow, int startCol, int endCol)
        {
            for (int i = startRow; i <= endRow; i++)
            {
                for (int j = startCol; j <= endCol; j++)
                {
                    Console.Write(arrayChar[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void PrintArrayInt(int[] arrayInt, int start, int end)
        {
            for (int i = start; i <= end; i++)
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


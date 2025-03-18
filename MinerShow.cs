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
    public class MinerShow
    {
        public static void Main(string[] args)
        {
            int row = Get_Int("Enter the number of row: ");
            int col = Get_Int("Enter the number of column: ");
            char[,] mapInput = new char[row + 2, col + 2];

            Array.Clear(mapInput, 0, mapInput.Length);

            Console.WriteLine("Enter the map. Note * is mine. ");

            for (int i = 1; i <= row; i++)
            {
                Console.Write("Enter the row " + i + " map: ");
                string input = Console.ReadLine();
                for (int j = 1; j <= col; j++)
                {
                    mapInput[i, j] = input[j - 1];
                }
            }

            char[,] mapOutput = new char[row + 2, col + 2];
            Array.Clear(mapOutput, 0, mapInput.Length);

            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= col; j++)
                {
                    if (mapInput[i, j] == '*')
                    {
                        mapOutput[i, j] = '*';
                    }
                    else
                        mapOutput[i, j] = ArroundMine(mapInput, i, j).ToString()[0];

                }
            }

            PrintArrayChar2(mapInput, 1, row, 1, col);

            Console.WriteLine("The map after processing: ");

            PrintArrayChar2(mapOutput, 1, row, 1, col);

        }

        static int ArroundMine(char[,] map, int row, int col)
        {
            int[][] aroundMap = new int[8][] { new int[] { -1, -1 }, new int[] { -1, 0 }, new int[] { -1, 1 }, new int[] { 0, -1 },
                                               new int[] { 0, 1 }, new int[] { 1, -1 }, new int[] { 1, 0 }, new int[] { 1, 1 } };

            int totalMine = 0;
            foreach (int[] around in aroundMap)
            {
                if (map[row + around[0], col + around[1]] == '*')
                {
                    totalMine++;
                }
            }
            return totalMine;
        }

        static void PrintArrayInt2(int[,] arrayInt, int startRow, int row, int startCol, int col)
        {
            for (int i = startRow; i <= row; i++)
            {
                for (int j = startCol; j <= col; j++)
                {
                    Console.Write(arrayInt[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void PrintArrayChar2(char[,] arrayChar, int startRow, int row, int startCol, int col)
        {
            for (int i = startRow; i <= row; i++)
            {
                for (int j = startCol; j <= col; j++)
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
            Console.WriteLine();
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


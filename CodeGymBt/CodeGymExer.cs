using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;


namespace CodeGym
{
    public class CodeGymExercise_InterestRate
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1. Print rectangular");
            Console.WriteLine("2. Print square triangle");
            Console.WriteLine("3. Print isosceles triangle");
            Console.WriteLine("4. Exit");

            int choice = Get_Int("Enter your choice: ");

            switch (choice) 
            {

                case 1:
                    Print_Rectangular();
                    break;
                case 2:
                    Console.WriteLine("Please select the type of triangle: ");
                    Console.WriteLine("1. Print triangle Top-Left");
                    Console.WriteLine("2. Print triangle Top-Right");
                    Console.WriteLine("3. Print triangle Bottom-Left");
                    Console.WriteLine("4. Print triangle Bottom-Right");
                    int choice2 = Get_Int("Enter your choice: ");
                    
                    switch (choice2)
                    {
                        case 1:
                            Print_Square_Triangle_Top_Left();
                            break;
                        case 2:
                            Print_Square_Triangle_Top_Right();
                            break;
                        case 3:
                            Print_Square_Triangle_Bottom_Left();
                            break;
                        case 4:
                            Print_Square_Triangle_Bottom_Right();
                            break;
                        default:
                            break;
                    }

                    break;
                case 3:
                    Print_Isosceles_Triangle();
                    break;
                default:
                    break;

            }


        }

        static void Print_Rectangular()
        {
            int width = Get_Int("Enter the width: ");
            int height = Get_Int("Enter the height: ");
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static void Print_Square_Triangle_Top_Right()
        {
            int height = Get_Int("Enter the height: ");
            for (int i = 0; i<height; i++)
            {
                for (int j = 0; j<i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j<height - i; j++)
                {
                    Console.Write("*");
                }
Console.WriteLine();
            }
        }
        static void Print_Square_Triangle_Bottom_Right()
        {
            int height = Get_Int("Enter the height: ");
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < height - i - 1; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static void Print_Square_Triangle_Top_Left()
        {
            int height = Get_Int("Enter the height: ");
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static void Print_Square_Triangle_Bottom_Left()
        {
            int height = Get_Int("Enter the height: ");
            for (int i = 0; i < height; i++)
            {
                for (int j = 1; j <= i+1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

       static void Print_Isosceles_Triangle()
        {
            int height = Get_Int("Enter the height: ");
            for (int i = 0; i < height; i++)
            {
                for (int j = 1; j <= height - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= 2 * i + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
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


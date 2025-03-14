using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CodeGymBt
{
    public class ReadNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is program to read non negative integer <1000 from console by Tuan Anh.");

            int numberRead;
            bool isNumberRead = false;

        startingLabel:

            do
            {
                Console.Write("Enter a non negative integer, less than 1000: ");
                isNumberRead = int.TryParse(Console.ReadLine(), out numberRead);
            }
            while (!isNumberRead || numberRead >= 1000 || numberRead < 0);

            Console.WriteLine("Your number: " + numberRead);

            if (numberRead < 20)
            {
                Console.WriteLine(ReadPart(numberRead));
            }
            else if (numberRead < 100)
                {
                Console.WriteLine(ReadTwoDigit(numberRead));
                }
            else
                {
                Console.WriteLine(ReadThreeDigit(numberRead));
                };

            Console.Write("Do you want to continue? (y/n): ");
            string answer = Console.ReadLine();
            if (!(answer == "n"))
                goto startingLabel;

        }

        static string ReadThreeDigit(int number)
        {
            int remainder = number % 100;
            int quotient = (number - remainder) / 100;
            string result = "";
            if (remainder == 0)
            {
                result = ReadPart(quotient) + " hundred";
            }
            else
            {
                result = ReadPart(quotient) + " hundred and " + ReadTwoDigit(remainder);
            };

            return result;
        }

        static string ReadTwoDigit(int number)
        {
            int remainder = number % 10;
            int quotient = (number - remainder) / 10;
            string result = "";
            if (remainder == 0)
            {
                result = ReadPart(quotient * 10);
            }
            else 
                if (quotient == 0)
                {
                result = ReadPart(remainder);
                }    
                else
                 {   
                   result = ReadPart(quotient * 10) + "-" + ReadPart(remainder);
                 };

            return result;
        }
        static string ReadPart(int number)
        {
            string result = "";

            switch (number)
            {
                case 0:
                    result = "zero";
                    break;
                case 1:
                    result = "one";
                    break;
                case 2:
                    result = "two";
                    break;
                case 3:
                    result = "three";
                    break;
                case 4:
                    result = "four";
                    break;
                case 5:
                    result = "five";
                    break;
                case 6:
                    result = "six";
                    break;
                case 7:
                    result = "seven";
                    break;
                case 8:
                    result = "eight";
                    break;
                case 9:
                    result = "nine";
                    break;
                case 10:
                    result = "ten";
                    break;
                case 11:
                    result = "eleven";
                    break;
                case 12:
                    result = "twelve";
                    break;
                case 13:
                    result = "thirteen";
                    break;
                case 14:
                    result = "fourteen";
                    break;
                case 15:
                    result = "fifteen";
                    break;
                case 16:
                    result = "sixteen";
                    break;
                case 17:
                    result = "seventeen";
                    break;
                case 18:
                    result = "eighteen";
                    break;
                case 19:
                    result = "nineteen";
                    break;
                case 20:
                    result = "twenty";
                    break;
                case 30:
                    result = "thirty";
                    break;
                case 40:
                    result = "forty";
                    break;
                case 50:
                    result = "fifty";
                    break;
                case 60:
                    result = "sixty";
                    break;
                case 70:
                    result = "seventy";
                    break;
                case 80:
                    result = "eighty";
                    break;
                case 90:
                    result = "ninety";
                    break;
                
            }
            return result;
        }


    }
}


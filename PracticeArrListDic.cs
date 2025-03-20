// Practicing in Array, List, Dictionary
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace ListExample
{
    public class Test
    {

        public class Mobile
        {
            public string Color { get; set; }
            public string Name { get; set; }
            public int Price { get; set; }
            public string Origin { get; set; }

        }


        public static void Main(string[] args)
        {
            Random randomVar = new Random();
            int n = 7;

            string[] Color = new string[] { "Red", "Green", "Yellow", "Blue", "Black", "White" };
            string[] Country = new string[] { "Vietnam", "USA", "Japan", "Korean", "China", "EU" };


            // array

            Mobile[] arrayMobile = new Mobile[n];
            for (int i = 0; i < arrayMobile.Length; i++)
            {
                arrayMobile[i] = new Mobile
                {
                    Color = Color[randomVar.Next(0, 5)],
                    Name = "A" + i,
                    Price = randomVar.Next(0, 1000),
                    Origin = Country[randomVar.Next(0, 5)],
                };
            }

            //PrintArray("Name Color Price Origin - Array Mobile", arrayMobile);

            // list
            List<Mobile> listMobile = new List<Mobile>();
            for (int i = 0; i < n; i++)
            {
                listMobile.Add(arrayMobile[i]);

            }
            //PrintList("Name Color Price Origin - List Mobile", listMobile);

            //change
            for (int i = 0; i < arrayMobile.Length; i++)
            {
                arrayMobile[i] = new Mobile
                {
                    Color = Color[randomVar.Next(0, 5)],
                    Name = "A" + i,
                    Price = randomVar.Next(0, 1000),
                    Origin = Country[randomVar.Next(0, 5)],
                };
            }
            PrintArray("Array change", arrayMobile);
            PrintList("List check", listMobile);

            // find in Array
            Mobile find1 = listMobile[0];
            var found1 = -1;
            for (int i = 0; i < arrayMobile.Length; i++)
            {
                if (arrayMobile[i].Origin == find1.Origin)
                {
                    found1 = i; break;
                }
            }
            Console.WriteLine("Origin: listMobile[0] = arrayMobile[{0}]", found1);


            // find in List
            Mobile find2 = arrayMobile[0];
            var found2 = listMobile.FindIndex(x => x.Origin == find2.Origin);
            Console.WriteLine("Origin:  arrayMobile[0] = listMobile[{0}]", found2);






        }

        static void PrintArray(string x, Mobile[] arrayMobile)
        {
            Console.WriteLine(x);
            int i = 0;
            foreach (var item in arrayMobile)
            {
                Console.WriteLine(i + ". " + item.Name + " " + item.Color + " " + item.Price + " " + item.Origin);
                i++;
            }
        }

        static void PrintList(string x, List<Mobile> listMobile)
        {
            Console.WriteLine(x);
            int i = 0;
            foreach (var item in listMobile)
            {
                Console.WriteLine(i + ". " + item.Name + " " + item.Color + " " + item.Price + " " + item.Origin);
                i++;
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

    }
}


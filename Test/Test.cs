using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ListExample
{
    public class Test
    {
        public class Product 
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public double Price { get; set; }
            public string Origin { get; set; }

        }

        //List
        public static void Main(string[] args)
        {
           
            //SortedList<string , Product> myProducts = new SortedList<string, Product>();
            //myProducts["sp1"] = new Product() { Id = 1, Name = "Iphone", Origin = "USA", Price = 1500 };
            //myProducts["sp2"] = new Product() { Id = 2, Name = "Galaxy", Origin = "Korea", Price = 1400 };
            //myProducts.Add("sp3", new Product() { Id = 3, Name = "Oppo", Origin = "China", Price = 1000 });

            //foreach (var item in myProducts)
            //{
            //    Console.Write(item.Key + " " + item.Value.Name);
            //    Console.WriteLine();
            //}
            //Console.WriteLine("---------");

            //myProducts.Remove("sp1");
            //foreach (var item in myProducts)
            //{
            //    Console.Write(item.Key + " " + item.Value.Name);
            //    Console.WriteLine();
            //}


            List <Product> myProducts2 = new List<Product>();
            //myProducts2 = new Product() { Id = 1, Name = "XPhone", Origin = "TA", Price = 10500 };
            //myProducts2[1] = new Product() { Id = 1, Name = "Iphone", Origin = "USA", Price = 1500 };
            //myProducts2[2] = new Product() { Id = 2, Name = "Galaxy", Origin = "Korea", Price = 1400 };
            //myProducts2[3] = new Product() { Id = 3, Name = "Oppo", Origin = "China", Price = 1000 };

            myProducts2 = new List<Product>() {
                new Product() { Id = 1, Name = "XPhone", Origin = "TA", Price = 10500 },
                new Product() { Id = 1, Name = "Iphone", Origin = "USA", Price = 1500 },
                new Product() { Id = 2, Name = "Galaxy", Origin = "Korea", Price = 1400 },
                new Product() { Id = 3, Name = "Oppo", Origin = "China", Price = 1000 },
                };

            myProducts2.Add(new Product() { Id = 1, Name = "Iphonexxxx", Origin = "USAxxxxx", Price = 1500 });


            foreach (var item in myProducts2)
            {
                Console.Write(item.Name + " " + item.Origin + " " + item.Price);
                Console.WriteLine();
            }
            Console.WriteLine("---------");



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


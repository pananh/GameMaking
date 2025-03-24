using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.IO.Pipes;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace ListExample
{
    
   

    public enum Color
    {
        Red = 0,
        Blue = 1,
        Green = 2,
        Yellow = 3,
        White = 4,
    }

    public class House
    {

        public string name;
        public int numberPerson;
        public string addhouse;
        public Color color;

        public House(string namex, int numberPersonx, string addhousex, Color colorx)
        {
            //this.name = namex;
            //this.number = numberx;
            //this.addhouse = addhousex;
            //this.color = colorx;
            name = namex;
            numberPerson = numberPersonx;
            addhouse = addhousex;
            color = colorx;
        }

    }
    public class Test
    {
        static Dictionary<int, Dictionary<Color, List<House>>> dictFinal = new Dictionary<int, Dictionary<Color, List<House>>>();
        // Dictionary by Color
       // static Dictionary<Color, List<House>> dictionaryHouseColor = new Dictionary<Color, List<House>>();



        public static List<House> AddNewHouses()
        {
            List<House> test = new List<House>
            {
                new House("h1",3,"abc",Color.Red),
                new House("h2",2,"abc",Color.Blue),
                new House("h3",3,"abc",Color.Red),
                new House("h4",4,"abc",Color.Blue),
                new House("h5",5,"abc",Color.Red),
                new House("h6",6,"abc",Color.Blue),
                new House("h7",6,"abcD",Color.Red),
                new House("h8",6,"abcDe",Color.Red),


            };
            return test;
        }

        public static void Main(string[] args)
        {
            Random randomVar = new Random();
            int n = 15;

           
            // Dictionary
            Console.WriteLine("Dictionary");

            List <House> listHouseMyDinh = AddNewHouses();

            // Tao ngau nhien n = 10 nha
            
            //for (int i = 0; i < n; i++)
            //{
            //    listHouseMyDinh.Add(RandomHouse());
            //}

            // In List House My Dinh
            foreach (var house in listHouseMyDinh)
            {
                //Console.WriteLine(i.name + " " + i.addhouse + " " + i.numberPerson + " " + i.color);
                int number = house.numberPerson;

                
                if (dictFinal.ContainsKey(number)) //  cap nhat dictChild 
                {
                    AddHouseToDictByColor(house, dictFinal[number]);
                }
                else // tao moi va cap nhat dictChild 
                {
                    Color color = house.color;
                    //cap nhat house vao dict con
                    Dictionary<Color, List<House>> dictChild = new Dictionary<Color, List<House>>();
                    AddHouseToDictByColor(house, dictChild);
                    dictFinal.Add(number,dictChild); //add dict con vao dict char
                }
            }

            foreach ( var  item in dictFinal)
            {
                Console.WriteLine("number ---- " + item.Key);
                foreach (var item2 in item.Value)
                {
                    Console.WriteLine ("color. " + item2.Value);
                    
                }

            }

            FindListHouse(6,Color.Red);


        }


        public static void FindListHouse(int number,Color color)
        {
            if (!dictFinal.ContainsKey(number))
            {
                Console.WriteLine("khong tim dc");
                return;
            }
            var childDict = dictFinal[number];
            if (!childDict.ContainsKey(color))
            {
                Console.WriteLine("khong tim dc");
                return;
            }
            var listHouse = childDict[color];
            foreach (var house in listHouse)
            {
                Console.WriteLine("house" + house.name);
            }
        }
      

        public static void AddHouseToDictByColor(House house, Dictionary<Color, List<House>> childDict)
        {
            Color color = house.color;
            if (childDict.ContainsKey(color)){
                childDict[color].Add(house);
            }
            else
            {
                childDict.Add(color, new List<House> { house});
                
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
        static Color ReturnColor(int colorIndex)
        {
            switch (colorIndex)
            {
                case 0: return Color.Red;
                case 1: return Color.Green;
                case 2: return Color.Yellow;
                case 3: return Color.White;
                case 4: return Color.White;
                default: return 0;
            }
        }




        static House RandomHouse()
        {
            Random randomVar = new Random();
            string nameh = "";
            for (int k = 0; k < 5; k++)
            {
                nameh += Convert.ToChar(randomVar.Next(97, 122));
            }
            string addh = "";
            for (int k = 0; k < 10; k++)
            {
                addh += Convert.ToChar(randomVar.Next(97, 122));
            }
            House returnHouse = new House(nameh, randomVar.Next(1, 6), addh, ReturnColor(randomVar.Next(0, 4)));

            return returnHouse;
        }



    }
}


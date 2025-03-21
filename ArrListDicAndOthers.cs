using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Pipes;
using System.Linq;
using System.Net.Sockets;
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

        public enum Color
        {
            Red = 0,
            Blue = 1,
            Green = 2,
            Yellow = 3,
            White = 4,
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
            House returnHouse = new House(nameh, randomVar.Next(1, 10), addh, ReturnColor(randomVar.Next(0, 4)));

            return returnHouse;
        }

        public static void Main(string[] args)
        {
            Random randomVar = new Random();
            int n = 15;

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
            //PrintArray("Name Color Price Origin - Array Mobile Origin", arrayMobile);

            // list
            List<Mobile> listMobile = new List<Mobile>();
            for (int i = 0; i < n; i++)
            {
                listMobile.Add(arrayMobile[i]);

            }
            //PrintList("Name Color Price Origin - List Mobile", listMobile);

            // Queue 
            Queue<Mobile> queueMobile = new Queue<Mobile>();
            for (int i = 0; i < n; i++)
            {
                queueMobile.Enqueue(arrayMobile[i]);
            }
            var hoso = queueMobile.Dequeue();
            hoso = queueMobile.Dequeue();
            //PrintQueue("Name Color Price Origin - Queue Mobile after taken 2",queueMobile);

            //Stack
            Stack<Mobile> stackMobile = new Stack<Mobile>();
            for (int i = 0; i < n; i++)
            {
                stackMobile.Push(arrayMobile[i]);
            }
            hoso = stackMobile.Pop();
            hoso = stackMobile.Pop();
            //PrintStack("Name Color Price Origin - Stack Mobile after taken 2", stackMobile);


            //Linked List
            LinkedList<Mobile> linkedListMobile = new LinkedList<Mobile>();

            var node0 = linkedListMobile.AddFirst(arrayMobile[0]);
            var node1 = linkedListMobile.AddLast(arrayMobile[1]);
            var node2 = linkedListMobile.AddAfter(node0, arrayMobile[2]);
            LinkedListNode<Mobile> node3 = linkedListMobile.AddLast(arrayMobile[3]);
            node0.Value = arrayMobile[4];
            //Console.WriteLine("Node0 test " + node0.Value.Name + " " + node0.Value.Origin + " " + node0.Value.Price);
            //PrintLinkedList("Name Color Price Origin - Linked Node",linkedListMobile);

            // Dictionary
            Console.WriteLine("Dictionary");

            List<House> listHouseMyDinh = new List<House>();

            // Tao ngau nhien n = 10 nha

            for (int i = 0; i < n; i++)
            {
                listHouseMyDinh.Add(RandomHouse());
            }

            // In List House My Dinh
            foreach (var i in listHouseMyDinh)
            {
                Console.WriteLine(i.name + " " + i.addhouse + " " + i.numberPerson + " " + i.color);
            }

            // Dictionary by Color
            Dictionary<Color, List<House>> dictionaryHouseColor = new Dictionary<Color, List<House>>();
            // Them vao Dictionary
            foreach (var i in listHouseMyDinh)
            {
                Color colorAdd = i.color;
                int numberHouse = i.numberPerson;
                if (dictionaryHouseColor.ContainsKey(colorAdd))
                {
                    dictionaryHouseColor[colorAdd].Add(i);
                }
                else
                {
                    dictionaryHouseColor.Add(colorAdd, new List<House>());
                }

            }

            Console.WriteLine("Dictionary by Color");
            foreach (var i in dictionaryHouseColor)
            {
                Console.WriteLine(i.Key + ": ");

                foreach (var j in i.Value)
                {
                    Console.WriteLine(j.name + " " + j.addhouse + " " + j.numberPerson + " " + j.color);
                }

            }

            // Dictionary by number



            Console.WriteLine("----------");

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
            //PrintArray("Array change",arrayMobile);
            //PrintList("List check", listMobile);

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
            //Console.WriteLine("Origin: listMobile[0] = arrayMobile[{0}]", found1);


            // find in List
            Mobile find2 = arrayMobile[0];
            var found2 = listMobile.FindIndex(x => x.Origin == find2.Origin);
            //Console.WriteLine("Origin:  arrayMobile[0] = listMobile[{0}]",found2);




        }


        static void PrintLinkedList(string x, LinkedList<Mobile> list)
        {
            Console.WriteLine(x);
            int i = 0;
            foreach (var item in list)
            {
                Console.WriteLine(i + ". " + item.Name + " " + item.Color + " " + item.Price + " " + item.Origin);
                i++;
            }
        }

        static void PrintStack(string x, Stack<Mobile> stackMobile)
        {
            Console.WriteLine(x);
            int i = 0;
            foreach (var item in stackMobile)
            {
                Console.WriteLine(i + ". " + item.Name + " " + item.Color + " " + item.Price + " " + item.Origin);
                i++;
            }
        }

        static void PrintQueue(string x, Queue<Mobile> queueMobile)
        {
            Console.WriteLine(x);
            int i = 0;
            foreach (var item in queueMobile)
            {
                Console.WriteLine(i + ". " + item.Name + " " + item.Color + " " + item.Price + " " + item.Origin);
                i++;
            }
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
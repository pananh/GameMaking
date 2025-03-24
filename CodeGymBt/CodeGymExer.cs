using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Pipes;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace ListExample
{

    public enum Color
    {
        Green = 0,
        Red = 1,
        Purple = 2,
        Yellow = 3,
        Blue = 4,
        White = 5,
    }



    public class Test
    {

        static Color IntToColor(int i)
        {
            switch (i)
            {
                case 0:
                    return Color.Green;
                case 1:
                    return Color.Red;
                case 2:
                    return Color.Purple;
                case 3:
                    return Color.Yellow;
                case 4:
                    return Color.Blue;
                default:
                    return Color.White;
            }
        }

        public class House
        {
            public string Address;
            public int NumberPerson;
            public Color ColorOutside;
            public string Owner;

            public House(string address, int numberPerson, Color colorOutside, string owner)
            {
                Address = address;
                NumberPerson = numberPerson;
                ColorOutside = colorOutside;
                Owner = owner;
                // Hoặc có thể đổi tên biến rồi assign giá trị. VD: Address = addressx;
                // Hoặc vì Address khác address không viết hoa nên không cần this
                // Nếu dùng this thì có thể trùng tên. VD: this.Address = Address;
            }

        }

        public static House RandomHouse(int o)
        {
            Random random = new Random();
            string address = "";
            for (int i = 0; i < 10; i++)
            {
                address += Convert.ToChar(random.Next(97, 122));
            }
            o++;
            string owner = "H" + o;
            return new House(address, random.Next(1, 6), IntToColor(random.Next(0, 5)), owner);
        }

        public static House[] NewArrH(int n)
        {
            House[] houses = new House[n];
            for (int i = 0; i < n; i++)
            {
                houses[i] = RandomHouse(i);
            }
            return houses;
        }

        public static void FindArray(House[] arrHouse, int findNumberPerson, Color findColor)
        {
            Console.Write("--- Find by Array: All houses have {0} people and {1}: ", findNumberPerson, findColor);
            bool found = false;
            foreach (var i in arrHouse)
            {
                if (i.NumberPerson == findNumberPerson && i.ColorOutside == findColor)
                {
                    Console.Write("{0} ", i.Owner);
                    found = true;
                }
            }
            if (!found)
            {
                Console.Write("No house found");
            }
            Console.WriteLine();
        }

        public static void FindList(List<House> listHouse, int findNumberPerson, Color findColor)
        {
            Console.Write("--- Find by List: All houses have {0} people and {1}: ", findNumberPerson, findColor);
            bool found = false;
            foreach (var i in listHouse)
            {
                if (i.NumberPerson == findNumberPerson && i.ColorOutside == findColor)
                {
                    Console.Write("{0} ", i.Owner);
                    found = true;
                }
            }
            if (!found)
            {
                Console.Write("No house found");
            }
            Console.WriteLine();
        }

        public static void FindListByAuto(List<House> listHouse, int findNumberPerson, Color findColor)
        {
            Console.Write("--- Find by List by Auto: All houses have {0} people and {1}: ", findNumberPerson, findColor);
            // var found = listHouse.Where(x => x.NumberPerson == findNumberPerson && x.ColorOutside == findColor); // Tìm kiếm theo điều kiện
            List<House> found = listHouse.FindAll(x => x.NumberPerson == findNumberPerson && x.ColorOutside == findColor); // Tìm kiếm theo điều kiện

            if (found.Count() > 0)
            {
                foreach (var i in found)
                {
                    Console.Write("{0} ", i.Owner);
                }
            }
            else
            {
                Console.Write("No house found");
            }
            Console.WriteLine();
        }

        public static void AddIntoSortedList(SortedList<string, List<House>> sortedListHouse, House house)
        {
            string key = house.NumberPerson + "" + house.ColorOutside;
            if (sortedListHouse.ContainsKey(key))
            {
                sortedListHouse[key].Add(house); // Add phần tử house vào list cũ có key = key
            }
            else
            {
                sortedListHouse.Add(key, new List<House> { house }); // Add phần tử house vào list mới {} trong list mới có 1 house
            }
        }

        public static void FindSortedList(SortedList<string, List<House>> sortedListHouse, int findNumberPerson, Color findColor)
        {
            string key = findNumberPerson + "" + findColor;
            Console.Write("--- Find by Sorted List: All houses have {0} people and {1}: ", findNumberPerson, findColor);
            if (sortedListHouse.ContainsKey(key))
            {
                foreach (var i in sortedListHouse[key])
                {
                    Console.Write("{0} ", i.Owner);
                }
            }
            else
            {
                Console.Write("No house found");
            }
            Console.WriteLine();
        }

        public static void FindQueue(Queue<House> queueHouse, int findNumberPerson, Color findColor)
        {
            Console.Write("--- Find by Queue: All houses have {0} people and {1}: ", findNumberPerson, findColor);
            bool found = false;
            // Tìm trong queue mà không xóa
            //foreach (var i in queueHouse)
            //{
            //    if (i.NumberPerson == findNumberPerson && i.ColorOutside == findColor)
            //    {
            //        Console.Write("{0} ", i.Owner);
            //        found = true;
            //    }
            //}

            // Tìm trong queue mà xóa
            while (queueHouse.Count > 0)
            {
                House house = queueHouse.Dequeue();
                if (house.NumberPerson == findNumberPerson && house.ColorOutside == findColor)
                {
                    Console.Write("{0} ", house.Owner);
                    found = true;
                }
            }
            if (!found)
            {
                Console.Write("No house found");
            }
            Console.WriteLine();
        }

        public static void FindStack(Stack<House> stackHouse, int findNumberPerson, Color findColor)
        {
            Console.Write("--- Find by Stack: All houses have {0} people and {1}: ", findNumberPerson, findColor);
            bool found = false;
            // Tìm trong stack mà không xóa
            //foreach (var i in stackHouse)
            //{
            //    if (i.NumberPerson == findNumberPerson && i.ColorOutside == findColor)
            //    {
            //        Console.Write("{0} ", i.Owner);
            //        found = true;
            //    }
            //}
            // Tìm trong stack mà xóa
            while (stackHouse.Count > 0)
            {
                House house = stackHouse.Pop();
                if (house.NumberPerson == findNumberPerson && house.ColorOutside == findColor)
                {
                    Console.Write("{0} ", house.Owner);
                    found = true;
                }
            }
            if (!found)
            {
                Console.Write("No house found");
            }
            Console.WriteLine();
        }

        public static void FindLinkedList(LinkedList<House> linkedListHouse, int findNumberPerson, Color findColor)
        {
            Console.Write("--- Find by Linked List: All houses have {0} people and {1}: ", findNumberPerson, findColor);
            bool found = false;
            //foreach (var i in linkedListHouse)
            //{
            //    if (i.NumberPerson == findNumberPerson && i.ColorOutside == findColor)
            //    {
            //        Console.Write("{0} ", i.Owner);
            //        found = true;
            //    }
            //}

            // Tìm trong linked list kiểu khác mà không xóa. Tìm ngược lại với Queue
            LinkedListNode<House> node = linkedListHouse.Last;  // Kiểu của Node, lấy node đầu tiên.
            while (node != null)
            {
                House house = node.Value;
                if (house.NumberPerson == findNumberPerson && house.ColorOutside == findColor)
                {
                    Console.Write("{0} ", house.Owner);
                    found = true;
                }
                node = node.Previous; // Lấy node tiếp theo
            }

            if (!found)
            {
                Console.Write("No house found");
            }
            Console.WriteLine();
        }

        public static void AddToChildDic(Dictionary<Color, List<House>> dictChild, House house)
        {
            if (dictChild.ContainsKey(house.ColorOutside))
            {
                dictChild[house.ColorOutside].Add(house);
            }
            else
            {
                dictChild.Add(house.ColorOutside, new List<House> { house });
            }
        }

        public static void FindDictionary(Dictionary<int, Dictionary<Color, List<House>>> dictFinal, int findNumberPerson, Color findColor)
        {
            Console.Write("--- Find by Dictionary: All houses have {0} people and {1}: ", findNumberPerson, findColor);
            if (dictFinal.ContainsKey(findNumberPerson))
            {
                if (dictFinal[findNumberPerson].ContainsKey(findColor))
                {
                    foreach (var i in dictFinal[findNumberPerson][findColor])
                    {
                        Console.Write("{0} ", i.Owner);
                    }
                }
                else
                {
                    Console.Write("No house found");
                }
            }
            else
            {
                Console.Write("No house found");
            }
            Console.WriteLine();
        }

        public static void Main(string[] args)
        {
            int nMax = 100;

        LabelStart:
            //array
            House[] arrHouse = NewArrH(nMax);

            Console.WriteLine("Here is {0} random houses", nMax);
            for (int i = 0; i < nMax; i++)
            {
                Console.WriteLine("House {0}: {1} {2} {3}", arrHouse[i].Owner, arrHouse[i].Address, arrHouse[i].NumberPerson, arrHouse[i].ColorOutside);
            }

            int findNumberPerson = 4;
            Color findColor = Color.Green;

            // find in Array
            FindArray(arrHouse, findNumberPerson, findColor);


            //Dictionary in Dictionary

            Dictionary<int, Dictionary<Color, List<House>>> dictFinal = new Dictionary<int, Dictionary<Color, List<House>>>();

            for (int i = 0; i < nMax; i++)
            {
                int numberPerson = arrHouse[i].NumberPerson;
                if (dictFinal.ContainsKey(numberPerson))
                {
                    AddToChildDic(dictFinal[numberPerson], arrHouse[i]);
                }
                else
                {
                    Dictionary <Color, List<House>> dictChild = new Dictionary<Color, List<House>>();
                    AddToChildDic(dictChild, arrHouse[i]);
                    //dictFinal.Add(numberPerson, dictChild); // cái này là chuẩn nhất
                    dictFinal[numberPerson] = dictChild;    // Cái này đúng vì khi có Key thì dictFinal[numberPerson] đã được khởi tạo
                    //AddToChildDic(dictFinal[numberPerson], arrHouse[i]);  Cách này không dùng được vì dictFinal[i] chưa được khởi tạo
                }
            }
            FindDictionary(dictFinal, findNumberPerson, findColor);


            // list
            List<House> listHouse = new List<House>();
            for (int i = 0; i < nMax; i++)
            {
                listHouse.Add(arrHouse[i]);     // Add vào list. List này độc lập với Array. Dù thay đổi Arr nhưng List không đổi
            }
            FindList(listHouse, findNumberPerson, findColor);
            // Tim bang lenh co san
            FindListByAuto(listHouse, findNumberPerson, findColor);

            //sorted List
            SortedList<string, List<House>> sortedListHouse = new SortedList<string, List<House>>();
            string key = "";
            for (int i = 0; i < nMax; i++)
            {
               AddIntoSortedList(sortedListHouse, arrHouse[i]);
            }
            FindSortedList(sortedListHouse, findNumberPerson, findColor);


            //Queue
            Queue<House> queueHouse = new Queue<House>();
            for (int i = 0; i < nMax; i++)
            {
                queueHouse.Enqueue(arrHouse[i]);
            }
            FindQueue(queueHouse, findNumberPerson, findColor); // Queue này sẽ mất dữ liệu sau khi dequeue hết

            //Stack
            Stack<House> stackHouse = new Stack<House>();
            for (int i = 0; i < nMax; i++)
            {
                stackHouse.Push(arrHouse[i]);
            }
            // Stack này sẽ mất dữ liệu sau khi pop hết. Stack sẽ tìm ra kết quả có thứ tự ngược với Queue
            FindStack(stackHouse, findNumberPerson, findColor);

            //Linked List - Node chứa giá trị và 2 con trỏ trỏ đến Node trước và Node sau
            LinkedList<House> linkedListHouse = new LinkedList<House>();
            for (int i = 0; i < nMax; i++)
            {
                linkedListHouse.AddLast(arrHouse[i]);
            }
            FindLinkedList(linkedListHouse, findNumberPerson, findColor); // Linked List này sẽ giữ nguyên dữ liệu sau khi tìm kiếm





            Console.Write("Do you want to continue? (Y/N). ");
            char c = Get_Char("Enter Y or N: ");
            if (c == 'Y' || c == 'y')
            {
                Console.Clear();
                goto LabelStart;
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

        static char Get_Char(string showString)
        {
            char c;
            bool isChar;
            Console.Write(showString);
            do
            {
                isChar = char.TryParse(Console.ReadLine(), out c);
                if (!isChar)
                {
                    Console.Write("Invalid input. Please enter a character again. " + showString);
                }
            } while (!isChar);
            return c;

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    // Symbol to Show: Snake, Food, Wall, Empty, Border
    public class Symbol
    {
        public char Snake { get; set; }
        public char Food { get; set; }
        public char Wall { get; set; }
        public char Empty { get; set; }
        public char Border { get; set; }

        public Symbol()
        {
            Snake = 'O'; Food = 'F';
            Wall = '#'; Empty = ' ';
            Border = '*';
        }
        public Symbol(char snake, char food, char wall, char empty, char border)
        {
            Snake = snake; Food = food;
            Wall = wall; Empty = empty;
            Border = border;
        }
    };

    // Land status
    public class LandStt
    {
        public bool IsEmpty { get; set; }
        public bool IsSnake { get; set; }
        public bool IsWall { get; set; }
        public bool IsFood { get; set; }
        public bool IsBorder { get; set; }
        public LandStt()
        {
            IsEmpty = true; IsBorder = false;
            IsSnake = false; IsWall = false; IsFood = false;
        }
        public void SetBorder() { IsBorder = true; IsEmpty = false; IsSnake = false; IsWall = false; IsFood = false; }
        public void SetEmpty() { IsEmpty = false; IsSnake = false; IsWall = false; IsFood = false; }
        public void SetSnake() { IsSnake = true; IsEmpty = false; IsWall = false; IsFood = false; }
        public void SetWall() { IsWall = true; IsEmpty = false; IsSnake = false; IsFood = false; }
        public void SetFood() { IsFood = true; IsEmpty = false; IsSnake = false; IsWall = false; }
        public void AddFood() { IsFood = true; IsEmpty = false; }
        public void RemoveFood() { IsFood = false; IsEmpty = true; }
    }

    // Position
    public class Pos
    {
        public int x; public int y;
        public int xMin { get; private set; }
        public int xMax { get; private set; }
        public int yMin { get; private set; }
        public int yMax { get; private set; }

        public Pos()
        {
            x = 0; y = 0;
            xMin = 0; yMin = 0;
            xMax = 21; yMax = 21;
        }

        public Pos(int x, int y)
        {
            this.x = x; this.y = y;
        }

        public Pos(int x, int y, int xMin, int xMax, int yMin, int yMax)
        {
            this.x = x; this.y = y;
            this.xMin = xMin; this.xMax = xMax; this.yMin = yMin; this.yMax = yMax;
        }

        public void PosSnake(int x, int y)
        {
            if (x < xMin) x = xMin; if (x > xMax) x = xMax;
            if (y < yMin) y = yMin; if (y > yMax) y = yMax;

            this.x = x; this.y = y;
        }

        public void SetXYMinMax(int xMin, int xMax, int yMin, int yMax)
        {
            this.xMin = xMin;
            this.xMax = xMax;
            this.yMin = yMin;
            this.yMax = yMax;
        }

    }


    class Program
    {
        // Create a border
        static void MakeBorder(List<Pos> border, int xMin, int xMax, int yMin, int yMax)
        {
            for (int x = xMin; x <= xMax; x++)
            {
                border.Add(new Pos(x, yMin));
                border.Add(new Pos(x, yMax));
            }

            for (int y = yMin + 1; y < yMax; y++)
            {
                border.Add(new Pos(xMin, y));
                border.Add(new Pos(xMax, y));
            }

        }

        static void MakeWall(List<Pos> wall, int xMin, int xMax, int yMin, int yMax)
        {
            for (int x = xMin; x <= xMax; x++)
            {
                wall.Add(new Pos(x, yMin));
                wall.Add(new Pos(x, yMax));
            }
            for (int y = yMin + 1; y < yMax; y++)
            {
                wall.Add(new Pos(xMin, y));
                wall.Add(new Pos(xMax, y));
            }
        }


        static void MakeMap(LandStt[,] map, List<Pos> border)
        {
            for (int x = 0; x < map.GetLength(0); x++)
            {
                for (int y = 0; y < map.GetLength(1); y++)
                {
                    map[x, y] = new LandStt();
                }
            }
            foreach (var pos in border)
            {
                map[pos.x, pos.y].SetBorder();
            }
        }

        static void ShowListChar(List<Pos> listChar, char show)
        {
            foreach (var pos in listChar)
            {
                Console.SetCursorPosition(pos.x, pos.y);
                Console.Write(show);
            }
        }


        static void ShowMap(LandStt[,] map, Symbol sym)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;



        }

        static void Main(string[] args)
        {

            int xMin = 0;
            int sizeX = 100;
            int yMin = 0;
            int sizeY = 20;

            int yMax = yMin + sizeY + 1;
            int xMax = xMin + sizeX + 1;

            Symbol sym = new Symbol();      // Create default symbol
            LandStt[,] map = new LandStt[xMax + 1, yMax + 1];

            List<Pos> border = new List<Pos>();
            MakeBorder(border, xMin, xMax, yMin, yMax);

            List<Pos> wall = new List<Pos>();
            MakeWall(wall, xMin + 1, xMax - 1, yMin + 1, yMax + 1);


            MakeMap(map, border);
            Console.CursorVisible = true;

            ShowMap(map, sym);
            ShowListChar(border, sym.Border);
            ShowListChar(wall, sym.Wall);


            Console.ReadLine();

            //Console.SetCursorPosition(10, 10);  // Set the cursor position to the specified coordinates
            //Console.ForegroundColor = ConsoleColor.Red; // Set the color of the text
            //Console.BackgroundColor = ConsoleColor.Black; // Set the background color of the text
            //Console.WriteLine("O");             // Write the specified string value
            //Console.ReadLine(); // Read the next line of characters from the standard input stream

            //Console.CursorVisible = false;
            //Console.Clear(); // Clear the console

        }
    }



}

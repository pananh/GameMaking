using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{

    public class Symbol
    {
        public char Snake { get; set; }
        public char Food { get; set; }
        public char Wall { get; set; }
        public char Empty { get; set; }
        
        public Symbol() 
        {
            Snake = 'O';
            Food = '*';
            Wall = '#';
            Empty = ' ';
        }

    };

    public class Pos
    {
        public int x;
        public int y;
        public int xMin { get; private set; }
        public int xMax { get; private set; }
        public int yMin { get; private set; }
        public int yMax { get; private set; }

        public Pos()
        {
            x = 0;
            y = 0;
            xMin = 0;
            xMax = 0;
            yMin = 0;
            yMax = 0;
        }

        public Pos(int x, int y)
        {
            if (x < xMin ) x = xMin;
            if (x > xMax) x = xMax;
            if (y < yMin) y = yMin;
            if (y > yMax) y = yMax;

            this.x = x;
            this.y = y;
        }

        public void SetSizeXY(int xMin, int xMax, int yMin, int yMax)
        {
            this.xMin = xMin;
            this.xMax = xMax;
            this.yMin = yMin;
            this.yMax = yMax;
        }

    }    



    class Program
    {

        static void SetWall(Symbol[,] map, Symbol sym)
        {
            int sizeX = map.GetLength(0);
            int sizeY = map.GetLength(1);
            

            for (int i = 0; i < sizeX; i++)
            {
                map[i, 0] = sym.Wall;
                map[i, sizeY - 1] = sym.Wall;
            }

        }


        static void Main(string[] args)
        {
           
            int xMin = 0;
            int sizeX = 20;
            int yMin = 0;
            int sizeY = 20;

            int yMax = yMin + sizeY-1;
            int xMax = xMin + sizeX - 1;

            Symbol sym = new Symbol();
            Symbol[,] map = new Symbol[sizeX, sizeY];
            SetWall (map, sym);




            Console.SetCursorPosition(10, 10);  // Set the cursor position to the specified coordinates
            Console.ForegroundColor = ConsoleColor.Red; // Set the color of the text
            Console.BackgroundColor = ConsoleColor.Black; // Set the background color of the text
            Console.WriteLine("O");             // Write the specified string value
            Console.ReadLine(); // Read the next line of characters from the standard input stream

            Console.Clear(); // Clear the console

        }
    }



}

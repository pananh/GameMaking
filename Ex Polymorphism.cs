using System;

namespace CompareTest
{

    public class Shape
    {
        public int x { get; private set; }
        public int y { get; private set; }
        public int Height { get; set; }
        public int Width { get; set; }

        // virtual method
        public virtual void Draw()
        {
            Console.WriteLine("Performing base class drawing:");
        }

    }

    public class Circle : Shape
    {
        public override void Draw()
        {
            // Code to draw a circle
            Console.WriteLine("Drawing a circle");
            base.Draw();
        }
    }

    public class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a triangle");
            base.Draw();
        }
    }

    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a rectagle");
            base.Draw();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var shape = new List<Shape>() { new Rectangle(), new Triangle(), new Circle() };

            foreach (var item in shape)
            {
                item.Draw();
            }

            shape[1].Draw();

        }

    }
}


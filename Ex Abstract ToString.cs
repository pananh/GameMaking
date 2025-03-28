using System;
using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace Example
{
    abstract class Shape
    {
        public const double PI = Math.PI;
        protected double x, y, z;
        public Shape(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public abstract double Area();

        public double getx()
        {
            return x;
        }
        public double gety()s
        {
            return y;
        }

        public double getz()
        {
            return z;
        }
    }

    class Circle : Shape
    {
        //private double radius;
        public Circle(double radius) : base(radius, 0)
        {
        }
        public override double Area()
        {
            return PI * x * x;
        }

        public override string ToString()
        {
            return " Here is new ToString Circle" + this.x;
        }


    }

    class Cylinder : Circle
    {
        public Cylinder(double radius, double height) : base(radius)
        {
            y = height;
        }
        public override double Area()
        {
            return 2 * base.Area() + 2 * PI * x * y;
        }

        public override string ToString()
        {
            return " Here is new ToString Cylinder" + this.x;
        }


    }

    public class Test
    {
        static void Main()
        {

            double radius = 2.5;
            double height = 3.0;
            Circle ring = new Circle(radius);
            Cylinder tube = new Cylinder(radius, height);

            Console.WriteLine(ring.GetType());
            Console.WriteLine(ring.getx());
            Console.WriteLine(ring.gety());
            Console.WriteLine(ring.getz());
            Console.WriteLine("Area of the circle = {0:F2} so sanh {1:F2}", ring.Area(), radius * radius * Shape.PI);
            Console.WriteLine(" ");


            Console.WriteLine(tube.GetType());
            Console.WriteLine(tube.getx());
            Console.WriteLine(tube.gety());
            Console.WriteLine(tube.getz());
            Console.WriteLine("Area of the cylinder = {0:F2} so sanh {1:F2}", tube.Area(), 2 * radius * radius * Shape.PI + 2 * radius * height * Shape.PI);


            Console.WriteLine(ring.ToString());
            Console.WriteLine(tube.ToString());

        }
    }

}


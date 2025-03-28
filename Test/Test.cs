using System;
using System.ComponentModel;
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
        public double gety()
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
        public Circle (double radius): base(radius, 0)
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

    class Cylinder: Circle
    {
        public Cylinder (double radius, double height) : base(radius)
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

        public void SetX(double x)
            { this.x = x; }
        public void SetY(double y)
            { this.y = y; }



    }

    public class Test
    {
        static void Main()
        {

            //double radius = 2.5;
            //double height = 3.0;
            //Circle ring = new Circle(radius);
            //Cylinder tube = new Cylinder(radius, height);

            //Console.WriteLine(ring.GetType());
            //Console.WriteLine(ring.getx());
            //Console.WriteLine(ring.gety());
            //Console.WriteLine(ring.getz());
            //Console.WriteLine("Area of the circle = {0:F2} so sanh {1:F2}", ring.Area(), radius * radius * Shape.PI);


            //Console.WriteLine(tube.GetType());
            //Console.WriteLine(tube.getx());
            //Console.WriteLine(tube.gety());
            //Console.WriteLine(tube.getz());
            //Console.WriteLine("Area of the cylinder = {0:F2} so sanh {1:F2}", tube.Area(), 2 * radius * radius * Shape.PI + 2 * radius * height * Shape.PI);

            //Console.WriteLine(ring.ToString());
            //Console.WriteLine(tube.ToString());

            //double radius2 = 2.5;
            //double height2 = 3.0;
            //Circle ring2 = new Cylinder(radius2, height2);  // Nhan ve Stack la Ring2 cho vao khu gia tri Cylinder

            //Console.WriteLine(ring2.GetType());
            //Console.WriteLine(ring2.getx());
            //Console.WriteLine(ring2.gety());
            //Console.WriteLine(ring2.getz());
            //Console.WriteLine("Area of the circle = {0:F2} so sanh {1:F2}", ring2.Area(), radius2 * radius2 * Shape.PI);
            //// Vi vay ham ring2.Area se lay ham cua Cylinder

            double radius3 = 2.5;
            double height3 = 3.0;
            //Circle ringtemp = new Circle(radius3);      // Ep khong thanh cong tu kieu Cha ve kieu con
            //Cylinder ring3 = (Cylinder) ringtemp;     
            //ring3.SetX(radius3);
            //ring3.SetY(height3);

            // Ep thanh cong tu kieu con ve kieu Cha. Tuy nhien ham lay se lay cua Cylinder
            Circle ring3 = new Cylinder(radius3, height3);

            Console.WriteLine(ring3.GetType());
            Console.WriteLine(ring3.getx());
            Console.WriteLine(ring3.gety());
            Console.WriteLine(ring3.getz());
            Console.WriteLine("Area of the circle = {0:F2} so sanh {1:F2}", ring3.Area(), radius3 * radius3 * Shape.PI);
            // Vi vay ham ring2.Area se lay ham cua Cylinder




        }
    }

}


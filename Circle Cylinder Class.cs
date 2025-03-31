using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CodeGym
{
	public class Circle
	{
		const double PI = Math.PI;
		protected double radius;
		protected string color;

		public double Radius
		{
			get { return radius; }
			set { radius = value; }
		}

		public string Color
		{
			get { return color; }
			set { color = value; }
		}

		public double Area()
		{
			return radius * radius * PI;
		}

		public override string ToString()
		{
			return "Here is Circle class";
		}

	}
	class Cylinder : Circle
	{
		public double height { get; set; }

		public double Volumne()
		{
			return this.Area() * height;
		}

		public override string ToString()
		{
			{
				return "Here is Cylinder class";
			}

		}
	}

	class Program
	{

		static void Main(string[] args)
		{
			Circle c = new Circle();
			c.Radius = 10;
			c.Color = "Green";
			Console.WriteLine(c.ToString());
			Console.WriteLine("Radius {0:F2}", c.Radius);
			Console.WriteLine("Color is " + c.Color);
			Console.WriteLine("Area is {0:F2}", c.Area());


			Cylinder cylinder = new Cylinder();
			cylinder.Radius = c.Radius;
			cylinder.Color = c.Color;
			cylinder.height = 20;


			Console.WriteLine("------------");
			c.Radius = 100; c.Color = "Red";        // Test thu doi gia tri, nhung Cylinder khong thay doi
			Console.WriteLine(c.ToString());
			Console.WriteLine("Radius {0:F2}", c.Radius);
			Console.WriteLine("Color is " + c.Color);
			Console.WriteLine("Area is {0:F2}", c.Area());

			Console.WriteLine("------------");
			Console.WriteLine(cylinder.ToString());
			Console.WriteLine("Cylinder radius {0:F2} - height {1:F2}", cylinder.Radius, cylinder.height);
			Console.WriteLine("Color is " + cylinder.Color);
			Console.WriteLine("Volumne is {0:F2}", cylinder.Volumne());

			Console.WriteLine("------------");
			cylinder.Radius = 200;
			cylinder.Color = "White";
			cylinder.height = 900;
			Console.WriteLine(c.ToString());
			Console.WriteLine("Radius {0:F2}", c.Radius);
			Console.WriteLine("Color is " + c.Color);
			Console.WriteLine("Area is {0:F2}", c.Area());

		}
	}


}




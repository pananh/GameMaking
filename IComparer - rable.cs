using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace CodeGym
{
	public class Circle : Shape
	{
		private double radius = 1.0;

		public Circle()
		{
		}

		public Circle(double radius)
		{
			this.radius = radius;
		}

		public Circle(double radius, String color, bool filled) : base(color, filled)
		{
			this.radius = radius;
		}

		public double getRadius()
		{
			return radius;
		}

		public void setRadius(double radius)
		{
			this.radius = radius;
		}

		public double getArea()
		{
			return radius * radius * Math.PI;
		}

		public double getPerimeter()
		{
			return 2 * radius * Math.PI;
		}

		public override string ToString()
		{
			return "A Circle with radius="
					+ getRadius()
					+ ", which is a subclass of "
					+ base.ToString();
		}
	}

	public class ComperableCircle : Circle, IComparable<ComperableCircle>, IComparer<ComperableCircle>
	{

		public ComperableCircle() { }
		public ComperableCircle(double radius) : base(radius) { }
		public ComperableCircle(double radius, string color, bool filled) : base(radius, color, filled) { }

		public int CompareTo(ComperableCircle o)
		{
			if (getRadius() > o.getRadius()) return 1;
			else if (getRadius() < o.getRadius()) return -1;
			else return 1;
		}

		public int Compare(ComperableCircle o1, ComperableCircle o2)
		{
			return o1.getColor().CompareTo(o2.getColor());
		}
	}

	public class CCircle : Circle, IComparer<CCircle>
	{

		public CCircle() { }
		public CCircle(double radius) : base(radius) { }
		public CCircle(double radius, string color, bool filled) : base(radius, color, filled) { }

		public int Compare(CCircle o1, CCircle o2)
		{
			return o1.getColor().CompareTo(o2.getColor());
		}
	}




	public class Rectangle : Shape
	{
		private double width = 1.0;
		private double length = 1.0;

		public Rectangle()
		{
		}

		public Rectangle(double width, double length)
		{
			this.width = width;
			this.length = length;
		}

		public Rectangle(double width, double length, string color, bool filled) : base(color, filled)
		{
			this.width = width;
			this.length = length;
		}

		public double getWidth()
		{
			return width;
		}

		public virtual void setWidth(double width)
		{
			this.width = width;
		}

		public double getLength()
		{
			return length;
		}

		public virtual void setLength(double length)
		{
			this.length = length;
		}

		public double getArea()
		{
			return width * this.length;
		}

		public double getPerimeter()
		{
			return 2 * (width + this.length);
		}

		public override string ToString()
		{
			return "A Rectangle with width="
					+ getWidth()
					+ " and length="
					+ getLength()
					+ ", which is a subclass of "
					+ base.ToString();
		}
	}

	public class Shape
	{
		private string color = "green";
		private bool filled = true;

		public Shape()
		{
		}

		public Shape(string color, bool filled)
		{
			this.color = color;
			this.filled = filled;
		}

		public string getColor()
		{
			return color;
		}

		public void setColor(string color)
		{
			this.color = color;
		}

		public bool isFilled()
		{
			return filled;
		}

		public void setFilled(bool filled)
		{
			this.filled = filled;
		}

		public override string ToString()
		{
			return "A Shape with color of "
					+ getColor()
					+ " and "
					+ (isFilled() ? "filled" : "not filled");
		}
	}

	public class Square : Rectangle
	{
		public Square()
		{
		}

		public Square(double side) : base(side, side)
		{
		}

		public Square(double side, string color, bool filled) : base(side, side, color, filled)
		{
		}

		public double getSide()
		{
			return getWidth();
		}

		public void setSide(double side)
		{
			base.setWidth(side);
			base.setLength(side);
		}
		public override void setWidth(double width)
		{
			setSide(width);
		}

		public override void setLength(double length)
		{
			setSide(length);
		}

		public override string ToString()
		{
			return "A Square with side="
					+ getSide()
					+ ", which is a subclass of "
					+ base.ToString();
		}
	}

	class Program
	{
		static void Main(string[] args)
		{

			ComperableCircle[] circles = new ComperableCircle[3];
			circles[0] = new ComperableCircle(3.6);
			circles[1] = new ComperableCircle();
			circles[2] = new ComperableCircle(3.5, "indigo", false);

			Console.WriteLine("Pre-sorted:");
			foreach (ComperableCircle circle in circles)
			{
				Console.WriteLine(circle);
			}

			Array.Sort(circles);
			Console.WriteLine("After-sorted:");
			foreach (ComperableCircle circle in circles)
			{
				Console.WriteLine(circle);
			}

			Array.Sort(circles, new ComperableCircle());
			Console.WriteLine("After-sorted by color:");
			foreach (ComperableCircle circle in circles)
			{
				Console.WriteLine(circle);
			}

			CCircle[] c = new CCircle[3];
			c[0] = new CCircle(3.6);
			c[1] = new CCircle(2.5, "blue", true);
			c[2] = new CCircle(3.5, "indigo", false);
			Console.WriteLine("Pre-sorted:");
			foreach (CCircle circle in c)
			{
				Console.WriteLine(circle);
			}

			Array.Sort(c, new CCircle());

			Console.WriteLine("After-sorted by color:");
			foreach (CCircle circle in c)
			{
				Console.WriteLine(circle);
			}

		}
	}


}




using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace CodeGym
{
	public interface Resizeable
	{
		void Resize(double percent);

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

	public class Rectangle : Shape, Resizeable
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

		public void Resize(double percent)
		{
			//this.width *= (100+ percent)/100;
			//this.length *= (100+ percent)/100;
			this.width = this.width * (100 + percent) / 100;
			this.length = this.length * (100 + percent) / 100;
		}
	}

	public class Circle : Shape, Resizeable
	{
		private double radius = 1.0;

		public void Resize(double percent)
		{
			this.radius *= (100 + percent) / 100;
		}

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

	public class Square : Rectangle, Resizeable
	{
		public void Resize(double percent)
		{
			// Cach 1: Su dung ham lay Width, Length va gan lai
			//double thisWidth = base.getWidth();
			//thisWidth *= (100 + percent) / 100;
			//base.setWidth(thisWidth);
			//base.setLength(thisWidth);

			//Cach 2: Su dung ham Resize cua base. Coi nhu Square la 1 dang cua Rectangle
			base.Resize(percent);
		}
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

			// Shape Test
			Console.WriteLine("Shape Test -------");
			Shape shape = new Shape();
			Console.WriteLine(shape);

			shape = new Shape("red", false);
			Console.WriteLine(shape);

			// Circle Test
			Console.WriteLine("Circle -------");
			Circle circle = new Circle();
			Console.WriteLine(circle);

			circle = new Circle(10);
			Console.WriteLine(circle);

			circle = new Circle(100, "indigo", false);
			circle.Resize(20);
			Console.WriteLine(circle);

			// Rectangle
			Console.WriteLine("Rectangle -----");
			Rectangle rectangle = new Rectangle();
			Console.WriteLine(rectangle);

			rectangle = new Rectangle(100, 10);
			rectangle.Resize(20);
			Console.WriteLine(rectangle);


			// Square Test
			Console.WriteLine("Square -------");
			Square square = new Square();
			Console.WriteLine(square);

			square = new Square(10);
			square.Resize(20);
			Console.WriteLine(square);

			square = new Square(100, "yellow", true);
			Console.WriteLine(square);




		}
	}


}




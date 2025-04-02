using System;
using System.Collections.Generic;
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
			return "A Shape "
					+ getColor()
					+ " & "
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
			return "A Rectangle width="
					+ getWidth()
					+ " & length="
					+ getLength()
					+ ", subclass of "
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

	public class Circle : Shape, Resizeable, IColorable
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
			return "A Circle R "
					+ getRadius()
					+ ", subclass of "
					+ base.ToString();
		}

		public void HowToColor()
		{
			Console.WriteLine("Color all four sides " + this.getColor());
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
			return "A Square Side="
					+ getSide()
					+ ", subclass of "
					+ base.ToString();
		}
	}

	public interface IColorable
	{
		public void HowToColor();

	}


	class Program
	{

		static void Main(string[] args)
		{



			// Circle Test
			Random random = new Random();
			int nMax = 10;
			int nCircle = random.Next(1, nMax);
			int nRec = random.Next(1, nMax);
			int nSq = random.Next(1, nMax);
			nMax = nCircle + nRec + nSq;
			Shape[] shapes = new Shape[nMax];

			for (int i = 0; i < nCircle; i++)
			{
				shapes[i] = new Circle(random.Next(1, 10));
			}

			for (int i = 0; i < nRec; i++)
			{
				shapes[nCircle + i] = new Rectangle(random.Next(1, 10), random.Next(1, 10));
			}

			for (int i = 0; i < nSq; i++)
			{
				shapes[nCircle + nRec + i] = new Square(random.Next(1, 10));
			}

			for (int i = 0; i < nMax; i++)
			{
				Console.WriteLine(shapes[i].ToString());
				if (shapes[i] is Circle)
				{
					var temp = (Circle)shapes[i];
					temp.HowToColor();
				}
			}



		}
	}


}




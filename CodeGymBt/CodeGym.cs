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
    public class Point2D
    {
        protected float x; protected float y;

        public Point2D(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public Point2D() { }

        public float GetX() { return x; }
        public float GetY() { return y; }
        public void SetX(float x) { this.x = x; }
        public void SetY(float y) { this.y = y; }

        public float X { get { return x; } set { x = value; } }
        public float Y { get { return y; } set { y = value; } }
        public void SetXY(float x, float y)
        {
            this.x = x; this.y = y;
        }

        public float[] GetXY()
        {
            return new float[] { x, y };
        }

        public override string ToString()
        {
            //string temp = string.Empty;
            string temp = "(x,y) = " + string.Format("({0:F2} ,{1:F2})", this.x, this.y);
            return temp;
        }

    }
   
    public class Point3D: Point2D
    {
        protected float z;

        public Point3D(float x, float y, float z)
        {
            this.x=x; this.y=y; this.z=z;
        }

        public Point3D() { }

        public float GetZ() { return z; }
        public void SetZ(float z) { this.z = z; }
        public float Z { get { return z; } set { z = value; } }
        
        public void SetXYZ (float x, float y, float z) {this.x = x; this.y = y; this.z = z; }
        
        public float[] GetXYZ() { return new float[] { x,y,z }; }

		public override string ToString()
		{
            string temp = "(x,y,z) = " + string.Format("({0:F2}, {1:F2}, {2:F2})",x, y, z);
            return temp;
		}

        public void Point2D (Point2D point2D)
        {
            this.x = point2D.X;
            this.y = point2D.Y;
        }

        public Point2D Point2DxyG
        {
            //get {  return this; }   // cach nay cung duoc nhung se tra ve kieu Point3D
            get
            {
                Point2D temp = new Point2D();
                temp.X = this.x; temp.Y = this.y;
                return temp;
            }
            set { this.x = value.X; this.y = value.Y; }
        }

        public Point2D Point2Dxy()
        {
            //return this;  // dung kieu nay thi se tra ve kieu type la Point3D
            Point2D temp = new Point2D(this.x, this.y);
            return temp;
        }

	}


    class Program
    {

        static void Main(string[] args)
        {
            Point2D p2 = new Point2D(2313.235465f, 321654.21316f);
            Console.WriteLine(p2.ToString());
            p2.X = 3215.5525f;
            p2.Y = 19.687f;
            Console.WriteLine(p2.ToString());
            Console.WriteLine(p2.GetXY()[0] + " " + p2.GetXY()[1]);

            Point3D p3 = new Point3D();
            p3.Point2D(p2);
            p3.Z = 10.10000f;
            Console.WriteLine(p3.ToString());

            p3.X = 99.88f;
            p3.Y = 66.88f;
            p2 = p3.Point2DxyG;
            Console.WriteLine(p2.ToString());

			p3.X = 88.88f;
			p3.Y = 77.77f;
			p2 = p3.Point2Dxy();
            //Console.WriteLine(p2.GetType());    
			Console.WriteLine(p2.ToString());

		}
    }


}




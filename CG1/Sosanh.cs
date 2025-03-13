using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TuanAnh
{
    public class Sosanh
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chuong trinh CG1 ");
            int a, b;
            Console.Write("Nhap so a: ");
            a = int.Parse(Console.ReadLine());
            a++;
            Console.WriteLine("a++: " + a);
            ++a;
            Console.WriteLine("++a: " + a);
            b = a++;

            Console.WriteLine("b= a++: " + b);
            Console.WriteLine("a= " + a);

            b = ++a;
            Console.WriteLine("b= ++a: " + b);
            Console.WriteLine("a= " + a);
        }
    }
}
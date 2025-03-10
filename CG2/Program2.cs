// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace TuanAnh
{
    /// <summary>
    /// Ghi chú trước class thôi
    /// </summary>
    class Program2
    {

        /// <summary>
        /// Tài liệu thần kỳ
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("CG2 Hello World from C#");
            Console.WriteLine("CG2 Bam phim bat ky de thoat");
            Console.ReadKey();
            
            
            Console.WriteLine("Hello World");
            int i, j, k;
            i = 10;
            j = 20;
            k = 30;
            var tong = i + j + k;
            string str = "Tong cua 3 so la: " + tong;
            Console.WriteLine(str);

            const double PI = 3.14159;
            double r = 5.0;
            double area = PI * r * r;

            bool dungsai = true;
            byte sobyte = 255;
            char kytu = 'A';
            decimal sothapphan = 3.1416926535897932384626433832m;
            double sothuc = 3.1416926535897932384626433832;
            float sothucdon = 3.1416926535897932384626433832f;
            Console.WriteLine(sothapphan);
            Console.WriteLine(sothuc);
            Console.WriteLine(sothucdon);

            object kieuobject;
            kieuobject = sothapphan;
            Console.WriteLine(kieuobject);

            kieuobject = "Hello World";
            Console.WriteLine(kieuobject);

            kieuobject = sothuc;
            Console.WriteLine(kieuobject);

            dynamic kieubatky;
            kieubatky = sothuc;
            Console.WriteLine(kieubatky);

            kieuobject = "Hello World Than ky";
            kieubatky = "Hello World";

            string chuoi1;
            string chuoi2;

            chuoi1 = kieuobject.ToString();
            chuoi2 = kieubatky;
            Console.WriteLine(chuoi1);
            Console.WriteLine(chuoi2);

            kieuobject = sothapphan;
            kieubatky = sothapphan;

            sothapphan = (decimal)kieuobject;
            float sothapphan2 = (float)kieubatky;
            Console.WriteLine(sothapphan);
            Console.WriteLine(sothapphan2);

            string chuoimoi = "Hello World 2";
            chuoimoi = chuoimoi + @" Hello World 3";
            Console.WriteLine(chuoimoi);

            // ghi chú dòng

            /* ghi chú nhiều dòng 

            decimal* p;
            p = &sothapphan;
            Console.WriteLine(p);

            string* p2;
            p2 = &chuoimoi;
            Console.WriteLine(p2);

            object* p3;
            p3 = &kieuobject;
            Console.WriteLine(p3);

            dynamic* p4;
            p4 = &kieubatky;
            Console.WriteLine(p4); 
            
            ghi chú tài liệu dùng ///
             
             */

                      

            float a = 5.2f;
            float b = 10;
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine(a % b);
            Console.WriteLine(b % a);
            Console.WriteLine((int)a % b);
            Console.WriteLine((int)b % a);



            
        }






    }
}
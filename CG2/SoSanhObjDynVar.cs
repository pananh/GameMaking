// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace TuanAnh
{
    /// <summary>
    /// Ghi chú trước class thôi
    /// </summary>
    public class SoSanhObjDynVar
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CG2 Hello World from C#");
            int i, j, k;
            Console.WriteLine("Nhap 3 so nguyen i, j, k: ");
            //i = int.Parse(Console.ReadLine());
            //j = int.Parse(Console.ReadLine());
            //k = int.Parse(Console.ReadLine());
            i = 1;
            j = 2;
            k = 3;
            dynamic tong = i + j + k; 
            int tong2 = tong * 2;
            Console.WriteLine("Tong1 so la: " + tong);
            Console.WriteLine("Tong2 so la: " + tong2);

            dynamic tong3 = tong*3;
            tong3 = tong * 3;
            int ganlai1;
            ganlai1 = tong3;
            Console.WriteLine("Tong3 so la: " + ganlai1);

            /* dynamic thay đổi được kiểu; không cần định nghĩa ngay từ đầu; được gán lại cho biến khác
             * var thay đổi được kiểu; phải định  nghĩa ngay từ đầu; được gán lại cho biến khác
             * object thay đổi được kiểu; không phải định nghĩa ngay từ đầu; không thể gán lại cho biến khác
            */
            tong3 = "fsfa";
            string ganlai2;
            ganlai2 = tong3;

            Console.WriteLine("Tong3 so la: " + ganlai2);

        }
    }
}
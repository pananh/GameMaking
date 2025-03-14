using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap
{
    public class TyGia
    {
        static void Main()
        {
            const int TyGiaVND_USD = 25000;
            Console.WriteLine("Ty gia hien tai la " + TyGiaVND_USD + " VND/USD.");
            decimal tienUSD;
            Console.Write("Nhap so tien USD can doi: ");
            tienUSD = decimal.Parse(Console.ReadLine());
            decimal tienVND = tienUSD * TyGiaVND_USD;
            Console.WriteLine("So tien VND tuong ung la: " + tienVND + " VND");

        }
    }
}
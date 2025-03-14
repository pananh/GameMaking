// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class GiaoTrinhC
    {

        enum MauSac
        {
            Do = 0,
            Cam = 1,
            Vang = 2,
            Luc = 3,
            Lam = 4,
            Cham = 5,
            Tim = 6
        }

        static void Main()
        {
            int soTuoi = 0;

            bool success = false;

            while (!success)
            {
                Console.WriteLine("Nhap tuoi: ");
                string strInput = Console.ReadLine();
                string strIn = (string)strInput;
                success = int.TryParse(strIn, out soTuoi);

                if (!success)
                {
                    Console.WriteLine("Nhap lai tuoi di: ");
                }
            }

            if ((soTuoi > 0) && (soTuoi <= 120))
            {
                int ngay = soTuoi * 365;
                Console.WriteLine("Ngay " + ngay);

                var tuananh = "\0";
                Console.WriteLine(tuananh);
                Console.WriteLine(tuananh.ToString());


            }
            else
            {
                Console.WriteLine("Nhieu tuoi hoac it tuoi qua ");
            }
        }


    }
}
/* static void Main1()
{
    int chonMau;
    Console.WriteLine("Mau Do {0}", (int)MauSac.Do);
    Console.WriteLine("Mau Cam {0}", (int)MauSac.Cam);
    Console.WriteLine("Mau Vang {0}", (int)MauSac.Vang);
    Console.WriteLine("Mau Luc {0}", (int)MauSac.Luc);
    Console.WriteLine("Mau Lam {0}", (int)MauSac.Lam);
    Console.WriteLine("Mau Cham {0}", (int)MauSac.Cham);
    Console.WriteLine("Mau Tim {0}", (int)MauSac.Tim);
    Console.Write("Chon mau: ");

    chonMau = Parse(Console.ReadLine());

    while IsNumber(chonMau) == false
    {
        Console.WriteLine("Ban phai nhap so");
        Console.Write("Chon mau: "); 
        chonMau = Parse(Console.ReadLine());
    }



    switch (chonMau)
    {
        case (int)MauSac.Do:
            Console.WriteLine("Ban da chon mau Đỏ");
            break;
        case (int)MauSac.Cam:
            Console.WriteLine("Ban da chon mau Cam");
            break;
        case (int)MauSac.Vang:
            //Console.WriteLine("Ban da chon mau vang");                    
        case (int)MauSac.Luc:
            Console.WriteLine("Ban da chon mau Lục");
            break;
        case (int)MauSac.Lam:
            Console.WriteLine("Ban da chon mau Lam");
            goto case MauSac.Cham;

        case (int)MauSac.Cham:
            Console.WriteLine("Ban da chon mau Chàm");
            goto case MauSac.Tim;

        case (int)MauSac.Tim:
            Console.WriteLine("Ban da chon mau Tím");
            goto case MauSac.Luc;
        default:
            Console.WriteLine("Ban khong chon mau nao het");
            break;

    }

}
}
} */
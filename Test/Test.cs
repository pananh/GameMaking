// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class GiaoTrinhC
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
            int chonMau;
            Console.WriteLine("Mau Do {0}", (int)MauSac.Do);
            Console.WriteLine("Mau Cam {0}", (int)MauSac.Cam);
            Console.WriteLine("Mau Vang {0}", (int)MauSac.Vang);
            Console.WriteLine("Mau Luc {0}", (int)MauSac.Luc);
            Console.WriteLine("Mau Lam {0}", (int)MauSac.Lam);
            Console.WriteLine("Mau Cham {0}", (int)MauSac.Cham);
            Console.WriteLine("Mau Tim {0}", (int)MauSac.Tim);
            Console.Write("Chon mau: ");
            chonMau = int.Parse(Console.ReadLine());
            switch (chonMau)
            {
                case (int)MauSac.Do:
                    Console.WriteLine("Ban da chon mau do");
                    break;
                case (int)MauSac.Cam:
                    Console.WriteLine("Ban da chon mau cam");
                    break;
                case (int)MauSac.Vang:
                    //Console.WriteLine("Ban da chon mau vang");                    
                case (int)MauSac.Luc:
                    Console.WriteLine("Ban da chon mau luc");
                    break;
                case (int)MauSac.Lam:
                    Console.WriteLine("Ban da chon mau lam");
                    goto case MauSac.Cham;
                    
                case (int)MauSac.Cham:
                    Console.WriteLine("Ban da chon mau cham");
                    goto case MauSac.Tim;

                case (int)MauSac.Tim:
                    Console.WriteLine("Ban da chon mau tim");
                    goto case MauSac.Luc;
                default:
                    Console.WriteLine("Ban khong chon mau nao het");
                    break;

            }

        }
    }
}
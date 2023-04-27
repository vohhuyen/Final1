using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentHK1
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            
        Home:
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("LOGIN");
            Console.ResetColor();
            Console.WriteLine("1. Customer");
            Console.WriteLine("2. Seller");
            Console.WriteLine("3. Admin");
            int x = Convert.ToInt32(Console.ReadLine());
            switch(x)
            {
                case 1:
                    {
                        Console.WriteLine("User name: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Passwork: ");
                        int kk = Console.ReadLine();
                        if(kk = 1234)
                        {
                            goto Home;
                        }
                      
                    }
                case 2:
                    {
                        Console.WriteLine("user name: ");
                        Console.WriteLine("Passwork: ");
                        goto Home;
                    }
                case 3:
                    {
                        Console.WriteLine("user name: ");
                        Console.WriteLine("Passwork: ");
                        goto Home;
                    }
            }
            DanhSachSeller lea = new DanhSachSeller();
            lea.Nhap();
            lea.Xuat();
            Console.ReadKey();
        }
    }
}

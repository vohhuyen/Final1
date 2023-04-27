using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentHK1
{
    internal class DanhSachSanPham
    {
        private Dictionary<string, SanPham> listStaff;
        public DanhSachSanPham()
        {
            listStaff = new Dictionary<string, SanPham>();
        }
        public void Nhap()
        {
            char t = 'y';
            while (t == 'y')
            {
                SanPham qlsp = new SanPham();
                qlsp.Nhap();
                listStaff.Add(qlsp.id, qlsp);
                Console.Write("The product has been added to the list\r\nEnter the character '");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("y");
                Console.ResetColor();
                Console.Write("' to continue entering the product\r\nType the character '");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("n");
                Console.ResetColor();
                Console.Write("' to escape \n");
                Console.Write("-> Your choose: ");
                t = Convert.ToChar(Console.ReadLine());
            }
        }
        public void Xuat()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("                                                  ========= LIST PRODUCT =========");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" ----------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("|{0, -5} |{1, -20} |{2, -50} |{3, -30} |{4, -10} |{5, -10} |",
                 "ID", "Name", "describe", "material", "cost", "price");
            Console.WriteLine("|------|---------------------|---------------------------------------------------|-------------------------------|-----------|-----------|");
            Console.ResetColor();
            foreach (SanPham qlsp in listStaff.Values)
            {
                qlsp.Xuat();
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("|------|---------------------|---------------------------------------------------|-------------------------------|-----------|-----------|");
            Console.ResetColor();

            Console.Write("Press key '");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("D");
            Console.ResetColor();
            Console.WriteLine("' to delete the seller");
            Console.Write("Press key '");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("F");
            Console.ResetColor();
            Console.WriteLine("' to find the seller");
            Console.Write("Press key '");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("E");
            Console.ResetColor();
            Console.WriteLine("' to exit.");
        }
        public SanPham tim()
        {
            Console.Write("Enter the product ID to find: ");
            string ID = Console.ReadLine();
            return this.listStaff[ID];

        }
        public void xoa()
        {
            Console.Write("nhap ID san pham can xoa: ");
            string ID = Console.ReadLine();
            listStaff.Remove(ID);
        }
    }
}

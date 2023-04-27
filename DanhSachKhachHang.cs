using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentHK1
{
    internal class DanhSachKhachHang
    {
        private Dictionary<string, KhachHang> listStaff;
        public DanhSachKhachHang()
        {
            listStaff = new Dictionary<string, KhachHang>();
        }
        public void Nhap()
        {
            char t = 'y';
            while (t == 'y')
            {
                KhachHang qlsp = new KhachHang();
                qlsp.Nhap();
                listStaff.Add(qlsp.id, qlsp);
                Console.Write("Nhap ky tu y de tiep tuc: ");
                t = Convert.ToChar(Console.ReadLine());
            }
        }
        public void Xuat()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("                                        ========= LIST CUSTOMER =========");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" ------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("|{0, -5} |{1, -20} |{2, -5} |{3, -40} |{4, -30} |{5, -15} |",
                 "ID", "Name", "sex", "Address", "Email", "Phone");
            Console.WriteLine("|------|---------------------|------|-----------------------------------------|-------------------------------|----------------|");
            Console.ResetColor();
            foreach (KhachHang qlsp in listStaff.Values)
            {
                qlsp.Xuat();
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("|------|---------------------|------|-----------------------------------------|-------------------------------|----------------|");
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
        public KhachHang tim()
        {
            Console.Write("nhap ID khach hang can tim : ");
            string ID = Console.ReadLine();
            return this.listStaff[ID];

        }
        public void xoa()
        {
            Console.Write("nhap ID khach hang can xoa: ");
            string ID = Console.ReadLine();
            listStaff.Remove(ID);
        }
    }
}

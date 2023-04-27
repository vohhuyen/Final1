using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentHK1
{
    internal class DanhSachSeller
    {
        private Dictionary<string, Seller> listStaff;
        public DanhSachSeller()
        {
            listStaff = new Dictionary<string, Seller>();
        }
        public void Nhap()
        {
            char t = 'y';
            while (t == 'y')
            {
                Seller qlss = new Seller();
                qlss.Nhap();
                listStaff.Add(qlss.id, qlss);
                Console.Write("Nhap ky tu y de tiep tuc: ");
                t = Convert.ToChar(Console.ReadLine());
            }
        }
        public void Xuat()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("                              ========= LIST SELLER =========");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" ----------------------------------------------------------------------------------------------------------");
            Console.WriteLine("|{0, -5} |{1, -20} |{2, -30} |{3, -10} |{4, -20} |{5, -10} |",
                "ID", "Name", "Email", "Phone", "Quantity Product", "revenue");
            Console.WriteLine("|------|---------------------|-------------------------------|-----------|---------------------|-----------|");
            Console.ResetColor();
            foreach (Seller qlss in listStaff.Values)
            {
                qlss.Xuat();
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("|------|---------------------|-------------------------------|-----------|---------------------|-----------|");
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
        public Seller tim()
        {
            Console.Write("nhap ID seller can tim : ");
            string ID = Console.ReadLine();
            return this.listStaff[ID];

        }
        public void xoa()
        {
            Console.Write("nhap ID seller can xoa: ");
            string ID = Console.ReadLine();
            listStaff.Remove(ID);
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentHK1
{
    internal class Seller
    {
        private string ID;
        private string hoten;
        private string email;
        private long sodienthoai;
        private int sosanpham;
        private double doanhthu;

        public string id
        {
            set { this.ID = value; }
            get { return this.ID; }
        }
        public String Hoten
        {
            set { this.hoten = value; }
            get { return this.hoten; }
        }
       
        public String Email
        {
            set { this.email = value; }
            get { return this.email; }
        }
        public long Sodienthoai
        {
            set { this.sodienthoai = value; }
            get { return this.sodienthoai; }
        }
        public int Sosanpham
        {
            set { this.sosanpham = value; }
            get { return this.sosanpham; }
        }
        public double Doanhthu
        {
            set { this.doanhthu = value;}
            get { return this.doanhthu;}
        }
        public Seller()
        { }
        public Seller(string ID, string hoten,
            string email, long sodienthoai, int sosanpham, double doanhthu)
        {
            this.ID = ID;
            this.hoten = hoten;
            this.email = email;
            this.sodienthoai = sodienthoai;
            this.sosanpham = sosanpham;
            this.doanhthu = doanhthu;
        }
        public virtual void Nhap()
        {

            Console.WriteLine("Nhap ID seller :");
            this.ID = Console.ReadLine();
            Console.WriteLine("Nhap ho ten seller :");
            this.hoten = Console.ReadLine();
            Console.WriteLine("Nhap email seller :");
            this.email = Console.ReadLine();
            Console.WriteLine("Nhap so dien thoai :");
            this.sodienthoai = long.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so san pham dang ban: ");
            this.sosanpham = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap doanh thu: ");
            this.doanhthu = double.Parse(Console.ReadLine());
        }
        public virtual void Xuat()
        { 
            Console.WriteLine("|{0, -5} |{1, -20} |{2, -30} |{3, -10} |{4, -20} |{5, -10} |",
                                      this.ID, this.hoten, this.email, this.sodienthoai, this.sosanpham, this.doanhthu);
        }
    }
}

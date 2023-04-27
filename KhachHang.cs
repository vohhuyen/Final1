using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentHK1
{
    internal class KhachHang
    {
        private string ID;
        private string hoten;
        private string gioitinh;
        private string diachi;
        private string email;
        private long sodienthoai;

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
        public String Gioitinh
        {
            set { this.gioitinh = value; }
            get { return this.gioitinh; }
        }
        public String Diachi
        {
            set { this.diachi = value; }
            get { return this.diachi; }
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
        public KhachHang()
        { }
        public KhachHang(string ID, string hoten, string gioitinh, string diachi,
            string email, long sodienthoai)
        {
            this.ID = ID;
            this.hoten = hoten;
            this.gioitinh = gioitinh;
            this.diachi = diachi;
            this.email = this.email;
            this.sodienthoai = this.sodienthoai;
        }
        public virtual void Nhap()
        {
            Console.WriteLine("Nhap ID khach hang :");
            this.ID = Console.ReadLine();
            Console.WriteLine("Nhap ho ten khach hang :");
            this.hoten = Console.ReadLine();
            Console.WriteLine("Nhap gioi tinh khach hang :");
            this.gioitinh = Console.ReadLine();
            Console.WriteLine("Nhap dia chi khach hang :");
            this.diachi = Console.ReadLine();
            Console.WriteLine("Nhap email khach hang :");
            this.email = Console.ReadLine();
            Console.WriteLine("Nhap so dien thoai :");
            this.sodienthoai = long.Parse(Console.ReadLine());
        }


        public virtual void Xuat()
        { 
            Console.WriteLine("|{0, -5} |{1, -20} |{2, -5} |{3, -40} |{4, -30} |{5, -15} |",
                                      this.ID, this.hoten, this.gioitinh, this.diachi, this.email, this.sodienthoai);
        }
    }
}

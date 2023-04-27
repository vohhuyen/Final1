using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentHK1
{
    internal class SanPham
    {
        private string ID;
        private string tensp;
        private string motasp;
        private string chatlieusp;
        private double giagoc;
        private double giaban;

        public string id
        {
            set { this.ID = value; }
            get { return this.ID; }
        }
        public String Tensp
        {
            set { this.tensp = value; }
            get { return this.tensp; }
        }

        public string Motasp
        {
            set { this.motasp = value; }
            get { return this.motasp; }
        }
        public string Chatlieusp
        {
            set { this.chatlieusp = value; }
            get { return this.chatlieusp; }
        }
        public double Giagoc
        {
            set { this.giagoc = value; }
            get { return this.giagoc; }
        }
        public double Giaban
        {
            set { this.giaban = value; }
            get { return this.giaban; }
        }
        public SanPham()
        { }
        public SanPham(string ID, string tensp, string motasp,
            string chatlieusp, double giagoc, double giaban)
        {
            this.ID = ID;
            this.tensp = tensp;
            this.motasp = motasp;
            this.chatlieusp = chatlieusp;
            this.giagoc = this.giagoc;
            this.giaban = this.giaban;

        }

        public virtual void Nhap()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("                                                   ========= ADD PRODUCT =========");
            Console.ResetColor();
            Console.Write("                                          | Product ID :");
            this.ID = Console.ReadLine();
            Console.Write("                                          | Product name:");
            this.tensp = Console.ReadLine();
            Console.Write("                                          | Description :");
            this.motasp = Console.ReadLine();
            Console.Write("                                          | Material :");
            this.chatlieusp = Console.ReadLine();
            Console.Write("                                          | Cost :");
            this.giagoc = double.Parse(Console.ReadLine());
            Console.Write("                                          | Price :");
            this.giaban = double.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("                                             ---------------------------------------------");
            Console.ResetColor();
        }


        public virtual void Xuat()
        { /*
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("            ========= PRODUCT =========");
            Console.ResetColor();
            Console.WriteLine(" ------------------------------------------------------------------------------");
            Console.WriteLine("|{0, -15} |{1,-60} |", "ID" , this.ID);
            Console.WriteLine("|----------------|-------------------------------------------------------------|");
            Console.WriteLine("|{0, -15} |{1,-60} |", "Name", this.tensp);
            Console.WriteLine("|----------------|-------------------------------------------------------------|");
            Console.WriteLine("|{0, -15} |{1,-60} |", "Describe", this.motasp);
            Console.WriteLine("|----------------|-------------------------------------------------------------|");
            Console.WriteLine("|{0, -15} |{1,-60} |", "Material", this.chatlieusp);
            Console.WriteLine("|----------------|-------------------------------------------------------------|");
            Console.WriteLine("|{0, -15} |{1,-60} |", "Cost", this.giagoc);
            Console.WriteLine("|----------------|-------------------------------------------------------------|");
            Console.WriteLine("|{0, -15} |{1,-60} |", "Price", this.giaban);
            Console.WriteLine(" ------------------------------------------------------------------------------"); */
              Console.WriteLine("|{0, -5} |{1, -20} |{2, -50} |{3, -30} |{4, -10} |{5, -10} |",
                                        this.ID, this.tensp, this.motasp, this.chatlieusp, this.giagoc, this.giaban); 
           /* Console.WriteLine("|{0, -5} |{1, -20} |{2, -50} |{3, -30} |{4, -10} |{5, -10} |",
                 "ID", "Name", "describe", "material", "cost", "price"); */
        }
    }
}

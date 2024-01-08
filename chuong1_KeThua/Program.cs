using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chuong1_KeThua
{
    class HinhTron
    {
        private double banKinh;



        public HinhTron(): base()
        {
            banKinh = 5;
        }
        public HinhTron (double banKinh)
        {
            this.banKinh = Math.Abs(banKinh);
        }
        public void setBanKinh(double banKinh)
        {
            this.banKinh = banKinh;
        }
        public double getBanKinh()
        {
            return banKinh;
        }
        public double TinhDienTich()
        {
            return Math.PI * banKinh * banKinh;
        }
        public double TinhChuVi()
        {
            return Math.PI * 2 * banKinh;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            HinhTron Htron = new HinhTron();
            Console.WriteLine("Xuat dien Tich : {0}- Xuat Chu Vi : {1}",Htron.TinhDienTich(),Htron.TinhChuVi());
            Hinh_Tru Htru = new Hinh_Tru();
            Console.WriteLine("Xuat dien Tich : {0}- Xuat The Tich : {1}",Htru.TinhDienTich(),Htru.TinhTheTich());
            Console.ReadKey();
        }
    }
}

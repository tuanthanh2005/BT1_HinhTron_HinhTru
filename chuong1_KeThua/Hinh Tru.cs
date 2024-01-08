using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chuong1_KeThua
{
    class Hinh_Tru : HinhTron
    {
        private double chieuCao;


        public Hinh_Tru() : base()
        {
            chieuCao = 6;
        }
        public Hinh_Tru(double chieuCao,double banKinh): base(banKinh)
        {
            this.chieuCao = chieuCao;

        }

        public void setChieuCao(double chieuCao)
        {
            this.chieuCao = chieuCao;
        }
        public double getChieuCao()
        {
            return chieuCao;
        }

        public new double TinhDienTich()
        {
            return 2 * base.TinhDienTich() + TinhChuVi() * chieuCao;
        }
        public double TinhTheTich()
        {
            return base.TinhDienTich() * chieuCao;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class BUS_BH
    {
        DAL_BH dal_bh = new DAL_BH();

        public DataTable dsXuatXu()
        {
            DataTable dt = new DataTable();
            dt = dal_bh.xuatxu();
            return dt;
        }


        public DataTable dsHoaDontheoXuatXu(string xuatxu)
        {
            DataTable dt = new DataTable();
            dt = dal_bh.xuatHoaDon(xuatxu);
            return dt;
        }


        public DataTable dsCTHoaDon(string mahd)
        {
            DataTable dt = new DataTable();
            dt = dal_bh.xuatctdonhang(mahd);
            return dt;
        }


        public int tongtien(string mahd)
        {
            int sum = dal_bh.tongtien(mahd);
            dal_bh.saveToHoaDon(sum, mahd);
            return sum;
        }


        public int layTongtien(string mahd)
        {
            int sum = dal_bh.xuatTongTien(mahd);
            return sum;
        }

        public DataTable dhBanNhieuNhatTheoXuatXu(string xuatxu)
        {
            DataTable dt = new DataTable();
            dt = dal_bh.banNhieuNhatTheoXuatXu(xuatxu);
            return dt;
        }

        public DataTable dhBanItNhatTheoXuatXu(string xuatxu)
        {
            DataTable dt = new DataTable();
            dt = dal_bh.banNhieuItTheoXuatXu(xuatxu);
            return dt;
        }

    }
}

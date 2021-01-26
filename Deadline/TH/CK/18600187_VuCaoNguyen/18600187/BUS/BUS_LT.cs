using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    
    public class BUS_LT
    {
        DAL_LT dal_lt = new DAL_LT();
        public DataTable DanhSachKhoa()
        {
            DataTable dt = new DataTable();
            dt = dal_lt.DanhSachKhoa();
            return dt;
        }

        public DataTable LietKeDanhSachSinhVien(string makhoa, string nh, string hk)
        {
            DataTable dt = new DataTable();
            dt = dal_lt.LietKeDanhSachSinhVien(makhoa, nh, hk);
            return dt;
        }

        public void XoaLichThi1SinhVien(string nk, string hk, string masv, string mahp)
        {
            dal_lt.XoaLichThi1SinhVien(nk, hk, masv, mahp);
        }

    }
}

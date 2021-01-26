using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_LT : DBConnect
    {
        public DataTable LietKeDanhSachSinhVien(string makhoa, string nh, string hk)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();

            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_ThiTatCa";
            cmd.Parameters.Add("@Khoa", SqlDbType.VarChar).Value = makhoa;
            cmd.Parameters.Add("@nh", SqlDbType.VarChar).Value = nh;
            cmd.Parameters.Add("@hk", SqlDbType.VarChar).Value = hk;

            OpenConnection();
            da.SelectCommand = cmd;
            da.Fill(dt);
            CloseConnection();

            return dt;
        }
        
        public void XoaLichThi1SinhVien(string nk, string hk, string masv, string mahp)
        {

        }

        public DataTable DanhSachKhoa()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();

            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select MaKhoa, TenKhoa from KHOA";

            OpenConnection();
            da.SelectCommand = cmd;
            da.Fill(dt);
            CloseConnection();

            return dt;
        }
    }
}
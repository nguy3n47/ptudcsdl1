using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_DKHP : DBConnect
    {
        public DataTable KQ_DKHP_SV(string mssv, string HK)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();

            SqlDataAdapter da = new SqlDataAdapter();

            cmd.Connection = con;

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "kq_DKHP_sv";
            cmd.Parameters.Add("@mssv", SqlDbType.VarChar).Value = mssv;
            cmd.Parameters.Add("@hk", SqlDbType.Int).Value = int.Parse(HK);

            OpenConnection();
            da.SelectCommand = cmd;
            da.Fill(dt);
            CloseConnection();
            return dt;
        }



        public DataTable DKHP_SV(string namHoc, string hocKy, string maSV, string mamh, int soTinhChi, string diaDiem)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();

            SqlDataAdapter da = new SqlDataAdapter();

            cmd.Connection = con;

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "dkhp_sv";
            cmd.Parameters.Add("@nh", SqlDbType.VarChar).Value = namHoc;
            cmd.Parameters.Add("@hk", SqlDbType.Int).Value = int.Parse(hocKy);
            cmd.Parameters.Add("@mssv", SqlDbType.VarChar).Value = maSV;
            cmd.Parameters.Add("@mamh", SqlDbType.VarChar).Value = mamh;
            cmd.Parameters.Add("@sotc", SqlDbType.Int).Value = soTinhChi;
            cmd.Parameters.Add("@diadiem", SqlDbType.NVarChar).Value = diaDiem;

            OpenConnection();
            da.SelectCommand = cmd;
            da.Fill(dt);
            CloseConnection();
            return dt;
        }
    }
}

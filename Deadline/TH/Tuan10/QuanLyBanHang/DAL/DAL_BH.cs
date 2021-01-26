using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_BH : DBConnect
    {
        public DataTable xuatxu()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();

            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from dbo.xuatxu()";

            OpenConnection();
            da.SelectCommand = cmd;
            da.Fill(dt);
            CloseConnection();

            return dt;
        }

        public DataTable xuatHoaDon(string xuatxu)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();

            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select distinct hd.* from HOADON hd join CTHOADON ct on hd.mahd = ct.mahd join HANGHOA hh on ct.mahh = hh.mahh where hh.xuatxu = @xuatxu";
            cmd.Parameters.Add($"@xuatxu", SqlDbType.NVarChar).Value = xuatxu;

            OpenConnection();
            da.SelectCommand = cmd;
            da.Fill(dt);
            CloseConnection();

            return dt;
        }

        public DataTable xuatctdonhang(string madh)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();

            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "lietkehoadon";
            cmd.Parameters.Add("@mahoadon", SqlDbType.VarChar).Value = madh;

            OpenConnection();
            da.SelectCommand = cmd;
            da.Fill(dt);
            CloseConnection();

            return dt;
        }

        public int tongtien(string madh)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();

            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select dbo.tongtienhoadon(@mahd)";
            cmd.Parameters.Add("@mahd", SqlDbType.VarChar).Value = madh;

            OpenConnection();
            int sum = int.Parse(cmd.ExecuteScalar().ToString());
            CloseConnection();
            return sum;
        }

        public void saveToHoaDon(int sum, string mahd)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();

            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "updateTongtien";
            cmd.Parameters.Add("@tong", SqlDbType.Int).Value = sum;
            cmd.Parameters.Add("@mahd", SqlDbType.VarChar).Value = mahd;

            OpenConnection();
            cmd.ExecuteNonQuery();
            CloseConnection();
        }

        public int xuatTongTien(string mahd)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();

            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select tongtien from HOADON where mahd = @mahd";
            cmd.Parameters.Add("@mahd", SqlDbType.VarChar).Value = mahd;

            OpenConnection();
            string t = cmd.ExecuteScalar().ToString();
            OpenConnection();
            if (t == "")
                return 0;
            return int.Parse(t);
        }


        public DataTable banNhieuNhatTheoXuatXu(string xuatxu)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();

            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "hdbannhieunhattheoxuatxu";
            cmd.Parameters.Add("@xuatxu", SqlDbType.NVarChar).Value = xuatxu;


            OpenConnection();
            da.SelectCommand = cmd;
            da.Fill(dt);
            CloseConnection();
            return dt;
        }

        public DataTable banNhieuItTheoXuatXu(string xuatxu)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();

            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "hdbanitnhattheoxuatxu";
            cmd.Parameters.Add("@xuatxu", SqlDbType.NVarChar).Value = xuatxu;


            OpenConnection();
            da.SelectCommand = cmd;
            da.Fill(dt);
            CloseConnection();
            return dt;
        }
    }
}

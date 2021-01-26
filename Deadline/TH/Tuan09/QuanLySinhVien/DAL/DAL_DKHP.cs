using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_DKHP : DBConnect
    {
        public void insertDKHP_sv(DTO_DANGKYHOCPHAN dk)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "insert into DKHP (NH, HK, MaSV, MaMH, SoTC, DiaDiem, Diem) values (@nh, @hk, @masv, @mamh, @sotc, @diadiem, @diem)";

            cmd.Parameters.Add("@nh", SqlDbType.VarChar).Value = dk.NamHoc;
            cmd.Parameters.Add("@hk", SqlDbType.VarChar).Value = dk.HocKy;
            cmd.Parameters.Add("@masv", SqlDbType.VarChar).Value = dk.MaSV;
            cmd.Parameters.Add("@mamh", SqlDbType.VarChar).Value = dk.MaMH;
            cmd.Parameters.Add("@sotc", SqlDbType.Int).Value = dk.SoTinhChi;
            cmd.Parameters.Add("@diadiem", SqlDbType.NVarChar).Value = dk.DiaDiem;
            cmd.Parameters.Add("@diem", SqlDbType.Float).Value = dk.DiemMonHoc;

            OpenConnection();
            cmd.ExecuteNonQuery();
            CloseConnection();
        }



        public void updateDKHP_sv(DTO_DANGKYHOCPHAN dk)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update DKHP set  SoTC = @sotc, DiaDiem = @diadiem, Diem = @diem where NH = @nh and HK = @hk and MaSV = @masv and MaMH = @mamh";

            cmd.Parameters.Add("@nh", SqlDbType.VarChar).Value = dk.NamHoc;
            cmd.Parameters.Add("@hk", SqlDbType.VarChar).Value = dk.HocKy;
            cmd.Parameters.Add("@masv", SqlDbType.VarChar).Value = dk.MaSV;
            cmd.Parameters.Add("@mamh", SqlDbType.VarChar).Value = dk.MaMH;
            cmd.Parameters.Add("@sotc", SqlDbType.Int).Value = dk.SoTinhChi;
            cmd.Parameters.Add("@diadiem", SqlDbType.NVarChar).Value = dk.DiaDiem;
            cmd.Parameters.Add("@diem", SqlDbType.Float).Value = dk.DiemMonHoc;

            OpenConnection();
            cmd.ExecuteNonQuery();
            CloseConnection();
        }

        public DataTable loadDSDKHP(string mssv)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();

            cmd.Connection = con;

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from DKHP where MaSV = '" + mssv + "'";

            OpenConnection();
            da.SelectCommand = cmd;
            da.Fill(dt);
            CloseConnection();
            return dt;
        }

        public void deleteDKHP_sv(string mssv, string mamh)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();

            cmd.Connection = con;

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE from DKHP where MaSV = '" + mssv + "' and MaMH = '" + mamh + "'";
            OpenConnection();
            da.SelectCommand = cmd;
            da.Fill(dt);
            CloseConnection();
        }

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

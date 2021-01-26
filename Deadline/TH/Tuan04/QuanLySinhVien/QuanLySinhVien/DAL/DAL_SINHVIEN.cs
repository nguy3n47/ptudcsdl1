using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_SINHVIEN : DBConnect
    {
        DBConnect dalSV = new DBConnect();
        public DTO_SINHVIEN SelectSV(string maSV)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();

            SqlDataAdapter da = new SqlDataAdapter();

            cmd.Connection = con;

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from SINHVIEN where MaSV = '" + maSV + "'";

            OpenConnection();
            da.SelectCommand = cmd;
            da.Fill(dt);
            CloseConnection();

            DTO_SINHVIEN sv = new DTO_SINHVIEN();

            if(dt.Rows.Count > 0)
            {
                sv.MaSV = dt.Rows[0]["MaSV"].ToString();
                sv.HoTen = dt.Rows[0]["HoTen"].ToString();
                sv.NgaySinh = dt.Rows[0]["NgaySinh"].ToString();
                sv.Phai = dt.Rows[0]["Phai"].ToString();

                float DTB = 0;
                float.TryParse(dt.Rows[0]["DTB"].ToString(), out DTB);
                sv.DiemTrugnBinh = DTB;

                sv.Lop = dt.Rows[0]["Lop"].ToString();
            }
            return sv;
        }

        public List<DTO_SINHVIEN> SelectDSSV(string phai)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();

            SqlDataAdapter da = new SqlDataAdapter();

            cmd.Connection = con;

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from SINHVIEN where Phai = '" + phai + "'";

            OpenConnection();
            da.SelectCommand = cmd;
            da.Fill(dt);
            CloseConnection();

            List<DTO_SINHVIEN> listSV = new List<DTO_SINHVIEN>();
            

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DTO_SINHVIEN sv = new DTO_SINHVIEN();

                    sv.MaSV = dt.Rows[i]["MaSV"].ToString();
                    sv.HoTen = dt.Rows[i]["HoTen"].ToString();
                    sv.NgaySinh = dt.Rows[i]["NgaySinh"].ToString();
                    sv.Phai = dt.Rows[i]["Phai"].ToString();

                    float DTB = 0;
                    float.TryParse(dt.Rows[i]["DTB"].ToString(), out DTB);
                    sv.DiemTrugnBinh = DTB;

                    sv.Lop = dt.Rows[0]["Lop"].ToString();

                    listSV.Add(sv);
                }
            }
            return listSV;
        }

        public void xuatDSLop(string lop)
        {
            DataTable dt = new DataTable();
            string strQuery;
            strQuery = "select* from SINHVIEN where Lop = '" + lop + "'";
            dt = dalSV.loadData(strQuery);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Console.WriteLine($"Mã sinh viên: {dt.Rows[i]["MaSV"]}");
                Console.WriteLine($"Họ tên: {dt.Rows[i]["HoTen"]}");
                Console.WriteLine($"Ngày sinh: {dt.Rows[i]["NgaySinh"]}");
                Console.WriteLine($"Giới tính: {dt.Rows[i]["Phai"]}");
            }    
        }

        public void insertSV(DTO_SINHVIEN sv)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into SINHVIEN (MaSV, HoTen, NgaySinh, Phai, Lop, DTB) values (@maSV, @hoTen, @ngaySinh, @phai, @lop, @dtb)";

            cmd.Parameters.Add("@maSV", SqlDbType.VarChar).Value = sv.MaSV;
            cmd.Parameters.Add("@hoTen", SqlDbType.NVarChar).Value = sv.HoTen;
            cmd.Parameters.Add("@ngaySinh", SqlDbType.DateTime).Value = sv.NgaySinh;
            cmd.Parameters.Add("@phai", SqlDbType.NVarChar).Value = sv.Phai;
            cmd.Parameters.Add("@lop", SqlDbType.VarChar).Value = sv.Lop;
            cmd.Parameters.Add("@dtb", SqlDbType.Float).Value = sv.DiemTrugnBinh;

            OpenConnection();
            cmd.ExecuteNonQuery();
            CloseConnection();
        }

        public void deleteSV(string maSV)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from SINHVIEN where MaSV = @maSV";

            cmd.Parameters.Add("@maSV", SqlDbType.VarChar).Value = maSV;

            OpenConnection();
            cmd.ExecuteNonQuery();
            CloseConnection();
        }

        public void updateSV(DTO_SINHVIEN sv)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "update SINHVIEN set HoTen = @hoTen where MaSV = @maSV update SINHVIEN set NgaySinh = @ngaySinh where MaSV = @maSV update SINHVIEN set Phai = @phai where MaSV = @maSV update SINHVIEN set Lop = @lop where MaSV = @maSV update SINHVIEN set DTB = @dtb where MaSV = @maSV";

            cmd.Parameters.Add("@maSV", SqlDbType.VarChar).Value = sv.MaSV;
            cmd.Parameters.Add("@hoTen", SqlDbType.NVarChar).Value = sv.HoTen;
            cmd.Parameters.Add("@ngaySinh", SqlDbType.DateTime).Value = sv.NgaySinh;
            cmd.Parameters.Add("@phai", SqlDbType.NVarChar).Value = sv.Phai;
            cmd.Parameters.Add("@lop", SqlDbType.VarChar).Value = sv.Lop;
            cmd.Parameters.Add("@dtb", SqlDbType.Float).Value = sv.DiemTrugnBinh;

            OpenConnection();
            cmd.ExecuteNonQuery();
            CloseConnection();
        }

        public float xuatDTB(string maSV)
        {
            float dtb;

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select DTB from SINHVIEN where MaSV = @maSV";

            cmd.Parameters.Add("@maSV", SqlDbType.VarChar).Value = maSV;
            OpenConnection();
            dtb = float.Parse(cmd.ExecuteScalar().ToString());
            return dtb;
        }
    }
}

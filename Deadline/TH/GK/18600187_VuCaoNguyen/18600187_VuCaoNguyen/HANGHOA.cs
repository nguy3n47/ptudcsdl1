using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18600187_VuCaoNguyen
{
    public class HANGHOA : DBConnect
    {
        DBConnect db = new DBConnect();
        public int tinhSoHHN(string nhom, string loai)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select dbo.fc_SoHH(@nhom, @loai)";
            cmd.Parameters.Add("@nhom", SqlDbType.NVarChar).Value = nhom;
            cmd.Parameters.Add("@loai", SqlDbType.NVarChar).Value = loai;
            OpenConnection();
            int count = int.Parse(cmd.ExecuteScalar().ToString());
            CloseConnection();
            return count;
        }

        public DataTable xuatThongTinLoaiHH(string nhom, string loai)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();

            SqlDataAdapter da = new SqlDataAdapter();

            cmd.Connection = con;

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ThongTin";
            cmd.Parameters.Add("@nhom", SqlDbType.VarChar).Value = nhom;
            cmd.Parameters.Add("@loai", SqlDbType.VarChar).Value = loai;
            OpenConnection();
            da.SelectCommand = cmd;
            da.Fill(dt);
            CloseConnection();
            return dt;
        }

        public void OutputTongSoHH()
        {

            Console.Write("Nhập nhóm: ");
            string nhom = Console.ReadLine();
            Console.Write("Nhập loại: ");
            string loai = Console.ReadLine();
            int sum = tinhSoHHN(nhom, loai);
            Console.WriteLine("Tong số hàng hóa: {0}", sum);
        }  
        public void OutputThongTin()
        {
            DataTable TT = new DataTable();
            Console.Write("Nhập nhóm: ");
            string nhom = Console.ReadLine();
            Console.Write("Nhập loại: ");
            string loai = Console.ReadLine();

            TT = xuatThongTinLoaiHH(nhom, loai);
            for (int i = 0; i < TT.Rows.Count; i++)
            {
                Console.WriteLine("Tên nhóm: {0}", TT.Rows[0]["TenNhom"].ToString());
                Console.WriteLine("Tên loại: {0}", TT.Rows[0]["TenLoai"].ToString());
                Console.WriteLine("Sản phẩm đại điện: {0}", TT.Rows[0]["SanPhamDD"].ToString());
                Console.WriteLine("Đơn vị tính: {0}", TT.Rows[0]["DonViTinh"].ToString());
            }
        }
    }
}

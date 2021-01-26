using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmSINHVIEN : Form
    {
        int index = 0;

        string connetionString = @"Server =.\SQLEXPRESS;database=QLSV;Trusted_Connection=True";
        public frmSINHVIEN()
        {
            InitializeComponent();
            phai.DataSource = GetAllPhai().Tables[0];
            phai.ValueMember = "Phai";

            lop.DataSource = GetAllClass().Tables[0];
            lop.ValueMember = "Malop";

        }

        DataSet GetAllPhai()
        {
            DataSet data = new DataSet();

            string query = "Select distinct Phai from SINHVIEN";

            using (SqlConnection connect = new SqlConnection(connetionString))
            {
                connect.Open();
                var adapter = new SqlDataAdapter(query, connect);
                adapter.Fill(data);

                connect.Close();
            }

            return data;
        }

        DataSet GetAllClass()
        {
            DataSet data = new DataSet();

            string query = "Select * from Lop";

            using (SqlConnection connect = new SqlConnection(connetionString))
            {
                connect.Open();
                var adapter = new SqlDataAdapter(query, connect);
                adapter.Fill(data);

                connect.Close();
            }

            return data;
        }

        DataSet GetAllStudent(string malop)
        {
            DataSet data = new DataSet();

            string query = "Select * from SINHVIEN where Lop = @malop";

            using (SqlConnection connect = new SqlConnection(connetionString))
            {
                connect.Open();
                SqlCommand command = new SqlCommand(query, connect);

                command.Parameters.AddWithValue("@malop", malop);
                var adapter = new SqlDataAdapter(query, connect);

                adapter.Fill(data);

                connect.Close();
            }

            return data;
        }



        private void frmSINHVIEN_Load(object sender, EventArgs e)
        {
            string sql = @"select * from SINHVIEN";
            SqlDataAdapter da = new SqlDataAdapter(sql, connetionString);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                masv.Text = dt.Rows[0]["MaSV"].ToString().Trim();
                hoten.Text = dt.Rows[0]["HoTen"].ToString().Trim();
                ngaysinh.Text = dt.Rows[0]["NgaySinh"].ToString().Trim();
                phai.Text = dt.Rows[0]["Phai"].ToString().Trim();
                lop.Text = dt.Rows[0]["Lop"].ToString().Trim();
                diemtb.Text = dt.Rows[0]["DTB"].ToString();
            }
        }

        private void themsv_Click(object sender, EventArgs e)
        {
            DTO_SINHVIEN sv = new DTO_SINHVIEN();
            sv.MaSV = masv.Text;
            sv.HoTen = hoten.Text;
            sv.NgaySinh = ngaysinh.Value.Date.ToString();
            sv.Phai = phai.Text;
            sv.Lop = lop.Text;
            sv.DiemTrugnBinh = float.Parse(diemtb.Text);
            DAL_SINHVIEN dal_sv = new DAL_SINHVIEN();
            dal_sv.insertSV(sv);
            MessageBox.Show("Bạn đã thêm thành công ^^");
        }

        private void xoasv_Click(object sender, EventArgs e)
        {
            DataSet data = new DataSet();

            string masvv = masv.Text.Trim();

            DAL_SINHVIEN sv = new DAL_SINHVIEN();
            sv.deleteSV(masvv);
            frmSINHVIEN_Load(sender, e);
        }

        private void suasv_Click(object sender, EventArgs e)
        {
            DTO_SINHVIEN sv = new DTO_SINHVIEN();
            sv.MaSV = masv.Text;
            sv.HoTen = hoten.Text;
            sv.NgaySinh = ngaysinh.Value.Date.ToString();
            sv.Phai = phai.Text;
            sv.Lop = lop.Text;
            sv.DiemTrugnBinh = float.Parse(diemtb.Text);


            string sql = @"select * from SINHVIEN";
            SqlDataAdapter da = new SqlDataAdapter(sql, connetionString);
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            string masvDel = dt.Rows[index]["MaSV"].ToString().Trim();

            DAL_SINHVIEN dal_sv = new DAL_SINHVIEN();
            dal_sv.updateSV(sv);
            frmSINHVIEN_Load(sender, e);
        }

        private void prev_Click(object sender, EventArgs e)
        {
            string sql = @"select * from SINHVIEN";
            SqlDataAdapter da = new SqlDataAdapter(sql, connetionString);
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            if (index > 0)
            {
                index--;
                masv.Text = dt.Rows[index]["MaSV"].ToString().Trim();
                hoten.Text = dt.Rows[index]["HoTen"].ToString().Trim();
                ngaysinh.Text = dt.Rows[index]["NgaySinh"].ToString().Trim();
                phai.Text = dt.Rows[index]["Phai"].ToString().Trim();
                lop.Text = dt.Rows[index]["Lop"].ToString().Trim();
                diemtb.Text = dt.Rows[index]["DTB"].ToString();
            }
            else
                MessageBox.Show("Đã đến Sinh Viên đầu tiên!");
        }

        private void next_Click(object sender, EventArgs e)
        {
            string sql = @"select * from SINHVIEN";
            SqlDataAdapter da = new SqlDataAdapter(sql, connetionString);
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            if (index < dt.Rows.Count - 1)
            {
                index++;
                masv.Text = dt.Rows[index]["MaSV"].ToString().Trim();
                hoten.Text = dt.Rows[index]["HoTen"].ToString().Trim();
                ngaysinh.Text = dt.Rows[index]["NgaySinh"].ToString().Trim();
                phai.Text = dt.Rows[index]["Phai"].ToString().Trim();
                lop.Text = dt.Rows[index]["Lop"].ToString().Trim();
                diemtb.Text = dt.Rows[index]["DTB"].ToString();
            }
            else
                MessageBox.Show("Đây là Sinh Viên cuối cùng !");
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

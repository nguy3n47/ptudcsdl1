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
using DTO;
using DAL;
using BUS;
using System.Data.Common;
using System.Windows.Documents;

namespace GUI
{
    public partial class Form1 : Form
    {
        int index = 1;

        string connetionString = @"Data Source=ADMIN;Initial Catalog=_QLSV;Integrated Security=True";
        public Form1()
        {

            InitializeComponent();
            cbClass.DataSource = GetAllLopHoc().Tables[0];
            cbClass.ValueMember = "MaLop";

            cbPhai.DataSource = GetAllPhai().Tables[0];
            cbPhai.ValueMember = "Phai";

        }
        DataSet GetAllLopHoc()
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

        DataSet GetAllSinhVien(string malop)
        {
            DataSet data = new DataSet();
            string query = "Select * from SINHVIEN where Lop = @malop";
            using (SqlConnection connect = new SqlConnection(connetionString))
            {
                connect.Open();

                SqlCommand command = new SqlCommand(query, connect);
                command.Parameters.AddWithValue("@malop", malop);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data);

                connect.Close();
            }

            return data;
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DTO_SINHVIEN a = new DTO_SINHVIEN();
            a.MaSV = txtMSSV.Text;
            a.HoTen = txtName.Text;
            a.NgaySinh = dateTimePicker1.Value.Date.ToString();
            a.Phai = cbPhai.Text;
            a.Lop = cbClass.Text;
            a.DiemTrugnBinh = float.Parse(txtDTB.Text);
            DAL_SINHVIEN dal = new DAL_SINHVIEN();
            dal.insertSV(a);
            MessageBox.Show("Bạn đã thêm thành công ^^");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            DAL_SINHVIEN dal = new DAL_SINHVIEN();
            dal.deleteSV(txtMSSV.Text);
            MessageBox.Show("Bạn đã xoá thành công SV ^^");
            txtMSSV.Text = "";
            txtName.Text = "";
            dateTimePicker1.Text = "";
            cbPhai.Text = "";
            cbClass.Text = "";
            txtDTB.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string sql = @"select * from SINHVIEN where Lop = '" + cbClass.Text.Trim() + "' ";
            SqlDataAdapter da = new SqlDataAdapter(sql, connetionString);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                txtMSSV.Text = dt.Rows[0]["MaSV"].ToString().Trim();
                txtName.Text = dt.Rows[0]["HoTen"].ToString().Trim();
                dateTimePicker1.Text = dt.Rows[0]["NgaySinh"].ToString().Trim();
                cbPhai.Text = dt.Rows[0]["Phai"].ToString().Trim();
                cbClass.Text = dt.Rows[0]["Lop"].ToString().Trim();
                txtDTB.Text = dt.Rows[0]["DTB"].ToString();
            }
        }

        private void cbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbClass.SelectedIndex == -1)
            {
                return;
            }

            string lhid = cbClass.SelectedValue as string;

            SqlConnection connect = new SqlConnection(connetionString);
            if (connect.State == ConnectionState.Closed)
            {
                connect.Open();
            }
            var command = new SqlCommand();
            command.CommandText = string.Format($"select * from SINHVIEN where Lop = '{lhid}'");
            command.Connection = connect;

            var reader = command.ExecuteReader();

            var dths = new DataTable();
            for (int i = 0; i < reader.FieldCount; i++)
            {
                var dc = new DataColumn(reader.GetName(i), reader.GetFieldType(i));
                dths.Columns.Add(dc);
            }
            while (reader.Read())
            {
                var dr = dths.NewRow();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    dr[i] = reader.GetValue(i);
                }
                dths.Rows.Add(dr);
            }
            connect.Close();
            Form1_Load(sender, e);
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            DTO_SINHVIEN a = new DTO_SINHVIEN();
            a.MaSV = txtMSSV.Text;
            a.HoTen = txtName.Text;
            a.NgaySinh = dateTimePicker1.Value.Date.ToString();
            a.Phai = cbPhai.Text;
            a.Lop = cbClass.Text;
            a.DiemTrugnBinh = float.Parse(txtDTB.Text);
            DAL_SINHVIEN dal = new DAL_SINHVIEN();
            dal.updateSV(a);
            MessageBox.Show("Bạn đã update thành công ^^");
        }
        
        private void btNext_Click(object sender, EventArgs e)
        {
            string sql = @"select * from SINHVIEN where Lop = '" + cbClass.Text.Trim() + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, connetionString);
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            if (index < dt.Rows.Count-1)
            {
                index++;
                txtMSSV.Text = dt.Rows[index]["MaSV"].ToString().Trim();
                txtName.Text = dt.Rows[index]["HoTen"].ToString().Trim();
                dateTimePicker1.Text = dt.Rows[index]["NgaySinh"].ToString().Trim();
                cbPhai.Text = dt.Rows[index]["Phai"].ToString().Trim();
                cbClass.Text = dt.Rows[index]["Lop"].ToString().Trim();
                txtDTB.Text = dt.Rows[index]["DTB"].ToString();
            }
            else
                MessageBox.Show("Đây là Sinh Viên cuối cùng !");
        }

        private void btPrev_Click(object sender, EventArgs e)
        {
            string sql = @"select * from SINHVIEN where Lop = '" + cbClass.Text.Trim() + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, connetionString);
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            if (index >0)
            {
                index--;
                txtMSSV.Text = dt.Rows[index]["MaSV"].ToString().Trim();
                txtName.Text = dt.Rows[index]["HoTen"].ToString().Trim();
                dateTimePicker1.Text = dt.Rows[index]["NgaySinh"].ToString().Trim();
                cbPhai.Text = dt.Rows[index]["Phai"].ToString().Trim();
                cbClass.Text = dt.Rows[index]["Lop"].ToString().Trim();
                txtDTB.Text = dt.Rows[index]["DTB"].ToString();
            }
            else
                MessageBox.Show("Đã đến Sinh Viên đầu tiên!");
        }

    }
}

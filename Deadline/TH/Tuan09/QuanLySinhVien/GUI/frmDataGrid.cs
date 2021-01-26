using BUS;
using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmDataGrid : Form
    {
        public frmDataGrid()
        {
            InitializeComponent();
        }

        DAL_SINHVIEN dal_sv = new DAL_SINHVIEN();
        DataTable dt1 = new DataTable();

        private void frmDataGrid_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            dt = dal_sv.loadDSLop();
            cboLop.DataSource = dt;
            cboLop.DisplayMember = "malop";
            cboLop.ValueMember = "malop";

            initGrid(cboLop.SelectedValue.ToString());
        }

        public void initGrid(string lop)
        {
            dssv.Columns.Clear();

            DataGridViewColumn col1 = new DataGridViewCheckBoxColumn();
            col1.Name = "chon";
            col1.HeaderText = "Chọn";
            col1.Width = 70;
            dssv.Columns.Add(col1);


            DataGridViewColumn col2 = new DataGridViewTextBoxColumn();
            col2.Name = "masv";
            col2.HeaderText = "Mã SV";
            col2.Width = 100;
            dssv.Columns.Add(col2);


            DataGridViewColumn col3 = new DataGridViewTextBoxColumn();
            col3.Name = "hoten";
            col3.HeaderText = "Họ Tên";
            col3.Width = 150;
            dssv.Columns.Add(col3);


            DataGridViewColumn col4 = new DataGridViewTextBoxColumn();
            col4.Name = "ngaysinh";
            col4.HeaderText = "Ngày Sinh";
            col4.Width = 120;
            dssv.Columns.Add(col4);


            DataGridViewComboBoxColumn col5 = new DataGridViewComboBoxColumn();
            col5.Name = "phai";
            col5.HeaderText = "Phái";
            col5.Width = 70;
            col5.Items.Add("Nam");
            col5.Items.Add("Nữ");
            dssv.Columns.Add(col5);


            DataGridViewComboBoxColumn col6 = new DataGridViewComboBoxColumn();
            col6.Name = "lop";
            col6.HeaderText = "Lớp";
            col6.Width = 100;
            col6.DataSource = dal_sv.loadDSLop();
            col6.DisplayMember = "malop";
            col6.ValueMember = "malop";
            dssv.Columns.Add(col6);


            DataGridViewColumn col7 = new DataGridViewTextBoxColumn();
            col7.Name = "diemtb";
            col7.HeaderText = "Điểm TB";
            col7.Width = 70;
            dssv.Columns.Add(col7);

            DataGridViewColumn col8 = new DataGridViewTextBoxColumn();
            col8.Name = "an";
            col8.HeaderText = "an";
            col8.Visible = false;
            dssv.Columns.Add(col8);

            dt1 = dal_sv.loadDSSV(cboLop.Text);

            for (int i = 0; i < dt1.Rows.Count; i++) {
                dssv.Rows.Add(false, dt1.Rows[i]["masv"].ToString(), dt1.Rows[i]["hoten"].ToString(),
                                DateTime.Parse(dt1.Rows[i]["ngaysinh"].ToString()).ToString("dd/mm/yyyy"),
                                dt1.Rows[i]["phai"].ToString(), dt1.Rows[i]["lop"].ToString(), float.Parse(dt1.Rows[i]["dtb"].ToString())
                                , "");
            }
        }

        private void Them_Click(object sender, EventArgs e)
        {
            dssv.Rows.Add(true, "", "", "", "", "", "", "them");
        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            initGrid(cboLop.SelectedValue.ToString());
        }

        private void capnhatsinhvien_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow r in dssv.Rows)
            {
                if((bool)r.Cells["chon"].Value == true && (string)r.Cells["an"].Value.ToString() == "them")
                {
                    DTO_SINHVIEN sv = new DTO_SINHVIEN();
                    sv.MaSV = r.Cells["masv"].Value.ToString();
                    sv.HoTen = r.Cells["hoten"].Value.ToString();
                    sv.NgaySinh = r.Cells["ngaysinh"].Value.ToString();
                    sv.Phai = r.Cells["phai"].Value.ToString();
                    sv.Lop = r.Cells["lop"].Value.ToString();


                    if(r.Cells["diemtb"].Value.ToString() != "")
                        sv.DiemTrugnBinh = float.Parse(r.Cells["diemtb"].Value.ToString());
                    dal_sv.insertSV(sv);
                    MessageBox.Show("Thêm thành công");
                }
                else if((bool)r.Cells["chon"].Value == true)
                {
                    DTO_SINHVIEN sv = new DTO_SINHVIEN();
                    sv.MaSV = r.Cells["masv"].Value.ToString();
                    sv.HoTen = r.Cells["hoten"].Value.ToString();
                    sv.NgaySinh = r.Cells["ngaysinh"].Value.ToString();
                    sv.Phai = r.Cells["phai"].Value.ToString();
                    sv.Lop = r.Cells["lop"].Value.ToString();


                    if (r.Cells["diemtb"].Value.ToString() != "")
                        sv.DiemTrugnBinh = float.Parse(r.Cells["diemtb"].Value.ToString());
                    dal_sv.updateSV(sv);
                    MessageBox.Show("cập nhật thành công");
                }
            }


            dt1 = dal_sv.loadDSSV(cboLop.SelectedValue.ToString());
            initGrid(cboLop.SelectedValue.ToString());
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dssv.Rows)
            {
                if ((bool)r.Cells["chon"].Value == true)
                {
                    dal_sv.deleteSV(r.Cells["masv"].Value.ToString());
                }
            }


            dt1 = dal_sv.loadDSSV(cboLop.SelectedValue.ToString());
            initGrid(cboLop.SelectedValue.ToString());
        }
    }
}

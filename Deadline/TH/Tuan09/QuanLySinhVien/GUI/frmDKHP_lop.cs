using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DAL;
using DTO;

namespace GUI
{
    public partial class frmDKHP_lop : Form
    {
        public frmDKHP_lop()
        {
            InitializeComponent();
        }

        BUS_SINHVIEN bsv = new BUS_SINHVIEN();
        DAL_DKHP dal_dkhp = new DAL_DKHP();
        private void frmDKHP_lop_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = bsv.DSLop();
            initGridlop(dt);
        }



        public void initGridlop(DataTable dt)
        {
            listLop.FullRowSelect = true;
            listLop.View = View.Details;

            listLop.Columns.Add("Mã lớp", 90);
            listLop.Columns.Add("Khóa", 50);
            listLop.Columns.Add("Loại", 50);


            for(int i = 0;i<dt.Rows.Count; i++)
            {
                ListViewItem t = new ListViewItem(dt.Rows[i]["malop"].ToString());
                t.SubItems.Add(dt.Rows[i]["khoa"].ToString());
                t.SubItems.Add(dt.Rows[i]["loai"].ToString());
                t.UseItemStyleForSubItems = true;

                listLop.Items.Add(t);
            }
        }



        public void initGridsv(string lop)
        {
            listSV.Columns.Clear();

            DataGridViewColumn col1 = new DataGridViewCheckBoxColumn();
            col1.Name = "chon";
            col1.HeaderText = "Chọn";
            col1.Width = 70;
            listSV.Columns.Add(col1);


            DataGridViewColumn col2 = new DataGridViewTextBoxColumn();
            col2.Name = "masv";
            col2.HeaderText = "Mã SV";
            col2.Width = 100;
            listSV.Columns.Add(col2);


            DataGridViewColumn col3 = new DataGridViewTextBoxColumn();
            col3.Name = "hoten";
            col3.HeaderText = "Họ Tên";
            col3.Width = 100;
            listSV.Columns.Add(col3);


            DataGridViewColumn col4 = new DataGridViewTextBoxColumn();
            col4.Name = "ngaysinh";
            col4.HeaderText = "Ngày Sinh";
            col4.Width = 70;
            listSV.Columns.Add(col4);


            DataGridViewColumn col5 = new DataGridViewTextBoxColumn();
            col5.Name = "phai";
            col5.HeaderText = "Phái";
            col5.Width = 70;
            listSV.Columns.Add(col5);


            DataGridViewColumn col6 = new DataGridViewTextBoxColumn();
            col6.Name = "lop";
            col6.HeaderText = "Lớp";
            col6.Width = 70;
            listSV.Columns.Add(col6);


            DataGridViewColumn col7 = new DataGridViewTextBoxColumn();
            col7.Name = "diemtb";
            col7.HeaderText = "Điểm TB";
            col7.Width = 70;
            listSV.Columns.Add(col7);


            DataTable dt1 = new DataTable();

            dt1 = bsv.DSSV(lop);

            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                listSV.Rows.Add(false, dt1.Rows[i]["masv"].ToString(), dt1.Rows[i]["hoten"].ToString(),
                                DateTime.Parse(dt1.Rows[i]["ngaysinh"].ToString()).ToString("dd/mm/yyyy"),
                                dt1.Rows[i]["phai"].ToString(), dt1.Rows[i]["lop"].ToString(), float.Parse(dt1.Rows[i]["dtb"].ToString()));
            }
        }

        private void listLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listLop.SelectedItems.Count == 0)
                return;

            initGridsv(listLop.SelectedItems[0].Text);
        }

        string nh, hk, masv;
        public void initGriddkhp(string masv)
        {
            listDKHP.Columns.Clear();

            DataGridViewColumn col1 = new DataGridViewCheckBoxColumn();
            col1.Name = "chon";
            col1.HeaderText = "Chọn";
            col1.Width = 70;
            listDKHP.Columns.Add(col1);


            DataGridViewColumn col2 = new DataGridViewTextBoxColumn();
            col2.Name = "namhoc";
            col2.HeaderText = "Năm học";
            col2.Width = 70;
            listDKHP.Columns.Add(col2);


            DataGridViewColumn col3 = new DataGridViewTextBoxColumn();
            col3.Name = "hk";
            col3.HeaderText = "Học kỳ";
            col3.Width = 50;
            listDKHP.Columns.Add(col3);


            DataGridViewColumn col4 = new DataGridViewTextBoxColumn();
            col4.Name = "masv";
            col4.HeaderText = "Mã SV";
            col4.Width = 100;
            listDKHP.Columns.Add(col4);


            DataGridViewColumn col5 = new DataGridViewTextBoxColumn();
            col5.Name = "mamh";
            col5.HeaderText = "Mã môn học";
            col5.Width = 100;
            listDKHP.Columns.Add(col5);


            DataGridViewColumn col6 = new DataGridViewTextBoxColumn();
            col6.Name = "sotc";
            col6.HeaderText = "Số TC";
            col6.Width = 50;
            listDKHP.Columns.Add(col6);

            DataGridViewComboBoxColumn col7 = new DataGridViewComboBoxColumn();
            col7.Name = "diadiem";
            col7.HeaderText = "Địa Điểm";
            col7.Width = 70;
            col7.Items.Add("LT");
            col7.Items.Add("NVC");
            listDKHP.Columns.Add(col7);


            DataGridViewColumn col8 = new DataGridViewTextBoxColumn();
            col8.Name = "diem";
            col8.HeaderText = "Điểm";
            col8.Width = 70;
            listDKHP.Columns.Add(col8);


            DataGridViewColumn col9 = new DataGridViewTextBoxColumn();
            col9.Name = "an";
            col9.HeaderText = "an";
            col9.Visible = false;
            listDKHP.Columns.Add(col9);

            DataTable dt1 = new DataTable();
            DAL_DKHP dal_dkhp = new DAL_DKHP();

            dt1 = dal_dkhp.loadDSDKHP(masv);

            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                nh = dt1.Rows[i]["nh"].ToString();
                hk = dt1.Rows[i]["hk"].ToString();
                listDKHP.Rows.Add(false, dt1.Rows[i]["nh"].ToString(), dt1.Rows[i]["hk"].ToString(),
                                dt1.Rows[i]["masv"].ToString(), dt1.Rows[i]["mamh"].ToString(),
                                float.Parse(dt1.Rows[i]["sotc"].ToString()), dt1.Rows[i]["diadiem"].ToString(),
                                float.Parse(dt1.Rows[i]["diem"].ToString()), "");
            }
        }

        private void listSV_SelectionChanged(object sender, EventArgs e)
        {
            masv = listSV.Rows[listSV.CurrentCell.RowIndex].Cells["masv"].Value.ToString();
            initGriddkhp(masv);
        }

        private void them_Click(object sender, EventArgs e)
        {
            listDKHP.Rows.Add(true, nh, hk, masv, "", "", "", "", "them");
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in listDKHP.Rows)
            {
                if ((bool)r.Cells["chon"].Value == true)
                {
                    dal_dkhp.deleteDKHP_sv(r.Cells["masv"].Value.ToString(), r.Cells["mamh"].Value.ToString());
                }
            }
            //string masv = listSV.Rows[listSV.CurrentCell.RowIndex].Cells["masv"].Value.ToString();
            initGriddkhp(masv);
        }


        private void capnhat_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in listDKHP.Rows)
            {
                if ((bool)r.Cells["chon"].Value == true && r.Cells["an"].Value.ToString() == "them")
                {
                    DTO_DANGKYHOCPHAN dk = new DTO_DANGKYHOCPHAN();
                    dk.NamHoc = r.Cells["namhoc"].Value.ToString();
                    dk.HocKy = r.Cells["hk"].Value.ToString();
                    dk.MaSV = r.Cells["masv"].Value.ToString();
                    dk.MaMH = r.Cells["mamh"].Value.ToString();
                    dk.SoTinhChi = int.Parse(r.Cells["sotc"].Value.ToString());
                    dk.DiaDiem = r.Cells["diadiem"].Value.ToString();
                    dk.DiemMonHoc = float.Parse(r.Cells["diem"].Value.ToString());
                    dal_dkhp.insertDKHP_sv(dk);
                    //if (dal_dkhp.insertDKHP_sv(dk))
                    //    MessageBox.Show("Thêm thành công ^^");
                    //else
                    //    MessageBox.Show("Thêm thất bại :((");
                }
                else if ((bool)r.Cells["chon"].Value == true)
                {
                    DTO_DANGKYHOCPHAN dk = new DTO_DANGKYHOCPHAN();
                    dk.NamHoc = r.Cells["namhoc"].Value.ToString();
                    dk.HocKy = r.Cells["hk"].Value.ToString();
                    dk.MaSV = r.Cells["masv"].Value.ToString();
                    dk.MaMH = r.Cells["mamh"].Value.ToString();
                    dk.SoTinhChi = int.Parse(r.Cells["sotc"].Value.ToString());
                    dk.DiaDiem = r.Cells["diadiem"].Value.ToString();
                    dk.DiemMonHoc = float.Parse(r.Cells["diem"].Value.ToString());
                    dal_dkhp.updateDKHP_sv(dk);
                    //if (dal_dkhp.updateDKHP_sv(dk))
                    //    MessageBox.Show("Thêm thành công ^^");
                    //else
                    //    MessageBox.Show("Thêm thất bại :((");
                }
            }
            initGriddkhp(masv);
        }



        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

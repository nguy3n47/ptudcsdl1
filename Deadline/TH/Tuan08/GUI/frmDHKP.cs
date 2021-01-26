using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DTO;

namespace GUI
{
    public partial class frmDHKP : Form
    {
        public frmDHKP()
        {
            InitializeComponent();
        }
        DAL_DKHP dal_dkhp = new DAL_DKHP();
        DAL_SINHVIEN dal_sv = new DAL_SINHVIEN();
        DataTable dt = new DataTable();

        private void frmDHKP_Load(object sender, EventArgs e)
        {
            dt = dal_sv.loadAllDSSV();

            dssv.DataSource = dt;
            dssv.DisplayMember = "masv";
            dssv.ValueMember = "masv";

            initGrid(dssv.SelectedValue.ToString());
        }


        public void initGrid(string masv)
        {
            dsdkhp.Columns.Clear();

            DataGridViewColumn col1 = new DataGridViewCheckBoxColumn();
            col1.Name = "chon";
            col1.HeaderText = "Chọn";
            col1.Width = 70;
            dsdkhp.Columns.Add(col1);


            DataGridViewColumn col2 = new DataGridViewTextBoxColumn();
            col2.Name = "namhoc";
            col2.HeaderText = "Năm học";
            col2.Width = 100;
            dsdkhp.Columns.Add(col2);


            DataGridViewColumn col3 = new DataGridViewTextBoxColumn();
            col3.Name = "hk";
            col3.HeaderText = "Học kỳ";
            col3.Width = 50;
            dsdkhp.Columns.Add(col3);


            DataGridViewColumn col4 = new DataGridViewTextBoxColumn();
            col4.Name = "masv";
            col4.HeaderText = "Mã SV";
            col4.Width = 120;
            dsdkhp.Columns.Add(col4);


            DataGridViewColumn col5 = new DataGridViewTextBoxColumn();
            col5.Name = "mamh";
            col5.HeaderText = "Mã môn học";
            col5.Width = 130;
            dsdkhp.Columns.Add(col5);


            DataGridViewColumn col6 = new DataGridViewTextBoxColumn();
            col6.Name = "sotc";
            col6.HeaderText = "Số TC";
            col6.Width = 100;
            dsdkhp.Columns.Add(col6);

            DataGridViewComboBoxColumn col7 = new DataGridViewComboBoxColumn();
            col7.Name = "diadiem";
            col7.HeaderText = "Địa Điểm";
            col7.Width = 80;
            col7.Items.Add("LT");
            col7.Items.Add("NVC");
            dsdkhp.Columns.Add(col7);


            DataGridViewColumn col8 = new DataGridViewTextBoxColumn();
            col8.Name = "diem";
            col8.HeaderText = "Điểm";
            col8.Width = 70;
            dsdkhp.Columns.Add(col8);


            DataGridViewColumn col9 = new DataGridViewTextBoxColumn();
            col9.Name = "an";
            col9.HeaderText = "an";
            col9.Visible = false;
            dsdkhp.Columns.Add(col9);

            dt = dal_dkhp.loadDSDKHP(dssv.Text);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dsdkhp.Rows.Add(false, dt.Rows[i]["nh"].ToString(), dt.Rows[i]["hk"].ToString(),
                                dt.Rows[i]["masv"].ToString(),dt.Rows[i]["mamh"].ToString(),
                               (dt.Rows[i]["sotc"].ToString()), dt.Rows[i]["diadiem"].ToString(), 
                              (dt.Rows[i]["diem"].ToString()) , "");
            }
        }

        private void dssv_SelectedIndexChanged(object sender, EventArgs e)
        {
            initGrid(dssv.SelectedValue.ToString());
        }

        private void them_Click(object sender, EventArgs e)
        {
            dsdkhp.Rows.Add(true, "", "", dssv.SelectedValue.ToString(), "", "", "", "", "them");
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow r in dsdkhp.Rows)
            {
                if((bool)r.Cells["chon"].Value == true)
                {
                    dal_dkhp.deleteDKHP_sv(r.Cells["masv"].Value.ToString(), r.Cells["mamh"].Value.ToString());
                }
            }
            dt = dal_dkhp.loadDSDKHP(dssv.SelectedValue.ToString());
            initGrid(dssv.SelectedValue.ToString());
        }

        private void capnhat_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dsdkhp.Rows)
            {
                if ((bool)r.Cells["chon"].Value == true && (string)r.Cells["an"].Value.ToString() == "them")
                {
                    DTO_DANGKYHOCPHAN dk = new DTO_DANGKYHOCPHAN();
                    dk.NamHoc = r.Cells["namhoc"].Value.ToString();
                    dk.HocKy = r.Cells["hk"].Value.ToString();
                    dk.MaSV = r.Cells["masv"].Value.ToString();
                    dk.MaMH = r.Cells["mamh"].Value.ToString();
                    dk.SoTinhChi = int.Parse(r.Cells["sotc"].Value.ToString());
                    dk.DiaDiem = r.Cells["diadiem"].Value.ToString();
                    dk.DiemMonHoc = float.Parse(r.Cells["diem"].Value.ToString());
                    if (dal_dkhp.insert(dk))
                        MessageBox.Show("Thêm thành công ^^");
                    else
                        MessageBox.Show("Thêm thất bại :((");
                }
                else if ((bool)r.Cells["chon"].Value == true)
                {
                    DTO_DANGKYHOCPHAN dk = new DTO_DANGKYHOCPHAN();
                    dk.NamHoc = r.Cells["nh"].Value.ToString();
                    dk.HocKy = r.Cells["hk"].Value.ToString();
                    dk.MaSV = r.Cells["masv"].Value.ToString();
                    dk.MaMH = r.Cells["mamh"].Value.ToString();
                    dk.SoTinhChi = int.Parse(r.Cells["sotc"].Value.ToString());
                    dk.DiaDiem = r.Cells["diadiem"].Value.ToString();
                    dk.DiemMonHoc = float.Parse(r.Cells["diem"].Value.ToString());
                    if (dal_dkhp.update(dk))
                        MessageBox.Show("Cập nhật thành công ^^");
                    else
                        MessageBox.Show("Cập nhật không thành công :(((");
                }
            }
            dt = dal_dkhp.loadDSDKHP(dssv.SelectedValue.ToString());
            initGrid(dssv.SelectedValue.ToString());
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

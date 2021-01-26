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

namespace GUI
{
    public partial class frmBanHang : Form
    {
        public frmBanHang()
        {
            InitializeComponent();
            lblxuatxu.DisplayMember = "xuatxu";
            lblxuatxu.ValueMember = "xuatxu";
            lblxuatxu.DataSource = initComboboxXuatXu();

        }

        BUS_BH busbh = new BUS_BH();
        DAL_BH dalbh = new DAL_BH();

        public DataTable initComboboxXuatXu()
        {
            DataTable dt = new DataTable();
            dt = busbh.dsXuatXu();
            return dt;

        }

        private void lblxuatxu_SelectedIndexChanged(object sender, EventArgs e)
        {
            tongtien.Text = "0";
            lblmahoadon.SelectedIndex = 0;
            gridHoadon(this.lblxuatxu.SelectedValue.ToString());
        }

        DataTable dt1 = new DataTable();
        public void gridHoadon(string xuatxu)
        {
            dt1 = busbh.dsHoaDontheoXuatXu(xuatxu);
            gridhoadon.DataSource = dt1;
        }

        private void gridhoadon_SelectionChanged(object sender, EventArgs e)
        {
            if(dt1.Rows.Count == 0)
            {
                gridcthoadon.DataSource = null;
                return;
            }
            string mahd = gridhoadon.Rows[gridhoadon.CurrentCell.RowIndex].Cells["mahd"].Value.ToString();
            XuatTongTien(mahd);
            gridChiTietHoaDon(mahd);
        }


        public void gridChiTietHoaDon(string mahd)
        {
            DataTable dt = new DataTable();
            dt = busbh.dsCTHoaDon(mahd);
            gridcthoadon.DataSource = dt;
        }

        private void tinhtien_Click(object sender, EventArgs e)
        {
            if(dt1.Rows.Count != 0)
            {
                string mahd = gridhoadon.Rows[gridhoadon.CurrentCell.RowIndex].Cells["mahd"].Value.ToString();
                int sum = busbh.tongtien(mahd);
                tongtien.Text = sum.ToString();
                lblxuatxu_SelectedIndexChanged(sender, e);
            }
        }

        private void XuatTongTien(string mahd)
        {
            tongtien.Text = busbh.layTongtien(mahd).ToString();
        }


        private void thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblmahoadon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dt1.Rows.Count == 0)
            {
                gridcthoadon.DataSource = null;
                return;
            }

            string temp = this.lblmahoadon.SelectedIndex.ToString();
            if(int.Parse(temp) == 0)
            {
                dt1 = busbh.dsHoaDontheoXuatXu(this.lblxuatxu.SelectedValue.ToString());
                gridhoadon.DataSource = dt1;
            }
            else if(int.Parse(temp) == 1)
            {
                dt1 = busbh.dhBanNhieuNhatTheoXuatXu(this.lblxuatxu.SelectedValue.ToString());
                gridhoadon.DataSource = dt1;
            }
            else
            {
                dt1 = busbh.dhBanItNhatTheoXuatXu(this.lblxuatxu.SelectedValue.ToString());
                gridhoadon.DataSource = dt1;
            }
        }
    }
}

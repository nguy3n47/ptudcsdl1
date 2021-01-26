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
using BUS;

namespace GUI
{
    public partial class frmLichThi : Form
    {
        public frmLichThi()
        {
            InitializeComponent();
            cboxKhoa.DataSource = initComboboxKhoa();
            cboxHK.DataSource = initComboboxHocKy();
            cboxNH.DataSource = initComboboxNamHoc();
        }
        BUS_LT buslt = new BUS_LT();
        DAL_LT dallt = new DAL_LT();
        private void buttonOK_Click(object sender, EventArgs e)
        {

        }

        public DataTable initComboboxKhoa()
        {
            DataTable dt = new DataTable();
            dt = buslt.DanhSachKhoa();
            return dt;
        }

        public DataTable initComboboxNamHoc()
        {
            DataTable dt = new DataTable();
            //dt = buslt.dsNamHoc();
            return dt;

        }

        public DataTable initComboboxHocKy()
        {
            DataTable dt = new DataTable();
            //dt = buslt.dsHocKy();
            return dt;

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {

        }

        private void dgvSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

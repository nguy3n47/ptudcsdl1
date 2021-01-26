using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_DANGKYHOCPHAN
    {
        private string _namHoc;
        private string _hocKy;
        private string _maSV;
        private int _soTinhChi;
        private string _diaDiem;
        private float _diemMonHoc;

        public DTO_DANGKYHOCPHAN()
        {
            this._namHoc = "";
            this._hocKy = "";
            this._maSV = "";
            this._soTinhChi = 0;
            this._diaDiem = "";
            this._diemMonHoc = 0;
        }

        public DTO_DANGKYHOCPHAN(string namHoc, string hocKy, string maSV, int soTinhChi, string diaDiem, float diemMonHoc)
        {
            this._namHoc = namHoc;
            this._hocKy = hocKy;
            this._maSV = maSV;
            this._soTinhChi = soTinhChi;
            this._diaDiem = diaDiem;
            this._diemMonHoc = diemMonHoc;
        }

        public DTO_DANGKYHOCPHAN(DTO_DANGKYHOCPHAN dk)
        {
            this._namHoc = dk._namHoc;
            this._hocKy = dk._hocKy;
            this._maSV = dk._maSV;
            this._soTinhChi = dk._soTinhChi;
            this._diaDiem = dk._diaDiem;
            this._diemMonHoc = dk._diemMonHoc;
        }


        public string NamHoc
        {
            get
            {
                return this._namHoc;
            }
            set
            {
                this._namHoc = value;
            }
        }

        public string HocKy
        {
            get
            {
                return this._hocKy;
            }
            set
            {
                this._hocKy = value;
            }
        }

        public string MaSV
        {
            get
            {
                return this._maSV;
            }
            set
            {
                this._maSV = value;
            }
        }

        public int SoTinhChi
        {
            get
            {
                return this._soTinhChi;
            }
            set
            {
                this._soTinhChi = value;
            }
        }

        public string DiaDiem
        {
            get
            {
                return this._diaDiem;
            }
            set
            {
                this._diaDiem = value;
            }
        }

        public float DiemMonHoc
        {
            get
            {
                return this._diemMonHoc;
            }
            set
            {
                this._diemMonHoc = value;
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_SINHVIEN
    {
        private string _maSV;
        private string _hoTen;
        private string _ngaySinh;
        private string _phai;
        private string _lop;
        private float _diemTrungBinh;

        public DTO_SINHVIEN()
        {
            this._maSV = "";
            this._hoTen = "";
            this._ngaySinh = "";
            this._phai = "";
            this._lop = "";
            this._diemTrungBinh = 0;
        }

        public DTO_SINHVIEN(string maSV, string hoTen, string ngaySinh, string phai, string lop, float diemTrungBinh)
        {
            this._maSV = maSV;
            this._hoTen = hoTen;
            this._ngaySinh = ngaySinh;
            this._phai = phai;
            this._lop = lop;
            this._diemTrungBinh = diemTrungBinh;
        }

        public DTO_SINHVIEN(DTO_SINHVIEN sv)
        {
            this._maSV = sv._maSV;
            this._hoTen = sv._hoTen;
            this._ngaySinh = sv._ngaySinh;
            this._phai = sv._phai;
            this._lop = sv._lop;
            this._diemTrungBinh = sv._diemTrungBinh;
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

        public string HoTen
        {
            get
            {
                return this._hoTen;
            }
            set
            {
                this._hoTen = value;
            }
        }

        public string NgaySinh
        {
            get
            {
                return this._ngaySinh;
            }
            set
            {
                this._ngaySinh = value;
            }
        }

        public string Phai
        {
            get
            {
                return this._phai;
            }
            set
            {
                this._phai = value;
            }
        }

        public string Lop
        {
            get
            {
                return this._lop;
            }
            set
            {
                this._lop = value;
            }
        }

        public float DiemTrugnBinh
        {
            get
            {
                return this._diemTrungBinh;
            }
            set
            {
                this._diemTrungBinh = value;
            }
        }
    }
}

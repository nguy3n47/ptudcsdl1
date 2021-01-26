using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_LOP
    {
        private string idClasses;
        private string Khoa;
        private string Loai;
        private DTO_SINHVIEN cap;

        public DTO_LOP()
        {
            this.idClasses = "";
            this.Khoa = "";
            this.Loai = "";
            this.cap = new DTO_SINHVIEN();
        }

        public DTO_LOP(string id, string k, string l, DTO_SINHVIEN c)
        {
            this.idClasses = id;
            this.Khoa = k;
            this.Loai = l;
            this.cap = c;
        }

        public DTO_LOP(DTO_LOP t)
        {
            this.idClasses = t.idClasses;
            this.Khoa = t.Khoa;
            this.Loai = t.Loai;
            this.cap = t.cap;
        }


        public string docghiidClasses
        {
            get { return idClasses; }
            set { idClasses = value; }
        }

        public string docghiKhoa
        {
            get { return Khoa; }
            set { Khoa = value; }
        }

        public string docghiLoai
        {
            get { return Loai; }
            set { Loai = value; }
        }

        public DTO_SINHVIEN docghicap
        {
            get { return cap; }
            set { cap = value; }
        }
    }
}

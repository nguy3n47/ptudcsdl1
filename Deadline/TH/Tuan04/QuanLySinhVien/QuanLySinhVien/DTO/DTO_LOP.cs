using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_LOP
    {
        private string _maLop;
        private string _khoa;
        private string _loaiLop;
        private string _lopTruong;

        public DTO_LOP()
        {
            this._maLop = "";
            this._khoa = "";
            this._loaiLop  = "";
            this._lopTruong = "";
        }

        public DTO_LOP(string maLop, string khoa, string loaiLop, string lopTruong)
        {
            this._maLop = maLop;
            this._khoa = khoa;
            this._loaiLop = loaiLop;
            this._lopTruong = lopTruong;
        }

        public DTO_LOP(DTO_LOP lop)
        {
            this._maLop = lop._maLop;
            this._khoa = lop._khoa;
            this._loaiLop = lop._loaiLop;
            this._lopTruong = lop._lopTruong;
        }

        public string MaLop
        {
            get
            {
                return this._maLop;
            }
            set
            {
                this._maLop = value;
            }
        }
        public string Khoa
        {
            get
            {
                return this._khoa;
            }
            set
            {
                this._khoa = value;
            }
        }
        public string LoaiLop
        {
            get
            {
                return this._loaiLop;
            }
            set
            {
                this._loaiLop = value;
            }
        }
        public string LopTruong
        {
            get
            {
                return this._lopTruong;
            }
            set
            {
                this._lopTruong = value;
            }
        }
    }
}

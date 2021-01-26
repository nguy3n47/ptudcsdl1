using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BUS
{
    class BUS_LOP
    {
        private List<DTO_LOP> dssv;
        public DTO_LOP NhapLop(DTO_LOP sv)
        {
            Console.Write("Nhap ID class: ");
            sv.docghiidClasses = Console.ReadLine();
            Console.Write("Nhap Loai: ");
            sv.docghiLoai = Console.ReadLine();
            Console.Write("Nhap Khoa: ");
            sv.docghiKhoa = Console.ReadLine();
            Console.Write("Nhap lop truong: ");
            DTO_SINHVIEN t = new DTO_SINHVIEN();
            BUS_SINHVIEN t1 = new BUS_SINHVIEN();
            t = t1.NhapSinhVien(t);
            sv.docghicap = t;

            return sv;

        }
        public void XuatLop(DTO_LOP sv)
        {
            Console.WriteLine("Ma lop: {0}", sv.docghiidClasses);
            Console.WriteLine("Khoa: {0}", sv.docghiKhoa);
            Console.WriteLine("Loai: {0}", sv.docghiLoai);
            Console.WriteLine("Cap: {0}", sv.docghicap);
        }

        public void thongTinLopTruong(DTO_LOP lp)
        {
            DTO_SINHVIEN t = new DTO_SINHVIEN();
            BUS_SINHVIEN t1 = new BUS_SINHVIEN();
            t = lp.docghicap;
            t1.XuatSinhVien(t);
        }
        public void xuatLop(DTO_LOP lp)
        {
            Console.WriteLine("Id lop: {0}", lp.docghiidClasses);
            Console.WriteLine("Khoa: {0}", lp.docghiKhoa);
            Console.WriteLine("Loai: {0}", lp.docghiLoai);
            Console.WriteLine("Lop truong");
            thongTinLopTruong(lp);
        }

        public void sinhVienThuocLop(List<DTO_SINHVIEN> dssv, DTO_LOP lp)
        {
            foreach (var sv in dssv)
            {
                if (sv.docghiclass == lp.docghiidClasses)
                {
                    BUS_SINHVIEN t1 = new BUS_SINHVIEN();
                    t1.XuatSinhVien(sv);
                }
            }
        }

        public void sinhVienCoDiemLonNhat(List<DTO_SINHVIEN> dssv, DTO_LOP lp)
        {
            float maxz = -1;
            foreach (var sv in dssv)
            {
                if (sv.docghiclass == lp.docghiidClasses)
                {
                    maxz = Math.Max(maxz, sv.docghiScore);
                }
            }

            if (maxz == -1)
            {
                Console.WriteLine("Danh sach lop rong!!");
                return;
            }

            // xuat sinh vien điểm lớn nhất
            foreach (var sv in dssv)
            {
                if (sv.docghiclass == lp.docghiidClasses && sv.docghiScore == maxz)
                {
                    BUS_SINHVIEN t1 = new BUS_SINHVIEN();
                    t1.XuatSinhVien(sv);
                }
            }
        }
    }
}

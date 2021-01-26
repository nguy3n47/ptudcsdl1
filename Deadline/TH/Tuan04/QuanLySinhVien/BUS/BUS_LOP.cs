using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BUS
{
    public class BUS_LOP
    {
        /// <summary>
        /// nhập thông tin lớp
        /// </summary>
        /// <param name="lop"></param>
        public void Input_Lop(DTO_LOP lop)
        {
            Console.Write("Nhap ma lop: ");
            lop.MaLop = Console.ReadLine();

            Console.Write("Nhap khoa: ");
            lop.Khoa = Console.ReadLine();

            Console.Write("Nhap loai lop: ");
            lop.LoaiLop = Console.ReadLine();

            Console.Write("Nhap lop truong: ");
            lop.LopTruong = Console.ReadLine();
        }

        /// <summary>
        /// xuất thông tin lớp
        /// </summary>
        /// <param name="lop"></param>
        public void Output_Lop(DTO_LOP lop)
        {
            Console.WriteLine($"Ma lop: {lop.MaLop}");
            Console.WriteLine($"Khoa: {lop.Khoa}");
            Console.WriteLine($"Loai lop: {lop.LoaiLop}");
            Console.WriteLine($"Lop truong: {lop.LopTruong}");
        }

        /// <summary>
        /// tìm thông tin lớp trưởng
        /// </summary>
        /// <param name="lop"></param>
        /// <returns> tên lớp trưởng </returns>
        public string ClassPresidentInfo(DTO_LOP lop)
        {
            string result = lop.LopTruong;
            return result;
        }

        /// <summary>
        /// xuất danh sách sinh viên thuộc lớp
        /// </summary>
        /// <param name="listSinhVien"></param>
        /// <param name="lop"></param>
        /// <returns> danh sách sinh viên thuộc lớp </returns>
        public List<DTO_SINHVIEN> OutputDSSVInClass(List<DTO_SINHVIEN> listSinhVien, DTO_LOP lop)
        {
            List<DTO_SINHVIEN> list = new List<DTO_SINHVIEN>();
            foreach (var sv in listSinhVien)
            {
                if (sv.Lop.Equals(lop.MaLop))
                {
                    list.Add(sv);
                }    
            }
            return list;
        }

        /// <summary>
        /// Tìm điểm trung bình lớn nhất trong lớp
        /// </summary>
        /// <param name="listSinhVien"></param>
        /// <param name="lop"></param>
        /// <returns> sinh viên có điểm trung bình lớn nhất (return: null - danh sách lớp rổng) </returns>
        public DTO_SINHVIEN SearchBiggestScore(List<DTO_SINHVIEN> listSinhVien, DTO_LOP lop)
        {
            List<DTO_SINHVIEN> list = OutputDSSVInClass(listSinhVien, lop);

            if (list.Count > 0)
            {
                DTO_SINHVIEN max = list[0];
                foreach (var sv in listSinhVien)
                {
                    if (sv.DiemTrugnBinh > max.DiemTrugnBinh)
                    {
                        max = sv;
                    }
                }
                return max;
            }
            else
                return null;
        }
    }
}

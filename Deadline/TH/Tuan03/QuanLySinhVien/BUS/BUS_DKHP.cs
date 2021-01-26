using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BUS
{
    public class BUS_DKHP
    {
        public void DKHP(DTO_DANGKYHOCPHAN dk)
        {
            Console.Write("Nam hoc: ");
            dk.NamHoc = Console.ReadLine();

            Console.Write("Hoc ky: ");
            dk.HocKy = Console.ReadLine();

            Console.Write("Ma sinh vien: ");
            dk.MaSV = Console.ReadLine();

            Console.Write("So tinh chi: ");
            string sotc = Console.ReadLine();
            int tc = 0;
            int.TryParse(sotc, out tc);
            dk.SoTinhChi = tc;

            Console.Write("Dia diem: ");
            dk.DiaDiem = Console.ReadLine();

            Console.Write("Diem mon hoc: ");
            string strDiem = Console.ReadLine();
            float diem = 0;
            float.TryParse(strDiem, out diem);
            dk.DiemMonHoc = diem;
        }

        /// <summary>
        /// xuất thông tin sinh viên cùng danh sách môn học đã đăng ký
        /// </summary>
        /// <param name="sv"></param>
        /// <param name="listDK"></param>
        /// <param name="bus_sv"></param>
        public void Output(DTO_SINHVIEN sv, List<DTO_DANGKYHOCPHAN> listDK, BUS_SINHVIEN bus_sv)
        {
            foreach (var dk in listDK)
            {
                if (sv.MaSV.Equals(dk.MaSV))
                {
                    bus_sv.Output_SV(sv);
                    Console.WriteLine("Danh sach mon hoc da dang ky");
                }    
            }    
        }


        /// <summary>
        /// Tính tổng số tín chỉ của một sinh viên
        /// </summary>
        /// <param name="maSV"></param>
        /// <param name="listDK"></param>
        /// <returns> tổng số tín chỉ</returns>
        public int Sum_TinhChi(string maSV, List<DTO_DANGKYHOCPHAN> listDK)
        {
            int sum = 0;
            foreach (var dk in listDK)
            {
                if (maSV.Equals(dk.MaSV))
                {
                    sum += dk.SoTinhChi;
                }    
            }
            return sum;
        }

        public bool Check(DTO_SINHVIEN sv, List<DTO_DANGKYHOCPHAN> listDK)
        {
            int sum = Sum_TinhChi(sv.MaSV, listDK);
            if(sum < 10)
            {
                return true;
            }

            return false;
        }
    }
}

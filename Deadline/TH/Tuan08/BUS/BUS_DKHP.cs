using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

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

        public void OutputKQ_DKHP(DTO_DANGKYHOCPHAN dk)
        {
            Console.WriteLine("Nam học: {0}", dk.NamHoc);
            Console.WriteLine("Hoc ky: {0}", dk.HocKy);
            Console.WriteLine("Ma sinh vien: {0}", dk.MaSV);
            Console.WriteLine("Ma môn học: {0}", dk.MaMH);
            Console.WriteLine("So tinh chi: {0}", dk.SoTinhChi);
            Console.WriteLine("Dia diem: {0}", dk.DiaDiem);
            Console.WriteLine("Diem mon hoc: {0}", dk.DiemMonHoc);
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


        DAL_DKHP dal_dkhp = new DAL_DKHP();
        public void xuatKQ_DKHP_SV()
        {
            DataTable dt = new DataTable();
            Console.Write("Nhập mã số sinh viên: ");
            string mssv = Console.ReadLine();
            Console.Write("Nhập học kỳ: ");
            string hk = Console.ReadLine();

            dt = dal_dkhp.KQ_DKHP_SV(mssv, hk);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DTO_DANGKYHOCPHAN dkhp = new DTO_DANGKYHOCPHAN();

                dkhp.NamHoc = dt.Rows[i]["NH"].ToString();
                dkhp.HocKy = dt.Rows[i]["HK"].ToString();
                dkhp.MaSV = dt.Rows[i]["MaSV"].ToString();
                dkhp.MaMH = dt.Rows[i]["MaMH"].ToString();
                var kokoko = dt.Rows[i]["SoTC"].ToString();
                dkhp.SoTinhChi = (int)float.Parse(dt.Rows[i]["SoTC"].ToString());
                dkhp.DiaDiem = dt.Rows[i]["Diadiem"].ToString();
                if (dt.Rows[i]["Diem"].ToString() != "")
                    dkhp.DiemMonHoc = float.Parse(dt.Rows[i]["Diem"].ToString());
                OutputKQ_DKHP(dkhp);
            }
        }

        public void DKHP_SV()
        {
            DataTable dt = new DataTable();
            DTO_DANGKYHOCPHAN dk = new DTO_DANGKYHOCPHAN();

            Console.Write("Nam hoc: ");
            dk.NamHoc = Console.ReadLine();

            Console.Write("Hoc ky: ");
            dk.HocKy = Console.ReadLine();

            Console.Write("Ma sinh vien: ");
            dk.MaSV = Console.ReadLine();

            Console.Write("Ma mon hoc: ");
            dk.MaMH = Console.ReadLine();

            Console.Write("So tinh chi: ");
            string sotc = Console.ReadLine();
            int tc = 0;
            int.TryParse(sotc, out tc);
            dk.SoTinhChi = tc;

            Console.Write("Dia diem: ");
            dk.DiaDiem = Console.ReadLine();

            dt = dal_dkhp.DKHP_SV(dk.NamHoc, dk.HocKy, dk.MaSV, dk.MaMH, dk.SoTinhChi, dk.DiaDiem);

            if (dt.Rows.Count == 0)
                Console.WriteLine("Số tín chỉ đã đủ!!");
            else if(dt.Rows[0]["sts"].ToString() == "-1")
            {
                Console.WriteLine("Kiểm tra lại dữ liệu!!!!!");
            }
            else 
            {
                Console.WriteLine("Số môn đã đăng ký: {0}", dt.Rows[0]["somon"].ToString());
                Console.WriteLine("Số tín chỉ đã đăng ký: {0}", dt.Rows[0]["sotc"].ToString());
            }
        }
    }
}

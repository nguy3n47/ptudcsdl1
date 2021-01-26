using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BUS
{
    public class BUS_SINHVIEN
    {
        public void Input_SV(DTO_SINHVIEN sv)
        {
            Console.Write("Nhập mã sinh viên: ");
            sv.MaSV = Console.ReadLine();

            Console.Write("Nhập họ tên: ");
            sv.HoTen = Console.ReadLine();

            Console.Write("Nhập ngày sinh: ");
            sv.NgaySinh = Console.ReadLine();

            Console.Write("Nhập giới tính: ");
            sv.Phai = Console.ReadLine();

            Console.Write("Nhập mã lớp: ");
            sv.Lop = Console.ReadLine();

            Console.Write("Nhập điểm trung bình: ");
            sv.DiemTrugnBinh = float.Parse(Console.ReadLine());
        }

        public void Output_SV(DTO_SINHVIEN sv)
        {
            Console.WriteLine("Mã sinh viên: {0}", sv.MaSV);
            Console.WriteLine("Họ tên: {0}", sv.HoTen);
            Console.WriteLine("Ngày sinh: {0}", sv.NgaySinh);
            Console.WriteLine("Giới tính: {0}", sv.Phai);
            Console.WriteLine("Lớp: {0}", sv.Lop);
            Console.WriteLine("Diểm trung bình: {0}", sv.DiemTrugnBinh);
        }

        public void Input_DSSV(List<DTO_SINHVIEN> listSinhVien)
        {
            do
            {
                Console.WriteLine("\tNhập thông tin sinh viên");

                DTO_SINHVIEN sv = new DTO_SINHVIEN();

                Input_SV(sv);
                listSinhVien.Add(sv);

                Console.Write("'esc' - dừng / 'enter' - tiếp tục: ");
                if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    Console.WriteLine();
                    break;
                }    
                    

            } while (true); 
        }

        public void Output_DSSV(List<DTO_SINHVIEN> listSinhVien)
        {
            foreach (var sv in listSinhVien)
            {
                Console.WriteLine("---------------------------------");
                Output_SV(sv);
            }    
        }

        /// <summary>
        /// tìm kiếm sinh viên có điểm cao nhất
        /// </summary>
        /// <param name="listSinhVien"></param>
        /// <returns> DTO_SINHVIEN </returns>
        public DTO_SINHVIEN SearchBiggestScore(List<DTO_SINHVIEN> listSinhVien)
        {
            DTO_SINHVIEN max = listSinhVien[0];
            foreach (var sv in listSinhVien)
            {
                if (sv.DiemTrugnBinh > max.DiemTrugnBinh)
                {
                    max = sv;
                }    
            }    
            return max;
        }

        /// <summary>
        /// tìm kiếm sinh viên có điểm nhỏ nhất
        /// </summary>
        /// <param name="listSinhVien"></param>
        /// <returns> điểm trung bình nhỏ nhất </returns>
        public DTO_SINHVIEN SearchSmallestScore(List<DTO_SINHVIEN> listSinhVien)
        {
            DTO_SINHVIEN min = listSinhVien[0];
            foreach (var sv in listSinhVien)
            {
                if (sv.DiemTrugnBinh < min.DiemTrugnBinh)
                {
                    min = sv;
                }
            }
            return min;
        }

        /// <summary>
        /// tiềm kiếm và xuất sinh viên có điểm trung bình lớn nhất hoặc nhỏ nhất
        /// </summary>
        /// <param name="listSinhVien"></param>
        public void SearchAndOutput(List<DTO_SINHVIEN> listSinhVien)
        {
            int select = 0;

            Console.WriteLine("1 - tìm kiếm sinh viên có điểm trung bình cao nhất");
            Console.WriteLine("2 - tìm kiếm sinh viên có điểm trung bình nhỏ nhất");
            Console.Write("chon: ");

            string str = Console.ReadLine();

            //ép kiểu về kiểu int
            int.TryParse(str, out select);

            switch (select)
            {
                case 1:
                    {

                        DTO_SINHVIEN sv = SearchBiggestScore(listSinhVien);
                        Output_SV(sv);
                        break;
                    }
                case 2:
                    {

                        DTO_SINHVIEN sv = SearchSmallestScore(listSinhVien);
                        Output_SV(sv);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("lựa chọn không tồn tại");
                        break;
                    }
            }    

        }

        /// <summary>
        /// in danh sách sinh viên theo giới tính
        /// </summary>
        /// <param name="listSinhVien"></param>
        public void PrintDSSVByGender(List<DTO_SINHVIEN> listSinhVien)
        {
            //sắp xếp danh sách theo giới tính
            listSinhVien.Sort((x, y) => x.Phai.CompareTo(y.Phai));

            Output_DSSV(listSinhVien);
        }

        /// <summary>
        /// tính tổng điểm của các sinh viên
        /// </summary>
        /// <param name="listSinhVien"></param>
        /// <returns> Tổng điểm </returns>
        public float Sum(List<DTO_SINHVIEN> listSinhVien)
        {
            float sum = 0;
            foreach (var sv in listSinhVien)
            {
                sum += sv.DiemTrugnBinh;
            }
            return sum;
        }

        /// <summary>
        /// tính điểm trung bình cộng của các sinh viên
        /// </summary>
        /// <param name="listSinhVien"></param>
        /// <returns> điểm trung bình cộng </returns>
        public double GPA(List<DTO_SINHVIEN> listSinhVien)
        {
            double gpa = Sum(listSinhVien) / listSinhVien.Count;
            return gpa;
        }

        /// <summary>
        /// in điển trung bình cộng của các sinh viên
        /// </summary>
        /// <param name="listSinhVien"></param>
        public void PrintGPA(List<DTO_SINHVIEN> listSinhVien)
        {
            double gpa = GPA(listSinhVien);
            Console.WriteLine($"diem trung binh cong cua cac sinh vien = {gpa}");
        }



        DAL_SINHVIEN dal_dkhp = new DAL_SINHVIEN();
        public void Select()
        {
            Console.WriteLine("\txuất thông tin tin sinh viên khi biết mã sinh viên");
            Console.Write("nhập mssv: ");
            string mssv = Console.ReadLine();
            DTO_SINHVIEN sv = dal_dkhp.SelectSV(mssv);

            Output_SV(sv);

            Console.WriteLine("\txuất danh sách sinh viên theo giới tính");
            Console.Write("Nhập giới tính: ");
            string phai = Console.ReadLine();
            List<DTO_SINHVIEN> listSV = dal_dkhp.SelectDSSV(phai);

            Output_DSSV(listSV);
        }

        public void XuatDSLop()
        {
            Console.Write("Nhập vào mã lớp: ");
            string strLop = Console.ReadLine();
            dal_dkhp.xuatDSLop(strLop);
        }

        public void insertSV()
        {
            DTO_SINHVIEN sv = new DTO_SINHVIEN();
            Input_SV(sv);
            dal_dkhp.insertSV(sv);
        }

        public void deleteSV()
        {
            Console.Write("Nhập mã sinh viên cần xóa: ");
            string maSV = Console.ReadLine();

            dal_dkhp.deleteSV(maSV);
        }

        public void xuatDTB()
        {
            Console.Write("Nhập mã sinh viên: ");
            string maSV = Console.ReadLine();
            float dtb;
            dtb = dal_dkhp.xuatDTB(maSV);
            Console.WriteLine($"Diểm trung bình của {maSV} là {dtb}");
        }

        public void updateSV()
        {
            Console.WriteLine("Nhập thông tin sinh viên cần update");
            DTO_SINHVIEN sv = new DTO_SINHVIEN();
            Input_SV(sv);
            dal_dkhp.updateSV(sv);
        }


        public void xuatDSLopTruong()
        {
            DataTable dt = new DataTable();
            dt = dal_dkhp.xuatDSLopTruong();
            for(int i = 0; i<dt.Rows.Count; i++)
            {
                DTO_SINHVIEN sv = new DTO_SINHVIEN();

                sv.MaSV = dt.Rows[i]["MaSV"].ToString();
                sv.HoTen = dt.Rows[i]["HoTen"].ToString();
                sv.NgaySinh = dt.Rows[i]["NgaySinh"].ToString();
                sv.Phai = dt.Rows[i]["Phai"].ToString();
                sv.Lop = dt.Rows[i]["Lop"].ToString();
                sv.DiemTrugnBinh = float.Parse(dt.Rows[i]["DTB"].ToString());
                Output_SV(sv);
            }
        }



        public void xuatDSLop()
        {
            DataTable dt = new DataTable();
            Console.Write("Nhập mã lớp: ");
            string malop = Console.ReadLine();
            dt = dal_dkhp.xuatDSLop(malop);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DTO_SINHVIEN sv = new DTO_SINHVIEN();

                sv.MaSV = dt.Rows[i]["MaSV"].ToString();
                sv.HoTen = dt.Rows[i]["HoTen"].ToString();
                sv.NgaySinh = dt.Rows[i]["NgaySinh"].ToString();
                sv.Phai = dt.Rows[i]["Phai"].ToString();
                sv.Lop = dt.Rows[i]["Lop"].ToString();
                sv.DiemTrugnBinh = float.Parse(dt.Rows[i]["DTB"].ToString());
                Output_SV(sv);
            }

        }

        public void TongSoSV()
        {   
            int tong = dal_dkhp.tongSoSinhVien();
            Console.WriteLine($"Tổng số sinh viên: {tong}");
        }

        public void DTB_SV()
        {
            Console.Write("Nhập mã sinh viên: ");
            string mssv = Console.ReadLine();
            float dtb = dal_dkhp.DiemTBSinhVien(mssv);
            Console.WriteLine($"Điểm trung bình của sinh viên: {mssv} là: {dtb}");
        }
    }
}

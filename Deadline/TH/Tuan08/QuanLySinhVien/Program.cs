using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using BUS;
using DAL;

namespace QuanLySinhVien
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            List<DTO_SINHVIEN> listSinhVien = new List<DTO_SINHVIEN>();
            BUS_SINHVIEN bus_SinhVien = new BUS_SINHVIEN();
            BUS_DKHP bus_dkhp = new BUS_DKHP();
            bus_dkhp.DKHP_SV();

            //bus_SinhVien.Select();

            //bus_SinhVien.Input_DSSV(listSinhVien);

            //Menu(bus_SinhVien, listSinhVien);
            //bus_SinhVien.xuatDSLop();

            //bus_SinhVien.insertSV();

            //bus_SinhVien.deleteSV();

            //bus_SinhVien.xuatDTB();

            //bus_SinhVien.updateSV();

            //Console.ReadKey();
        }

        static void Menu(BUS_SINHVIEN bus_sv, List<DTO_SINHVIEN> listSV)
        {
            Console.WriteLine("0 - Thoat");
            Console.WriteLine("1 - In danh sach sinh vien");
            Console.WriteLine("2 - In sinh vien co diem trung binh lon nhat hoac nho nhat");
            Console.WriteLine("3 - In danh sach sinh vien theo gioi tinh");
            Console.WriteLine("4 - In diem trung binh cong");

            int Chon = 0;
            string str;
            do
            {
                Console.Write("Chon: ");
                str = Console.ReadLine();
                int.TryParse(str, out Chon);

                switch(Chon)
                {
                    case 0:
                        {
                            break;
                        }
                    case 1:
                        {
                            bus_sv.Output_DSSV(listSV);
                            break;
                        }
                    case 2:
                        {
                            bus_sv.SearchAndOutput(listSV);
                            break;
                        }
                    case 3:
                        {
                            bus_sv.PrintDSSVByGender(listSV);
                            break;
                        }
                    case 4:
                        {
                            bus_sv.PrintGPA(listSV);
                            break;
                        }
                }    
            } while (Chon != 0);
        }
    }
}

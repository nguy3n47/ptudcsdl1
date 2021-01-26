using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using BUS;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;

namespace QuanLySinhVien
{
    class Program
    {

        static void tieptuc(out string n)
        {
            Console.WriteLine("\nBAn co muon tiep tuc khong (Y/N): ");
            n = Console.ReadLine();
            if (n == "N" || n == "n")
            {
                Environment.Exit(0);
            }
        }

        static void xuly(out int a)
        {
            Console.WriteLine("//---------------MENU-----------------//");
            Console.WriteLine("1. In danh sách Sinh Vien.");
            Console.WriteLine("2. In Sinh Vien co DTB lon nhat.");
            Console.WriteLine("3. In danh sach SV theo gioi tinh.");
            Console.WriteLine("4. In diem trung binh cong.");
            Console.WriteLine("0. Thoat!");
            Console.Write("Chon: ");
            a = int.Parse(Console.ReadLine());
            Console.Clear();
        }


        static void Main()
        {
            string k = "";
            int bai=0;
            BUS_SINHVIEN t = new BUS_SINHVIEN();

            t.DanhSachSinhVien();
            do
            {
                xuly(out bai);
                switch (bai)
                {
                    case 0:
                        {
                            Environment.Exit(0);
                            break;
                        }
                    case 1:
                        {
                            t.XuatDanhSachSinhVien();
                            tieptuc(out k);
                            break;
                        }
                    case 2:
                        {
                            t.findListMaxScore();
                            tieptuc(out k);
                            break;
                        }
                    case 3:
                        {
                            Console.Write("Nhap gioi tinh (nam or nu): ");
                            string q = Console.ReadLine();
                            t.ListStudentWithGender(q);
                            tieptuc(out k);
                            break;
                        }
                    case 4:
                        {
                            float i = t.averageScore();
                            Console.WriteLine("DTB cong cua tat ca sinh vien là: {0}", i);
                            tieptuc(out k);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Bai ban nhap khong hop le !!!");
                            tieptuc(out k);
                            break;
                        }
                }
                Console.Clear();
            } while (k == "Y" || k == "y");
            Console.ReadKey();
        }
    }
}

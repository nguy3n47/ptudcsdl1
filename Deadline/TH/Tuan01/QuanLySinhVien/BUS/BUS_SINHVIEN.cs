using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BUS
{
    public class BUS_SINHVIEN
    {
        public List<DTO_SINHVIEN> dssv;
        public DTO_SINHVIEN NhapSinhVien(DTO_SINHVIEN sv)
        {
            Console.Write("Nhap MSSV: ");
            sv.docghiID = Console.ReadLine();
            Console.Write("Nhap Ten: ");
            sv.docghiName = Console.ReadLine();


            //nhập và kiểm tra ngày sinh hợp lệ
            while (true)
            {
                int flag = -1;
                Console.Write("Nhap ngay sinh (dd/mm/yyyy): ");
                string bd = Console.ReadLine();
                DateTime temp;
                bool tt = DateTime.TryParse(bd, out temp);

                if (DateTime.TryParse(bd, out temp))
                {
                    sv.docghiBD = temp;
                    flag = 0;
                }
                else
                {
                    Console.WriteLine("Ngay sinh khong hop le!");
                }
                if (flag == 0)
                    break;
            }

            // nhập và kt giới tính
            while (true)
            {
                Console.Write("Nhap phai (Nam or Nu): ");
                int t = -1;
                string temp = Console.ReadLine();
                switch (temp)
                {
                    case "Nam":
                        sv.docghigender = "Nam";
                        t = 1;
                        break;

                    case "Nu":
                        sv.docghigender = "Nu";
                        t = 1;
                        break;
                    default:
                        break;
                }
                if (t == -1)
                    Console.WriteLine("Gioi tinh khong hop le!");
                else
                    break;
            }

            Console.Write("Nhap lop: ");
            sv.docghiclass = Console.ReadLine();

            while (true)
            {
                Console.Write("Nhap diem: ");
                string temp = Console.ReadLine();
                int flag = -1;
                if (float.TryParse(temp, out float n))
                {
                    float t = float.Parse(temp);
                    if (t >= 0 && t <= 10)
                    {
                        sv.docghiScore = t;
                        flag = 1;
                    }
                }
                if (flag == -1)
                    Console.WriteLine("Diem khong hop le!!");
                else
                    break;
            }

            return sv;

        }
        public void XuatSinhVien(DTO_SINHVIEN sv)
        {
            Console.WriteLine("MSSV: {0}", sv.docghiID);
            Console.WriteLine("Ten: {0}", sv.docghiName);
            Console.WriteLine("Ngay Sinh: {0}", sv.docghiBD.ToString("dd/M/yyyy", CultureInfo.InvariantCulture));
            Console.WriteLine("Phai: {0}", sv.docghigender);
            Console.WriteLine("Lop: {0}", sv.docghiclass);
            Console.WriteLine("Diem: {0}", sv.docghiScore);
        }

        public void DanhSachSinhVien()
        {
            dssv = new List<DTO_SINHVIEN>();
            int i = 1;
            while (true)
            {
                Console.WriteLine("#--------Thong tin sinh vien {0}--------#", i);
                BUS_SINHVIEN t = new BUS_SINHVIEN();
                DTO_SINHVIEN t1 = new DTO_SINHVIEN();
                t1 = t.NhapSinhVien(t1);
                dssv.Add(t1);
                i++;
                Console.Write("1 tiep tuc (-1 thoat): ");
                string temp = Console.ReadLine();

                if (float.TryParse(temp, out float n))
                {
                    float t2 = float.Parse(temp);
                    if (t2 == -1)
                        break;
                }
                else
                {
                    Console.WriteLine("Thoat danh sach nhap!!");
                    break;
                }
            }
        }
        public void XuatDanhSachSinhVien()
        {
            int i = 1;
            foreach (var sv in dssv)
            {
                Console.WriteLine("#--------Thong tin sinh vien {0}--------#", i);
                BUS_SINHVIEN t = new BUS_SINHVIEN();
                t.XuatSinhVien(sv);
                i++;
            }
        }

        public float maxScore()
        {
            float maxScore = -1;
            foreach (var sv in dssv)
            {
                if (sv.docghiScore > maxScore)
                    maxScore = sv.docghiScore;
            }
            return maxScore;
        }

        public void findListMaxScore()
        {
            float score = maxScore();
            foreach (var sv in dssv)
            {
                if (sv.docghiScore == score)
                {
                    BUS_SINHVIEN t = new BUS_SINHVIEN();
                    t.XuatSinhVien(sv);
                }
            }
        }

        // kiểm tra giới tính
        private int checkGender(string gender)
        {
            switch (gender)
            {
                case "nam":
                    return 1;
                    break;

                case "nu":
                    return 2;
                    break;
                default:
                    break;
            }
            return 0;
        }

        // in dssv theo giới tính
        public void ListStudentWithGender(string gender)
        {
            int t = checkGender(gender);
            if (t == 0)
                Console.WriteLine("Gioi tinh khong hop le!!!!");
            string s = "nam";
            if (t == 2)
                s = "nu";

            foreach (var sv in dssv)
            {
                if (sv.docghigender == s)
                {
                    BUS_SINHVIEN a = new BUS_SINHVIEN();
                    a.XuatSinhVien(sv);
                }
            }
        }


        // in DTB
        public float averageScore()
        {
            float score = 0;
            foreach (var sv in dssv)
                score += sv.docghiScore;
            return score / dssv.Count;
        }
    }
}

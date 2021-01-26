using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BUS
{
    class BUS_DKHP
    {
        private List<DTO_DKHP> ds_dkhp;

        public bool checkSoTC(int tc)
        {
            return tc < 10;
        }

        public DTO_DKHP nhapDKHP(DTO_DKHP dkhp)
        {
            Console.Write("Nhap nam hoc: ");
            dkhp.docghiYear = int.Parse(Console.ReadLine());
            Console.Write("Nhap hoc ky: ");
            dkhp.docghiHK = int.Parse(Console.ReadLine());
            Console.Write("Nhap ma sinh vien: ");
            dkhp.docghiID_SV = Console.ReadLine();
            Console.Write("Nhap so tin chi: ");
            dkhp.docghiTC = int.Parse(Console.ReadLine());
            Console.Write("Nhap dia diem: ");
            dkhp.docghiaddress = Console.ReadLine();
            Console.Write("Nhap diem ");
            dkhp.docghisco = float.Parse(Console.ReadLine());

            return dkhp;
        }

        public void xuatDKHP(DTO_DKHP dkhp)
        {
            Console.Write("Nam hoc: {0}", dkhp.docghiYear);
            Console.Write("hoc ky: {0}", dkhp.docghiHK);
            Console.Write("ma sinh vien: {0}", dkhp.docghiID_SV);
            Console.Write("So tin chi: {0}", dkhp.docghiTC);
            Console.Write("Dia diem: {0}", dkhp.docghiaddress);
            Console.Write("Diem: {0}", dkhp.docghisco);
        }


        public void nhapDanhSachDKHP()
        {
            ds_dkhp = new List<DTO_DKHP>();
            int i = 1;
            while (true)
            {
                Console.WriteLine("#--------Thong tin dang ky hoc phan {0}--------#", i);
                BUS_DKHP t = new BUS_DKHP();
                DTO_DKHP t1 = new DTO_DKHP();
                t1 = t.nhapDKHP(t1);
                ds_dkhp.Add(t1);
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

        public void xuatDS_DKHPtheoSinhVien(List<DTO_SINHVIEN> dssv)
        {
            foreach (var sv in dssv)
            {
                int i = 1;
                BUS_SINHVIEN svv = new BUS_SINHVIEN();
                svv.XuatSinhVien(sv);
                Console.WriteLine("Danh sach mon");
                foreach (var hp in ds_dkhp)
                {
                    if (sv.docghiID == hp.docghiID_SV)
                    {
                        Console.WriteLine("#--------Thong tin mon {0}--------#", i);
                        BUS_DKHP t = new BUS_DKHP();
                        t.xuatDKHP(hp);
                        i++;
                    }
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18600187_VuCaoNguyen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            HANGHOA hh = new HANGHOA();
            hh.OutputTongSoHH();
            hh.OutputThongTin();
        }
    }
}
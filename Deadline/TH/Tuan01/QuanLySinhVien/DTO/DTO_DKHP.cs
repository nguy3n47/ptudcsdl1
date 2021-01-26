using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_DKHP
    {
        private int Year;
        private int HK;
        private string ID_SV;
        private int TC;
        private string address;
        private float sco;

        public DTO_DKHP()
        {
            this.Year = 0;
            this.HK = 0;
            this.ID_SV = "";
            this.TC = 0;
            this.address = "";
            this.sco = 0;
        }

        public DTO_DKHP(int yy, int hk, string id, int tc, string ad, float sc)
        {
            this.Year = yy;
            this.HK = hk;
            this.ID_SV = id;
            this.TC = tc;
            this.address = ad;
            this.sco = sc;
        }

        public DTO_DKHP(DTO_DKHP t)
        {
            this.Year = t.Year;
            this.HK = t.HK;
            this.ID_SV = t.ID_SV;
            this.TC = t.TC;
            this.address = t.address;
            this.sco = t.sco;
        }


        public int docghiYear
        {
            get { return Year; }
            set { Year = value; }
        }

        public int docghiHK
        {
            get { return HK; }
            set { HK = value; }
        }

        public string docghiID_SV
        {
            get { return ID_SV; }
            set { ID_SV = value; }
        }

        public int docghiTC
        {
            get { return TC; }
            set { TC = value; }
        }

        public string docghiaddress
        {
            get { return address; }
            set { address = value; }
        }

        public float docghisco
        {
            get { return sco; }
            set { sco = value; }
        }
    }
}

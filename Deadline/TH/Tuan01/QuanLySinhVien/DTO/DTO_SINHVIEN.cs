using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_SINHVIEN
    {
        private string ID;
        private string Name;
        private DateTime NgS;
        private string gender;
        private string classes;
        private float score;


        public DTO_SINHVIEN()
        {
            this.ID = "";
            this.Name = "";
            string temp = "01/01/1000";
            this.NgS = DateTime.Parse(temp);
            this.gender = "";
            this.classes = "";
            this.score = 0;
        }

        public DTO_SINHVIEN(string id, string name, DateTime bd, string gender, string classes, float sc)
        {
            this.ID = id;
            this.Name = name;
            this.NgS = bd;
            this.gender = gender;
            this.classes = classes;
            this.score = sc;
        }

        public DTO_SINHVIEN(DTO_SINHVIEN t)
        {
            this.ID = t.ID;
            this.Name = t.Name;
            this.NgS = t.NgS;
            this.gender = t.gender;
            this.classes = t.classes;
            this.score = t.score;
        }

        public string docghiID
        {
            get { return ID; }
            set { ID = value; }
        }

        public string docghiName
        {
            get { return Name; }
            set { Name = value; }
        }

        public DateTime docghiBD
        {
            get { return NgS; }
            set { NgS = value; }
        }

        public string docghigender
        {
            get { return gender; }
            set { gender = value; }
        }

        public string docghiclass
        {
            get { return classes; }
            set { classes = value; }
        }

        public float docghiScore
        {
            get { return score; }
            set { score = value; }
        }
    }
}

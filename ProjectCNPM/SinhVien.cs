using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCNPM
{
    public class SinhVien
    {
        private string name;
        private DateTime birthDay;
        private string sex;
        private string sbd;

        private string mahoso;
        private string dtut;
        private string truong;
        private string matruong;
        private string nganh;
        private string manganh;
        private string hokhau;
        private string cmnd;
        private string sdt;
        private string dantoc;
        public string Name { get => name; set => name = value; }
        public DateTime BirthDay { get => birthDay; set => birthDay = value; }
        public string Sex { get => sex; set => sex = value; }
        public string Sbd { get => sbd; set => sbd = value; }

        public string Mahoso { get => mahoso; set => mahoso = value; }
        public string Dtut { get => dtut; set => dtut = value; }
        public string Truong { get => truong; set => truong = value; }
        public string Matruong { get => matruong; set => matruong = value; }
        public string Nganh { get => nganh; set => nganh = value; }
        public string Manganh { get => manganh; set => manganh = value; }
        public string Hokhau { get => hokhau; set => hokhau = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Dantoc { get => dantoc; set => dantoc = value; }

        public SinhVien( string sbd, string name, DateTime birthDay, string sex, string mahoso, string dtut, string truong, string matruong, string nganh, string manganh,string hokhau,string cmnd,string sdt,string dantoc)
        {
            
            this.Sbd = sbd;
            this.Name = name;
            this.BirthDay = birthDay;
            this.Sex = sex;
            
            this.Dtut = dtut;
            this.Truong = truong;
            this.Matruong = matruong;
            this.Mahoso = mahoso;
            this.Nganh = nganh;
            this.Manganh = manganh;
            this.Hokhau = hokhau;
            this.Cmnd = cmnd;
            this.Sdt = sdt;
            this.Dantoc = dantoc;
        }
        public SinhVien()
        {

        }
    }
}

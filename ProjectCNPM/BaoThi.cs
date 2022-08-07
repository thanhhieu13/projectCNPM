using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCNPM
{
    public class BaoThi
    {
        private string name;
        private string noisinh ;
        private DateTime birthDay;
       
        private string sbd;

        private string diachibaotin;
        private string diachithi;
        private string phongthi;
        private DateTime ngaythi;
        private string tien;
        
        public string Name { get => name; set => name = value; }
        public string Noisinh { get => noisinh; set => noisinh = value; }
        public DateTime BirthDay { get => birthDay; set => birthDay = value; }
        public string Sbd { get => sbd; set => sbd = value; }

        public string Diachibaotin { get => diachibaotin; set => diachibaotin = value; }
        public string Diachithi { get => diachithi; set => diachithi = value; }
        public string Phongthi { get => phongthi; set => phongthi = value; }
        public DateTime Ngaythi { get => ngaythi; set => ngaythi = value; }
        public string Tien { get => tien; set => tien = value; }
        

        public BaoThi(string name, string noisinh, DateTime birthDay, string sbd, string diachibaotin, string diachithi, string phongthi, DateTime ngaythi, string tien)
        {
            this.Name = name;
            this.Noisinh = noisinh;
            this.BirthDay = birthDay;
            this.Sbd = sbd;

            this.Diachibaotin = diachibaotin;
            this.Diachithi = diachithi;
            this.Phongthi = phongthi;
            this.Ngaythi = ngaythi;
            this.Tien = tien;
            
        }
        public BaoThi()
        {

        }
    }
}

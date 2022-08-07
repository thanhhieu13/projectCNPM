using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCNPM
{
    public class Diem
    {
        private string sbd;
        private string mon1;
        private string mon2;
        private string mon3;
        private string diem1;
        private string diem2;
        private string diem3;
        private string diemuutien;
     
        public string Sbd { get => sbd; set => sbd = value; }
        public string Mon1 { get => mon1; set => mon1 = value; }
        public string Mon2 { get => mon2; set => mon2 = value; }

        public string Mon3 { get => mon3; set => mon3 = value; }
        public string Diem1 { get => diem1; set => diem1 = value; }
        public string Diem2 { get => diem2; set => diem2 = value; }
        public string Diem3 { get => diem3; set => diem3 = value; }
        public string Diemuutien { get => diemuutien; set => diemuutien = value; }
        
        public Diem(string sbd, string mon1, string diem1, string mon2, string diem2, string mon3, string diem3, string diemuutien)
        {

            this.Sbd = sbd;
            this.Mon1 = mon1;
            this.Mon2 = mon2;
            this.Mon3 = mon3;

            this.Diem1 = diem1;
            this.Diem2 = diem2;
            this.Diem3 = diem3;
            this.Diemuutien = diemuutien;
          
        }
        public Diem()
        {

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCNPM
{
    public class ListSinhVien
    {
        private static ListSinhVien instance;
        private List<SinhVien> listSinhVien;
        
        public List<SinhVien> ListSinhVienn { 
            get => listSinhVien; 
            set => listSinhVien = value; 
        }


        public static ListSinhVien Instance
        {
            get {
                if (instance == null)
                    instance = new ListSinhVien();
                return instance;
                   
            } 
            set => instance = value;
        }
        private ListSinhVien()
        {
            listSinhVien = new List<SinhVien>();
            listSinhVien.Add(new SinhVien("20521328","Hieu", new DateTime(2002, 4, 13), "nam","12","1","UIT","U1","cnpm","PMCL","1 Vo Van Ngan","123", "123213213", "kinh"));
            listSinhVien.Add(new SinhVien("20521312", "Huy", new DateTime(2002, 4, 13), "nam", "12", "1", "UIT", "U1", "cnpm", "PMCL", "1 Vo Van Ngan", "123", "123213213", "kinh"));
            listSinhVien.Add(new SinhVien("20521322", "Hai", new DateTime(2002, 4, 13), "nam", "12", "1", "UIT", "U1", "cnpm", "PMCL", "1 Vo Van Ngan", "123", "123213213", "kinh"));
            listSinhVien.Add(new SinhVien("20521323", "Hoang", new DateTime(2002, 4, 13), "nam", "12", "1", "UIT", "U1", "cnpm", "PMCL", "1 Vo Van Ngan", "123", "123213213", "kinh"));
            listSinhVien.Add(new SinhVien("20521324", "Quy", new DateTime(2002, 4, 13), "nam", "12", "1", "UIT", "U1", "cnpm", "PMCL", "1 Vo Van Ngan", "123", "123213213", "kinh"));
            listSinhVien.Add(new SinhVien("20521325", "Van", new DateTime(2002, 4, 13), "nu", "12", "1", "UIT", "U1", "cnpm", "PMCL", "1 Vo Van Ngan", "123", "123213213", "kinh"));
            listSinhVien.Add(new SinhVien("20521326", "Trang", new DateTime(2002, 4, 13), "nu", "12", "1", "UIT", "U1", "cnpm", "PMCL", "1 Vo Van Ngan", "123", "123213213", "kinh"));
            listSinhVien.Add(new SinhVien("20521327", "Quynh", new DateTime(2002, 4, 13), "nu", "12", "1", "UIT", "U1", "cnpm", "PMCL", "1 Vo Van Ngan", "123", "123213213", "kinh"));
            listSinhVien.Add(new SinhVien("20521329", "Linh", new DateTime(2002, 4, 13), "nu", "12", "1", "UIT", "U1", "cnpm", "PMCL", "1 Vo Van Ngan", "123", "123213213", "kinh"));
            listSinhVien.Add(new SinhVien("20521331", "Duong", new DateTime(2002, 4, 13), "nu", "12", "1", "UIT", "U1", "cnpm", "PMCL", "1 Vo Van Ngan", "123", "123213213", "kinh"));

        }
    }
}

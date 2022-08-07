using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCNPM
{
     class ListDiem
    {
        private static ListDiem instance;
        private List<Diem> listDiem;

        public List<Diem> ListDiemThi
        {
            get => listDiem;
            set => listDiem = value;
        }


        public static ListDiem Instance
        {
            get
            {
                if (instance == null)
                    instance = new ListDiem();
                return instance;

            }
            set => instance = value;
        }
        private ListDiem()
        {
            listDiem = new List<Diem>();
            listDiem.Add(new Diem("20521328", "toan", "7", "ly", "9", "hoa", "8", "0.5"));
            listDiem.Add(new Diem("20521312", "toan", "7", "ly", "9", "hoa", "8", "0.5"));
            listDiem.Add(new Diem("20521322", "toan", "7", "ly", "9", "hoa", "8", "0.5"));
            listDiem.Add(new Diem("20521323", "toan", "7", "ly", "9", "hoa", "8", "0.5"));
            listDiem.Add(new Diem("20521324", "toan", "7", "ly", "9", "hoa", "8", "0.5"));
            listDiem.Add(new Diem("20521325", "toan", "7", "ly", "9", "hoa", "8", "0.5"));
            listDiem.Add(new Diem("20521326", "toan", "7", "ly", "9", "hoa", "8", "0.5"));
            listDiem.Add(new Diem("20521327", "toan", "7", "ly", "9", "hoa", "8", "0.5"));
            listDiem.Add(new Diem("20521329", "toan", "7", "ly", "9", "hoa", "8", "0.5"));
            listDiem.Add(new Diem("20521331", "toan", "7", "ly", "9", "hoa", "8", "0.5"));


        }
    }
}

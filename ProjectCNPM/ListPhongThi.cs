using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCNPM
{
    class ListPhongThi
    {
        private static ListPhongThi instance;
        private List<PhongThi> listPhongThi;

        public List<PhongThi> ListPhongThis { get => listPhongThi; set => listPhongThi = value; }

        public static ListPhongThi Instance
        {
            get
            {
                if (instance == null)
                    instance = new ListPhongThi();
                return instance;
            }

            set => instance = value;
        }

        private ListPhongThi()
        {
            ListPhongThis = new List<PhongThi>();
            ListPhongThis.Add(new PhongThi("Phòng 1"));
            ListPhongThis.Add(new PhongThi("Phòng 2"));
            ListPhongThis.Add(new PhongThi("Phòng 3"));
            ListPhongThis.Add(new PhongThi("Phòng 4"));
            ListPhongThis.Add(new PhongThi("Phòng 5"));
        }
    }
}

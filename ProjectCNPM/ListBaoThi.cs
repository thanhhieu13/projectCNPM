using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCNPM
{
    class ListBaoThi
    {
        private static ListBaoThi instance;
        private List<BaoThi> listBaoThi;

        public List<BaoThi> ListBaoPhongThi
        {
            get => listBaoThi;
            set => listBaoThi = value;
        }


        public static ListBaoThi Instance
        {
            get
            {
                if (instance == null)
                    instance = new ListBaoThi();
                return instance;

            }
            set => instance = value;
        }
        private ListBaoThi()
        {
            listBaoThi = new List<BaoThi>();
            listBaoThi.Add(new BaoThi("Hieu", "Vung Tau", new DateTime(2002, 4, 13), "20521328", "Đại học UIT", "Trường THPT Nguyễn Huệ", "phòng 1", new DateTime(2022, 4, 13), "250000"));
            listBaoThi.Add(new BaoThi("Huy", "Vung Tau", new DateTime(2002, 4, 13), "20521312", "Đại học UIT", "Trường THPT Nguyễn Huệ", "phòng 1", new DateTime(2022, 4, 13), "250000"));
            listBaoThi.Add(new BaoThi("Hai", "Vung Tau", new DateTime(2002, 4, 13), "20521322", "Đại học UIT", "Trường THPT Nguyễn Huệ", "phòng 1", new DateTime(2022, 4, 13), "250000"));
            listBaoThi.Add(new BaoThi("Hoang", "Vung Tau", new DateTime(2002, 4, 13), "20521323", "Đại học UIT", "Trường THPT Nguyễn Huệ", "phòng 1", new DateTime(2022, 4, 13), "250000"));
            listBaoThi.Add(new BaoThi("Quy", "Vung Tau", new DateTime(2002, 4, 13), "20521324", "Đại học UIT", "Trường THPT Nguyễn Huệ", "phòng 1", new DateTime(2022, 4, 13), "250000"));
            listBaoThi.Add(new BaoThi("Van", "Vung Tau", new DateTime(2002, 4, 13), "20521325", "Đại học UIT", "Trường THPT Nguyễn Huệ", "phòng 1", new DateTime(2022, 4, 13), "250000"));
            listBaoThi.Add(new BaoThi("Trang", "Vung Tau", new DateTime(2002, 4, 13), "20521326", "Đại học UIT", "Trường THPT Nguyễn Huệ", "phòng 1", new DateTime(2022, 4, 13), "250000"));
            listBaoThi.Add(new BaoThi("Quynh", "Vung Tau", new DateTime(2002, 4, 13), "20521327", "Đại học UIT", "Trường THPT Nguyễn Huệ", "phòng 1", new DateTime(2022, 4, 13), "250000"));
            listBaoThi.Add(new BaoThi("Linh", "Vung Tau", new DateTime(2002, 4, 13), "20521329", "Đại học UIT", "Trường THPT Nguyễn Huệ", "phòng 1", new DateTime(2022, 4, 13), "250000"));
            listBaoThi.Add(new BaoThi("Duong", "Vung Tau", new DateTime(2002, 4, 13), "20521331", "Đại học UIT", "Trường THPT Nguyễn Huệ", "phòng 1", new DateTime(2022, 4, 13), "250000"));

        }
    }
}

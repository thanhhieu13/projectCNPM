using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectCNPM
{
    
    public partial class FormBaoThidtgv : Form
    {
        int index = -1;
        public FormBaoThidtgv()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            FormShowBaoThi f = new FormShowBaoThi();
            f.ShowDialog();
        }

        private void txbSBD_TextChanged(object sender, EventArgs e)
        {
            string search = txbSBD.Text;
            List<BaoThi> ListSearch = new List<BaoThi>();
            foreach (var i in ListBaoThi.Instance.ListBaoPhongThi)
            {
                if (i.Sbd.Contains(search))
                {
                    ListSearch.Add(i);
                }
            }
            dtgvBaoThi.DataSource = ListSearch;
        }
        void LoadListBaoThi()
        {
            foreach (var item in ListBaoThi.Instance.ListBaoPhongThi)
            {
                dtgvBaoThi.Rows.Add(item.Name, item.Noisinh, item.BirthDay.ToShortDateString(), item.Sbd, item.Diachibaotin, item.Diachithi, item.Phongthi, item.Ngaythi.ToShortDateString(), item.Tien);
            }
        }
        void Decentralization()
        {
            if (Const1.AcountType == false)
            {
                btnThem.Enabled = false;
            }
        }
        private void FormBaoThidtgv_Load(object sender, EventArgs e)
        {
            Decentralization();
            LoadListBaoThi();
        }

        private void dtgvBaoDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index < 0 || index >= ListBaoThi.Instance.ListBaoPhongThi.Count)
                return;
            Const1.NewBaoThi = new BaoThi();
            Const1.NewBaoThi.Name = ListBaoThi.Instance.ListBaoPhongThi[index].Name;
            Const1.NewBaoThi.Noisinh = ListBaoThi.Instance.ListBaoPhongThi[index].Noisinh;
            Const1.NewBaoThi.BirthDay = ListBaoThi.Instance.ListBaoPhongThi[index].BirthDay;
            Const1.NewBaoThi.Sbd = ListBaoThi.Instance.ListBaoPhongThi[index].Sbd;
            Const1.NewBaoThi.Diachibaotin = ListBaoThi.Instance.ListBaoPhongThi[index].Diachibaotin;
            Const1.NewBaoThi.Diachithi = ListBaoThi.Instance.ListBaoPhongThi[index].Diachithi;
            Const1.NewBaoThi.Phongthi = ListBaoThi.Instance.ListBaoPhongThi[index].Phongthi; 
            Const1.NewBaoThi.Ngaythi = ListBaoThi.Instance.ListBaoPhongThi[index].Ngaythi;
            Const1.NewBaoThi.Tien = ListBaoThi.Instance.ListBaoPhongThi[index].Tien;
       

        }

        private void dtgvBaoDiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FormBaoThi f = new FormBaoThi();
            f.FormClosed += F_FormClosed;
            f.ShowDialog();
        }

        private void F_FormClosed(object sender, FormClosedEventArgs e)
        {
            ListBaoThi.Instance.ListBaoPhongThi.Add(Const1.NewBaoThi);
            LoadListBaoThi();
        }
    }
}

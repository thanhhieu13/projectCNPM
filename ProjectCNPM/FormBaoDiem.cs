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
    
    public partial class FormBaoDiem : Form
    {
        int index = -1;
        public FormBaoDiem()
        {
            InitializeComponent();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            FormShowDiem f = new FormShowDiem();
            f.ShowDialog();
        }
        void LoadListDiem()
        {
            foreach (var item in ListDiem.Instance.ListDiemThi)
            {
                dtgvDiem.Rows.Add(item.Sbd, item.Mon1, item.Diem1, item.Mon2, item.Diem2, item.Mon3, item.Diem3, item.Diemuutien);
            }
        }
        void Decentralization()
        {
            if (Const1.AcountType == false)
            {
                btnThem.Enabled = false;
            }
        }
        public void FormBaoDiem_Load(object sender, EventArgs e)
        {
            Decentralization();
            LoadListDiem();
        }

        private void txbSBD_TextChanged(object sender, EventArgs e)
        {
            string search = txbSBD.Text;
            List<Diem> ListSearch = new List<Diem>();
            foreach (var i in ListDiem.Instance.ListDiemThi)
            {
                if (i.Sbd.Contains(search))
                {
                    ListSearch.Add(i);
                }
            }
            dtgvDiem.DataSource = ListSearch;
        }

        public void dtgvDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index < 0 || index >= ListDiem.Instance.ListDiemThi.Count)
                return;
            Const1.Newdiem = new Diem();
            Const1.Newdiem.Sbd = ListDiem.Instance.ListDiemThi[index].Sbd;
            Const1.Newdiem.Mon1 = ListDiem.Instance.ListDiemThi[index].Mon1;
            Const1.Newdiem.Diem1 = ListDiem.Instance.ListDiemThi[index].Diem1;
            Const1.Newdiem.Mon2 = ListDiem.Instance.ListDiemThi[index].Mon2;
            Const1.Newdiem.Diem2 = ListDiem.Instance.ListDiemThi[index].Diem2;
            Const1.Newdiem.Mon3 = ListDiem.Instance.ListDiemThi[index].Mon3;
            Const1.Newdiem.Diem3 = ListDiem.Instance.ListDiemThi[index].Diem3;
            Const1.Newdiem.Diemuutien = ListDiem.Instance.ListDiemThi[index].Diemuutien;
           
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            FormDiem f = new FormDiem();
            f.FormClosed += F_FormClosed;
            f.ShowDialog();
        }

        private void F_FormClosed(object sender, FormClosedEventArgs e)
        {
            ListDiem.Instance.ListDiemThi.Add(Const1.Newdiem);
            LoadListDiem();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

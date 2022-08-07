using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
namespace ProjectCNPM
{
    

    public partial class FormMain : Form
    {
        int index = -1;
        public bool isExit = true;

        public event EventHandler Logout;
        public FormMain()
        {
            InitializeComponent();
        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged_2(object sender, EventArgs e)
        {

        }


        void Decentralization()
        {
            if (Const1.AcountType == false)
            {
                tsmiUser.Enabled = tsmiHoSo.Enabled = tsmiDiem.Enabled = tsmiDanhMuc.Enabled = tsmiPhongThi.Enabled=tsmiBaoThi.Enabled= false;
            }
        }
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isExit)
            {
                if (MessageBox.Show("ban muon thoat chuong trinh", "canh bao", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    e.Cancel = true;
            }
                
        }
        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {   if(isExit)
                Application.Exit();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logout(this, new EventArgs());
        }

        void LoadListSinhVien()
        {
            dtgvStudent.Rows.Clear();

            foreach (var item in ListSinhVien.Instance.ListSinhVienn)
            {
                dtgvStudent.Rows.Add(item.Sbd, item.Name, item.BirthDay.ToShortDateString(), item.Sex,item.Mahoso, item.Dtut,item.Truong,item.Matruong, item.Nganh,item.Manganh,item.Hokhau,item.Cmnd,item.Sdt,item.Dantoc);
            }
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            btnAdd.Enabled = btnEdit.Enabled = btnDelete.Enabled = false;
            
            Decentralization();

            LoadListSinhVien();

        }

        private void btnAdd_cliclk(object sender, EventArgs e)
        {
            Const1.NewSinhVien = null;
            AddStudent f = new AddStudent();
            f.FormClosed += F_FormClosed;
            f.ShowDialog();
        }

        private void F_FormClosed(object sender, FormClosedEventArgs e)
        {
            ListSinhVien.Instance.ListSinhVienn.Add(Const1.NewSinhVien);
            LoadListSinhVien();
        }

        private void btnEdit_click(object sender, EventArgs e)
        {

            if(index < 0 || index >= ListSinhVien.Instance.ListSinhVienn.Count)
            {
                MessageBox.Show("hãy chọn 1 bản ghi");
                return;
            }
            FormEditSinhVien f = new FormEditSinhVien();
            f.FormClosed += F_FormClosed1;
            f.ShowDialog();
        }

        private void F_FormClosed1(object sender, FormClosedEventArgs e)
        {
            ListSinhVien.Instance.ListSinhVienn[index].Name = Const1.NewSinhVien.Name;
            ListSinhVien.Instance.ListSinhVienn[index].BirthDay = Const1.NewSinhVien.BirthDay;
            ListSinhVien.Instance.ListSinhVienn[index].Sex = Const1.NewSinhVien.Sex;
            ListSinhVien.Instance.ListSinhVienn[index].Sbd = Const1.NewSinhVien.Sbd;


            ListSinhVien.Instance.ListSinhVienn[index].Mahoso = Const1.NewSinhVien.Mahoso;
            ListSinhVien.Instance.ListSinhVienn[index].Dtut = Const1.NewSinhVien.Dtut;
            ListSinhVien.Instance.ListSinhVienn[index].Truong = Const1.NewSinhVien.Truong;
            ListSinhVien.Instance.ListSinhVienn[index].Matruong = Const1.NewSinhVien.Matruong;
            ListSinhVien.Instance.ListSinhVienn[index].Nganh = Const1.NewSinhVien.Nganh;
            ListSinhVien.Instance.ListSinhVienn[index].Manganh = Const1.NewSinhVien.Manganh;
            ListSinhVien.Instance.ListSinhVienn[index].Hokhau = Const1.NewSinhVien.Hokhau;
            ListSinhVien.Instance.ListSinhVienn[index].Cmnd = Const1.NewSinhVien.Cmnd;
            ListSinhVien.Instance.ListSinhVienn[index].Sdt = Const1.NewSinhVien.Sdt;
            ListSinhVien.Instance.ListSinhVienn[index].Dantoc = Const1.NewSinhVien.Dantoc;
            
            LoadListSinhVien();
        }

        private void btnDelete_click(object sender, EventArgs e)
        {
            if (index < 0 || index >= ListSinhVien.Instance.ListSinhVienn.Count)
            {
                MessageBox.Show("hãy chọn 1 bản ghi");
                return;
            }
            ListSinhVien.Instance.ListSinhVienn.RemoveAt(index);
            LoadListSinhVien();

            //dtgvStudent.Rows[index].Cells[0].Value = Const1.NewSinhVien.Sbd;
            //dtgvStudent.Rows[index].Cells[1].Value = Const1.NewSinhVien.Name;
            //dtgvStudent.Rows[index].Cells[2].Value = Const1.NewSinhVien.BirthDay.ToShortDateString();
            //dtgvStudent.Rows[index].Cells[3].Value = Const1.NewSinhVien.Sex;

        }

        private void btnSave_click(object sender, EventArgs e)
        {

        }

        private void btnCancel_click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_click(object sender, EventArgs e)
        {

        }

        private void quảnLýĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            FormBaoDiem f = new FormBaoDiem();
            
            f.Show();
        }
        
        private void F_FormClosed2(object sender, FormClosedEventArgs e)
        {
          

        }

        private void tsmiHoSo_Click(object sender, EventArgs e)
        {
            btnShow.Enabled = btnAdd.Enabled = btnEdit.Enabled = btnDelete.Enabled = true;

        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Const1.AcountType == false)
                MessageBox.Show("Bạn không phải là admin", "Cảnh báo");
           
        }

        private void tsmiUser_Click(object sender, EventArgs e)
        {
            FormUsers f = new FormUsers();
            f.ShowDialog();
        }

        private void phiếuĐăngKíDựThiToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void phòngThiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPhongThi f = new FormPhongThi();
            f.ShowDialog();
        }

        private void tsmiDanhMuc_Click(object sender, EventArgs e)
        {

            FormsQLDM f = new FormsQLDM();
            f.ShowDialog();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dtgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (index < 0 || index >= ListSinhVien.Instance.ListSinhVienn.Count)
            {
                MessageBox.Show("hãy chọn 1 bản ghi");
                return;
            }
            FormShowInfoSinhVien f = new FormShowInfoSinhVien();
            f.ShowDialog();
        }

        private void dtgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index < 0 || index >= ListSinhVien.Instance.ListSinhVienn.Count)
                return;
            Const1.NewSinhVien = new SinhVien();
            Const1.NewSinhVien.Sbd = ListSinhVien.Instance.ListSinhVienn[index].Sbd;
            Const1.NewSinhVien.Name = ListSinhVien.Instance.ListSinhVienn[index].Name;
            Const1.NewSinhVien.BirthDay = ListSinhVien.Instance.ListSinhVienn[index].BirthDay;
            Const1.NewSinhVien.Sex = ListSinhVien.Instance.ListSinhVienn[index].Sex;

            Const1.NewSinhVien.Hokhau = ListSinhVien.Instance.ListSinhVienn[index].Hokhau;
            Const1.NewSinhVien.Dtut = ListSinhVien.Instance.ListSinhVienn[index].Dtut;
            Const1.NewSinhVien.Truong = ListSinhVien.Instance.ListSinhVienn[index].Truong;
            Const1.NewSinhVien.Matruong = ListSinhVien.Instance.ListSinhVienn[index].Matruong;
            Const1.NewSinhVien.Nganh = ListSinhVien.Instance.ListSinhVienn[index].Nganh;
            Const1.NewSinhVien.Manganh = ListSinhVien.Instance.ListSinhVienn[index].Manganh;
            Const1.NewSinhVien.Hokhau = ListSinhVien.Instance.ListSinhVienn[index].Hokhau;
            Const1.NewSinhVien.Cmnd = ListSinhVien.Instance.ListSinhVienn[index].Cmnd;
            
            Const1.NewSinhVien.Sdt = ListSinhVien.Instance.ListSinhVienn[index].Sdt;
            Const1.NewSinhVien.Dantoc = ListSinhVien.Instance.ListSinhVienn[index].Dantoc;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tsmiBaoThi_Click(object sender, EventArgs e)
        {
            FormBaoThidtgv f = new FormBaoThidtgv();
            f.ShowDialog();
        }

        private void phiếuĐăngKíDựThiToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormDangki f = new FormDangki();
            f.ShowDialog();
        }

        private void phiếuBáoĐiểmToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormBaoThidtgv f = new FormBaoThidtgv();
            f.ShowDialog();
        }

        private void phiếuBáoĐiểmToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormBaoDiem f = new FormBaoDiem();
            f.ShowDialog();
        }

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHelp f = new FormHelp();
            f.ShowDialog();
        }

        private void txbSBD_TextChanged(object sender, EventArgs e)
        {
            string search = txbSBD.Text;
            List<SinhVien> ListSearch = new List<SinhVien>();
            foreach(var i in ListSinhVien.Instance.ListSinhVienn)
            {
                if (i.Sbd.Contains(search))
                {
                    ListSearch.Add(i);
                }
            }
            dtgvStudent.DataSource = ListSearch;
        }

        private void txbSBD_TextChanged_1(object sender, EventArgs e)
        {
            string search = txbSBD.Text;
            List<SinhVien> ListSearch = new List<SinhVien>();
            foreach (var i in ListSinhVien.Instance.ListSinhVienn)
            {
                if (i.Sbd.Contains(search))
                {
                    ListSearch.Add(i);
                }
            }
            dtgvStudent.DataSource = ListSearch;
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

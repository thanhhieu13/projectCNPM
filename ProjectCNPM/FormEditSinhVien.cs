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
    public partial class FormEditSinhVien : Form
    {
        public FormEditSinhVien()
        {
            InitializeComponent();
        }
        void LoadInfo()
        {
            txbSbd.Text = Const1.NewSinhVien.Sbd;
            txbName.Text = Const1.NewSinhVien.Name;
            cboSex.Text = Const1.NewSinhVien.Sex;
            dtpkBirthDay.Value = Const1.NewSinhVien.BirthDay;
            txbMaHoSo.Text = Const1.NewSinhVien.Mahoso;
            txbDtut.Text = Const1.NewSinhVien.Dtut;
            txbTruong.Text = Const1.NewSinhVien.Truong;
            txbMaTruong.Text = Const1.NewSinhVien.Matruong;
            txbNganh.Text = Const1.NewSinhVien.Nganh;
            txbMaNganh.Text = Const1.NewSinhVien.Manganh;
            txbHoKhau.Text = Const1.NewSinhVien.Hokhau;
            txbCmnd.Text = Const1.NewSinhVien.Cmnd;
            txbDanToc.Text = Const1.NewSinhVien.Dantoc;
            txbSdt.Text = Const1.NewSinhVien.Sdt;

        }

        private void FormEditSinhVien_Load(object sender, EventArgs e)
        {
            cboSex.DataSource = Const1.ListSex;

            LoadInfo();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string name = txbName.Text;
            DateTime birthDay = dtpkBirthDay.Value;
            string sex = cboSex.Text;
            string sbd = txbSbd.Text;
            string mahoso = txbMaHoSo.Text;
            string dtut = txbDtut.Text;
            string truong = txbTruong.Text;
            string matruong = txbMaTruong.Text;
            string nganh = txbNganh.Text;
            string manganh = txbMaNganh.Text;
            string hokhau = txbHoKhau.Text;
            string cmnd = txbCmnd.Text;
            string dantoc = txbDanToc.Text;
            string sdt = txbSdt.Text;

            Const1.NewSinhVien = new SinhVien(sbd, name, birthDay, sex, mahoso, dtut, truong, matruong, nganh, manganh, hokhau, cmnd, dantoc, sdt);
            this.Close();
        }

        private void cboSex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

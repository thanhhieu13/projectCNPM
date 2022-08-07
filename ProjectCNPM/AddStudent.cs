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
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void AddStudent_Load(object sender, EventArgs e)
        {
            cboSex.DataSource = Const1.ListSex;
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string name = txbName.Text;
            DateTime birthDay = dtpkBirth.Value;
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

            Const1.NewSinhVien = new SinhVien(sbd, name, birthDay, sex, mahoso,dtut,truong,matruong,nganh,manganh,hokhau,cmnd,dantoc,sdt);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cboSex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

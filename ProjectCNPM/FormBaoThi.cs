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
    public partial class FormBaoThi : Form
    {
        public FormBaoThi()
        {
            InitializeComponent();
        }

        private void FormBaoThi_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txbName.Text;
            string noisinh = txbNoiSinh.Text;
            DateTime birth = dtpkBirth.Value;
            string sbd = txbSbd.Text;
            string diachibaotin = txbDiaChiBaoTin.Text;
            string diachithi = txbDiaChiThi.Text;
            string phongthi = txbPhongThi.Text;
            DateTime ngaythi = dtpkNgayThi.Value;
            string tien = txbTien.Text;


            Const1.NewBaoThi = new BaoThi(name, noisinh, birth, sbd, diachibaotin, diachithi, phongthi, ngaythi,tien);
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class FormShowBaoThi : Form
    {
        public FormShowBaoThi()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        void LoadInfo()
        {
            txbName.Text = Const1.NewBaoThi.Name;
            txbNoiSinh.Text = Const1.NewBaoThi.Noisinh;
            dtpkBirth.Value = Const1.NewBaoThi.BirthDay;
            txbSbd.Text = Const1.NewBaoThi.Sbd;
            txbDiaChiBaoTin.Text = Const1.NewBaoThi.Diachibaotin;
            txbDiaChiThi.Text = Const1.NewBaoThi.Diachithi;
            txbPhongThi.Text = Const1.NewBaoThi.Phongthi;
            dtpkNgayThi.Value = Const1.NewBaoThi.Ngaythi;
            txbTien.Text = Const1.NewBaoThi.Tien;
            


        }
        private void FormShowBaoThi_Load(object sender, EventArgs e)
        {
            LoadInfo();
        }
    }
}

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
    public partial class FormShowInfoSinhVien : Form
    {
        public FormShowInfoSinhVien()
        {
            InitializeComponent();
        }
        void LoadInfo()
        {
            txbSbd.Text = Const1.NewSinhVien.Sbd;
            txbName.Text = Const1.NewSinhVien.Name;
            txbSex.Text = Const1.NewSinhVien.Sex;
            dtpkBirthDay.Value = Const1.NewSinhVien.BirthDay;

            txbDtut.Text = Const1.NewSinhVien.Dtut;
            txbTruong.Text = Const1.NewSinhVien.Truong;
            txbMatruong.Text = Const1.NewSinhVien.Matruong;
            txbNganh.Text = Const1.NewSinhVien.Nganh;
            txbManganh.Text = Const1.NewSinhVien.Manganh;
            txbHokhau.Text = Const1.NewSinhVien.Hokhau;
            txbCmnd.Text = Const1.NewSinhVien.Cmnd;
            txbDantoc.Text = Const1.NewSinhVien.Dantoc;
            txbSdt.Text = Const1.NewSinhVien.Sdt;

        }
        private void FormShowInfoSinhVien_Load(object sender, EventArgs e)
        {
            LoadInfo();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbSex_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class FormShowDiem : Form
    {
        public FormShowDiem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void LoadInfo()
        {
            txbSbd.Text = Const1.Newdiem.Sbd;
            txbMon1.Text = Const1.Newdiem.Mon1;
            txbDiem1.Text = Const1.Newdiem.Diem1;
            txbMon2.Text = Const1.Newdiem.Mon2;
            txbDiem2.Text = Const1.Newdiem.Diem2;
            txbMon3.Text = Const1.Newdiem.Mon3;
            txbDiem3.Text = Const1.Newdiem.Diem3;
            txbDiemuutien.Text = Const1.Newdiem.Diemuutien;
           

        }
        private void FormShowDiem_Load(object sender, EventArgs e)
        {
            LoadInfo();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

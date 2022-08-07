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
    public partial class FormDiem : Form
    {
        public FormDiem()
        {
            InitializeComponent();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sbd = txbSbd.Text;
            string mon1 = txbMon1.Text;
            string diem1 = txbDiem1.Text;
            string mon2 = txbMon2.Text;
            string diem2 = txbDiem2.Text;
            string mon3 = txbMon3.Text;
            string diem3 = txbDiem3.Text;
            string diemuutien = txbDiemuutien.Text;
           

            Const1.Newdiem = new Diem(sbd, mon1, diem1, mon2, diem2, mon3, diem3, diemuutien);
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FormDiem_Load(object sender, EventArgs e)
        {

        }
    }
}

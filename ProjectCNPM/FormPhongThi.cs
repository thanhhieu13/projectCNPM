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
    public partial class FormPhongThi : Form
    {
        int index = -1;
        public FormPhongThi()
        {
            InitializeComponent();
        }

        private void FormPhongThi_Load(object sender, EventArgs e)
        {
            LoadListPhongThi();

        }

        private void lbPhongThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = lbPhongThi.SelectedIndex;
            if (index < 0)
                return;
            txbPhongThi.Text = ListPhongThi.Instance.ListPhongThis[index].Name;
        }

        void LoadListPhongThi()
        {
            lbPhongThi.DataSource = null;
            lbPhongThi.DataSource = ListPhongThi.Instance.ListPhongThis;
            lbPhongThi.DisplayMember = "Name";
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string PhongThiName = txbPhongThi.Text;
            ListPhongThi.Instance.ListPhongThis.Add(new PhongThi(PhongThiName));
            LoadListPhongThi();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string PhongThiName = txbPhongThi.Text;
            ListPhongThi.Instance.ListPhongThis[index].Name = PhongThiName;
            LoadListPhongThi();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ListPhongThi.Instance.ListPhongThis.RemoveAt(index);
            LoadListPhongThi();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

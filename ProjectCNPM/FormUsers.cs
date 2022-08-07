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
    
    public partial class FormUsers : Form
    {
        List<string> listAccountType = new List<string>() { "Admin", "User" };
        int index = -1;
        public FormUsers()
        {
            InitializeComponent();
        }

        void LoadListUser()
        {
            dtgvUser.DataSource = null;
            
            dtgvUser.DataSource = ListUser.Instance.ListAccountUser;
            dtgvUser.Refresh();
        }
        private void FormUsers_Load(object sender, EventArgs e)
        {
            cboStaff.DataSource = listAccountType;
            LoadListUser();
        }

        private void dtgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index < 0)
            {
               
                return;
            }    
                
            
            txbUserName.Text = dtgvUser.Rows[index].Cells[0].Value.ToString();
            
            txbPassWord.Text = dtgvUser.Rows[index].Cells[1].Value.ToString();

            switch (ListUser.Instance.ListAccountUser[index].AccountType)
            {
                case true: cboStaff.Text = "Admin";
                    break;
                case false:
                    cboStaff.Text = "User";
                   break;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            string passWord = txbPassWord.Text;
            bool accountType= false;
            switch (cboStaff.Text)
            {
                case "Admin":
                    accountType = true;
                    break;
                case "User":
                    accountType = false;
                    break;
            }
            ListUser.Instance.ListAccountUser.Add(new User(userName, passWord, accountType));
            LoadListUser();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (index < 0)
            {
                MessageBox.Show("vui lòng không để trống textbox");
                return;
            }
            string userName = txbUserName.Text;
            string passWord = txbPassWord.Text;
            bool accountType = false;
            switch (cboStaff.Text)
            {
                case "Admin":
                    accountType = true;
                    break;
                case "User":
                    accountType = false;
                    break;
            }
            ListUser.Instance.ListAccountUser[index].UserName = userName;
            ListUser.Instance.ListAccountUser[index].PassWord = passWord;
            ListUser.Instance.ListAccountUser[index].AccountType = accountType;
            LoadListUser();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (index < 0)
            {
                MessageBox.Show("vui lòng không để trống textbox");
                return;
            }
            ListUser.Instance.ListAccountUser.RemoveAt(index);
            LoadListUser();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

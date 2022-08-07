using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace ProjectCNPM
{
    public partial class FormLogin : System.Windows.Forms.Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        bool CheckLogin(string userName, string passWord)
        {
            for(int i=0; i < ListUser.Instance.ListAccountUser.Count; i++)
            {
                if (userName == ListUser.Instance.ListAccountUser[i].UserName && passWord == ListUser.Instance.ListAccountUser[i].PassWord)
                {
                    Const1.AcountType = ListUser.Instance.ListAccountUser[i].AccountType;
                    return true;
                }    
            }
            return false;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPassword.PasswordChar = (char)0;
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

       
       

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUsername.Text;
            string passWord = txtPassword.Text;
            if (CheckLogin(userName, passWord))
            {
                FormMain f = new FormMain();
                f.Show();
                this.Hide();
                f.Logout += F_Logout;
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu", "Lỗi", MessageBoxButtons.OK);
                txtUsername.Focus();
                return;
            }
        }
        private void F_Logout(object sender, EventArgs e)
        {
            (sender as FormMain).isExit = false;
            (sender as FormMain).Close();
            this.Show();
        }


        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

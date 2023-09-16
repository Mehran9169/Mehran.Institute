using DataAccess;
using System;
using System.Windows.Forms;

namespace Mehran.Institute
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        //public string CurrentUserName 
        //{
        //    EmployeeRepository repo = new EmployeeRepository();
        //    return repo.GetCurrentUser(txtUsername.Text, txtPassword.Text);
        //}

        private void btnLogin_Click(object sender, EventArgs e)
        {
            EmployeeRepository repo = new EmployeeRepository();

            if (repo.Validate(txtUsername.Text, txtPassword.Text))
            {
                frmSwitchBoard frm = new frmSwitchBoard(txtUsername.Text);
                frm.Show();
                Program.SwitchMainForm(frm);
                this.Hide();
            }
            else
            {
                MessageBox.Show("نام کاربری یا کلمه عبور اشتباه است");
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged_1(object sender, EventArgs e)
        {

        }

    }
}

using System;
using System.Windows.Forms;
using DataAccess;
using DomainModel.Models;

namespace Mehran.Institute
{
    public partial class frmRegistration : Form
    {
        private readonly StudentRepository stuRepo = new StudentRepository();
        public frmRegistration()
        {
            InitializeComponent();
        }
        private void search()
        {
            Student sm = new Student();
            if (txtFirstName.Text.Length > 0)
            {
                sm.FirstName = txtFirstName.Text;
            }
            if (txtLastName.Text.Length > 0)
            {
                sm.LastName = txtLastName.Text;
            }
            if (txtNationalCode.Text.Length > 0)
            {
                sm.NationalCode = txtNationalCode.Text;
            }
            if (txtMobile.Text.Length > 0)
            {
                sm.Mobile = txtMobile.Text;
            }
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = stuRepo.Search(sm);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            search();
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            search();
        }

        private void txtNationalCode_TextChanged(object sender, EventArgs e)
        {
            search();
        }

        private void txtMobile_TextChanged(object sender, EventArgs e)
        {
            search();
        }
    }
}

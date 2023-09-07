using DataAccess;
using DomainModel.Models;
using System;
using System.Windows.Forms;

namespace Mehran.Institute
{
    public partial class frmEmployee : Form
    {
        EmployeeRepository empRep = new EmployeeRepository();
        int id = 0;
        public frmEmployee()
        {
            InitializeComponent();
            BindGrid();
            AddMode();
        }
        #region Utility
        public void BindGrid()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = empRep.GetAll();
        }
        public void ClearForm()
        {
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtMobile.Text = string.Empty;
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }
        public void EditMode()
        {
            btnAdd.Visible = false;
            btnUpdate.Visible = true;
            btnCancel.Visible = true;

        }
        public void AddMode()
        {
            btnAdd.Visible = true;
            btnUpdate.Visible = false;
            btnCancel.Visible = true;
        }
        #endregion

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            BindGrid();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.FirstName = txtFirstName.Text;
            emp.LastName = txtLastName.Text;
            emp.Mobile = txtMobile.Text;
            emp.UserName = txtUsername.Text;
            emp.Password = txtPassword.Text;
            empRep.Add(emp);
            BindGrid();
            ClearForm();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                if (MessageBox.Show("آیا از حذف رکورد انتخابی اطمینان دارید؟", "هشدار", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                    empRep.Delete(id);
                    BindGrid();
                    ClearForm();
                    AddMode();
                }
            }

            if (e.ColumnIndex == 6)
            {

                this.id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                var repo = new EmployeeRepository().GetById(id);
                txtFirstName.Text = repo.FirstName;
                txtLastName.Text = repo.LastName;
                txtMobile.Text = repo.Mobile;
                txtUsername.Text = repo.UserName;
                txtPassword.Text = repo.Password;

                repo.EmployeeID = id;
                EditMode();
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.EmployeeID = id;
            emp.FirstName = txtFirstName.Text;
            emp.LastName = txtLastName.Text;
            emp.Mobile = txtMobile.Text;
            emp.UserName = txtUsername.Text;
            emp.Password = txtPassword.Text;
            var message = empRep.Update(emp);
            ClearForm();
            BindGrid();
            EditMode();
            MessageBox.Show(message);
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            AddMode();
            ClearForm();
            BindGrid();
        }
    }
}

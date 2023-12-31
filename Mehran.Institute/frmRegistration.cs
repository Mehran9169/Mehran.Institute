﻿using System;
using System.Windows.Forms;
using DataAccess;
using DomainModel.Models;

namespace Mehran.Institute
{
    public partial class frmRegistration : Form
    {
        private readonly StudentRepository stuRepo = new StudentRepository();
        private readonly EmployeeRepository empRepo = new EmployeeRepository();
        private readonly RegistrationRepository regRepo = new RegistrationRepository();
        private string CurrentUserName;
        int studentId = 0;
        int regId = 0;
        public frmRegistration(string cun)
        {
            InitializeComponent();
            this.CurrentUserName = cun;
            var userFullName = empRepo.GetCurrentUser(CurrentUserName);
            lblCurrentUserName.Text = userFullName;
            BindGrid();
            BindGridStudent();
        }

        #region Utility
        public void BindGrid()
        {
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.DataSource = regRepo.GetAll();
        }
        public void BindGridStudent()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = stuRepo.GetAll();
        }
        public void ClearForm()
        {
            lblCoursePreq.Text = string.Empty;
            lblCourseStatus.Text = string.Empty;
            lblCurrentUserName.Text = string.Empty;
            lblStudentFirstName.Text = string.Empty;
            lblStudentLastName.Text = string.Empty;
            lblStudentNationalCode.Text = string.Empty;
            txtDescription.Text = string.Empty;
            txtTuition.Text = string.Empty;
            cmbCourse.Text = string.Empty;
        }
        #endregion

        #region DataBinders
        private void BindCourse()
        {
            CourseRepository repo = new CourseRepository();
            cmbCourse.DisplayMember = "CourseName";
            cmbCourse.ValueMember = "CourseID";
            var courseItems = repo.GetAll();
            courseItems.Insert(0, new Course { CourseID = -1, CourseName = "انتخاب کنید..." });
            cmbCourse.DataSource = courseItems;
        }
        #endregion
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

            if (e.ColumnIndex == 5)
            {
                MessageBox.Show("دانشجوی مورد نظر انتخاب شد");
                this.studentId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                var student = stuRepo.GetById(studentId);
                lblStudentFirstName.Text = student.FirstName;
                lblStudentLastName.Text = student.LastName;
                lblStudentNationalCode.Text = student.NationalCode;
                BindCourse();
            }
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

        private void button2_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtMobile.Text = string.Empty;
            txtNationalCode.Text = string.Empty;
        }

        private void cmbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            CourseRepository courseRepo = new CourseRepository();
            int CourseID = Convert.ToInt32(cmbCourse.SelectedValue);
            if (!(CourseID == -1))
            {
                var courseList = courseRepo.GetById(CourseID);
                lblCourseStatus.Text = courseList.CourseStatusName;
                lblCoursePreq.Text = courseList.Preq;
                txtTuition.Text = courseList.Tuition.ToString();
            }
            else
            {
                MessageBox.Show("لطفا دوره ی مدنظر را انتخاب نمایید");
                lblCoursePreq.Text = string.Empty;
                lblCourseStatus.Text = string.Empty;
            }

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();
            reg.RegistrationDate = DateTime.Now;
            reg.CourseID = Convert.ToInt32(cmbCourse.SelectedValue);
            reg.StudentID = studentId;
            reg.EmployeeID = empRepo.GetCurrentUserID(CurrentUserName);
            reg.Tuition = Convert.ToInt32(txtTuition.Text);
            reg.Description = txtDescription.Text;
            // TODO : Change When Payment Implement
            // TODO : Pass To Payment Form
            reg.TotalPayment = 0;

            regRepo.Add(reg);
            MessageBox.Show("ثبت نام با موفقیت انجام شد.");
            BindGrid();
            ClearForm();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 9)
            {
                if (MessageBox.Show("آیا از حذف رکورد انتخابی اطمینان دارید؟", "هشدار", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.regId = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[0].Value);
                    regRepo.Delete(regId);
                    //BindCourse();
                    BindGrid();
                }
            }
            if (e.ColumnIndex == 8)
            {
                this.regId = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[0].Value);
                frmPayment frm = new frmPayment(this.CurrentUserName , regId);
                frm.Show();
            }
        }

        private void frmRegistration_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void groupBox2_ParentChanged(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void groupBox2_MouseHover(object sender, EventArgs e)
        {
            BindGrid();
        }
    }
}

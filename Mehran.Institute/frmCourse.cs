using DataAccess;
using DomainModel.Models;
using FrameWork;
using System;
using System.Windows.Forms;

namespace Mehran.Institute
{
    public partial class frmCourse : Form
    {
        CourseRepository corRepo = new CourseRepository();
        int id = 0;
        public frmCourse()
        {
            InitializeComponent();
            BindGrid();
            AddMode();
        }

        #region Utility
        public void BindGrid()
        {
            dataGridView1.AutoGenerateColumns = false;
            var dtSource = corRepo.GetAll();
            dataGridView1.DataSource = dtSource;
        }
        public void ClearForm()
        {
            txtCourseName.Text = string.Empty;
            txtTution.Text = string.Empty;
            cmbTeacher.Text = string.Empty;
            cmbCourseStatus.Text = string.Empty;
            txtPreq.Text = string.Empty;
            cmbTerm.Text = string.Empty;
            txtCourseContent.Text = string.Empty;
            numHours.Value = 0;
            txtRuningTime.Text = string.Empty;
            dpStartDate.Text = string.Empty;
            dpEndDate.Text = string.Empty;
            BindTeachers();
            BindCourseStatus();
            BindTerms();
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

        #region DataBinders
        private void BindTeachers()
        {
            DataAccess.TeacherRepository repo = new DataAccess.TeacherRepository();
            cmbTeacher.DisplayMember = "FullInfo";
            cmbTeacher.ValueMember = "TeacherID";
            var teacher = repo.GetTeacherListDropDown();
            teacher.Insert(0, new TeachersListItem { TeacherID = -1, FullInfo = "انتخاب کنید..." });
            cmbTeacher.DataSource = teacher;
        }

        private void BindCourseStatus()
        {
            DataAccess.CourseStatusRepository repo = new DataAccess.CourseStatusRepository();
            cmbCourseStatus.DisplayMember = "CourseStatusName";
            cmbCourseStatus.ValueMember = "CourseStatusID";
            var courseStatus = repo.GetAll();
            courseStatus.Insert(0, new CourseStatus { CourseStatusID = -1, CourseStatusName = "انتخاب کنید..." });
            cmbCourseStatus.DataSource = courseStatus;
        }

        private void BindTerms()
        {
            DataAccess.TermRepository repo = new DataAccess.TermRepository();
            cmbTerm.DisplayMember = "TermName";
            cmbTerm.ValueMember = "TermID";
            var termItems = repo.GetAll();
            termItems.Insert(0, new Term { TermID = -1, TermName = "انتخاب کنید..." });
            cmbTerm.DataSource = termItems;
        }


        #endregion

        private void frmCourse_Load(object sender, EventArgs e)
        {
            BindGrid();
            BindTeachers();
            BindCourseStatus();
            BindTerms();
            cmbTeacher.SelectedIndexChanged += cmbTeacher_SelectedIndexChanged;
            cmbCourseStatus.SelectedIndexChanged += cmbCourseStatus_SelectedIndexChanged;
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbCourseStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            CourseStatusRepository courseRepo = new CourseStatusRepository();
            int courseStatusID = Convert.ToInt32(cmbCourseStatus.SelectedValue);
            var courseStatusList = courseRepo.GetById(courseStatusID);

        }

        private void cmbTeacher_SelectedIndexChanged(object sender, EventArgs e)
        {

            TeacherRepository tchRepo = new TeacherRepository();
            int teacherID = Convert.ToInt32(cmbTeacher.SelectedValue);
            var teacherList = tchRepo.GetById(teacherID);
        }

        private void cmbTerm_SelectedIndexChanged(object sender, EventArgs e)
        {
            TermRepository trmRepo = new TermRepository();
            int termID = Convert.ToInt32(cmbTerm.SelectedValue);
            var termList = trmRepo.GetById(termID);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtCourseName.Text == string.Empty || txtTution.Text == string.Empty || Convert.ToInt32(cmbTeacher.SelectedValue) == -1 || dpStartDate.Value == null || Convert.ToInt32(cmbTerm.SelectedValue) == -1 || Convert.ToInt32(cmbCourseStatus.SelectedValue) == -1
                || cmbTeacher.SelectedValue is null || cmbTerm.SelectedValue is null || cmbCourseStatus.SelectedValue is null)
            {
                MessageBox.Show("فیلد های اجباری نمی توانند خالی باشند");
            }
            else
            {
                Course cor = new Course();
                cor.CourseName = txtCourseName.Text;
                cor.Tuition = (txtTution.Text == string.Empty ? 0 : Convert.ToInt32(txtTution.Text));
                cor.TeacherID = Convert.ToInt32(cmbTeacher.SelectedValue);
                cor.CourseStatusID = Convert.ToInt32(cmbCourseStatus.SelectedValue);
                cor.Preq = txtPreq.Text;
                cor.TermID = Convert.ToInt32(cmbTerm.SelectedValue);
                cor.CourseContent = txtCourseContent.Text;
                cor.Hours = (int)numHours.Value;
                cor.RuningTime = txtRuningTime.Text;
                cor.StartDate = DateHelper.ToGeorgianDateTime(dpStartDate.Text);
                cor.EndDate = DateHelper.ToGeorgianDateTimeNullable(dpEndDate.Text);

                corRepo.Add(cor);
                BindGrid();
                ClearForm();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 13)
            {
                if (MessageBox.Show("آیا از حذف رکورد انتخابی اطمینان دارید؟", "هشدار", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                    corRepo.Delete(id);
                    BindGrid();
                    ClearForm();
                    AddMode();
                }
            }

            if (e.ColumnIndex == 12)
            {
                BindTeachers();
                BindCourseStatus();
                BindTerms();

                this.id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                var repo = new CourseRepository().GetById(id);
                txtCourseName.Text = repo.CourseName;
                txtTution.Text = repo.Tuition.ToString();
                cmbTeacher.SelectedValue = repo.TeacherID;
                cmbCourseStatus.SelectedValue = repo.CourseStatusID;
                txtPreq.Text = repo.Preq;
                cmbTerm.SelectedValue = repo.TermID;
                txtCourseContent.Text = repo.CourseContent;
                numHours.Text = repo.Hours.ToString();
                txtRuningTime.Text = repo.RuningTime;
                dpStartDate.Value = repo.StartDate;
                dpEndDate.Value = repo.EndDate;

                repo.CourseID = id;
                EditMode();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            AddMode();
            ClearForm();
            BindGrid();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Course cor = new Course();
            cor.CourseID = id;
            cor.CourseName = txtCourseName.Text;
            cor.Tuition = Convert.ToInt32(txtTution.Text);
            cor.TeacherID = Convert.ToInt32(cmbTeacher.SelectedValue);
            cor.CourseStatusID = Convert.ToInt32(cmbCourseStatus.SelectedValue);
            cor.Preq = txtPreq.Text;
            cor.TermID = Convert.ToInt32(cmbTerm.SelectedValue);
            cor.CourseContent = txtCourseContent.Text;
            cor.Hours = (int)numHours.Value;
            cor.RuningTime = txtRuningTime.Text;
            cor.StartDate = DateHelper.ToGeorgianDateTime(dpStartDate.Text);
            cor.EndDate = DateHelper.ToGeorgianDateTimeNullable(dpEndDate.Text);
            if (txtCourseName.Text == string.Empty || txtTution.Text == string.Empty || Convert.ToInt32(cmbTeacher.SelectedValue) == -1 || dpStartDate.Value == null || Convert.ToInt32(cmbTerm.SelectedValue) == -1 || Convert.ToInt32(cmbCourseStatus.SelectedValue) == -1
                || cmbTeacher.SelectedValue is null || cmbTerm.SelectedValue is null || cmbCourseStatus.SelectedValue is null)
                MessageBox.Show("فیلد های اجباری نمی توانند خالی باشند");
            else
            {
                var message = corRepo.Update(cor);
                ClearForm();
                BindGrid();
                AddMode();
                MessageBox.Show(message);
            };
        }
    }
}

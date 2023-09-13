using DataAccess;
using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mehran.Institute
{
    public partial class frmCourse : Form
    {
        public frmCourse()
        {
            InitializeComponent();
        }

        private void frmCourse_Load(object sender, EventArgs e)
        {
            BindTeachers();
            BindCourseStatus();
            cmbTeacher.SelectedIndexChanged += cmbTeacher_SelectedIndexChanged;
            cmbCourseStatus.SelectedIndexChanged += cmbCourseStatus_SelectedIndexChanged;
        }

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
    }
}

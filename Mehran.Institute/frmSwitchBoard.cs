using DataAccess;
using DomainModel.Models;
using System;
using System.Windows.Forms;
using FrameWork;

namespace Mehran.Institute
{
    public partial class frmSwitchBoard : Form
    {
        private string CurrentUserName;
        public frmSwitchBoard(string cun)
        {
            EmployeeRepository empRepo= new EmployeeRepository();
            this.CurrentUserName = cun;
            InitializeComponent();
            lblCurrentUser.Text = empRepo.GetCurrentUser(cun);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();

            lblDate.Text = DateHelper.GetPersianDate(DateTime.Now);
        }

        private void frmSwitchBoard_Load(object sender, EventArgs e)
        {

        }
        private void frmSwitchBoard_Close(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void مدیریتترمهاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool ExistInMyChildren = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm is frmTerm)
                {
                    ExistInMyChildren = true;
                    frm.Activate();
                }
            }
            if (!ExistInMyChildren)
            {
                frmTerm frmTerm = new frmTerm();
                frmTerm.MdiParent = this;
                frmTerm.Show();
            }
        }

        private void کارکنانToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool ExistInMyChildren = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm is frmEmployee)
                {
                    ExistInMyChildren = true;
                    frm.Activate();
                }
            }
            if (!ExistInMyChildren)
            {
                frmEmployee frmEmployee = new frmEmployee();
                frmEmployee.MdiParent = this;
                frmEmployee.Show();
            }

        }

        private void اساتیدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool ExistInMyChildren = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm is frmTeacher)
                {
                    ExistInMyChildren = true;
                    frm.Activate();
                }
            }
            if (!ExistInMyChildren)
            {
                frmTeacher frmTeacher = new frmTeacher();
                frmTeacher.MdiParent = this;
                frmTeacher.Show();
            }

        }

        private void مدیریتدورههاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool ExistInMyChildren = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm is frmCourse)
                {
                    ExistInMyChildren = true;
                    frm.Activate();
                }
            }
            if (!ExistInMyChildren)
            {
                frmCourse frmCourse = new frmCourse();
                frmCourse.MdiParent = this;
                frmCourse.Show();
            }

        }

        private void دانشجویانToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool ExistInMyChildren = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm is frmStudent)
                {
                    ExistInMyChildren = true;
                    frm.Activate();
                }
            }
            if (!ExistInMyChildren)
            {
                frmStudent frmStudent = new frmStudent();
                frmStudent.MdiParent = this;
                frmStudent.Show();
            }
        }

        private void ثبتنامToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool ExistInMyChildren = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm is frmRegistration)
                {
                    ExistInMyChildren = true;
                    frm.Activate();
                }
            }
            if (!ExistInMyChildren)
            {
                frmRegistration frmStudent = new frmRegistration(CurrentUserName);
                frmStudent.MdiParent = this;
                frmStudent.Show();
            }

        }

        private void مدیریتپرداختToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool ExistInMyChildren = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm is frmPayment)
                {
                    ExistInMyChildren = true;
                    frm.Activate();
                }
            }
            if (!ExistInMyChildren)
            {
                frmPayment frmPayment = new frmPayment(CurrentUserName,0);
                frmPayment.MdiParent = this;
                frmPayment.Show();
            }
        }

        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

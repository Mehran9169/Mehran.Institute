using System;
using System.Windows.Forms;

namespace Mehran.Institute
{
    public partial class frmSwitchBoard : Form
    {
        public frmSwitchBoard()
        {
            InitializeComponent();
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
    }
}

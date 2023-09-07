using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    
    }
}

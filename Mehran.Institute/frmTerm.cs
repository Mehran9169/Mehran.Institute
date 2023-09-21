using DataAccess;
using DomainModel.Models;
using System;
using System.Windows.Forms;

namespace Mehran.Institute
{
    public partial class frmTerm : Form
    {
        TermRepository termRep = new TermRepository();
        int id = 0;
        public frmTerm()
        {
            InitializeComponent();
            WindowState= FormWindowState.Normal;
            BindGrid();
            AddMode();
        }

        #region Utility
        public void BindGrid()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = termRep.GetAll();
        }
        public void ClearForm()
        {
            txtTermName.Text = string.Empty;
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


        private void frmTerm_Load(object sender, EventArgs e)
        {
            BindGrid();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            Term trm = new Term();
            trm.TermName = txtTermName.Text;
            termRep.Add(trm);
            BindGrid();
            ClearForm();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                if (MessageBox.Show("آیا از حذف رکورد انتخابی اطمینان دارید؟", "هشدار", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                    termRep.Delete(id);
                    BindGrid();
                    ClearForm();
                    AddMode();

                }
            }

            if (e.ColumnIndex == 2)
            {

                this.id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                var repo = new TermRepository().GetById(id);
                txtTermName.Text = repo.TermName;
                repo.TermID = id;
                EditMode();
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Term trm = new Term();
            trm.TermID = id;
            trm.TermName = txtTermName.Text;
            var message = termRep.Update(trm);
            ClearForm();
            BindGrid();
            AddMode();
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

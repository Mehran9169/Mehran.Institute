using DataAccess;
using DomainModel.Models;
using FrameWork;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
namespace Mehran.Institute
{
    public partial class frmTeacher : Form
    {
        TeacherRepository tchRep = new TeacherRepository();
        int id = 0;
        string pdfFile = string.Empty;
        string pictureFile = string.Empty;
        string installedPathPdf = Application.StartupPath + "/pdf";
        string installedPathPicture = Application.StartupPath + "/picture";

        public frmTeacher()
        {
            InitializeComponent();
            BindGrid();
            AddMode();
            axAcroPDF1.Hide();
        }

        #region Utility
        public void BindGrid()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = tchRep.GetAll();
        }
        public void ClearForm()
        {
            txtName.Text = string.Empty;
            txtResumeDescription.Text = string.Empty;
            txtMobile.Text = string.Empty;
            txtAbout.Text = string.Empty;
            pdfFile = string.Empty;
            pictureFile = string.Empty;
            axAcroPDF1.Hide();
            pictureBox1.Image = null;

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

        private void frmTeacher_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void btnPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.CheckFileExists = true;
            openFileDialog.AddExtension = true;
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = @"All Images Files(*.png; *.jpeg; *.gif; *.jpg; *.bmp; *.tiff; *.tif)| *.png; *.jpeg; *.gif; *.jpg; *.bmp; *.tiff; *.tif" +
            "|PNG Portable Network Graphics (*.png)|*.png" +
            "|JPEG File Interchange Format (*.jpg *.jpeg *jfif)|*.jpg;*.jpeg;*.jfif" +
            "|BMP Windows Bitmap (*.bmp)|*.bmp" +
            "|TIF Tagged Imaged File Format (*.tif *.tiff)|*.tif;*.tiff" +
            "|GIF Graphics Interchange Format (*.gif)|*.gif";

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pictureFile = openFileDialog.FileName;
                pictureBox1.Image = new Bitmap(openFileDialog.FileName);
            }

        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.CheckFileExists = true;
            openFileDialog.AddExtension = true;
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = "PDF files (*.pdf)|*.pdf";

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pdfFile = openFileDialog.FileName;
            }

            axAcroPDF1.src = pdfFile;
            axAcroPDF1.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Teacher tch = new Teacher();
            tch.TeacherName = txtName.Text;
            tch.Mobile = txtMobile.Text;
            tch.ResumeDescription = txtResumeDescription.Text;
            tch.AboutTeacher = txtAbout.Text;

            //PDF
            if (!System.IO.Directory.Exists(installedPathPdf))
            {
                System.IO.Directory.CreateDirectory(installedPathPdf);
            }
            if (!(pdfFile is null || pdfFile == string.Empty))
            {
                string pdfFileName = DateHelper.GetPersianDateTimeForFileName(DateTime.Now) + System.IO.Path.GetFileName(pdfFile);

                string destinationPdfFileName = System.IO.Path.Combine(installedPathPdf, pdfFileName);
                System.IO.File.Copy(pdfFile, destinationPdfFileName);

                tch.ResumeFile = $"{Application.StartupPath}\\pdf\\{pdfFileName}";
            }
            else tch.ResumeFile = null;

            //Picture
            if (!System.IO.Directory.Exists(installedPathPicture))
            {
                System.IO.Directory.CreateDirectory(installedPathPicture);
            }

            if (!(pictureFile is null || pictureFile == string.Empty))
            {
                string pictureFileName = DateHelper.GetPersianDateTimeForFileName(DateTime.Now) + System.IO.Path.GetFileName(pictureFile);

                string destinationPictureFileName = System.IO.Path.Combine(installedPathPicture, pictureFileName);
                System.IO.File.Copy(pictureFile, destinationPictureFileName);

                tch.Picture = $"{Application.StartupPath}\\picture\\{pictureFileName}";
            }
            else tch.Picture = null;

            tchRep.Add(tch);
            BindGrid();
            ClearForm();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8)
            {
                if (MessageBox.Show("آیا از حذف رکورد انتخابی اطمینان دارید؟", "هشدار", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                    tchRep.Delete(id);
                    BindGrid();
                    ClearForm();
                    AddMode();
                }
            }

            if (e.ColumnIndex == 7)
            {

                this.id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                var repo = new TeacherRepository().GetById(id);
                txtName.Text = repo.TeacherName;
                txtMobile.Text = repo.Mobile;
                txtAbout.Text = repo.AboutTeacher;
                txtResumeDescription.Text = repo.TeacherName;

                if (!(repo.Picture is null))
                    pictureBox1.Image = new Bitmap(repo.Picture);
                else
                    pictureBox1.Image = null;

                if (!(repo.ResumeFile is null))
                {
                    axAcroPDF1.Show();
                    axAcroPDF1.src = repo.ResumeFile;
                }
                else
                    axAcroPDF1.Hide();
                repo.TeacherID = id;
                EditMode();
            }

            if (e.ColumnIndex == 5)
            {
                this.id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                var repo = new TeacherRepository().GetById(id);
                Process.Start("iexplore.exe", repo.ResumeFile);

            }
            if (e.ColumnIndex == 6)
            {
                this.id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                var repo = new TeacherRepository().GetById(id);
                Process.Start("iexplore.exe", repo.Picture);
            }

        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Teacher tch = new Teacher();
            tch.TeacherID = this.id;
            tch.TeacherName = txtName.Text;
            tch.Mobile = txtMobile.Text;
            tch.ResumeDescription = txtResumeDescription.Text;
            tch.AboutTeacher = txtAbout.Text;

            //PDF
            if (!System.IO.Directory.Exists(installedPathPdf))
            {
                System.IO.Directory.CreateDirectory(installedPathPdf);
            }
            if (!(pdfFile is null || pdfFile == string.Empty))
            {
                string pdfFileName = DateHelper.GetPersianDateTimeForFileName(DateTime.Now) + System.IO.Path.GetFileName(pdfFile);

                string destinationPdfFileName = System.IO.Path.Combine(installedPathPdf, pdfFileName);
                System.IO.File.Copy(pdfFile, destinationPdfFileName);

                tch.ResumeFile = $"{Application.StartupPath}\\pdf\\{pdfFileName}";
            }
            else tch.ResumeFile = null;

            //Picture
            if (!System.IO.Directory.Exists(installedPathPicture))
            {
                System.IO.Directory.CreateDirectory(installedPathPicture);
            }

            if (!(pictureFile is null || pictureFile == string.Empty))
            {
                string pictureFileName = DateHelper.GetPersianDateTimeForFileName(DateTime.Now) + System.IO.Path.GetFileName(pictureFile);

                string destinationPictureFileName = System.IO.Path.Combine(installedPathPicture, pictureFileName);
                System.IO.File.Copy(pictureFile, destinationPictureFileName);

                tch.Picture = $"{Application.StartupPath}\\picture\\{pictureFileName}";
            }
            else tch.Picture = null;

            var message = tchRep.Update(tch);

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

        private void axAcroPDF1_Enter(object sender, EventArgs e)
        {

        }
    }
}

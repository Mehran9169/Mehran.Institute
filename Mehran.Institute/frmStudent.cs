using DataAccess;
using DomainModel.Models;
using System;
using System.Windows.Forms;

namespace Mehran.Institute
{
    public partial class frmStudent : Form
    {
        StudentRepository stuRepo = new StudentRepository();
        int id = 0;
        public frmStudent()
        {
            InitializeComponent();
            BindGrid();
            AddMode();
        }
        #region Utility
        public void BindGrid()
        {
            dataGridView1.AutoGenerateColumns = false;
            var dtSource = stuRepo.GetAll();
            dataGridView1.DataSource = dtSource;
        }
        public void ClearForm()
        {
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtMobile.Text = string.Empty;
            txtNationalCode.Text = string.Empty;
            txtAddress.Text = string.Empty;
            cmbCity.Text = string.Empty;
            cmbEducationDegree.Text = string.Empty;
            BindCity();
            BindEducationDegree();
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
        private void BindCity()
        {
            CityRepository repo = new CityRepository();
            cmbCity.DisplayMember = "CityName";
            cmbCity.ValueMember = "CityID";
            var cityItems = repo.GetAll();
            cityItems.Insert(0, new City { CityID = -1, CityName = "انتخاب کنید..." });
            cmbCity.DataSource = cityItems;
        }

        private void BindEducationDegree()
        {
            EducationDegreeRepository repo = new EducationDegreeRepository();
            cmbEducationDegree.DisplayMember = "EducationDegreeName";
            cmbEducationDegree.ValueMember = "EducationDegreeID";
            var educationDegreeItems = repo.GetAll();
            educationDegreeItems.Insert(0, new EducationDegree { EducationDegreeID = -1, EducationDegreeName = "انتخاب کنید..." });
            cmbEducationDegree.DataSource = educationDegreeItems;
        }
        #endregion

        private void frmStudent_Load(object sender, EventArgs e)
        {
            BindGrid();
            BindCity();
            BindEducationDegree();
            cmbCity.SelectedIndexChanged += cmbCity_SelectedIndexChanged;
            cmbEducationDegree.SelectedIndexChanged += cmbEducationDegree_SelectedIndexChanged;
        }

        private void cmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            CityRepository cityRepo = new CityRepository();
            int cityID = Convert.ToInt32(cmbCity.SelectedValue);
            var cityList = cityRepo.GetById(cityID);

        }

        private void cmbEducationDegree_SelectedIndexChanged(object sender, EventArgs e)
        {
            EducationDegreeRepository educationDegreeRepo = new EducationDegreeRepository();
            int educationDegreeID = Convert.ToInt32(cmbEducationDegree.SelectedValue);
            var educationDegreeList = educationDegreeRepo.GetById(educationDegreeID);
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text == string.Empty || txtLastName.Text == string.Empty || txtNationalCode.Text == string.Empty || Convert.ToInt32(cmbCity.SelectedValue) == -1 || Convert.ToInt32(cmbEducationDegree.SelectedValue) == -1
                || cmbCity.SelectedValue is null || cmbEducationDegree.SelectedValue is null)
            {
                MessageBox.Show("فیلد های اجباری نمی توانند خالی باشند");
            }
            else
            {
                Student stu = new Student();
                stu.FirstName = txtFirstName.Text;
                stu.LastName = txtLastName.Text;
                stu.NationalCode = txtNationalCode.Text;
                stu.Address = txtAddress.Text;
                stu.Mobile = txtMobile.Text;
                stu.CityID = Convert.ToInt32(cmbCity.SelectedValue);
                stu.EducationDegreeID = Convert.ToInt32(cmbEducationDegree.SelectedValue);

                stuRepo.Add(stu);
                ClearForm();
                BindGrid();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 9)
            {
                if (MessageBox.Show("آیا از حذف رکورد انتخابی اطمینان دارید؟", "هشدار", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                    stuRepo.Delete(id);
                    BindGrid();
                    ClearForm();
                    AddMode();
                }
            }

            if (e.ColumnIndex == 8)
            {
                BindCity();
                BindEducationDegree();
                this.id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                var repo = new StudentRepository().GetById(id);
                txtFirstName.Text = repo.FirstName;
                txtLastName.Text = repo.LastName;
                txtMobile.Text = repo.Mobile;
                txtAddress.Text = repo.Address;
                txtNationalCode.Text = repo.NationalCode;
                cmbCity.SelectedValue = repo.CityID;
                cmbEducationDegree.SelectedValue = repo.EducationDegreeID;

                repo.StudentID = id;
                EditMode();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Student stu = new Student();
            stu.StudentID = id;
            stu.FirstName = txtFirstName.Text;
            stu.LastName = txtLastName.Text;
            stu.NationalCode = txtNationalCode.Text;
            stu.Address = txtAddress.Text;
            stu.Mobile = txtMobile.Text;
            stu.CityID = Convert.ToInt32(cmbCity.SelectedValue);
            stu.EducationDegreeID = Convert.ToInt32(cmbEducationDegree.SelectedValue);

            if (txtFirstName.Text == string.Empty || txtLastName.Text == string.Empty || txtNationalCode.Text == string.Empty || Convert.ToInt32(cmbCity.SelectedValue) == -1 || Convert.ToInt32(cmbEducationDegree.SelectedValue) == -1
                || cmbCity.SelectedValue is null || cmbEducationDegree.SelectedValue is null)
            {
                MessageBox.Show("فیلد های اجباری نمی توانند خالی باشند");
            }
            else
            {
                var message = stuRepo.Update(stu);
                ClearForm();
                AddMode();
                MessageBox.Show(message);
                BindGrid();
            };
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            AddMode();
            ClearForm();
            BindGrid();
        }
    }
}

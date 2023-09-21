using DataAccess;
using DomainModel.Models;
using FrameWork;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Mehran.Institute
{
    public partial class frmPayment : Form
    {
        private readonly PaymentRepository payRepo = new PaymentRepository();
        private readonly EmployeeRepository empRepo = new EmployeeRepository();
        private string CurrentUserName;
        int id = 0;
        public frmPayment(string cun, int registrationID)
        {
            InitializeComponent();
            this.CurrentUserName = cun;
            this.id = registrationID;
            if(registrationID != 0)
            {
                cmbRegistration.SelectedValue = registrationID;
                BindRegisterByID(registrationID);
                BindUser();
                BindGrid();
            }
            else
            {
                BindRegister();
                BindUser();
                BindGrid();
            }
            AddMode();
        }

        #region Utility
        public void BindGrid()
        {
            dataGridView1.AutoGenerateColumns = false;
            var dtSource = payRepo.GetAll();
            dataGridView1.DataSource = dtSource;
        }
        public void ClearForm()
        {
            cmbRegistration.Text = string.Empty;
            txtAmount.Text = string.Empty;
            dpPaymentDate.Text = string.Empty;
            lblEmployee.Text = string.Empty;
        }
        public void EditMode()
        {
            btnPayment.Visible = false;
            btnUpdate.Visible = true;
            btnCancel.Visible = true;

        }
        public void AddMode()
        {
            btnPayment.Visible = true;
            btnUpdate.Visible = false;
            btnCancel.Visible = true;
        }
        public void BindUser()
        {
            var userFullName = empRepo.GetCurrentUser(CurrentUserName);
            lblEmployee.Text = userFullName;
        }
        #endregion

        #region DataBinders
        private void BindRegister()
        {
            RegistrationRepository repo = new RegistrationRepository();
            cmbRegistration.DisplayMember = "FullInfo";
            cmbRegistration.ValueMember = "RegistrationID";
            var register = repo.GetRegListDropDown();
            register.Insert(0, new RegistrationListItem { RegistrationID = -1, FullInfo = "انتخاب کنید..." });
            cmbRegistration.DataSource = register;
        }
        private void BindRegisterByID(int id)
        {
            RegistrationRepository repo = new RegistrationRepository();
            cmbRegistration.DisplayMember = "FullInfo";
            cmbRegistration.ValueMember = "RegistrationID";
            var register = repo.GetRegListDropDown();
            register.FirstOrDefault(x => x.RegistrationID == id);
            cmbRegistration.DataSource = register;
            cmbRegistration.SelectedValue= id;
        }
        #endregion

        //private void frmPayment_Load(object sender, EventArgs e)
        //{
        //    BindGrid();
        //    BindRegister();
        //    cmbRegistration.SelectedIndexChanged += cmbRegistration_SelectedIndexChanged;
        //    if (id != 0)
        //    {
        //        BindRegister();
        //        cmbRegistration.SelectedValue = RegisterationID;
        //    }

        //    BindUser();
        //    BindGrid();
        //    AddMode();

        //}

        private void cmbRegistration_SelectedIndexChanged(object sender, EventArgs e)
        {
            RegistrationRepository regRepo = new RegistrationRepository();
            int regID = Convert.ToInt32(cmbRegistration.SelectedValue);
            var regList = regRepo.GetById(regID);
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            if (lblEmployee is null || txtAmount.Text is null || dpPaymentDate.Value == null || Convert.ToInt32(cmbRegistration.SelectedValue) == -1 )
            {
                MessageBox.Show("فیلد های اجباری نمی توانند خالی باشند");
            }
            else
            {
                Payment pay = new Payment();
                pay.PaymentDate = DateHelper.ToGeorgianDateTime(dpPaymentDate.Text);
                pay.Amount = (txtAmount.Text == string.Empty ? 0 : Convert.ToInt32(txtAmount.Text));
                pay.RegisterationID = Convert.ToInt32(cmbRegistration.SelectedValue);
                pay.EmployeeID = empRepo.GetCurrentUserID(CurrentUserName);

                payRepo.Add(pay);
                BindGrid();
                ClearForm();
                BindUser();
                BindRegister();
                AddMode();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                if (MessageBox.Show("آیا از حذف رکورد انتخابی اطمینان دارید؟", "هشدار", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                    payRepo.Delete(id);
                    BindGrid();
                    ClearForm();
                    AddMode();
                    BindUser();
                }
            }

            if (e.ColumnIndex == 5)
            {
                BindRegister();
                this.id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                var repo = new PaymentRepository().GetById(id);
                cmbRegistration.SelectedValue = repo.RegisterationID;
                txtAmount.Text = repo.Amount.ToString();
                dpPaymentDate.Value = repo.PaymentDate;
                //lblEmployee = repo.Employee.FullName;
                repo.PayementID = id;
                EditMode();
                BindUser();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            AddMode();
            ClearForm();
            BindGrid();
            BindUser();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Payment pay = new Payment();
            pay.PayementID = id;
            pay.PaymentDate = DateHelper.ToGeorgianDateTime(dpPaymentDate.Text);
            pay.RegisterationID = Convert.ToInt32(cmbRegistration.SelectedValue);
            pay.EmployeeID = empRepo.GetCurrentUserID(CurrentUserName);
            pay.Amount = Convert.ToInt32(txtAmount.Text);
            if (pay.Registration?.RegistrationID == -1 || pay.Amount == 0 || pay?.PaymentDate is null)
            {
                MessageBox.Show("فیلد های اجباری نمی توانند خالی باشند");
            }
            else
            {
                var message = payRepo.Update(pay);
                ClearForm();
                BindGrid();
                AddMode();
                BindUser();
                MessageBox.Show(message);
            };
        }
    }
}

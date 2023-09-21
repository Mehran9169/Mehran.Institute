namespace Mehran.Institute
{
    partial class frmPayment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbRegistration = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.dpPaymentDate = new Atf.UI.DateTimeSelector();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PayementID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegisterationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PayementID,
            this.RegisterationID,
            this.Amount,
            this.PaymentDate,
            this.EmployeeID,
            this.btnEdit,
            this.btnDelete});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 209);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(785, 135);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(25, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "اطلاعات ثبت نام:";
            // 
            // cmbRegistration
            // 
            this.cmbRegistration.FormattingEnabled = true;
            this.cmbRegistration.Location = new System.Drawing.Point(121, 32);
            this.cmbRegistration.Margin = new System.Windows.Forms.Padding(2);
            this.cmbRegistration.Name = "cmbRegistration";
            this.cmbRegistration.Size = new System.Drawing.Size(293, 21);
            this.cmbRegistration.TabIndex = 2;
            this.cmbRegistration.SelectedIndexChanged += new System.EventHandler(this.cmbRegistration_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(35, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "مبلغ پرداختی:";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(122, 79);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(2);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(193, 20);
            this.txtAmount.TabIndex = 3;
            // 
            // dpPaymentDate
            // 
            this.dpPaymentDate.Location = new System.Drawing.Point(435, 79);
            this.dpPaymentDate.Margin = new System.Windows.Forms.Padding(2);
            this.dpPaymentDate.Name = "dpPaymentDate";
            this.dpPaymentDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dpPaymentDate.Size = new System.Drawing.Size(172, 21);
            this.dpPaymentDate.TabIndex = 20;
            this.dpPaymentDate.UsePersianFormat = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(348, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "مبلغ پرداختی:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.2F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(470, 35);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "کاربر ثبت کننده:";
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Font = new System.Drawing.Font("Calibri", 9.2F, System.Drawing.FontStyle.Bold);
            this.lblEmployee.Location = new System.Drawing.Point(609, 35);
            this.lblEmployee.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(0, 15);
            this.lblEmployee.TabIndex = 1;
            // 
            // btnPayment
            // 
            this.btnPayment.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnPayment.Location = new System.Drawing.Point(179, 142);
            this.btnPayment.Margin = new System.Windows.Forms.Padding(2);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(88, 26);
            this.btnPayment.TabIndex = 21;
            this.btnPayment.Text = "پرداخت";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.Location = new System.Drawing.Point(305, 142);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(88, 26);
            this.btnUpdate.TabIndex = 22;
            this.btnUpdate.Text = "ویرایش";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Location = new System.Drawing.Point(435, 142);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 26);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "انصراف";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(319, 79);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(11, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "*";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(418, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "*";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(611, 79);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "*";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PayementID
            // 
            this.PayementID.DataPropertyName = "PayementID";
            this.PayementID.HeaderText = "PayementID";
            this.PayementID.MinimumWidth = 8;
            this.PayementID.Name = "PayementID";
            this.PayementID.Visible = false;
            this.PayementID.Width = 90;
            // 
            // RegisterationID
            // 
            this.RegisterationID.DataPropertyName = "RegistrInfo";
            this.RegisterationID.HeaderText = "اطلاعات ثبت نام";
            this.RegisterationID.MinimumWidth = 8;
            this.RegisterationID.Name = "RegisterationID";
            this.RegisterationID.Width = 83;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "مبلغ پرداختی";
            this.Amount.MinimumWidth = 8;
            this.Amount.Name = "Amount";
            this.Amount.Width = 85;
            // 
            // PaymentDate
            // 
            this.PaymentDate.DataPropertyName = "PaymentDateShamsi";
            this.PaymentDate.HeaderText = "تاریخ ثبت نام";
            this.PaymentDate.MinimumWidth = 8;
            this.PaymentDate.Name = "PaymentDate";
            this.PaymentDate.Width = 73;
            // 
            // EmployeeID
            // 
            this.EmployeeID.DataPropertyName = "EmployeeFullName";
            this.EmployeeID.HeaderText = "کاربر ثبت کننده";
            this.EmployeeID.MinimumWidth = 8;
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.Width = 97;
            // 
            // btnEdit
            // 
            this.btnEdit.HeaderText = "ویرایش";
            this.btnEdit.MinimumWidth = 8;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Text = "ویرایش";
            this.btnEdit.UseColumnTextForButtonValue = true;
            this.btnEdit.Width = 44;
            // 
            // btnDelete
            // 
            this.btnDelete.HeaderText = "حذف";
            this.btnDelete.MinimumWidth = 8;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseColumnTextForButtonValue = true;
            this.btnDelete.Width = 34;
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(785, 344);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.dpPaymentDate);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.cmbRegistration);
            this.Controls.Add(this.lblEmployee);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPayment";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مدیریت پرداخت";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbRegistration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAmount;
        private Atf.UI.DateTimeSelector dpPaymentDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn PayementID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegisterationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeID;
        private System.Windows.Forms.DataGridViewButtonColumn btnEdit;
        private System.Windows.Forms.DataGridViewButtonColumn btnDelete;
    }
}
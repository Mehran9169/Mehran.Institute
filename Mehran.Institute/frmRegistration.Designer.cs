namespace Mehran.Institute
{
    partial class frmRegistration
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
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NationalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSelect = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNationalCode = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTuition = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblCurrentUserName = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblCoursePreq = new System.Windows.Forms.Label();
            this.cmbCourse = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCourseStatus = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblStudentNationalCode = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblStudentLastName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblStudentFirstName = new System.Windows.Forms.Label();
            this.RegistrationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegistrationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tuition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(1253, 43);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(258, 30);
            this.txtFirstName.TabIndex = 0;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentID,
            this.FirstName,
            this.LastName,
            this.NationalCode,
            this.Mobile,
            this.btnSelect});
            this.dataGridView1.Location = new System.Drawing.Point(19, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1204, 213);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // StudentID
            // 
            this.StudentID.DataPropertyName = "StudentID";
            this.StudentID.HeaderText = "StudentID";
            this.StudentID.MinimumWidth = 8;
            this.StudentID.Name = "StudentID";
            this.StudentID.Visible = false;
            this.StudentID.Width = 8;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "نام";
            this.FirstName.MinimumWidth = 8;
            this.FirstName.Name = "FirstName";
            this.FirstName.Width = 150;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "نام خانوادگی";
            this.LastName.MinimumWidth = 8;
            this.LastName.Name = "LastName";
            this.LastName.Width = 150;
            // 
            // NationalCode
            // 
            this.NationalCode.DataPropertyName = "NationalCode";
            this.NationalCode.HeaderText = "شماره ملی";
            this.NationalCode.MinimumWidth = 8;
            this.NationalCode.Name = "NationalCode";
            this.NationalCode.Width = 150;
            // 
            // Mobile
            // 
            this.Mobile.DataPropertyName = "Mobile";
            this.Mobile.HeaderText = "شماره موبایل";
            this.Mobile.MinimumWidth = 8;
            this.Mobile.Name = "Mobile";
            this.Mobile.Width = 150;
            // 
            // btnSelect
            // 
            this.btnSelect.HeaderText = "انتخاب دانشجو";
            this.btnSelect.MinimumWidth = 8;
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Text = "انتخاب دانشجو";
            this.btnSelect.UseColumnTextForButtonValue = true;
            this.btnSelect.Width = 150;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.txtMobile);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNationalCode);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 9.2F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(1661, 282);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "جستجوی دانشجو";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(1253, 214);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(258, 42);
            this.button2.TabIndex = 7;
            this.button2.Text = "پاک کردن";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(1253, 172);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(258, 30);
            this.txtMobile.TabIndex = 5;
            this.txtMobile.TextChanged += new System.EventHandler(this.txtMobile_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(1535, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "شماره موبایل:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(1535, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "شماره ملی:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(1535, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "نام خانوادگی:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(1535, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "نام:";
            // 
            // txtNationalCode
            // 
            this.txtNationalCode.Location = new System.Drawing.Point(1253, 130);
            this.txtNationalCode.Name = "txtNationalCode";
            this.txtNationalCode.Size = new System.Drawing.Size(258, 30);
            this.txtNationalCode.TabIndex = 3;
            this.txtNationalCode.TextChanged += new System.EventHandler(this.txtNationalCode_TextChanged);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(1253, 87);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(258, 30);
            this.txtLastName.TabIndex = 2;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RegistrationID,
            this.RegistrationDate,
            this.CourseID,
            this.StudentFullName,
            this.EmployeeID,
            this.Tuition,
            this.TotalPayment,
            this.Description});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView2.Location = new System.Drawing.Point(0, 785);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(1528, 239);
            this.dataGridView2.TabIndex = 3;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTuition);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.btnRegister);
            this.groupBox2.Controls.Add(this.txtDescription);
            this.groupBox2.Controls.Add(this.lblCurrentUserName);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.lblCoursePreq);
            this.groupBox2.Controls.Add(this.cmbCourse);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lblCourseStatus);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lblStudentNationalCode);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lblStudentLastName);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lblStudentFirstName);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 9.2F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(12, 337);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1661, 233);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ثبت نام";
            // 
            // txtTuition
            // 
            this.txtTuition.Location = new System.Drawing.Point(698, 173);
            this.txtTuition.Name = "txtTuition";
            this.txtTuition.Size = new System.Drawing.Size(258, 30);
            this.txtTuition.TabIndex = 7;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.Location = new System.Drawing.Point(157, 150);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(142, 48);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "ویرایش";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnRegister.Location = new System.Drawing.Point(157, 72);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(142, 48);
            this.btnRegister.TabIndex = 5;
            this.btnRegister.Text = "ثبت نام";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(1171, 173);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(340, 30);
            this.txtDescription.TabIndex = 4;
            // 
            // lblCurrentUserName
            // 
            this.lblCurrentUserName.AutoSize = true;
            this.lblCurrentUserName.Location = new System.Drawing.Point(426, 178);
            this.lblCurrentUserName.Name = "lblCurrentUserName";
            this.lblCurrentUserName.Size = new System.Drawing.Size(0, 23);
            this.lblCurrentUserName.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(576, 179);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 23);
            this.label11.TabIndex = 3;
            this.label11.Text = "کاربر جاری:";
            // 
            // lblCoursePreq
            // 
            this.lblCoursePreq.AutoSize = true;
            this.lblCoursePreq.Location = new System.Drawing.Point(820, 116);
            this.lblCoursePreq.Name = "lblCoursePreq";
            this.lblCoursePreq.Size = new System.Drawing.Size(0, 23);
            this.lblCoursePreq.TabIndex = 2;
            // 
            // cmbCourse
            // 
            this.cmbCourse.FormattingEnabled = true;
            this.cmbCourse.Location = new System.Drawing.Point(1171, 111);
            this.cmbCourse.Name = "cmbCourse";
            this.cmbCourse.Size = new System.Drawing.Size(340, 30);
            this.cmbCourse.TabIndex = 1;
            this.cmbCourse.SelectedIndexChanged += new System.EventHandler(this.cmbCourse_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1533, 173);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 23);
            this.label12.TabIndex = 0;
            this.label12.Text = "توضیحات:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1535, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "دوره ی مدنظر:";
            // 
            // lblCourseStatus
            // 
            this.lblCourseStatus.AutoSize = true;
            this.lblCourseStatus.Location = new System.Drawing.Point(422, 114);
            this.lblCourseStatus.Name = "lblCourseStatus";
            this.lblCourseStatus.Size = new System.Drawing.Size(0, 23);
            this.lblCourseStatus.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(576, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 23);
            this.label10.TabIndex = 0;
            this.label10.Text = "وضعیت دوره:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(994, 180);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 23);
            this.label13.TabIndex = 0;
            this.label13.Text = "شهریه:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(994, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "پیش نیاز دوره:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(576, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 23);
            this.label9.TabIndex = 0;
            this.label9.Text = "شماره ملی دانشجو:";
            // 
            // lblStudentNationalCode
            // 
            this.lblStudentNationalCode.AutoSize = true;
            this.lblStudentNationalCode.Location = new System.Drawing.Point(402, 59);
            this.lblStudentNationalCode.Name = "lblStudentNationalCode";
            this.lblStudentNationalCode.Size = new System.Drawing.Size(0, 23);
            this.lblStudentNationalCode.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(994, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 23);
            this.label8.TabIndex = 0;
            this.label8.Text = "نام خانوادگی دانشجو:";
            // 
            // lblStudentLastName
            // 
            this.lblStudentLastName.AutoSize = true;
            this.lblStudentLastName.Location = new System.Drawing.Point(820, 59);
            this.lblStudentLastName.Name = "lblStudentLastName";
            this.lblStudentLastName.Size = new System.Drawing.Size(0, 23);
            this.lblStudentLastName.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1539, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = " نام دانشجو:";
            // 
            // lblStudentFirstName
            // 
            this.lblStudentFirstName.AutoSize = true;
            this.lblStudentFirstName.Location = new System.Drawing.Point(1426, 59);
            this.lblStudentFirstName.Name = "lblStudentFirstName";
            this.lblStudentFirstName.Size = new System.Drawing.Size(0, 23);
            this.lblStudentFirstName.TabIndex = 0;
            // 
            // RegistrationID
            // 
            this.RegistrationID.HeaderText = "RegistrationID";
            this.RegistrationID.MinimumWidth = 8;
            this.RegistrationID.Name = "RegistrationID";
            this.RegistrationID.Width = 8;
            // 
            // RegistrationDate
            // 
            this.RegistrationDate.DataPropertyName = "RegistrationDate";
            this.RegistrationDate.HeaderText = "تاریخ ثبت نام";
            this.RegistrationDate.MinimumWidth = 8;
            this.RegistrationDate.Name = "RegistrationDate";
            // 
            // CourseID
            // 
            this.CourseID.DataPropertyName = "CourseID";
            this.CourseID.HeaderText = "دوره";
            this.CourseID.MinimumWidth = 8;
            this.CourseID.Name = "CourseID";
            // 
            // StudentFullName
            // 
            this.StudentFullName.DataPropertyName = "StudentFullName";
            this.StudentFullName.HeaderText = "StudentFullName";
            this.StudentFullName.MinimumWidth = 8;
            this.StudentFullName.Name = "StudentFullName";
            this.StudentFullName.Width = 150;
            // 
            // EmployeeID
            // 
            this.EmployeeID.DataPropertyName = "EmployeeID";
            this.EmployeeID.HeaderText = "EmployeeID";
            this.EmployeeID.MinimumWidth = 8;
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.Width = 150;
            // 
            // Tuition
            // 
            this.Tuition.DataPropertyName = "Tuition";
            this.Tuition.HeaderText = "Tuition";
            this.Tuition.MinimumWidth = 8;
            this.Tuition.Name = "Tuition";
            this.Tuition.Width = 150;
            // 
            // TotalPayment
            // 
            this.TotalPayment.DataPropertyName = "TotalPayment";
            this.TotalPayment.HeaderText = "TotalPayment";
            this.TotalPayment.MinimumWidth = 8;
            this.TotalPayment.Name = "TotalPayment";
            this.TotalPayment.Width = 150;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 8;
            this.Description.Name = "Description";
            this.Description.Width = 150;
            // 
            // frmRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1528, 1024);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRegistration";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "ثبت نام";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNationalCode;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn NationalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mobile;
        private System.Windows.Forms.DataGridViewButtonColumn btnSelect;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblStudentNationalCode;
        private System.Windows.Forms.Label lblStudentLastName;
        private System.Windows.Forms.Label lblStudentFirstName;
        private System.Windows.Forms.Label lblCoursePreq;
        private System.Windows.Forms.ComboBox cmbCourse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCourseStatus;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblCurrentUserName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtTuition;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegistrationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegistrationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tuition;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
    }
}
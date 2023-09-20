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
            this.RegistrationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegDateShamsi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tuition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTuition = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(909, 28);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(173, 22);
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
            this.dataGridView1.Location = new System.Drawing.Point(13, 28);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(861, 138);
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
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(1180, 183);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "جستجوی دانشجو";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(909, 139);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 27);
            this.button2.TabIndex = 7;
            this.button2.Text = "پاک کردن";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(909, 112);
            this.txtMobile.Margin = new System.Windows.Forms.Padding(2);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(173, 22);
            this.txtMobile.TabIndex = 5;
            this.txtMobile.TextChanged += new System.EventHandler(this.txtMobile_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(1097, 116);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "شماره موبایل:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(1097, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "شماره ملی:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(1097, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "نام خانوادگی:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(1097, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "نام:";
            // 
            // txtNationalCode
            // 
            this.txtNationalCode.Location = new System.Drawing.Point(909, 84);
            this.txtNationalCode.Margin = new System.Windows.Forms.Padding(2);
            this.txtNationalCode.Name = "txtNationalCode";
            this.txtNationalCode.Size = new System.Drawing.Size(173, 22);
            this.txtNationalCode.TabIndex = 3;
            this.txtNationalCode.TextChanged += new System.EventHandler(this.txtNationalCode_TextChanged);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(909, 57);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(2);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(173, 22);
            this.txtLastName.TabIndex = 2;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RegistrationID,
            this.RegDateShamsi,
            this.CourseName,
            this.StudentFullName,
            this.EmployeeName,
            this.Tuition,
            this.TotalPayment,
            this.Description,
            this.btnDelete});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView2.Location = new System.Drawing.Point(0, 463);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(1199, 234);
            this.dataGridView2.TabIndex = 3;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // RegistrationID
            // 
            this.RegistrationID.DataPropertyName = "RegistrationID";
            this.RegistrationID.HeaderText = "RegistrationID";
            this.RegistrationID.MinimumWidth = 8;
            this.RegistrationID.Name = "RegistrationID";
            this.RegistrationID.Visible = false;
            this.RegistrationID.Width = 8;
            // 
            // RegDateShamsi
            // 
            this.RegDateShamsi.DataPropertyName = "RegDateShamsi";
            this.RegDateShamsi.HeaderText = "تاریخ ثبت نام";
            this.RegDateShamsi.MinimumWidth = 8;
            this.RegDateShamsi.Name = "RegDateShamsi";
            this.RegDateShamsi.Width = 150;
            // 
            // CourseName
            // 
            this.CourseName.DataPropertyName = "CourseName";
            this.CourseName.HeaderText = "دوره";
            this.CourseName.MinimumWidth = 8;
            this.CourseName.Name = "CourseName";
            this.CourseName.Width = 150;
            // 
            // StudentFullName
            // 
            this.StudentFullName.DataPropertyName = "StudentFullName";
            this.StudentFullName.HeaderText = "دانشجو";
            this.StudentFullName.MinimumWidth = 8;
            this.StudentFullName.Name = "StudentFullName";
            this.StudentFullName.Width = 150;
            // 
            // EmployeeName
            // 
            this.EmployeeName.DataPropertyName = "EmployeeName";
            this.EmployeeName.HeaderText = "نام کاربر ثبت کننده";
            this.EmployeeName.MinimumWidth = 8;
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.Width = 150;
            // 
            // Tuition
            // 
            this.Tuition.DataPropertyName = "Tuition";
            this.Tuition.HeaderText = "شهریه";
            this.Tuition.MinimumWidth = 8;
            this.Tuition.Name = "Tuition";
            this.Tuition.Width = 150;
            // 
            // TotalPayment
            // 
            this.TotalPayment.DataPropertyName = "TotalPayment";
            this.TotalPayment.HeaderText = "مجموع پرداختی";
            this.TotalPayment.MinimumWidth = 8;
            this.TotalPayment.Name = "TotalPayment";
            this.TotalPayment.Width = 150;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "توضیحات";
            this.Description.MinimumWidth = 8;
            this.Description.Name = "Description";
            this.Description.Width = 150;
            // 
            // btnDelete
            // 
            this.btnDelete.HeaderText = "حذف";
            this.btnDelete.MinimumWidth = 8;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseColumnTextForButtonValue = true;
            this.btnDelete.Width = 80;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTuition);
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
            this.groupBox2.Location = new System.Drawing.Point(8, 219);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(1180, 151);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ثبت نام";
            // 
            // txtTuition
            // 
            this.txtTuition.Location = new System.Drawing.Point(465, 112);
            this.txtTuition.Margin = new System.Windows.Forms.Padding(2);
            this.txtTuition.Name = "txtTuition";
            this.txtTuition.Size = new System.Drawing.Size(173, 22);
            this.txtTuition.TabIndex = 7;
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnRegister.Location = new System.Drawing.Point(112, 83);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(95, 47);
            this.btnRegister.TabIndex = 5;
            this.btnRegister.Text = "ثبت نام";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(781, 112);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(228, 22);
            this.txtDescription.TabIndex = 4;
            // 
            // lblCurrentUserName
            // 
            this.lblCurrentUserName.AutoSize = true;
            this.lblCurrentUserName.Location = new System.Drawing.Point(284, 116);
            this.lblCurrentUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrentUserName.Name = "lblCurrentUserName";
            this.lblCurrentUserName.Size = new System.Drawing.Size(0, 15);
            this.lblCurrentUserName.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(384, 116);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 15);
            this.label11.TabIndex = 3;
            this.label11.Text = "کاربر جاری:";
            // 
            // lblCoursePreq
            // 
            this.lblCoursePreq.AutoSize = true;
            this.lblCoursePreq.Location = new System.Drawing.Point(547, 75);
            this.lblCoursePreq.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCoursePreq.Name = "lblCoursePreq";
            this.lblCoursePreq.Size = new System.Drawing.Size(0, 15);
            this.lblCoursePreq.TabIndex = 2;
            // 
            // cmbCourse
            // 
            this.cmbCourse.FormattingEnabled = true;
            this.cmbCourse.Location = new System.Drawing.Point(781, 72);
            this.cmbCourse.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCourse.Name = "cmbCourse";
            this.cmbCourse.Size = new System.Drawing.Size(228, 22);
            this.cmbCourse.TabIndex = 1;
            this.cmbCourse.SelectedIndexChanged += new System.EventHandler(this.cmbCourse_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1022, 112);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 15);
            this.label12.TabIndex = 0;
            this.label12.Text = "توضیحات:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1023, 77);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "دوره ی مدنظر:";
            // 
            // lblCourseStatus
            // 
            this.lblCourseStatus.AutoSize = true;
            this.lblCourseStatus.Location = new System.Drawing.Point(281, 74);
            this.lblCourseStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCourseStatus.Name = "lblCourseStatus";
            this.lblCourseStatus.Size = new System.Drawing.Size(0, 15);
            this.lblCourseStatus.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(384, 74);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "وضعیت دوره:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(663, 117);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 15);
            this.label13.TabIndex = 0;
            this.label13.Text = "شهریه:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(663, 77);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "پیش نیاز دوره:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(384, 38);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "شماره ملی دانشجو:";
            // 
            // lblStudentNationalCode
            // 
            this.lblStudentNationalCode.AutoSize = true;
            this.lblStudentNationalCode.Location = new System.Drawing.Point(268, 38);
            this.lblStudentNationalCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStudentNationalCode.Name = "lblStudentNationalCode";
            this.lblStudentNationalCode.Size = new System.Drawing.Size(0, 15);
            this.lblStudentNationalCode.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(663, 38);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "نام خانوادگی دانشجو:";
            // 
            // lblStudentLastName
            // 
            this.lblStudentLastName.AutoSize = true;
            this.lblStudentLastName.Location = new System.Drawing.Point(547, 38);
            this.lblStudentLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStudentLastName.Name = "lblStudentLastName";
            this.lblStudentLastName.Size = new System.Drawing.Size(0, 15);
            this.lblStudentLastName.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1026, 38);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = " نام دانشجو:";
            // 
            // lblStudentFirstName
            // 
            this.lblStudentFirstName.AutoSize = true;
            this.lblStudentFirstName.Location = new System.Drawing.Point(951, 38);
            this.lblStudentFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStudentFirstName.Name = "lblStudentFirstName";
            this.lblStudentFirstName.Size = new System.Drawing.Size(0, 15);
            this.lblStudentFirstName.TabIndex = 0;
            // 
            // frmRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1199, 697);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.TextBox txtTuition;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegistrationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegDateShamsi;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tuition;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewButtonColumn btnDelete;
    }
}
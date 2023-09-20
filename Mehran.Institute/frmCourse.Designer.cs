namespace Mehran.Institute
{
    partial class frmCourse
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
            this.CourseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tuition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeacherID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseStatusName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TermName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RuningTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.txtTution = new System.Windows.Forms.TextBox();
            this.txtPreq = new System.Windows.Forms.TextBox();
            this.txtRuningTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbCourseStatus = new System.Windows.Forms.ComboBox();
            this.cmbTeacher = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCourseContent = new System.Windows.Forms.RichTextBox();
            this.cmbTerm = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dpStartDate = new Atf.UI.DateTimeSelector();
            this.dpEndDate = new Atf.UI.DateTimeSelector();
            this.numHours = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHours)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CourseID,
            this.CourseName,
            this.Tuition,
            this.TeacherID,
            this.CourseStatusName,
            this.Preq,
            this.TermName,
            this.CourseContent,
            this.Hours,
            this.RuningTime,
            this.StartDate,
            this.EndDate,
            this.btnEdit,
            this.btnDelete});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 370);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(1173, 277);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // CourseID
            // 
            this.CourseID.DataPropertyName = "CourseID";
            this.CourseID.HeaderText = "CourseID";
            this.CourseID.MinimumWidth = 8;
            this.CourseID.Name = "CourseID";
            this.CourseID.Visible = false;
            this.CourseID.Width = 76;
            // 
            // CourseName
            // 
            this.CourseName.DataPropertyName = "CourseName";
            this.CourseName.HeaderText = "نام دوره";
            this.CourseName.MinimumWidth = 8;
            this.CourseName.Name = "CourseName";
            this.CourseName.Width = 70;
            // 
            // Tuition
            // 
            this.Tuition.DataPropertyName = "Tuition";
            this.Tuition.HeaderText = "شهریه";
            this.Tuition.MinimumWidth = 8;
            this.Tuition.Name = "Tuition";
            this.Tuition.Width = 61;
            // 
            // TeacherID
            // 
            this.TeacherID.DataPropertyName = "TeacherName";
            this.TeacherID.HeaderText = "نام استاد";
            this.TeacherID.MinimumWidth = 8;
            this.TeacherID.Name = "TeacherID";
            this.TeacherID.Width = 73;
            // 
            // CourseStatusName
            // 
            this.CourseStatusName.DataPropertyName = "CourseStatusName";
            this.CourseStatusName.HeaderText = "وضعیت";
            this.CourseStatusName.MinimumWidth = 8;
            this.CourseStatusName.Name = "CourseStatusName";
            this.CourseStatusName.Width = 65;
            // 
            // Preq
            // 
            this.Preq.DataPropertyName = "Preq";
            this.Preq.HeaderText = "پیش نیاز";
            this.Preq.MinimumWidth = 8;
            this.Preq.Name = "Preq";
            this.Preq.Width = 69;
            // 
            // TermName
            // 
            this.TermName.DataPropertyName = "TermName";
            this.TermName.HeaderText = "ترم";
            this.TermName.MinimumWidth = 8;
            this.TermName.Name = "TermName";
            this.TermName.Width = 46;
            // 
            // CourseContent
            // 
            this.CourseContent.DataPropertyName = "CourseContent";
            this.CourseContent.HeaderText = "محتوای دوره";
            this.CourseContent.MinimumWidth = 8;
            this.CourseContent.Name = "CourseContent";
            this.CourseContent.Width = 92;
            // 
            // Hours
            // 
            this.Hours.DataPropertyName = "Hours";
            this.Hours.HeaderText = "بازه زمانی";
            this.Hours.MinimumWidth = 8;
            this.Hours.Name = "Hours";
            this.Hours.Width = 82;
            // 
            // RuningTime
            // 
            this.RuningTime.DataPropertyName = "RuningTime";
            this.RuningTime.HeaderText = "زمان برگزاری";
            this.RuningTime.MinimumWidth = 8;
            this.RuningTime.Name = "RuningTime";
            this.RuningTime.Width = 95;
            // 
            // StartDate
            // 
            this.StartDate.DataPropertyName = "StartDateShamsi";
            this.StartDate.HeaderText = "تاریخ شروع";
            this.StartDate.MinimumWidth = 8;
            this.StartDate.Name = "StartDate";
            this.StartDate.Width = 87;
            // 
            // EndDate
            // 
            this.EndDate.DataPropertyName = "EndDateShamsi";
            this.EndDate.HeaderText = "تاریخ پایان";
            this.EndDate.MinimumWidth = 8;
            this.EndDate.Name = "EndDate";
            this.EndDate.Width = 83;
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
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(87, 31);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(173, 20);
            this.txtCourseName.TabIndex = 1;
            this.txtCourseName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtTution
            // 
            this.txtTution.Location = new System.Drawing.Point(87, 83);
            this.txtTution.Name = "txtTution";
            this.txtTution.Size = new System.Drawing.Size(173, 20);
            this.txtTution.TabIndex = 2;
            // 
            // txtPreq
            // 
            this.txtPreq.Location = new System.Drawing.Point(362, 31);
            this.txtPreq.Name = "txtPreq";
            this.txtPreq.Size = new System.Drawing.Size(185, 20);
            this.txtPreq.TabIndex = 3;
            // 
            // txtRuningTime
            // 
            this.txtRuningTime.Location = new System.Drawing.Point(663, 83);
            this.txtRuningTime.Name = "txtRuningTime";
            this.txtRuningTime.Size = new System.Drawing.Size(173, 20);
            this.txtRuningTime.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(33, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "نام دوره:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(38, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "شهریه:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(21, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "استاد دوره:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(589, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "تاریخ شروع:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(561, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "بازه زمانی(ساعت):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(303, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "پیش نیاز:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(585, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "زمان برگزاری:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(593, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "تاریخ پایان:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(284, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "محتوای دوره:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(8, 202);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 17);
            this.label10.TabIndex = 11;
            this.label10.Text = "وضعیت دوره:";
            // 
            // cmbCourseStatus
            // 
            this.cmbCourseStatus.FormattingEnabled = true;
            this.cmbCourseStatus.Location = new System.Drawing.Point(87, 201);
            this.cmbCourseStatus.Name = "cmbCourseStatus";
            this.cmbCourseStatus.Size = new System.Drawing.Size(173, 21);
            this.cmbCourseStatus.TabIndex = 12;
            this.cmbCourseStatus.SelectedIndexChanged += new System.EventHandler(this.cmbCourseStatus_SelectedIndexChanged);
            // 
            // cmbTeacher
            // 
            this.cmbTeacher.FormattingEnabled = true;
            this.cmbTeacher.Location = new System.Drawing.Point(87, 143);
            this.cmbTeacher.Name = "cmbTeacher";
            this.cmbTeacher.Size = new System.Drawing.Size(173, 21);
            this.cmbTeacher.TabIndex = 13;
            this.cmbTeacher.SelectedIndexChanged += new System.EventHandler(this.cmbTeacher_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(329, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 17);
            this.label11.TabIndex = 10;
            this.label11.Text = "ترم:";
            // 
            // txtCourseContent
            // 
            this.txtCourseContent.Location = new System.Drawing.Point(365, 124);
            this.txtCourseContent.Name = "txtCourseContent";
            this.txtCourseContent.Size = new System.Drawing.Size(182, 96);
            this.txtCourseContent.TabIndex = 14;
            this.txtCourseContent.Text = "";
            // 
            // cmbTerm
            // 
            this.cmbTerm.FormattingEnabled = true;
            this.cmbTerm.Location = new System.Drawing.Point(365, 79);
            this.cmbTerm.Name = "cmbTerm";
            this.cmbTerm.Size = new System.Drawing.Size(182, 21);
            this.cmbTerm.TabIndex = 15;
            this.cmbTerm.SelectedIndexChanged += new System.EventHandler(this.cmbTerm_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnAdd.Location = new System.Drawing.Point(891, 79);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(97, 25);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "افزودن";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.Location = new System.Drawing.Point(891, 140);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(97, 25);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "ویرایش";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Location = new System.Drawing.Point(891, 198);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(97, 25);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "انصراف";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dpStartDate
            // 
            this.dpStartDate.Location = new System.Drawing.Point(663, 144);
            this.dpStartDate.Margin = new System.Windows.Forms.Padding(2);
            this.dpStartDate.Name = "dpStartDate";
            this.dpStartDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dpStartDate.Size = new System.Drawing.Size(172, 21);
            this.dpStartDate.TabIndex = 19;
            this.dpStartDate.UsePersianFormat = true;
            // 
            // dpEndDate
            // 
            this.dpEndDate.Location = new System.Drawing.Point(663, 202);
            this.dpEndDate.Margin = new System.Windows.Forms.Padding(2);
            this.dpEndDate.Name = "dpEndDate";
            this.dpEndDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dpEndDate.Size = new System.Drawing.Size(171, 21);
            this.dpEndDate.TabIndex = 20;
            this.dpEndDate.UsePersianFormat = true;
            // 
            // numHours
            // 
            this.numHours.Location = new System.Drawing.Point(663, 31);
            this.numHours.Margin = new System.Windows.Forms.Padding(2);
            this.numHours.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numHours.Name = "numHours";
            this.numHours.Size = new System.Drawing.Size(171, 20);
            this.numHours.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(263, 31);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(11, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "*";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(263, 143);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(11, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "*";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(263, 201);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(11, 13);
            this.label14.TabIndex = 22;
            this.label14.Text = "*";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(551, 79);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(11, 13);
            this.label15.TabIndex = 22;
            this.label15.Text = "*";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(839, 143);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(11, 13);
            this.label16.TabIndex = 22;
            this.label16.Text = "*";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1173, 647);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.numHours);
            this.Controls.Add(this.dpEndDate);
            this.Controls.Add(this.dpStartDate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbTerm);
            this.Controls.Add(this.txtCourseContent);
            this.Controls.Add(this.cmbTeacher);
            this.Controls.Add(this.cmbCourseStatus);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRuningTime);
            this.Controls.Add(this.txtPreq);
            this.Controls.Add(this.txtTution);
            this.Controls.Add(this.txtCourseName);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.Name = "frmCourse";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "مدیریت دوره ها";
            this.Load += new System.EventHandler(this.frmCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.TextBox txtTution;
        private System.Windows.Forms.TextBox txtPreq;
        private System.Windows.Forms.TextBox txtRuningTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbCourseStatus;
        private System.Windows.Forms.ComboBox cmbTeacher;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox txtCourseContent;
        private System.Windows.Forms.ComboBox cmbTerm;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private Atf.UI.DateTimeSelector dpStartDate;
        private Atf.UI.DateTimeSelector dpEndDate;
        private System.Windows.Forms.NumericUpDown numHours;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tuition;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseStatusName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preq;
        private System.Windows.Forms.DataGridViewTextBoxColumn TermName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseContent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hours;
        private System.Windows.Forms.DataGridViewTextBoxColumn RuningTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
        private System.Windows.Forms.DataGridViewButtonColumn btnEdit;
        private System.Windows.Forms.DataGridViewButtonColumn btnDelete;
    }
}
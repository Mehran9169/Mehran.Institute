namespace Mehran.Institute
{
    partial class frmSwitchBoard
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.اطلاعاتپایهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.مدیریتترمهاToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.مدیریتدورههاToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.مدیریتاشخاصToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.کارکنانToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اساتیدToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.دانشجویانToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ثبتنامToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.مدیریتپرداختToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblCurrentUser = new System.Windows.Forms.ToolStripLabel();
            this.lblDate = new System.Windows.Forms.ToolStripLabel();
            this.lblTime = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuStrip1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 5);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.اطلاعاتپایهToolStripMenuItem,
            this.مدیریتاشخاصToolStripMenuItem,
            this.ثبتنامToolStripMenuItem,
            this.مدیریتپرداختToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(1158, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 11, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(148, 770);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip";
            // 
            // اطلاعاتپایهToolStripMenuItem
            // 
            this.اطلاعاتپایهToolStripMenuItem.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.اطلاعاتپایهToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.مدیریتترمهاToolStripMenuItem,
            this.مدیریتدورههاToolStripMenuItem});
            this.اطلاعاتپایهToolStripMenuItem.Name = "اطلاعاتپایهToolStripMenuItem";
            this.اطلاعاتپایهToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 10, 4, 0);
            this.اطلاعاتپایهToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.اطلاعاتپایهToolStripMenuItem.Size = new System.Drawing.Size(138, 40);
            this.اطلاعاتپایهToolStripMenuItem.Text = "اطلاعات پایه";
            this.اطلاعاتپایهToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.اطلاعاتپایهToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // مدیریتترمهاToolStripMenuItem
            // 
            this.مدیریتترمهاToolStripMenuItem.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.مدیریتترمهاToolStripMenuItem.Name = "مدیریتترمهاToolStripMenuItem";
            this.مدیریتترمهاToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.مدیریتترمهاToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.مدیریتترمهاToolStripMenuItem.Size = new System.Drawing.Size(167, 40);
            this.مدیریتترمهاToolStripMenuItem.Text = "ترم ها";
            this.مدیریتترمهاToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.مدیریتترمهاToolStripMenuItem.Click += new System.EventHandler(this.مدیریتترمهاToolStripMenuItem_Click);
            // 
            // مدیریتدورههاToolStripMenuItem
            // 
            this.مدیریتدورههاToolStripMenuItem.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.مدیریتدورههاToolStripMenuItem.Name = "مدیریتدورههاToolStripMenuItem";
            this.مدیریتدورههاToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.مدیریتدورههاToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.مدیریتدورههاToolStripMenuItem.Size = new System.Drawing.Size(167, 40);
            this.مدیریتدورههاToolStripMenuItem.Text = "دوره ها";
            this.مدیریتدورههاToolStripMenuItem.Click += new System.EventHandler(this.مدیریتدورههاToolStripMenuItem_Click);
            // 
            // مدیریتاشخاصToolStripMenuItem
            // 
            this.مدیریتاشخاصToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.کارکنانToolStripMenuItem,
            this.اساتیدToolStripMenuItem,
            this.دانشجویانToolStripMenuItem});
            this.مدیریتاشخاصToolStripMenuItem.Name = "مدیریتاشخاصToolStripMenuItem";
            this.مدیریتاشخاصToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 10, 4, 0);
            this.مدیریتاشخاصToolStripMenuItem.Size = new System.Drawing.Size(138, 40);
            this.مدیریتاشخاصToolStripMenuItem.Text = "مدیریت اشخاص";
            this.مدیریتاشخاصToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // کارکنانToolStripMenuItem
            // 
            this.کارکنانToolStripMenuItem.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.کارکنانToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.کارکنانToolStripMenuItem.Name = "کارکنانToolStripMenuItem";
            this.کارکنانToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 5, 0, 1);
            this.کارکنانToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.کارکنانToolStripMenuItem.Size = new System.Drawing.Size(193, 36);
            this.کارکنانToolStripMenuItem.Text = "کارکنان";
            this.کارکنانToolStripMenuItem.Click += new System.EventHandler(this.کارکنانToolStripMenuItem_Click);
            // 
            // اساتیدToolStripMenuItem
            // 
            this.اساتیدToolStripMenuItem.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.اساتیدToolStripMenuItem.Name = "اساتیدToolStripMenuItem";
            this.اساتیدToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 5, 0, 1);
            this.اساتیدToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.اساتیدToolStripMenuItem.Size = new System.Drawing.Size(193, 36);
            this.اساتیدToolStripMenuItem.Text = "اساتید";
            this.اساتیدToolStripMenuItem.Click += new System.EventHandler(this.اساتیدToolStripMenuItem_Click);
            // 
            // دانشجویانToolStripMenuItem
            // 
            this.دانشجویانToolStripMenuItem.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.دانشجویانToolStripMenuItem.Name = "دانشجویانToolStripMenuItem";
            this.دانشجویانToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 5, 0, 1);
            this.دانشجویانToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.دانشجویانToolStripMenuItem.Size = new System.Drawing.Size(193, 36);
            this.دانشجویانToolStripMenuItem.Text = "دانشجویان";
            this.دانشجویانToolStripMenuItem.Click += new System.EventHandler(this.دانشجویانToolStripMenuItem_Click);
            // 
            // ثبتنامToolStripMenuItem
            // 
            this.ثبتنامToolStripMenuItem.Name = "ثبتنامToolStripMenuItem";
            this.ثبتنامToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 10, 4, 0);
            this.ثبتنامToolStripMenuItem.Size = new System.Drawing.Size(138, 40);
            this.ثبتنامToolStripMenuItem.Text = "ثبت نام";
            this.ثبتنامToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ثبتنامToolStripMenuItem.Click += new System.EventHandler(this.ثبتنامToolStripMenuItem_Click);
            // 
            // مدیریتپرداختToolStripMenuItem
            // 
            this.مدیریتپرداختToolStripMenuItem.Name = "مدیریتپرداختToolStripMenuItem";
            this.مدیریتپرداختToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 10, 4, 0);
            this.مدیریتپرداختToolStripMenuItem.Size = new System.Drawing.Size(138, 40);
            this.مدیریتپرداختToolStripMenuItem.Text = "مدیریت پرداخت";
            this.مدیریتپرداختToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(89, 25);
            this.lblCurrentUser.Text = "کاربر جاری";
            // 
            // lblDate
            // 
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(50, 25);
            this.lblDate.Text = "تاریخ";
            // 
            // lblTime
            // 
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(46, 25);
            this.lblTime.Text = "زمان";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblCurrentUser,
            this.lblDate,
            this.lblTime});
            this.toolStrip1.Location = new System.Drawing.Point(0, 770);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(1306, 30);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // frmSwitchBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Mehran.Institute.Properties.Resources.geometric_science_education_background_vector_gradient_blue_digital_remix_53876_125993;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1306, 800);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmSwitchBoard";
            this.Text = "سیستم مدیریت آموزشگاه مهران";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSwitchBoard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem اطلاعاتپایهToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem مدیریتترمهاToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem مدیریتدورههاToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem مدیریتاشخاصToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem کارکنانToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem اساتیدToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem دانشجویانToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ثبتنامToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem مدیریتپرداختToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripLabel lblCurrentUser;
        private System.Windows.Forms.ToolStripLabel lblDate;
        private System.Windows.Forms.ToolStripLabel lblTime;
        private System.Windows.Forms.ToolStrip toolStrip1;
    }
}
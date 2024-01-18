namespace QLHS.Views
{
    partial class frm_Control
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tùyChọnToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.case_info = new System.Windows.Forms.ToolStripMenuItem();
            this.case_changepass = new System.Windows.Forms.ToolStripMenuItem();
            this.case_closeform = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.case_student = new System.Windows.Forms.ToolStripMenuItem();
            this.case_faculty = new System.Windows.Forms.ToolStripMenuItem();
            this.case_class = new System.Windows.Forms.ToolStripMenuItem();
            this.case_subject = new System.Windows.Forms.ToolStripMenuItem();
            this.case_score = new System.Windows.Forms.ToolStripMenuItem();
            this.tùyChọnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchHọcSinhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchLớpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchKhoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chọnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcBảngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chọnToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcBảngToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.case_chagepassword = new System.Windows.Forms.ToolStripMenuItem();
            this.case_close = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tùyChọnToolStripMenuItem1,
            this.danhMụcToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tùyChọnToolStripMenuItem1
            // 
            this.tùyChọnToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.case_info,
            this.case_changepass,
            this.case_closeform});
            this.tùyChọnToolStripMenuItem1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tùyChọnToolStripMenuItem1.Name = "tùyChọnToolStripMenuItem1";
            this.tùyChọnToolStripMenuItem1.Size = new System.Drawing.Size(77, 23);
            this.tùyChọnToolStripMenuItem1.Text = "Tùy chọn";
            // 
            // case_info
            // 
            this.case_info.Name = "case_info";
            this.case_info.Size = new System.Drawing.Size(193, 24);
            this.case_info.Text = "Thông tin tài khoản";
            // 
            // case_changepass
            // 
            this.case_changepass.Name = "case_changepass";
            this.case_changepass.Size = new System.Drawing.Size(193, 24);
            this.case_changepass.Text = "Đổi mật khẩu";
            this.case_changepass.Click += new System.EventHandler(this.case_changepass_Click);
            // 
            // case_closeform
            // 
            this.case_closeform.Name = "case_closeform";
            this.case_closeform.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.case_closeform.ShowShortcutKeys = false;
            this.case_closeform.Size = new System.Drawing.Size(193, 24);
            this.case_closeform.Text = "Thoát";
            this.case_closeform.Click += new System.EventHandler(this.case_closeform_Click);
            // 
            // danhMụcToolStripMenuItem1
            // 
            this.danhMụcToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.case_student,
            this.case_faculty,
            this.case_class,
            this.case_subject,
            this.case_score});
            this.danhMụcToolStripMenuItem1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.danhMụcToolStripMenuItem1.Name = "danhMụcToolStripMenuItem1";
            this.danhMụcToolStripMenuItem1.Size = new System.Drawing.Size(82, 23);
            this.danhMụcToolStripMenuItem1.Text = "Danh mục";
            // 
            // case_student
            // 
            this.case_student.Name = "case_student";
            this.case_student.Size = new System.Drawing.Size(152, 24);
            this.case_student.Text = "Sinh viên";
            this.case_student.Click += new System.EventHandler(this.case_student_Click);
            // 
            // case_faculty
            // 
            this.case_faculty.Name = "case_faculty";
            this.case_faculty.Size = new System.Drawing.Size(152, 24);
            this.case_faculty.Text = "Khoa";
            this.case_faculty.Click += new System.EventHandler(this.case_faculty_Click);
            // 
            // case_class
            // 
            this.case_class.Name = "case_class";
            this.case_class.Size = new System.Drawing.Size(152, 24);
            this.case_class.Text = "Lớp";
            this.case_class.Click += new System.EventHandler(this.case_class_Click);
            // 
            // case_subject
            // 
            this.case_subject.Name = "case_subject";
            this.case_subject.Size = new System.Drawing.Size(152, 24);
            this.case_subject.Text = "Môn học";
            this.case_subject.Click += new System.EventHandler(this.case_subject_Click);
            // 
            // case_score
            // 
            this.case_score.Name = "case_score";
            this.case_score.Size = new System.Drawing.Size(152, 24);
            this.case_score.Text = "Điểm";
            // 
            // tùyChọnToolStripMenuItem
            // 
            this.tùyChọnToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tùyChọnToolStripMenuItem.Name = "tùyChọnToolStripMenuItem";
            this.tùyChọnToolStripMenuItem.Size = new System.Drawing.Size(77, 23);
            this.tùyChọnToolStripMenuItem.Text = "Tùy chọn";
            // 
            // danhMụcToolStripMenuItem
            // 
            this.danhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhSáchHọcSinhToolStripMenuItem,
            this.danhSáchLớpToolStripMenuItem,
            this.danhSáchKhoaToolStripMenuItem});
            this.danhMụcToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(82, 23);
            this.danhMụcToolStripMenuItem.Text = "Danh mục";
            // 
            // danhSáchHọcSinhToolStripMenuItem
            // 
            this.danhSáchHọcSinhToolStripMenuItem.Name = "danhSáchHọcSinhToolStripMenuItem";
            this.danhSáchHọcSinhToolStripMenuItem.Size = new System.Drawing.Size(194, 24);
            this.danhSáchHọcSinhToolStripMenuItem.Text = "Danh sách học sinh";
            // 
            // danhSáchLớpToolStripMenuItem
            // 
            this.danhSáchLớpToolStripMenuItem.Name = "danhSáchLớpToolStripMenuItem";
            this.danhSáchLớpToolStripMenuItem.Size = new System.Drawing.Size(194, 24);
            this.danhSáchLớpToolStripMenuItem.Text = "Danh sách lớp";
            // 
            // danhSáchKhoaToolStripMenuItem
            // 
            this.danhSáchKhoaToolStripMenuItem.Name = "danhSáchKhoaToolStripMenuItem";
            this.danhSáchKhoaToolStripMenuItem.Size = new System.Drawing.Size(194, 24);
            this.danhSáchKhoaToolStripMenuItem.Text = "Danh sách khoa";
            // 
            // chọnToolStripMenuItem
            // 
            this.chọnToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chọnToolStripMenuItem.Name = "chọnToolStripMenuItem";
            this.chọnToolStripMenuItem.Size = new System.Drawing.Size(54, 23);
            this.chọnToolStripMenuItem.Text = "&Chọn";
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(166, 24);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi Mật Khẩu";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(166, 24);
            this.thoátToolStripMenuItem.Text = "Thoát";
            // 
            // danhMụcBảngToolStripMenuItem
            // 
            this.danhMụcBảngToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.danhMụcBảngToolStripMenuItem.Name = "danhMụcBảngToolStripMenuItem";
            this.danhMụcBảngToolStripMenuItem.Size = new System.Drawing.Size(115, 23);
            this.danhMụcBảngToolStripMenuItem.Text = "Danh mục bảng";
            // 
            // chọnToolStripMenuItem1
            // 
            this.chọnToolStripMenuItem1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chọnToolStripMenuItem1.Name = "chọnToolStripMenuItem1";
            this.chọnToolStripMenuItem1.Size = new System.Drawing.Size(54, 23);
            this.chọnToolStripMenuItem1.Text = "Chọn";
            // 
            // danhMụcBảngToolStripMenuItem1
            // 
            this.danhMụcBảngToolStripMenuItem1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.danhMụcBảngToolStripMenuItem1.Name = "danhMụcBảngToolStripMenuItem1";
            this.danhMụcBảngToolStripMenuItem1.Size = new System.Drawing.Size(115, 23);
            this.danhMụcBảngToolStripMenuItem1.Text = "Danh mục bảng";
            // 
            // case_chagepassword
            // 
            this.case_chagepassword.Name = "case_chagepassword";
            this.case_chagepassword.Size = new System.Drawing.Size(32, 19);
            // 
            // case_close
            // 
            this.case_close.Name = "case_close";
            this.case_close.Size = new System.Drawing.Size(32, 19);
            // 
            // frm_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_Control";
            this.Text = "Bảng điều khiển";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tùyChọnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem case_thoat;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchHọcSinhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchLớpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchKhoaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chọnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMụcBảngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chọnToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem case_chagepassword;
        private System.Windows.Forms.ToolStripMenuItem case_close;
        private System.Windows.Forms.ToolStripMenuItem danhMụcBảngToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tùyChọnToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem case_info;
        private System.Windows.Forms.ToolStripMenuItem case_changepass;
        private System.Windows.Forms.ToolStripMenuItem case_closeform;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem case_student;
        private System.Windows.Forms.ToolStripMenuItem case_faculty;
        private System.Windows.Forms.ToolStripMenuItem case_class;
        private System.Windows.Forms.ToolStripMenuItem case_subject;
        private System.Windows.Forms.ToolStripMenuItem case_score;
    }
}
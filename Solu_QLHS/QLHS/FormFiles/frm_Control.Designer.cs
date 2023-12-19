namespace QLHS.FormFiles
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
            this.tùyChọnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.case_changePass = new System.Windows.Forms.ToolStripMenuItem();
            this.case_thoat = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchHọcSinhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchLớpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchKhoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tùyChọnToolStripMenuItem,
            this.danhMụcToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tùyChọnToolStripMenuItem
            // 
            this.tùyChọnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.case_changePass,
            this.case_thoat});
            this.tùyChọnToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tùyChọnToolStripMenuItem.Name = "tùyChọnToolStripMenuItem";
            this.tùyChọnToolStripMenuItem.Size = new System.Drawing.Size(77, 23);
            this.tùyChọnToolStripMenuItem.Text = "Tùy chọn";
            // 
            // case_changePass
            // 
            this.case_changePass.Name = "case_changePass";
            this.case_changePass.Size = new System.Drawing.Size(159, 24);
            this.case_changePass.Text = "Đổi mật khẩu";
            // 
            // case_thoat
            // 
            this.case_thoat.Name = "case_thoat";
            this.case_thoat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.case_thoat.ShowShortcutKeys = false;
            this.case_thoat.Size = new System.Drawing.Size(159, 24);
            this.case_thoat.Text = "Thoát";
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
        private System.Windows.Forms.ToolStripMenuItem case_changePass;
        private System.Windows.Forms.ToolStripMenuItem case_thoat;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchHọcSinhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchLớpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchKhoaToolStripMenuItem;
    }
}
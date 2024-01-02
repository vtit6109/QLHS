namespace QLHS.Views
{
    partial class frm_Faculty
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
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tbox_search = new System.Windows.Forms.TextBox();
            this.btn_show = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tbox_tenkhoa = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbox_makhoa = new System.Windows.Forms.TextBox();
            this.dgv_Faculty = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_skip = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_exportExcel = new System.Windows.Forms.Button();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Faculty)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.panel7);
            this.panel8.Controls.Add(this.panel1);
            this.panel8.Controls.Add(this.dgv_Faculty);
            this.panel8.Location = new System.Drawing.Point(38, 72);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(761, 509);
            this.panel8.TabIndex = 6;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.tbox_search);
            this.panel7.Controls.Add(this.btn_show);
            this.panel7.Controls.Add(this.btn_search);
            this.panel7.Location = new System.Drawing.Point(18, 15);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(724, 54);
            this.panel7.TabIndex = 3;
            // 
            // tbox_search
            // 
            this.tbox_search.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_search.Location = new System.Drawing.Point(67, 13);
            this.tbox_search.Name = "tbox_search";
            this.tbox_search.Size = new System.Drawing.Size(371, 26);
            this.tbox_search.TabIndex = 4;
            this.tbox_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbox_search_KeyDown);
            // 
            // btn_show
            // 
            this.btn_show.Location = new System.Drawing.Point(525, 13);
            this.btn_show.Name = "btn_show";
            this.btn_show.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_show.Size = new System.Drawing.Size(93, 29);
            this.btn_show.TabIndex = 2;
            this.btn_show.Text = "Hiển thị tất cả";
            this.btn_show.UseVisualStyleBackColor = true;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(444, 13);
            this.btn_search.Name = "btn_search";
            this.btn_search.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_search.Size = new System.Drawing.Size(75, 29);
            this.btn_search.TabIndex = 3;
            this.btn_search.Text = "Tìm kiếm";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(18, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(724, 59);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.tbox_tenkhoa);
            this.panel3.Location = new System.Drawing.Point(373, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(290, 33);
            this.panel3.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Khoa";
            // 
            // tbox_tenkhoa
            // 
            this.tbox_tenkhoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_tenkhoa.Location = new System.Drawing.Point(86, 4);
            this.tbox_tenkhoa.Name = "tbox_tenkhoa";
            this.tbox_tenkhoa.Size = new System.Drawing.Size(194, 26);
            this.tbox_tenkhoa.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tbox_makhoa);
            this.panel2.Location = new System.Drawing.Point(16, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(284, 33);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Khoa";
            // 
            // tbox_makhoa
            // 
            this.tbox_makhoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_makhoa.Location = new System.Drawing.Point(83, 4);
            this.tbox_makhoa.Name = "tbox_makhoa";
            this.tbox_makhoa.Size = new System.Drawing.Size(194, 26);
            this.tbox_makhoa.TabIndex = 0;
            // 
            // dgv_Faculty
            // 
            this.dgv_Faculty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Faculty.Location = new System.Drawing.Point(18, 140);
            this.dgv_Faculty.Name = "dgv_Faculty";
            this.dgv_Faculty.Size = new System.Drawing.Size(724, 313);
            this.dgv_Faculty.TabIndex = 0;
            this.dgv_Faculty.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Faculty_CellContentClick);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.btn_exportExcel);
            this.panel5.Controls.Add(this.btn_close);
            this.panel5.Controls.Add(this.btn_skip);
            this.panel5.Controls.Add(this.btn_edit);
            this.panel5.Controls.Add(this.btn_save);
            this.panel5.Controls.Add(this.btn_del);
            this.panel5.Controls.Add(this.btn_add);
            this.panel5.Location = new System.Drawing.Point(38, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(761, 54);
            this.panel5.TabIndex = 5;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(667, 13);
            this.btn_close.Name = "btn_close";
            this.btn_close.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_close.Size = new System.Drawing.Size(75, 29);
            this.btn_close.TabIndex = 5;
            this.btn_close.Text = "Đóng";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_skip
            // 
            this.btn_skip.Location = new System.Drawing.Point(295, 13);
            this.btn_skip.Name = "btn_skip";
            this.btn_skip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_skip.Size = new System.Drawing.Size(75, 29);
            this.btn_skip.TabIndex = 4;
            this.btn_skip.Text = "Bỏ qua";
            this.btn_skip.UseVisualStyleBackColor = true;
            this.btn_skip.Click += new System.EventHandler(this.btn_skip_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(97, 13);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_edit.Size = new System.Drawing.Size(75, 29);
            this.btn_edit.TabIndex = 1;
            this.btn_edit.Text = "Sửa";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(178, 13);
            this.btn_save.Name = "btn_save";
            this.btn_save.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_save.Size = new System.Drawing.Size(75, 29);
            this.btn_save.TabIndex = 3;
            this.btn_save.Text = "Lưu";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(376, 13);
            this.btn_del.Name = "btn_del";
            this.btn_del.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_del.Size = new System.Drawing.Size(75, 29);
            this.btn_del.TabIndex = 2;
            this.btn_del.Text = "Xóa";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(16, 13);
            this.btn_add.Name = "btn_add";
            this.btn_add.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_add.Size = new System.Drawing.Size(75, 29);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_exportExcel
            // 
            this.btn_exportExcel.Location = new System.Drawing.Point(544, 13);
            this.btn_exportExcel.Name = "btn_exportExcel";
            this.btn_exportExcel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_exportExcel.Size = new System.Drawing.Size(75, 29);
            this.btn_exportExcel.TabIndex = 7;
            this.btn_exportExcel.Text = "Xuất Excel";
            this.btn_exportExcel.UseVisualStyleBackColor = true;
            this.btn_exportExcel.Click += new System.EventHandler(this.btn_exportExcel_Click);
            // 
            // frm_Faculty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 593);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel5);
            this.Name = "frm_Faculty";
            this.Text = "Khoa";
            this.Load += new System.EventHandler(this.frm_Faculty_Load);
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Faculty)).EndInit();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox tbox_search;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbox_tenkhoa;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbox_makhoa;
        private System.Windows.Forms.DataGridView dgv_Faculty;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_skip;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_exportExcel;
    }
}
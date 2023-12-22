namespace QLHS.Views
{
    partial class frm_ChangePassword
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tbox_confirmpass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbox_newpass = new System.Windows.Forms.TextBox();
            this.tbox_oldpass = new System.Windows.Forms.TextBox();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbox_confirmpass);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbox_newpass);
            this.panel1.Controls.Add(this.tbox_oldpass);
            this.panel1.Location = new System.Drawing.Point(106, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 135);
            this.panel1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nhập lại mật khẩu";
            // 
            // tbox_confirmpass
            // 
            this.tbox_confirmpass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_confirmpass.Location = new System.Drawing.Point(140, 87);
            this.tbox_confirmpass.Name = "tbox_confirmpass";
            this.tbox_confirmpass.Size = new System.Drawing.Size(204, 26);
            this.tbox_confirmpass.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mật khẩu mới";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mật khẩu cũ";
            // 
            // tbox_newpass
            // 
            this.tbox_newpass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_newpass.Location = new System.Drawing.Point(140, 53);
            this.tbox_newpass.Name = "tbox_newpass";
            this.tbox_newpass.Size = new System.Drawing.Size(204, 26);
            this.tbox_newpass.TabIndex = 1;
            // 
            // tbox_oldpass
            // 
            this.tbox_oldpass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_oldpass.Location = new System.Drawing.Point(140, 17);
            this.tbox_oldpass.Name = "tbox_oldpass";
            this.tbox_oldpass.Size = new System.Drawing.Size(204, 26);
            this.tbox_oldpass.TabIndex = 0;
            // 
            // btn_confirm
            // 
            this.btn_confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirm.Location = new System.Drawing.Point(243, 216);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(95, 29);
            this.btn_confirm.TabIndex = 4;
            this.btn_confirm.Text = "Xác nhận";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(137, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(307, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "THAY ĐỔI MẬT KHẨU";
            // 
            // frm_ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 280);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "frm_ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbox_confirmpass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbox_newpass;
        private System.Windows.Forms.TextBox tbox_oldpass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Label label4;
    }
}
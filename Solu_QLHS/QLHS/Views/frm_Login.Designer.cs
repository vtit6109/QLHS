namespace QLHS.Views
{
    partial class frm_Login
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
            this.tbox_userName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.link_fogotPass = new System.Windows.Forms.LinkLabel();
            this.check_showpass = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbox_pass = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.link_register = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbox_userName
            // 
            this.tbox_userName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_userName.Location = new System.Drawing.Point(125, 17);
            this.tbox_userName.Name = "tbox_userName";
            this.tbox_userName.Size = new System.Drawing.Size(204, 26);
            this.tbox_userName.TabIndex = 0;
            this.tbox_userName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbox_userName_KeyDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.link_fogotPass);
            this.panel1.Controls.Add(this.check_showpass);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbox_pass);
            this.panel1.Controls.Add(this.tbox_userName);
            this.panel1.Location = new System.Drawing.Point(25, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 118);
            this.panel1.TabIndex = 1;
            // 
            // link_fogotPass
            // 
            this.link_fogotPass.AutoSize = true;
            this.link_fogotPass.Location = new System.Drawing.Point(249, 88);
            this.link_fogotPass.Name = "link_fogotPass";
            this.link_fogotPass.Size = new System.Drawing.Size(80, 13);
            this.link_fogotPass.TabIndex = 5;
            this.link_fogotPass.TabStop = true;
            this.link_fogotPass.Text = "Quên mật khẩu";
            // 
            // check_showpass
            // 
            this.check_showpass.AutoSize = true;
            this.check_showpass.Location = new System.Drawing.Point(125, 88);
            this.check_showpass.Name = "check_showpass";
            this.check_showpass.Size = new System.Drawing.Size(95, 17);
            this.check_showpass.TabIndex = 4;
            this.check_showpass.Text = "Hiện mật khẩu";
            this.check_showpass.UseVisualStyleBackColor = true;
            this.check_showpass.CheckedChanged += new System.EventHandler(this.check_showpass_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên đăng nhập";
            // 
            // tbox_pass
            // 
            this.tbox_pass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_pass.Location = new System.Drawing.Point(125, 55);
            this.tbox_pass.Name = "tbox_pass";
            this.tbox_pass.Size = new System.Drawing.Size(204, 26);
            this.tbox_pass.TabIndex = 1;
            this.tbox_pass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbox_pass_KeyDown);
            // 
            // btn_login
            // 
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Location = new System.Drawing.Point(162, 199);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(95, 29);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "Đăng Nhập";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // link_register
            // 
            this.link_register.AutoSize = true;
            this.link_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_register.Location = new System.Drawing.Point(178, 237);
            this.link_register.Name = "link_register";
            this.link_register.Size = new System.Drawing.Size(62, 18);
            this.link_register.TabIndex = 6;
            this.link_register.TabStop = true;
            this.link_register.Text = "Đăng ký";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(339, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "ĐĂNG NHẬP / ĐĂNG KÝ";
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 283);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.link_register);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập / Đăng ký";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbox_userName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel link_fogotPass;
        private System.Windows.Forms.CheckBox check_showpass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbox_pass;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.LinkLabel link_register;
        private System.Windows.Forms.Label label3;
    }
}
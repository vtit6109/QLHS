﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLHS.DataAccess;
using QLHS.Model;
using QLHS.Views;
using QLHS.Controllers;

namespace QLHS.Views
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
            // Đặt thuộc tính UseSystemPasswordChar để ẩn mật khẩu
            tbox_pass.UseSystemPasswordChar = true;
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            tbox_userName.Focus();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            frm_Control frmControl = new frm_Control();
            frm_Login frmLogin = this;

            string id = tbox_userName.Text;
            string pass = tbox_pass.Text;

            QLHS.Controllers.UserControl userControl = new QLHS.Controllers.UserControl();
            User user = userControl.GetUser(id);

            if (user != null && user.matKhau == pass)
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                frmControl.CurrentUser = user; // Truyền dữ liệu user vào frm_Control
                frmControl.Show(); // Hiển thị frm_Control
                frmLogin.Close();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.");
            }
        }

        private void check_showpass_CheckedChanged(object sender, EventArgs e)
        {
            tbox_pass.UseSystemPasswordChar = !check_showpass.Checked; // sự kiện showpassword
        }

        private void tbox_userName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Ngăn chặn tiếng bíp khi nhấn Enter
                e.SuppressKeyPress = true;
                if (tbox_pass.Text == "")
                {
                    MessageBox.Show("Vui lòng điền mật khẩu !", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }
                // Gọi phương thức đăng nhập
                btn_login_Click(sender, e);
            }
        }

        private void tbox_pass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Ngăn chặn tiếng bíp khi nhấn Enter
                e.SuppressKeyPress = true;

                // Gọi phương thức đăng nhập
                btn_login_Click(sender, e);
            }
        }
    }
}

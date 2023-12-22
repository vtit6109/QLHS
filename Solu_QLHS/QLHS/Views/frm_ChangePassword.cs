using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLHS.Model;
using QLHS.DataAccess;
namespace QLHS.Views
{
    public partial class frm_ChangePassword : Form
    {
        public User CurrentUser { get; set; }

        public frm_ChangePassword()
        {
            InitializeComponent();
            tbox_oldpass.UseSystemPasswordChar = true;
            tbox_newpass.UseSystemPasswordChar = true;
            tbox_oldpass.UseSystemPasswordChar = true;
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            string oldPassword = tbox_oldpass.Text;
            string newPassword = tbox_newpass.Text;
            string confirmPassword = tbox_confirmpass.Text;

            if (oldPassword != CurrentUser.matKhau)
            {
                MessageBox.Show("Mật khẩu cũ không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Mật khẩu mới và mật khẩu xác nhận không khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            QLHS.DataAccess.UserControl userControl = new QLHS.DataAccess.UserControl();

            if (userControl.ChangePassword(CurrentUser.tenTK, newPassword))
            {
                MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra khi cập nhật mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };
        }
    }
}

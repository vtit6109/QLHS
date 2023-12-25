using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLHS.DataAccess;

namespace QLHS.Views
{
    public partial class frm_Student : Form
    {
        DataTable tblStudent;
        public frm_Student()
        {
            InitializeComponent();
        }
        private void frm_Student_Load(object sender, EventArgs e)
        {
            LoadDataGirdView();
        }
        private void LoadDataGirdView()
        {
            string sql;
            sql = "SELECT maSV, hoTen, ngaySinh, maLop FROM SinhVien";
            tblStudent = DataAccess.BaseAccess.GetDataToTable(sql);
            dgv_Student.DataSource = tblStudent;
            dgv_Student.Columns[0].HeaderText = "Mã Sinh Viên";
            dgv_Student.Columns[1].HeaderText = "Họ và Tên";
            dgv_Student.Columns[2].HeaderText = "Ngày Sinh";
            dgv_Student.Columns[3].HeaderText = "Mã Lớp";

            dgv_Student.AllowUserToAddRows = false; // không cho người dùng thêm dữ liệu trực tiếp
            dgv_Student.EditMode = DataGridViewEditMode.EditProgrammatically;

            // Đặt thuộc tính AutoSizeColumnsMode
            dgv_Student.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgv_Student_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btn_add.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbox_masv.Focus();
                return;
            }
            if (tblStudent.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            tbox_masv.Text = dgv_Student.CurrentRow.Cells["maSV"].Value.ToString();
            tbox_tensv.Text = dgv_Student.CurrentRow.Cells["hoTen"].Value.ToString();
            tbox_ngaysinh.Text = dgv_Student.CurrentRow.Cells["ngaySinh"].Value.ToString();
            cb_malop.SelectedItem = dgv_Student.CurrentRow.Cells["maLop"].Value.ToString();

            btn_edit.Enabled = true;
            btn_del.Enabled = true;
            btn_skip.Enabled = true;
        }
        private void ResetValue()
        {
            cb_malop.SelectedIndex = -1;
            tbox_masv.Text = "";
            tbox_tensv.Text = "";
            tbox_ngaysinh.Text = "";

        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            btn_edit.Enabled = false;
            btn_del.Enabled = false;
            btn_skip.Enabled = true;
            btn_save.Enabled = true;
            btn_add.Enabled = false;
            ResetValue();
            tbox_masv.Enabled = true;
            tbox_tensv.Focus();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string sql;
            if (tbox_masv.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbox_masv.Focus();
                return;
            }
            if (tbox_tensv.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbox_tensv.Focus();
                return;
            }
            if (tbox_ngaysinh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbox_ngaysinh.Focus();
                return;
            }
            if (cb_malop.SelectedItem == null)
            {
                MessageBox.Show("Bạn phải chọn mã lớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_malop.Focus();
                return;
            }
            sql = "SELECT maSV FROM SinhVien WHERE maSV=N'" + tbox_masv.Text.Trim() + "'";

            if (BaseAccess.CheckKey(sql))
            {
                MessageBox.Show("Mã sinh viên này đã có, Vui lòng nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbox_masv.Focus();
                return;
            }
            DateTime ngaySinh = DateTime.Parse(tbox_ngaysinh.Text);
            string sqlNgaySinh = ngaySinh.ToString("yyyy-MM-dd");
            sql = "INSERT INTO ChatLieu VALUES(N'" + tbox_masv.Text + "', N'" + tbox_tensv.Text + ", N'" + sqlNgaySinh + ", '" + cb_malop.Text + "')";
            BaseAccess.RunSQL(sql);
            LoadDataGirdView();
            ResetValue();
            btn_del.Enabled = true;
            btn_add.Enabled = true;
            btn_edit.Enabled = true;
            btn_skip.Enabled = false;
            btn_save.Enabled = false;
            tbox_masv.Enabled = false;
        }
    }
}

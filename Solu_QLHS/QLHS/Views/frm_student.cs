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
            string sql;
            tbox_masv.Enabled = false;
            btn_save.Enabled = false;
            btn_skip.Enabled = false;
            LoadDataGirdView();
            sql = "SELECT * FROM Lop";
            BaseAccess.FillCombo(sql, "maLop", "tenLop", cb_malop);
            cb_malop.SelectedIndex = -1;
            ResetValues();

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
            string MaLop;
            string sql;
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
            datePick_birthDay.Value = DateTime.Parse(dgv_Student.CurrentRow.Cells["ngaySinh"].Value.ToString()); ;
            MaLop = dgv_Student.CurrentRow.Cells["maLop"].Value.ToString();
            sql = "SELECT maLop FROM Lop WHERE maLop=N'" + MaLop + "'";
            cb_malop.Text = BaseAccess.GetFieldValues(sql);
            btn_edit.Enabled = true;
            btn_del.Enabled = true;
            btn_skip.Enabled = true;
        }
        private void ResetValues()
        {
            cb_malop.SelectedIndex = -1;
            tbox_masv.Text = "";
            tbox_tensv.Text = "";
            datePick_birthDay.Value = DateTime.Now; 

        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            btn_edit.Enabled = false;
            btn_del.Enabled = false;
            btn_skip.Enabled = true;
            btn_save.Enabled = true;
            btn_add.Enabled = false;
            ResetValues();
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
            string sqlNgaySinh = datePick_birthDay.Value.ToString("yyyy-MM-dd");
            sql = "INSERT INTO SinhVien VALUES(N'" + tbox_masv.Text + "', N'" + tbox_tensv.Text + "', N'" + sqlNgaySinh + "', '" + cb_malop.Text + "')";

            BaseAccess.RunSQL(sql);
            LoadDataGirdView();
            ResetValues();
            btn_del.Enabled = true;
            btn_add.Enabled = true;
            btn_edit.Enabled = true;
            btn_skip.Enabled = false;
            btn_save.Enabled = false;
            tbox_masv.Enabled = false;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblStudent.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                return;
            }
            if (tbox_masv.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbox_masv.Focus();
                return;
            }
            if (tbox_tensv.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên sinh viên", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbox_tensv.Focus();
                return;
            }
            if (cb_malop.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn mã lớp", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_malop.Focus();
                return;
            }
            if (datePick_birthDay.Value >= DateTime.Now)
            {
                MessageBox.Show("Ngày tháng năm sinh phải bé hơn ngày hiện tại", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                datePick_birthDay.Focus();
                return;
            }
            string sqlNgaySinh = datePick_birthDay.Value.ToString("yyyy-MM-dd");
            sql = "UPDATE SinhVien SET hoTen=N'" + tbox_tensv.Text + "', ngaySinh=N'" + sqlNgaySinh + "', maLop='" + cb_malop.Text + "' WHERE maSV=N'" + tbox_masv.Text + "'";
            BaseAccess.RunSQL(sql);
            LoadDataGirdView();
            ResetValues();
            btn_del.Enabled = true;
            btn_add.Enabled = true;
            btn_edit.Enabled = true;
            btn_skip.Enabled = false;
            btn_save.Enabled = false;
            tbox_masv.Enabled = false;
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblStudent.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                return;
            }
            if (tbox_masv.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá bản ghi này không?", "Thông báo",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE SinhVien WHERE maSV=N'" + tbox_masv.Text + "'";
                BaseAccess.RunSqlDel(sql);
                LoadDataGirdView();
                ResetValues();
            }
        }

        private void btn_skip_Click(object sender, EventArgs e)
        {
            ResetValues();
            btn_del.Enabled = true;
            btn_skip.Enabled = true;
            btn_add.Enabled = true;
            btn_skip.Enabled = false;
            btn_save.Enabled = false;
            tbox_masv.Enabled = false;
        }
        private void btn_show_Click(object sender, EventArgs e)
        {
            string sql;
            sql = "SELECT* FROM SinhVien";
            tblStudent = DataAccess.BaseAccess.GetDataToTable(sql);
            dgv_Student.DataSource = tblStudent;
        }


        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string sql;
            if ((tbox_masv.Text == "") && (tbox_tensv.Text == "") && (cb_malop.Text == ""))
            {
                MessageBox.Show("Bạn hãy nhập điều kiện tìm kiếm", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * from SinhVien WHERE 1=1";
            if (tbox_masv.Text != "")
                sql += " AND maSV LIKE N'%" + tbox_masv.Text + "%'";
            if (tbox_tensv.Text != "")
                sql += " AND hoTen LIKE N'%" + tbox_tensv.Text + "%'";
            if (cb_malop.Text != "")
                sql += " AND maLop LIKE N'%" + cb_malop.SelectedValue + "%'";
            tblStudent = BaseAccess.GetDataToTable(sql);
            if (tblStudent.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thoả mãn điều kiện tìm kiếm!", "Thôngbáo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Có " + tblStudent.Rows.Count + "  bản ghi thoả mãn điều kiện!",
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgv_Student.DataSource = tblStudent;
            ResetValues();
        }
    }
}

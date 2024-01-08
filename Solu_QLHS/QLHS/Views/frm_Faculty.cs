using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataGridViewAutoFilter; // thư viện filter 
using Excel = Microsoft.Office.Interop.Excel;

using System.Windows.Forms;
using QLHS.DataAccess;
using QLHS.Controllers;
using QLHS.Model;
namespace QLHS.Views
{
    public partial class frm_Faculty : Form
    {

        private BindingSource bindingSource = new BindingSource();
        FacultyControl facultyControl = new FacultyControl();
        public frm_Faculty()
        {
            InitializeComponent();
        }

        private void frm_Faculty_Load(object sender, EventArgs e)
        {
            tbox_makhoa.Enabled = false;
            btn_save.Enabled = false;
            btn_skip.Enabled = false;
            LoadDataGridView();
            ResetValues();
        }
        private void LoadDataGridView()
        {
            // Sử dụng phương thức GetFaculties từ lớp FacultyControl
            DataTable faculties = facultyControl.GetFaculties();

            // Liên kết BindingSource với dữ liệu
            bindingSource.DataSource = faculties;
            dgv_Faculty.DataSource = bindingSource;
            foreach (DataGridViewColumn column in dgv_Faculty.Columns)
            {
                column.HeaderCell = new DataGridViewAutoFilterColumnHeaderCell(column.HeaderCell);
            }

            dgv_Faculty.Columns[0].HeaderText = "Mã Khoa";
            dgv_Faculty.Columns[1].HeaderText = "Tên Khoa";

            dgv_Faculty.AllowUserToAddRows = false; // không cho người dùng thêm dữ liệu trực tiếp
            dgv_Faculty.EditMode = DataGridViewEditMode.EditProgrammatically;

            // Đặt thuộc tính AutoSizeColumnsMode
            dgv_Faculty.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

     

        private void dgv_Faculty_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string maKhoa = dgv_Faculty.CurrentRow.Cells["maKhoa"].Value.ToString();
            Faculty faculty = facultyControl.GetFacultyByMaKhoa(maKhoa);

            if (faculty != null)
            {
                tbox_makhoa.Text = faculty.maKhoa;
                tbox_tenkhoa.Text = faculty.tenKhoa;
            }

            btn_edit.Enabled = true;
            btn_del.Enabled = true;
            btn_skip.Enabled = true;
        }
        private void ResetValues()
        {
            Faculty emptyFaculty = facultyControl.GetEmptyFaculty();
            tbox_makhoa.Text = emptyFaculty.maKhoa;
            tbox_tenkhoa.Text = emptyFaculty.tenKhoa;
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            btn_edit.Enabled = false;
            btn_del.Enabled = false;
            btn_skip.Enabled = true;
            btn_save.Enabled = true;
            btn_add.Enabled = false;
            ResetValues();
            tbox_makhoa.Enabled = true;
            tbox_tenkhoa.Focus();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Faculty faculty = new Faculty()
            {
                maKhoa = tbox_makhoa.Text,
                tenKhoa = tbox_tenkhoa.Text
            };

            facultyControl.AddFaculty(faculty);
            MessageBox.Show("Thêm mới thành công!");
            LoadDataGridView();
            ResetValues();

            btn_del.Enabled = true;
            btn_add.Enabled = true;
            btn_edit.Enabled = true;
            btn_skip.Enabled = false;
            btn_save.Enabled = false;
            tbox_makhoa.Enabled = false;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            Faculty faculty = new Faculty()
            {
                maKhoa = tbox_makhoa.Text,
                tenKhoa = tbox_tenkhoa.Text
            };

            facultyControl.UpdateFaculty(faculty);
            MessageBox.Show("Cập nhật thành công!");
            LoadDataGridView();
            ResetValues();

            btn_del.Enabled = true;
            btn_add.Enabled = true;
            btn_edit.Enabled = true;
            btn_skip.Enabled = false;
            btn_save.Enabled = false;
            tbox_makhoa.Enabled = false;
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            DataTable faculties = facultyControl.GetFaculties();
            bindingSource.DataSource = faculties;

            if (faculties.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                return;
            }
            if (tbox_makhoa.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá bản ghi này không?", "Thông báo",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                facultyControl.DeleteFaculty(tbox_makhoa.Text);
                MessageBox.Show("Xóa thành công!");
                LoadDataGridView();
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
            tbox_makhoa.Enabled = false;
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            DataTable students = facultyControl.GetAllStudents();
            bindingSource.DataSource = students;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (tbox_search.Text == "")
            {
                MessageBox.Show("Bạn hãy nhập điều kiện tìm kiếm", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable faculties = facultyControl.SearchFaculties(tbox_search.Text);
            if (faculties.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Có {faculties.Rows.Count} kết quả tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bindingSource.DataSource = faculties;
                ResetValues();
            }
        }

        private void tbox_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Ngăn chặn tiếng bíp khi nhấn Enter
                e.SuppressKeyPress = true;

                // Gọi phương thức tìm kiếm
                btn_search_Click(sender, e);
            }
        }

        private void btn_exportExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel files (*.xls)|*.xls";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Tạo ứng dụng Excel mới
                Excel.Application xlApp = new Excel.Application();

                if (xlApp == null)
                {
                    MessageBox.Show("Excel is not properly installed!!");
                    return;
                }

                // Tạo một workbook mới
                Excel.Workbook xlWorkBook;
                Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;

                xlWorkBook = xlApp.Workbooks.Add(misValue);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                // Thêm dữ liệu vào các ô
                for (int i = 0; i < dgv_Faculty.ColumnCount; i++)
                {
                    xlWorkSheet.Cells[1, i + 1] = dgv_Faculty.Columns[i].HeaderText;
                }

                for (int i = 0; i < dgv_Faculty.RowCount; i++)
                {
                    for (int j = 0; j < dgv_Faculty.ColumnCount; j++)
                    {
                        xlWorkSheet.Cells[i + 2, j + 1] = dgv_Faculty.Rows[i].Cells[j].Value.ToString();
                    }
                }

                // Lưu workbook
                xlWorkBook.SaveAs(saveFileDialog.FileName, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                xlWorkBook.Close(true, misValue, misValue);
                xlApp.Quit();

                // Giải phóng các đối tượng
                ReleaseObject(xlWorkSheet);
                ReleaseObject(xlWorkBook);
                ReleaseObject(xlApp);

                MessageBox.Show("Exported successfully to Excel!");
            }
        }

        private void ReleaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Unable to release the Object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}

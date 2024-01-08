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
    public partial class frm_Student : Form
    {
        private BindingSource bindingSource = new BindingSource();
         StudentControl Students = new StudentControl();

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
            LoadDataGridView();
            sql = "SELECT * FROM Lop";
            BaseAccess.FillCombo(sql, "maLop", "tenLop", cb_malop);
            cb_malop.SelectedIndex = -1;
            ResetValues();

        }
        private void LoadDataGridView()
        {
            DataTable students = Students.GetStudents();
            bindingSource.DataSource = students;
            dgv_Student.DataSource = bindingSource;
            foreach (DataGridViewColumn column in dgv_Student.Columns)
            {
                column.HeaderCell = new DataGridViewAutoFilterColumnHeaderCell(column.HeaderCell);
            }

            dgv_Student.Columns[0].HeaderText = "Mã Sinh Viên";
            dgv_Student.Columns[1].HeaderText = "Họ & Tên Sinh Viên";
            dgv_Student.Columns[2].HeaderText = "Ngày Tháng Năm Sinh";
            dgv_Student.Columns[3].HeaderText = "Mã Lớp";


            dgv_Student.AllowUserToAddRows = false; // không cho người dùng thêm dữ liệu trực tiếp
            dgv_Student.EditMode = DataGridViewEditMode.EditProgrammatically;

            // Đặt thuộc tính AutoSizeColumnsMode
            dgv_Student.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgv_Student_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string maSV = dgv_Student.CurrentRow.Cells["maSV"].Value.ToString();
            Student student = Students.GetStudentByMaSV(maSV);

            if (student != null)
            {
                tbox_masv.Text = student.maSV;
                tbox_tensv.Text = student.hoTen;
                datePick_birthDay.Value = student.ngaySinh;
                cb_malop.Text = student.maLop;
            }
        }
        private void ResetValues()
        {
           /* Student emptyStudent = Students.GetEmptyStudent();
            tbox_masv.Text = emptyStudent.maSV;
            tbox_tensv.Text = emptyStudent.hoTen;
            datePick_birthDay.Value = emptyStudent.ngaySinh;
            cb_malop.Text = emptyStudent.maLop;*/

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
            Student student = new Student()
            {
                maSV = tbox_masv.Text,
                hoTen = tbox_tensv.Text,
                ngaySinh = datePick_birthDay.Value,
                maLop = cb_malop.Text
            };

            Students.AddStudent(student);
            MessageBox.Show("Thêm mới thành công!");
            LoadDataGridView();
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
            Student student = new Student()
            {
                maSV = tbox_masv.Text,
                hoTen = tbox_tensv.Text,
                ngaySinh = datePick_birthDay.Value,
                maLop = cb_malop.Text
            };

            Students.UpdateStudent(student);
            MessageBox.Show("Cập nhật thành công!");
            LoadDataGridView();
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
            string maSV = tbox_masv.Text;
            Students.DeleteStudent(maSV);
            MessageBox.Show("Xóa thành công!");
            LoadDataGridView();
            ResetValues();

            btn_del.Enabled = true;
            btn_add.Enabled = true;
            btn_edit.Enabled = true;
            btn_skip.Enabled = false;
            btn_save.Enabled = false;
            tbox_masv.Enabled = false;
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
            DataTable students = Students.GetAllStudents();
            bindingSource.DataSource = students;
            dgv_Student.DataSource = bindingSource;
        }


        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string keyword = tbox_search.Text;
            DataTable students = Students.SearchStudents(keyword);
            bindingSource.DataSource = students;
            dgv_Student.DataSource = bindingSource;
        }

        private void tbox_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                e.SuppressKeyPress = true;

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
                for (int i = 0; i < dgv_Student.ColumnCount; i++)
                {
                    xlWorkSheet.Cells[1, i + 1] = dgv_Student.Columns[i].HeaderText;
                }

                for (int i = 0; i < dgv_Student.RowCount; i++)
                {
                    for (int j = 0; j < dgv_Student.ColumnCount; j++)
                    {
                        xlWorkSheet.Cells[i + 2, j + 1] = dgv_Student.Rows[i].Cells[j].Value.ToString();
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

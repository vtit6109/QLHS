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
    public partial class frm_Subject : Form
    {
        private BindingSource bindingSource = new BindingSource();
        SubjectControl subjectControl = new SubjectControl();
        public frm_Subject()
        {
            InitializeComponent();
        }

        private void frm_Subject_Load(object sender, EventArgs e)
        {
            tbox_maMH.Enabled = false;
            btn_save.Enabled = false;
            btn_skip.Enabled = false;
            LoadDataGridView();
            ResetValues();
        }

        private void LoadDataGridView()
        {
            // Sử dụng phương thức GetFaculties từ lớp FacultyControl
            DataTable subjects = subjectControl.GetSubjects();

            // Liên kết BindingSource với dữ liệu
            bindingSource.DataSource = subjects;
            dgv_Subject.DataSource = bindingSource;
            foreach (DataGridViewColumn column in dgv_Subject.Columns)
            {
                column.HeaderCell = new DataGridViewAutoFilterColumnHeaderCell(column.HeaderCell);
            }

            dgv_Subject.Columns[0].HeaderText = "Mã Môn Học";
            dgv_Subject.Columns[1].HeaderText = "Tên Môn Học";

            dgv_Subject.AllowUserToAddRows = false; // không cho người dùng thêm dữ liệu trực tiếp
            dgv_Subject.EditMode = DataGridViewEditMode.EditProgrammatically;

            // Đặt thuộc tính AutoSizeColumnsMode
            dgv_Subject.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ResetValues()
        {
            Subject emptySubject = subjectControl.GetEmptySubject();
            tbox_maMH.Text = emptySubject.maMonHoc;
            tbox_tenMH.Text = emptySubject.tenMonHoc;
        }

        private void dgv_Subject_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            string maMonHoc = dgv_Subject.CurrentRow.Cells["maMonHoc"].Value.ToString();
            Subject subject = subjectControl.GetSubjectBymaMonHoc(maMonHoc);

            if (subject != null)
            {
                tbox_maMH.Text = subject.maMonHoc;
                tbox_tenMH.Text = subject.tenMonHoc;
            }

            btn_edit.Enabled = true;
            btn_del.Enabled = true;
            btn_skip.Enabled = true;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            btn_edit.Enabled = false;
            btn_del.Enabled = false;
            btn_skip.Enabled = true;
            btn_save.Enabled = true;
            btn_add.Enabled = false;
            ResetValues();
            tbox_maMH.Enabled = true;
            tbox_tenMH.Focus();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Subject subject = new Subject()
            {
                maMonHoc = tbox_maMH.Text,
                tenMonHoc = tbox_tenMH.Text
            };

            subjectControl.AddSubject(subject);
            MessageBox.Show("Thêm mới thành công!");
            LoadDataGridView();
            ResetValues();

            btn_del.Enabled = true;
            btn_add.Enabled = true;
            btn_edit.Enabled = true;
            btn_skip.Enabled = false;
            btn_save.Enabled = false;
            tbox_maMH.Enabled = false;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            Subject subject = new Subject()
            {
                maMonHoc = tbox_maMH.Text,
                tenMonHoc = tbox_tenMH.Text
            };

            subjectControl.UpdateSubject(subject);
            MessageBox.Show("Cập nhật thành công!");
            LoadDataGridView();
            ResetValues();

            btn_del.Enabled = true;
            btn_add.Enabled = true;
            btn_edit.Enabled = true;
            btn_skip.Enabled = false;
            btn_save.Enabled = false;
            tbox_maMH.Enabled = false;
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            DataTable subjects = subjectControl.GetSubjects();
            bindingSource.DataSource = subjects;

            if (subjects.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                return;
            }
            if (tbox_maMH.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá bản ghi này không?", "Thông báo",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                subjectControl.DeleteSubject(tbox_maMH.Text);
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
            tbox_maMH.Enabled = false;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            DataTable subject = subjectControl.GetAllSubject();
            bindingSource.DataSource = subject;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (tbox_search.Text == "")
            {
                MessageBox.Show("Bạn hãy nhập điều kiện tìm kiếm", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable subjects = subjectControl.SearchSubject(tbox_search.Text);
            if (subjects.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Có {subjects.Rows.Count} kết quả tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bindingSource.DataSource = subjects;
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
                for (int i = 0; i < dgv_Subject.ColumnCount; i++)
                {
                    xlWorkSheet.Cells[1, i + 1] = dgv_Subject.Columns[i].HeaderText;
                }

                for (int i = 0; i < dgv_Subject.RowCount; i++)
                {
                    for (int j = 0; j < dgv_Subject.ColumnCount; j++)
                    {
                        xlWorkSheet.Cells[i + 2, j + 1] = dgv_Subject.Rows[i].Cells[j].Value.ToString();
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

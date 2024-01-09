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
    public partial class frm_Class : Form
    {

        private BindingSource bindingSource = new BindingSource();
        ClassControl Class = new ClassControl();

        public frm_Class()
        {
            InitializeComponent();
        }

        private void frm_Class_Load(object sender, EventArgs e)
        {
            string sql;
            tbox_malop.Enabled = false;
            btn_save.Enabled = false;
            btn_skip.Enabled = false;
            LoadDataGridView();
            sql = "SELECT * FROM Khoa";
            BaseAccess.FillCombo(sql, "maKhoa", "tenKhoa", cb_makhoa);
            cb_makhoa.SelectedIndex = -1;
            ResetValues();
        }
        private void LoadDataGridView()
        {
            DataTable _class = Class.GetClass();
            bindingSource.DataSource = _class;
            dgv_Class.DataSource = bindingSource;
            foreach (DataGridViewColumn column in dgv_Class.Columns)
            {
                column.HeaderCell = new DataGridViewAutoFilterColumnHeaderCell(column.HeaderCell);
            }

            dgv_Class.Columns[0].HeaderText = "Mã Lớp";
            dgv_Class.Columns[1].HeaderText = "Tên Lớp";
            dgv_Class.Columns[2].HeaderText = "Mã Khoa";


            dgv_Class.AllowUserToAddRows = false; // không cho người dùng thêm dữ liệu trực tiếp
            dgv_Class.EditMode = DataGridViewEditMode.EditProgrammatically;

            // Đặt thuộc tính AutoSizeColumnsMode
            dgv_Class.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void ResetValues()
        {
            Class emptyClass = Class.GetEmptyClass();
            tbox_malop.Text = emptyClass.maLop;
            tbox_tenlop.Text = emptyClass.tenLop;
            cb_makhoa.Text = emptyClass.maKhoa;
        }

        private void dgv_Class_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string maLop = dgv_Class.CurrentRow.Cells["maLop"].Value.ToString();
            Class _class = Class.GetClassBymaLop(maLop);

            if (_class != null)
            {
                tbox_malop.Text = _class.maLop;
                tbox_tenlop.Text = _class.tenLop;
                cb_makhoa.Text = _class.maKhoa;
            }
            btn_save.Enabled = false;
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
            tbox_malop.Enabled = true;
            tbox_tenlop.Focus();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Class _class = new Class()
            {
                maLop = tbox_malop.Text,
                tenLop = tbox_tenlop.Text,
                maKhoa = cb_makhoa.Text
            };

            Class.AddClass(_class);
            MessageBox.Show("Thêm mới thành công!");
            LoadDataGridView();
            ResetValues();

            btn_del.Enabled = true;
            btn_add.Enabled = true;
            btn_edit.Enabled = true;
            btn_skip.Enabled = false;
            btn_save.Enabled = false;
            tbox_malop.Enabled = false;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            Class _class = new Class()
            {
                maLop = tbox_malop.Text,
                tenLop = tbox_tenlop.Text,
                maKhoa = cb_makhoa.Text
            };
            Class.UpdateClass(_class);
            MessageBox.Show("Sửa dữ liệu thành công!");
            LoadDataGridView();
            ResetValues();

            btn_del.Enabled = true;
            btn_add.Enabled = true;
            btn_edit.Enabled = true;
            btn_skip.Enabled = false;
            btn_save.Enabled = false;
            tbox_malop.Enabled = false;
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            string maLop = tbox_malop.Text;
            Class.DeleteClass(maLop);
            MessageBox.Show("Xóa Thành công");
            LoadDataGridView();
            ResetValues();

            btn_del.Enabled = true;
            btn_add.Enabled = true;
            btn_edit.Enabled = true;
            btn_skip.Enabled = false;
            btn_save.Enabled = false;
            tbox_malop.Enabled = false;
        }

        private void btn_skip_Click(object sender, EventArgs e)
        {
            ResetValues();
            btn_del.Enabled = true;
            btn_skip.Enabled = true;
            btn_add.Enabled = true;
            btn_skip.Enabled = false;
            btn_save.Enabled = false;
            tbox_malop.Enabled = false;
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            DataTable _class = Class.GetAllClass();
            bindingSource.DataSource = _class;
            dgv_Class.DataSource = bindingSource;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string keyword = tbox_search.Text;
            DataTable _class = Class.SearchClass(keyword);

            bindingSource.DataSource = _class;
            dgv_Class.DataSource = bindingSource;
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
                for (int i = 0; i < dgv_Class.ColumnCount; i++)
                {
                    xlWorkSheet.Cells[1, i + 1] = dgv_Class.Columns[i].HeaderText;
                }

                for (int i = 0; i < dgv_Class.RowCount; i++)
                {
                    for (int j = 0; j < dgv_Class.ColumnCount; j++)
                    {
                        xlWorkSheet.Cells[i + 2, j + 1] = dgv_Class.Rows[i].Cells[j].Value.ToString();
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            sql = "SELECT maSV, hoTen, ngaySinh FROM SinhVien";
            tblStudent = DataAccess.BaseAccess.GetDataToTable(sql);
            dgv_Student.DataSource = tblStudent;
            dgv_Student.Columns[0].HeaderText = "Mã Sinh Viên";
            dgv_Student.Columns[1].HeaderText = "Họ và Tên";
            dgv_Student.Columns[2].HeaderText = "Ngày Sinh";
            dgv_Student.Columns[0].Width = 100;
            dgv_Student.Columns[0].Width = 300;
            dgv_Student.AllowUserToAddRows = true; // không cho người dùng thêm dữ liệu trực tiếp
            dgv_Student.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

       
    }
}

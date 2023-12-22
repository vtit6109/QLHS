using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using QLHS.Model;
using QLHS.DataAccess;

namespace QLHS.DataAccess
{
    public class Connection
    {
        private static string _connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLHS;Integrated Security=True";

        public SqlConnection SqlConnection { get; private set; } //tạo một thuộc tính SqlConnection có thể truy cập được từ bên ngoài lớp (do từ khóa public), nhưng chỉ có thể được gán giá trị từ bên trong lớp (do từ khóa private)

        public void Connect()
        {
            try
            {
                if (SqlConnection == null || SqlConnection.State == ConnectionState.Closed)
                {
                    SqlConnection = new SqlConnection(_connectionString);
                    SqlConnection.Open();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể kết nối đến máy chủ, vui lòng thử lại...", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Disconnect()
        {
            try
            {
                if (SqlConnection != null && SqlConnection.State == ConnectionState.Open)
                {
                    SqlConnection.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể ngắt kết nối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

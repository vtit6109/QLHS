using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLHS.DataAccess
{
    public class Connection
    {
        private string _connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLHS;Integrated Security=True";
        private SqlConnection _sqlConnection;

        public SqlConnection SqlConnection
        {
            get { return _sqlConnection; }
        }

        public void Connect()
        {
            try
            {
                _sqlConnection = new SqlConnection(_connectionString);
                _sqlConnection.Open();
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
                _sqlConnection.Close();
                MessageBox.Show("Đã ngắt kết nối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể ngắt kết nối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

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

        public static SqlConnection SqlConnection = new SqlConnection();

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

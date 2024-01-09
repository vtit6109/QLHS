using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using QLHS.DataAccess;
namespace QLHS.DataAccess
{
    public class BaseAccess
    {
        public static DataTable GetDataToTable(string sql)
        {
            Connection connection = new Connection();
            connection.Connect();
            SqlDataAdapter dap = new SqlDataAdapter(sql, DataAccess.Connection.SqlConnection);
            DataTable table = new DataTable();
            dap.Fill(table);

            connection.Disconnect();
            return table;
        }
        public static bool CheckKey(string sql)
        {
            Connection connection = new Connection();
            connection.Connect();
            SqlDataAdapter dap = new SqlDataAdapter(sql, DataAccess.Connection.SqlConnection);
            DataTable table = new DataTable();
            dap.Fill(table);
            connection.Disconnect();
            if (table.Rows.Count > 0)
                return true;
            else return false;
        }

        public static void RunSQL(string sql)
        {
            Connection connection = new Connection();
            connection.Connect();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = DataAccess.Connection.SqlConnection;
            cmd.CommandText = sql;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cmd.Dispose();
            cmd = null;
            connection.Disconnect();
        }
        public static void FillCombo(string sql, string id, string name, ComboBox cbo)
        {
            SqlDataAdapter dap = new SqlDataAdapter(sql, DataAccess.Connection.SqlConnection);
            DataTable table = new DataTable();
            dap.Fill(table);
            cbo.DataSource = table;
            cbo.DisplayMember = id;
            cbo.ValueMember = id;
        }
        public static void RunSqlDel(string sql)
        {
            Connection connection = new Connection();
            connection.Connect();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = DataAccess.Connection.SqlConnection;
            cmd.CommandText = sql;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi xóa dữ liệu", "Không thể xóa!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                MessageBox.Show(ex.ToString());
            }
            cmd.Dispose();
            cmd = null;
        }
        public static string GetFieldValues(string sql)
        {
            string ma = "";
            Connection connection = new Connection();
            connection.Connect();
            SqlCommand cmd = new SqlCommand(sql, DataAccess.Connection.SqlConnection);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
                ma = reader.GetValue(0).ToString();
            reader.Close();
            return ma;
        }
    }
}

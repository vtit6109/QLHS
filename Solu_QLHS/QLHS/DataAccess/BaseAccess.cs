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
    class BaseAccess
    {
        public static DataTable GetDataToTable(string sql)
        {
            Connection connection = new Connection();
            connection.Connect();
            SqlDataAdapter dap = new SqlDataAdapter(sql, connection.SqlConnection);
            DataTable table = new DataTable();
            dap.Fill(table);

            connection.Disconnect();
            return table;
        }
        public static bool CheckKey(string sql)
        {
            Connection connection = new Connection();
            connection.Connect();
            SqlDataAdapter dap = new SqlDataAdapter(sql, connection.SqlConnection);
            DataTable table = new DataTable();
            dap.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            else return false;
        }

        public static void RunSQL(string sql)
        {
            Connection connection = new Connection();
            connection.Connect();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection.SqlConnection;
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
        }
    }
}

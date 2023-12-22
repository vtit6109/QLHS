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
    }
}

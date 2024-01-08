using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QLHS.Model;
using QLHS.DataAccess;

namespace QLHS.Controllers
{
    public class UserControl
    {
        Connection connection = new Connection();
        public User GetUser(string tentk)
        {
            User user = null;
            connection.Connect();

            using (SqlCommand command = new SqlCommand("select * from TaiKhoan WHERE tenTK = @tenTK", DataAccess.Connection.SqlConnection))
            {
                command.Parameters.AddWithValue("@tenTK", tentk);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        user = new User()
                        {
                            tenTK = reader["tenTK"].ToString(),
                            matKhau = reader["matKhau"].ToString(),
                            tenNguoidung = reader["tenNguoidung"].ToString(),
                        };
                    }
                }
            }
            return user;
        }
        public bool ChangePassword(string tentk, string newPassword)
        {
            bool result = false;
            connection.Connect();

            using (SqlCommand command = new SqlCommand("UPDATE TaiKhoan SET matKhau = @newPassword WHERE tenTK = @tenTK", DataAccess.Connection.SqlConnection))
            {
                command.Parameters.AddWithValue("@tenTK", tentk);
                command.Parameters.AddWithValue("@newPassword", newPassword);

                if (command.ExecuteNonQuery() > 0)
                {
                    result = true;
                }
            }
            return result;
        }
    }
}

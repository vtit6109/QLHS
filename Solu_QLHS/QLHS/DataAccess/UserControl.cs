using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using QLHS.Model;
namespace QLHS.DataAccess
{
    class UserControl
    {
        private string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLHS;Integrated Security=True";
        public User GetUser(string tentk)
        {
            User user = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("select * from TaiKhoan WHERE tenTK = @tenTK", connection))
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
            }

            return user;
        }

    }
}

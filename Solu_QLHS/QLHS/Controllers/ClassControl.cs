using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLHS.DataAccess;
using QLHS.Model;

namespace QLHS.Controllers
{
    class ClassControl
    {
        Connection connection = new Connection();

        public DataTable GetClass()
        {
            connection.Connect();
            string sql = "SELECT * FROM Lop";
            DataTable students = BaseAccess.GetDataToTable(sql);
            connection.Disconnect();
            return students;
        }

        public Class GetEmptyClass()
        {
            return new Class()
            {
                maLop = "",
                tenLop = "",
                maKhoa = ""
            };
        }

        public void AddClass(Class _class)
        {
            connection.Connect();
            string sql = $"INSERT INTO Lop VALUES(N'{_class.maLop}', N'{_class.tenLop}', N'{_class.maKhoa}')";
            BaseAccess.RunSQL(sql);
            connection.Disconnect();
        }

        public Class GetClassBymaLop(string maLop)
        {
            connection.Connect();
            string sql = $"SELECT * FROM Lop WHERE maLop=N'{maLop}'";
            DataTable classTable = BaseAccess.GetDataToTable(sql);
            connection.Disconnect();

            if (classTable.Rows.Count > 0)
            {
                DataRow row = classTable.Rows[0];
                return new Class()
                {
                    maLop = row["maLop"].ToString(),
                    tenLop = row["tenLop"].ToString(),
                    maKhoa = row["maKhoa"].ToString()
                };
            }
            return null;
        }

        public void UpdateClass(Class _class)
        {
            connection.Connect();
            string sql = $"UPDATE Lop SET tenLop=N'{_class.tenLop}', maKhoa=N'{_class.maKhoa}' WHERE maLop=N'{_class.maLop}'";
            BaseAccess.RunSQL(sql);
            connection.Disconnect();
        }

        public void DeleteClass(string maLop)
        {
            connection.Connect();
            string sql = $"DELETE Lop WHERE maLop=N'{maLop}'";
            BaseAccess.RunSQL(sql);
            connection.Disconnect();
        }

        public DataTable GetAllClass()
        {
            connection.Connect();
            string sql = "SELECT * FROM Lop";
            DataTable _class = BaseAccess.GetDataToTable(sql);
            connection.Disconnect();
            return _class;
        }

        public DataTable SearchClass(string keyword)
        {
            connection.Connect();
            string sql = $"SELECT * FROM Lop WHERE maLop LIKE N'%{keyword}%' OR tenLop LIKE N'%{keyword}%' OR maKhoa LIKE N'%{keyword}%'";
            DataTable _class = BaseAccess.GetDataToTable(sql);
            connection.Disconnect();
            return _class;
        }

    }
}

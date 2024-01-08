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
    public class FacultyControl
    {
        Connection connection = new Connection();

        public DataTable GetFaculties()
        {
            connection.Connect();
            string sql = "SELECT * FROM Khoa";
            DataTable faculties = BaseAccess.GetDataToTable(sql);
            connection.Disconnect();
            return faculties;
        }
        public Faculty GetEmptyFaculty()
        {
            return new Faculty()
            {
                maKhoa = "",
                tenKhoa = ""
            };
        }
        public void AddFaculty(Faculty faculty)
        {
            connection.Connect();
            string sql = $"INSERT INTO Khoa VALUES(N'{faculty.maKhoa}', N'{faculty.tenKhoa}')";
            BaseAccess.RunSQL(sql);
            connection.Disconnect();
        }

        public Faculty GetFacultyByMaKhoa(string maKhoa)
        {
            connection.Connect();
            string sql = $"SELECT * FROM Khoa WHERE maKhoa=N'{maKhoa}'";
            DataTable facultyTable = BaseAccess.GetDataToTable(sql);
            connection.Disconnect();

            if (facultyTable.Rows.Count > 0)
            {
                DataRow row = facultyTable.Rows[0];
                return new Faculty()
                {
                    maKhoa = row["maKhoa"].ToString(),
                    tenKhoa = row["tenKhoa"].ToString()
                };
            }

            return null;
        }
        public void UpdateFaculty(Faculty faculty)
        {
            connection.Connect();
            string sql = $"UPDATE Khoa SET tenKhoa=N'{faculty.tenKhoa}' WHERE maKhoa=N'{faculty.maKhoa}'";
            BaseAccess.RunSQL(sql);
            connection.Disconnect();
        }

        public void DeleteFaculty(string maKhoa)
        {
            connection.Connect();
            string sql = $"DELETE Khoa WHERE maKhoa=N'{maKhoa}'";
            BaseAccess.RunSQL(sql);
            connection.Disconnect();
        }

   
        public DataTable GetAllStudents()
        {
            connection.Connect();
            string sql = "SELECT * FROM Khoa";
            DataTable students = BaseAccess.GetDataToTable(sql);
            connection.Disconnect();
            return students;
        }

        public DataTable SearchFaculties(string keyword)
        {
            connection.Connect();
            string sql = $"SELECT * FROM Khoa WHERE maKhoa LIKE N'%{keyword}%' OR tenKhoa LIKE N'%{keyword}%'";
            DataTable faculties = BaseAccess.GetDataToTable(sql);
            connection.Disconnect();
            return faculties;
        }

       }
   }

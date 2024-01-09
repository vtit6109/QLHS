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
    public class StudentControl
    {
        Connection connection = new Connection();

        public DataTable GetStudents()
        {
            connection.Connect();
            string sql = "SELECT * FROM SinhVien";
            DataTable students = BaseAccess.GetDataToTable(sql);
            connection.Disconnect();
            return students;
        }

        public Student GetEmptyStudent()
        {
            return new Student()
            {
                maSV = "",
                hoTen = "",
                ngaySinh = DateTime.Now,
                maLop = ""
            };
        }

        public void AddStudent(Student student)
        {
            connection.Connect();
            string sql = $"INSERT INTO SinhVien VALUES(N'{student.maSV}', N'{student.hoTen}', '{student.ngaySinh.ToString("yyyy-MM-dd")}', N'{student.maLop}')";
            BaseAccess.RunSQL(sql);
            connection.Disconnect();
        }

        public Student GetStudentByMaSV(string maSV)
        {
            connection.Connect();
            string sql = $"SELECT * FROM SinhVien WHERE maSV=N'{maSV}'";
            DataTable studentTable = BaseAccess.GetDataToTable(sql);
            connection.Disconnect();

            if (studentTable.Rows.Count > 0)
            {
                DataRow row = studentTable.Rows[0];
                return new Student()
                {
                    maSV = row["maSV"].ToString(),
                    hoTen = row["hoTen"].ToString(),
                    ngaySinh = DateTime.Parse(row["ngaySinh"].ToString()),
                    maLop = row["maLop"].ToString()
                };
            }
            return null;
        }

        public void UpdateStudent(Student student)
        {
            connection.Connect();
            string sql = $"UPDATE SinhVien SET hoTen=N'{student.hoTen}', ngaySinh='{student.ngaySinh.ToString("yyyy-MM-dd")}', maLop=N'{student.maLop}' WHERE maSV=N'{student.maSV}'";
            BaseAccess.RunSQL(sql);
            connection.Disconnect();
        }

        public void DeleteStudent(string maSV)
        {
            connection.Connect();
            string sql = $"DELETE SinhVien WHERE maSV=N'{maSV}'";
            BaseAccess.RunSQL(sql);
            connection.Disconnect();
        }

        public DataTable GetAllStudents()
        {
            connection.Connect();
            string sql = "SELECT * FROM SinhVien";
            DataTable students = BaseAccess.GetDataToTable(sql);
            connection.Disconnect();
            return students;
        }

        public DataTable SearchStudents(string keyword)
        {
            connection.Connect();
            string sql = $"SELECT * FROM SinhVien WHERE maSV LIKE N'%{keyword}%' OR hoTen LIKE N'%{keyword}%' OR maLop LIKE N'%{keyword}%'";
            DataTable students = BaseAccess.GetDataToTable(sql);
            connection.Disconnect();
            return students;
        }
    }
}

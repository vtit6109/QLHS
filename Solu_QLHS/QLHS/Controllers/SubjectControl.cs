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
    class SubjectControl
    {
        Connection connection = new Connection();

        public DataTable GetSubjects()
        {
            connection.Connect();
            string sql = "SELECT * FROM MonHoc";
            DataTable subjects = BaseAccess.GetDataToTable(sql);
            connection.Disconnect();
            return subjects;
        }
        public Subject GetEmptySubject()
        {
            return new Subject()
            {
                maMonHoc = "",
                tenMonHoc = ""
            };
        }
        public void AddSubject(Subject subject)
        {
            connection.Connect();
            string sql = $"INSERT INTO MonHoc VALUES(N'{subject.maMonHoc}', N'{subject.tenMonHoc}')";
            BaseAccess.RunSQL(sql);
            connection.Disconnect();
        }

        public Subject GetSubjectBymaMonHoc(string maMonHoc)
        {
            connection.Connect();
            string sql = $"SELECT * FROM MonHoc WHERE maMonHoc=N'{maMonHoc}'";
            DataTable SubjectTable = BaseAccess.GetDataToTable(sql);
            connection.Disconnect();

            if (SubjectTable.Rows.Count > 0)
            {
                DataRow row = SubjectTable.Rows[0];
                return new Subject()
                {
                    maMonHoc = row["maMonHoc"].ToString(),
                    tenMonHoc = row["tenMonHoc"].ToString()
                };
            }

            return null;
        }
        public void UpdateSubject(Subject subject)
        {
            connection.Connect();
            string sql = $"UPDATE MonHoc SET tenMonHoc=N'{subject.tenMonHoc}' WHERE maMonHoc=N'{subject.maMonHoc}'";
            BaseAccess.RunSQL(sql);
            connection.Disconnect();
        }

        public void DeleteSubject(string maMonHoc)
        {
            connection.Connect();
            string sql = $"DELETE MonHoc WHERE maMonHoc=N'{maMonHoc}'";
            BaseAccess.RunSQL(sql);
            connection.Disconnect();
        }


        public DataTable GetAllSubject()
        {
            connection.Connect();
            string sql = "SELECT * FROM MonHoc";
            DataTable subject = BaseAccess.GetDataToTable(sql);
            connection.Disconnect();
            return subject;
        }

        public DataTable SearchSubject(string keyword)
        {
            connection.Connect();
            string sql = $"SELECT * FROM MonHoc WHERE maMonHoc LIKE N'%{keyword}%' OR tenMonHoc LIKE N'%{keyword}%'";
            DataTable subjects = BaseAccess.GetDataToTable(sql);
            connection.Disconnect();
            return subjects;
        }

    }
}


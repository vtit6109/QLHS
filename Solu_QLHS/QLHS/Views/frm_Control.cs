using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLHS.Model;
using QLHS.DataAccess;
using QLHS.Views;
using QLHS.Controllers;

namespace QLHS.Views
{
    
    public partial class frm_Control : Form
    {
        public User CurrentUser { get; set; }
        //public string CurrentPassword { get; set; }

        Connection connection = new Connection();

        public frm_Control()
        {
            InitializeComponent();
            this.Shown += new EventHandler(frm_Control_Shown);
        }

        private void frm_Control_Shown(object sender, EventArgs e)
        {
            if (CurrentUser != null)
            {
                this.Text = "Người dùng: " + CurrentUser.tenNguoidung;
            }
        }

        private void case_closeform_Click(object sender, EventArgs e)
        {
            connection.Disconnect();
            this.Close();
        }

        private void case_changepass_Click(object sender, EventArgs e)
        {
            frm_ChangePassword frmChagePass = new frm_ChangePassword();
            frmChagePass.MdiParent = this;

            QLHS.Controllers.UserControl userControl = new QLHS.Controllers.UserControl();
            User user = userControl.GetUser(CurrentUser.tenTK);

            frmChagePass.CurrentUser = user;
            frmChagePass.Show();
        }

        private void case_student_Click(object sender, EventArgs e)
        {
            frm_Student frmStudent = new frm_Student();
            frmStudent.MdiParent = this;
            frmStudent.Show();
        }

        private void case_faculty_Click(object sender, EventArgs e)
        {
            frm_Faculty frmFaculty = new frm_Faculty();
            frmFaculty.MdiParent = this;
            frmFaculty.Show();
        }
    }
}

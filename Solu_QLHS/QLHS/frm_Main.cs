using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLHS.Views;
using QLHS.DataAccess;
namespace QLHS
{
    public partial class frm_Main : Form
    {
        Connection connection = new Connection();
        public frm_Main()
        {
            InitializeComponent();
            link_github.Links.Add(0, link_github.Text.Length, "https://github.com/vtit6109");
            link_project.Links.Add(0, link_project.Text.Length, "https://github.com/vtit6109/QLHS");
            connection.Connect();

        }
        private void link_github_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        private void link_project_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_Login frmLogin = new frm_Login();
            frmLogin.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hiện tại chưa có chức năng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}

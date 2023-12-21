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

namespace QLHS.Views
{
    
    public partial class frm_Control : Form
    {
        public User CurrentUser { get; set; }

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

        private void case_close_Click(object sender, EventArgs e)
        {
            connection.Disconnect();
            this.Close();
        }
    }
}

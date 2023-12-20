using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLHS.DataAccess;
namespace QLHS.FormFiles
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tenDangNhap = tbox_userName.Text;
            string matKhau = tbox_pass.Text;
            DataAccess.UserControl UserControl = new DataAccess.UserControl();
        }
    }
}

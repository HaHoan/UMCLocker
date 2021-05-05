using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UMCLocker
{
    public partial class LoginForm : Form
    {
        public Action<string> LoginOK;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            using (var db = new UMCLOCKEREntities())
            {
                var login = db.Members.Where(m => m.Username == txbUsername.Text.Trim() && m.Password == txbPassword.Text.Trim()).FirstOrDefault();
                if (login != null)
                {
                    LoginOK(login.Username);
                    Close();
                }
                else
                {
                    lblStatus.Text = "Sai Username hoặc password";
                    txbUsername.SelectAll();
                    txbUsername.Focus();
                }
            }
        }
        private void txbPassword_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }
    }
}

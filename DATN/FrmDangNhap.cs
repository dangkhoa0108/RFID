using System;
using System.Linq;
using System.Windows.Forms;

namespace DATN
{
    public partial class FrmLogin : Form
    {
        RFIDEntities _db = new RFIDEntities();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void tbUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                tbPassword.Focus();
        }

        private void tbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnLogin.Focus();
        }
        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            string user = tbUser.Text;
            string pass = tbPassword.Text;
            var isLogin = Login(user, pass);
            if (isLogin)
            {
                var mainForm = new FrmQlHeThong();
                Hide();
                mainForm.Show();
            }
        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        #region methods

        bool Login(string user, string pass)
        {
            try
            {
                if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
                {
                    MessageBox.Show(@"Login Fail", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    var login = _db.Users.SingleOrDefault(i => i.UserName.Equals(user) && i.Password.Equals(pass));
                    if (login != null)
                    {
                        var getInfo = (from u in _db.Users where u.UserName.Equals(user) select u).SingleOrDefault();
                        if (getInfo != null)
                        {
                            LoginInfo.UserId = getInfo.ID;
                            LoginInfo.UserName = getInfo.UserName;
                            LoginInfo.Role = getInfo.Role.Role1;
                            return true;
                        }
                    }
                    else
                    {
                        MessageBox.Show(@"Login Fail", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return false;
        }

        #endregion
    }
}

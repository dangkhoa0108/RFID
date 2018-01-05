using System;
using System.Linq;
using System.Windows.Forms;

namespace DATN
{
    public partial class FrmDoiMatKhau : Form
    {
        RFIDEntities _db = new RFIDEntities();
        public FrmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void tbOldPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                tbNewPass.Focus();
        }

        private void tbNewPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                tbRePass.Focus();
        }

        private void tbRePass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnLuu.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            Check();
        }
        private void FrmDoiMatKhau_FormClosed(object sender, FormClosedEventArgs e)
        {
            var frmMain = new FrmQlHeThong();
            frmMain.Show();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            var frmMain = new FrmQlHeThong();
            frmMain.Show();
            Hide();
        }
        #region Methods

        private void Check()
        {
            try
            {
                string oldPass = tbOldPass.Text;
                string newPass = tbNewPass.Text;
                string reNewPass = tbRePass.Text;
                var us = (from u in _db.Users where u.ID.Equals(LoginInfo.UserId) select u).FirstOrDefault();
                if (us != null && us.Password.Equals(oldPass))
                {
                    if (newPass.Equals(reNewPass))
                    {
                        var id = LoginInfo.UserId;
                        var user = _db.Users.Find(id);
                        if (user == null) return;
                        user.Password = newPass;
                        _db.SaveChanges();
                        MessageBox.Show(@"Change success", @"Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        var frmMain = new FrmQlHeThong();
                        frmMain.Show();
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show(@"Don't match", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(@"Don't match", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }


        #endregion
    }
}

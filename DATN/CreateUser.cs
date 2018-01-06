using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DATN
{
    public partial class frmCreateUser : Form
    {
        RFIDEntities _db=new RFIDEntities();
        public frmCreateUser()
        {
            InitializeComponent();
        }

        private void tbUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                tbPass.Focus();
        }

        private void tbPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnCreate.Focus();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        #region methods

        void Add()
        {
            try
            {
                string userName = tbUser.Text;
                var check = _db.Users.SingleOrDefault(i => i.UserName.Equals(userName));
                if (check == null)
                {
                    User user = new User
                    {
                        UserName = tbUser.Text,
                        Password = tbPass.Text,
                        RoleID = 1
                    };
                    _db.Users.Add(user);
                    _db.SaveChanges();
                    MessageBox.Show(@"Add success", @"Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    User idUs = _db.Users.OrderByDescending(x => x.ID).Take(1).SingleOrDefault();
                    if (idUs != null)
                    {
                        LoginInfo.MaNV = idUs.ID;
                        LoginInfo.isAddUser = 1;
                    }
                    var frmQl= new FrmQLTTNhanVien();
                    frmQl.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show(@"User already", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

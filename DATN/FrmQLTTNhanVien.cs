using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DATN
{
    public partial class FrmQLTTNhanVien : Form
    {
        RFIDEntities _db = new RFIDEntities();
        public FrmQLTTNhanVien()
        {
            InitializeComponent();
            txtHoTen.Focus();
            if (LoginInfo.isAddUser != 1)
            {
                LoadData();
                BindingData();
            }
            else
            {
                LoadData();
                IsAddUserLoad();
            }
        }

        private void txtMaNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txtHoTen.Focus();
        }

        private void txtHoTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txtSoDienThoai.Focus();
        }

        private void txtSoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txtDiaChi.Focus();
        }

        private void txtDiaChi_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtTim_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void FrmQLTTNhanVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            var frmMain = new FrmQlHeThong();
            frmMain.Show();
            Hide();
        }

        #region methods

        void LoadData()
        {
           
            try
            {
                int id = LoginInfo.UserId;
                string role = LoginInfo.Role;
                if (role.Equals("Quản lý"))
                {
                    var listNhanVien = _db.InfomationUsers.OrderBy(u=>u.UserID).Select(u => new
                    {
                        u.UserID,
                        u.Name,
                        u.Sex,
                        u.Address,
                        u.Phone,
                        u.User.Role.Role1
                    }).ToList();
                    dgvQLTTNhanVien.DataSource = listNhanVien;
                }
                else
                {
                    var listNhanVien = _db.InfomationUsers.Where(u => u.UserID.Equals(id)).Select(u => new
                    {
                        u.UserID,
                        u.Name,
                        u.Sex,
                        u.Address,
                        u.Phone,
                        u.User.Role.Role1
                    }).ToList();
                    dgvQLTTNhanVien.DataSource = listNhanVien;
                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    txtTim.Enabled = false;
                    var newColor = Color.FromArgb(165, 164, 164);
                    btnThem.BackColor = newColor;
                    btnSua.BackColor = newColor;
                    btnXoa.BackColor = newColor;
                }

                var listRole = _db.Roles.ToList();
                if (listRole.Count <= 0) return;
                cbChucVu.DataSource = listRole;
                cbChucVu.DisplayMember = "Role1";
                cbChucVu.ValueMember = "ID";
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        void IsAddUserLoad()
        {
            try
            {
                txtMaNV.Text = LoginInfo.MaNV.ToString();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        void BindingData()
        {
            txtMaNV.DataBindings.Clear();
            txtHoTen.DataBindings.Clear();
            cbGioiTinh.DataBindings.Clear();
            txtSoDienThoai.DataBindings.Clear();
            txtDiaChi.DataBindings.Clear();
            cbChucVu.DataBindings.Clear();
            txtMaNV.DataBindings.Add(new Binding("Text", dgvQLTTNhanVien.DataSource, "UserID"));
            txtHoTen.DataBindings.Add(new Binding("Text", dgvQLTTNhanVien.DataSource, "Name"));
            cbGioiTinh.DataBindings.Add(new Binding("Text", dgvQLTTNhanVien.DataSource, "Sex"));
            txtSoDienThoai.DataBindings.Add(new Binding("Text", dgvQLTTNhanVien.DataSource, "Phone"));
            txtDiaChi.DataBindings.Add(new Binding("Text", dgvQLTTNhanVien.DataSource, "Address"));
            cbChucVu.DataBindings.Add(new Binding("Text", dgvQLTTNhanVien.DataSource, "Role1"));
        }

        void Add()
        {
            try
            {
                int id = LoginInfo.MaNV;
                InfomationUser info = new InfomationUser
                {
                    UserID = LoginInfo.MaNV,
                    Name = txtHoTen.Text,
                    Sex = cbGioiTinh.Text,
                    Phone = txtSoDienThoai.Text,
                    Address = txtDiaChi.Text
                };
                _db.InfomationUsers.Add(info);
                _db.SaveChanges();
                LoadData();
                BindingData();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        void Edit()
        {
            try
            {
                int id = int.Parse(dgvQLTTNhanVien.SelectedCells[0].OwningRow.Cells["UserID"].Value.ToString());
                var edit = _db.InfomationUsers.Where(i => i.UserID.Equals(id)).SingleOrDefault();
                if (edit != null)
                {
                    edit.Name = txtHoTen.Text;
                    edit.Sex = cbGioiTinh.Text;
                    edit.Phone = txtSoDienThoai.Text;
                    edit.Address = txtDiaChi.Text;
                    edit.User.RoleID = int.Parse(cbChucVu.SelectedValue.ToString());
                    _db.SaveChanges();
                    MessageBox.Show(@"Edit success", @"Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    BindingData();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        void Delete()
        {
            try
            {
                int id = int.Parse(dgvQLTTNhanVien.SelectedCells[0].OwningRow.Cells["UserID"].Value.ToString());
                var del = _db.InfomationUsers.Where(i => i.UserID.Equals(id)).SingleOrDefault();
                if (del != null)
                {
                    _db.InfomationUsers.Remove(del);
                    var us = _db.Users.Where(u => u.ID.Equals(id)).SingleOrDefault();
                    {
                        if (us != null)
                        {
                            _db.Users.Remove(us);
                        }
                    }
                    _db.SaveChanges();
                    MessageBox.Show(@"Delete success", @"Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    BindingData();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
        void Search()
        {
            try
            {
                string stringText = txtTim.Text;
                var checkString = _db.InfomationUsers.Where(i => i.Address.Equals(stringText) ||
                                                             i.Name.Contains(stringText) || i.Phone.Contains(stringText)||
                                                             i.User.Role.Role1.Contains(stringText)
                                                             ).Select(u => new
                                                             {
                                                                 u.UserID,
                                                                 u.Name,
                                                                 u.Sex,
                                                                 u.Address,
                                                                 u.Phone,
                                                                 u.User.Role.Role1
                                                             }).ToList();

                if (checkString.ToList().Count > 0)
                {
                    dgvQLTTNhanVien.DataSource = checkString.ToList();
                    BindingData();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        #endregion

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                int k = int.Parse(txtMaNV.Text);
                var check = _db.InfomationUsers.SingleOrDefault(i => i.UserID.Equals(k));
                if (check != null)
                {
                    DialogResult result;
                    result = MessageBox.Show(@"First, Add Nomal User and Pass ", @"Warring", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (result == DialogResult.OK)
                    {
                        var frmCreate = new frmCreateUser();
                        frmCreate.Show();
                        Hide();
                    }
                }
                else
                {
                    Add();
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Delete();
        }
    }
}

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
    public partial class FrmQLTTNhanVien : Form
    {
        RFIDEntities _db = new RFIDEntities();
        public FrmQLTTNhanVien()
        {
            InitializeComponent();
            LoadData();
            BindingData();
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
                if (role.Equals("Admin"))
                {
                    var listNhanVien = _db.InfomationUsers.Select(u => new
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
                    btnTim.Enabled = false;
                    txtTim.Enabled = false;
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
                DialogResult result; 
                result=MessageBox.Show(@"First, Add Nomal User and Pass ", @"Warring", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    var frmCreate= new frmCreateUser();
                    frmCreate.ShowDialog();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}

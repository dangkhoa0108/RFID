using System;
using System.Linq;
using System.Windows.Forms;

namespace DATN
{
    public partial class FrmQlHeThong : Form
    {
        RFIDEntities _db = new RFIDEntities();
        public FrmQlHeThong()
        {
            InitializeComponent();
        }

        #region Methods

        void LoadData()
        {
            try
            {
                var showInfo = (from u in _db.InfomationUsers where u.ID.Equals(LoginInfo.UserId) select u).FirstOrDefault();
                if (showInfo != null)
                {
                    lblMaNV.Text = LoginInfo.UserId.ToString();
                    lblHoTen.Text = showInfo.Name;
                    var gt = showInfo.Sex;
                    lblGioiTinh.Text = showInfo.Sex;
                    lblSoDienThoai.Text = showInfo.Phone;
                    lblDiaChi.Text = showInfo.Address;
                    lblChucVu.Text = LoginInfo.Role;
                }

                var inFo = (from u in _db.RFID_User
                            join k in _db.RFIDManages on u.RFID equals k.RFID
                            join m in _db.Users on u.UserID equals m.ID
                            join x in _db.InfomationUsers on m.ID equals x.UserID
                            select new
                            {
                                u.ID,
                                k.RFID_Name,
                                k.RFID_CarID,
                                x.Name,
                                u.Date
                            }).ToList();
                dgvInfo.DataSource = inFo;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        #endregion

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            var frmChangePass = new FrmDoiMatKhau();
            frmChangePass.Show();
            this.Hide();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            LoginInfo.UserId = -1;
            LoginInfo.UserName = null;
            LoginInfo.Role = null;
            Application.Restart();
        }

        private void FrmQlHeThong_FormClosed(object sender, FormClosedEventArgs e) => Application.Exit();

        private void FrmQlHeThong_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void QuanLyRFIDToolTrip_Click(object sender, EventArgs e)
        {
            var qLyRfid = new FrmRfid();
            qLyRfid.Show();
            Hide();
        }

        private void QLNhanVienToolStrip_Click(object sender, EventArgs e)
        {
            var qLNhanVien = new FrmQLTTNhanVien();
            qLNhanVien.Show();
            Hide();
        }

        private void QLLanDuongToolStrip_Click(object sender, EventArgs e)
        {
            var qLyLanDuong = new FrmQLLanDuong();
            qLyLanDuong.Show();
            Hide();
        }
    }
}

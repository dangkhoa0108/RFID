using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

using System.IO.Ports;

namespace DATN
{
    public partial class FrmQLLanDuong : Form
    {
        RFIDEntities _db = new RFIDEntities();
        string _inputData = String.Empty; // Khai báo string buff dùng cho hiển thị dữ liệu sau này.

        delegate void SetTextCallback(string text); // Khai bao delegate SetTextCallBack voi tham so string

        public FrmQLLanDuong()
        {
            InitializeComponent();
            serialPort1.DataReceived += DataReceive;
            lblTrangthai.Text = (@"Chưa kết nối");

            lblTrangthai.ForeColor = Color.Red;
            //Timer1.Start();


        }

        private void FrmQLLanDuong_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort1.IsOpen)
                {
                    serialPort1.Open();
                    lblTrangthai.Text = (@"Đã kết nối");

                    lblTrangthai.ForeColor = Color.Green;

                }
            }
            catch (Exception)
            {

                MessageBox.Show(@"Không kết được cổng COM");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            lblTrangthai.Text = (@"Chưa kết nối");

            lblTrangthai.ForeColor = Color.Red;
        }
        private void SetText(string text)

        {

            if (lstRFID.InvokeRequired)

            {
                SetTextCallback d = SetText; 
                Invoke(d, text);

            }

            else
            {
                //this.txtMaRFID.ResetText();
                txtMaRFID.Text = text;
                lstRFID.Items.Add(text);
            }

        }
        private void DataReceive(object obj, SerialDataReceivedEventArgs e)

        {
            _inputData = serialPort1.ReadLine();
            if (_inputData != String.Empty)
            {
                SetText(_inputData); 
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblday.Text = DateTime.Now.ToString("dd-MMM-yyyy hh:mm:ss tt");
            timer1.Start();
        }

        private void lstRFID_Click(object sender, EventArgs e)
        {
        }

        void Submit()
        {
            try
            {
                var click = txtMaRFID.Text;
                LoginInfo.RFID = click;
                var check = _db.RFIDManages.SingleOrDefault(i => i.RFID.Equals(click));
                if (check == null)
                {
                    serialPort1.Write("NotCSDL");
                    MessageBox.Show(@"Xe không có trong CSDL");
                    txtBienSo.ResetText();
                    txtTenDangKy.ResetText();
                    txtSoTien.ResetText();
                    txtDu.ResetText();
                }
                else
                {   
                    var isCar = _db.RFIDManages.SingleOrDefault(i => i.RFID.Equals(click));
                    serialPort1.Write("YesCSDL");
               
                        if (isCar != null)
                        {
                            txtBienSo.ResetText();
                            txtTenDangKy.ResetText();
                            txtSoTien.ResetText();
                            txtDu.ResetText();
                            txtBienSo.Text = isCar.RFID_CarID;
                            txtTenDangKy.Text = isCar.RFID_Name;
                            txtSoTien.Text = isCar.RFID_Money.ToString();
                            int? loaiXe = isCar.RFID_LoaiXe;
                            if (loaiXe != null)
                            {
                                double? money = isCar.RFID_Money;
                                if (money > 5000)
                                {
                                    Check(isCar, click, money);
                                }
                                else
                                {
                                    var result = MessageBox.Show(@"Vui lòng nạp thêm tiền ", @"Warring", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                                    if (result == DialogResult.OK)
                                    {
                                        var frmMoney = new Add_Money();
                                        frmMoney.ShowDialog();
                                        var newTien = (from u in _db.RFIDManages where u.RFID.Equals(click) select new { u.RFID_Money }).SingleOrDefault();
                                        txtSoTien.Text = newTien?.RFID_Money.ToString();
                                        txtDu.ResetText();
                                        money = double.Parse(newTien?.RFID_Money.ToString() ?? throw new InvalidOperationException());
                                        if (money > 5000)
                                        {
                                            Check(isCar, click, money);
                                        }
                                    }
                                }
                            }
                        }
                    
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void Check(RFIDManage isCar, string click, double? money)
        {
            var tienBiTru = (_db.LoaiXes
                .Join(_db.RFIDManages, u => u.ID, m => m.RFID_LoaiXe, (u, m) => new { u, m })
                .Where(@t => @t.m.RFID.Equals(click))
                .Select(@t => new { @t.u.SoTien })).SingleOrDefault();
            double kk = double.Parse(tienBiTru?.SoTien.ToString() ??
                                     throw new InvalidOperationException());
            txtDu.Text = (isCar.RFID_Money - kk).ToString();
            RFIDManage edit = _db.RFIDManages.Find(click);
            if (edit != null)
            {

                edit.RFID_Money = double.Parse(txtDu.Text);
                RFID_User info = new RFID_User
                {
                    RFID = click,
                    UserID = LoginInfo.UserId,
                    Date = DateTime.Now.ToString()
                };
                _db.RFID_User.Add(info);
                _db.SaveChanges();
                MessageBox.Show(@"Có xe qua trạm", @"Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(@"Can't not Edit  RFID", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmQLLanDuong_FormClosed(object sender, FormClosedEventArgs e)
        {
            var frmMain = new FrmQlHeThong();
            frmMain.Show();
            Hide();
        }

        private void btnMo_Click(object sender, EventArgs e)
        {
            serialPort1.Write("Mo");
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            serialPort1.Write("Dong");
        }

        private void txtMaRFID_TextChanged(object sender, EventArgs e)
        {
            var i = txtMaRFID.Text.ToString();
            if (!string.IsNullOrEmpty(i))
            { Submit(); }
        }
    }
}

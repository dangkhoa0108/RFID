using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

using System.IO.Ports;

namespace DATN
{
    public partial class FrmQLLanDuong : Form
    {
        RFIDEntities _db = new RFIDEntities();
        string InputData = String.Empty; // Khai báo string buff dùng cho hiển thị dữ liệu sau này.

        delegate void SetTextCallback(string text); // Khai bao delegate SetTextCallBack voi tham so string

        public FrmQLLanDuong()
        {
            InitializeComponent();
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(DataReceive);
            lblTrangthai.Text = ("Chưa kết nối");

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
                    lblTrangthai.Text = ("Đã kết nối");

                    lblTrangthai.ForeColor = Color.Green;

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Không kết được cổng COM");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            lblTrangthai.Text = ("Chưa kết nối");

            lblTrangthai.ForeColor = Color.Red;
        }
        private void SetText(string text)

        {

            if (this.lstRFID.InvokeRequired)

            {

                SetTextCallback d = new SetTextCallback(SetText); // khởi tạo 1 delegate mới gọi đến SetText

                this.Invoke(d, new object[] { text });

            }

            else
            {
                //this.txtMaRFID.ResetText();
                this.txtMaRFID.Text = text;
                this.lstRFID.Items.Add(text);
            }

        }
        private void DataReceive(object obj, SerialDataReceivedEventArgs e)

        {

            InputData = serialPort1.ReadLine();

            if (InputData != String.Empty)

            {

                // textbox1 = InputData; // Ko dùng đc như thế này vì khác threads .

                SetText(InputData); // Chính vì vậy phải sử dụng ủy quyền tại đây. Gọi delegate đã khai báo trước đó.

            }



        }
        private void timer1_Tick(object sender, EventArgs e)

        {

            //this.lblday.Text = DateTime.Now.ToString();

            lblday.Text = DateTime.Now.ToString("dd-MMM-yyyy hh:mm:ss tt");
            timer1.Start();
        }

        private void lstRFID_Click(object sender, EventArgs e)
        {
            //submit();
        }

        void submit()
        {
            try
            {
                //var click = lstRFID.SelectedItem.ToString();
                var click = txtMaRFID.Text;
                LoginInfo.RFID = click;
                //var click = test.Substring(0,8).ToString();
                var check = _db.RFIDManages.Where(i => i.RFID.Equals(click)).SingleOrDefault();
                if (check == null)
                    MessageBox.Show("Xe không có trong CSDL");
                else
                {
                    //txtMaRFID.Text = click.ToString();
                    string id = txtMaRFID.ToString();
                    var isCar = _db.RFIDManages.Where(i => i.RFID.Equals(click)).SingleOrDefault();
                    if (isCar != null)
                    {
                        txtBienSo.ResetText();
                        txtTenDangKy.ResetText();
                        txtSoTien.ResetText();
                        txtDu.ResetText();
                        //int? loaiXe = isCar.RFID_LoaiXe;

                        txtBienSo.Text = isCar.RFID_CarID;
                        txtTenDangKy.Text = isCar.RFID_Name;
                        txtSoTien.Text = isCar.RFID_Money.ToString();
                        int? loaiXe = isCar.RFID_LoaiXe;
                        if (loaiXe != null)
                        {
                            double? money = isCar.RFID_Money;
                            if (money>5000)
                            {
                                var tienBiTru = (from u in _db.LoaiXes join m in _db.RFIDManages on u.ID equals m.RFID_LoaiXe where m.RFID.Equals(click) select new { u.SoTien }).SingleOrDefault();
                                double kk = double.Parse(tienBiTru.SoTien.ToString());
                                //var tienBiTru = _db.LoaiXes.Local.Where(i => i.ID.Equals(loaiXe)).SingleOrDefault();

                                txtDu.Text = (isCar.RFID_Money - kk).ToString();
                                RFIDManage edit = _db.RFIDManages.Find(click);
                                if (edit != null)
                                {
                                    edit.RFID_Money = double.Parse(txtDu.Text);
                                    _db.SaveChanges();
                                    MessageBox.Show(@"Edit success", @"Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show(@"Can't not Edit  RFID", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                DialogResult result;
                                result = MessageBox.Show(@"Vui lòng nạp thêm tiền ", @"Warring", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                                if (result == DialogResult.OK)
                                {
                                    var frmMoney = new Add_Money();
                                    frmMoney.ShowDialog();
                                    var newTien = (from u in _db.RFIDManages where u.RFID.Equals(click) select new { u.RFID_Money }).SingleOrDefault();
                                    txtSoTien.Text = newTien.RFID_Money.ToString();
                                    txtDu.ResetText();
                                    money = double.Parse(newTien.RFID_Money.ToString());
                                    if (money > 5000)
                                    {
                                        var tienBiTru = (from u in _db.LoaiXes join m in _db.RFIDManages on u.ID equals m.RFID_LoaiXe where m.RFID.Equals(click) select new { u.SoTien }).SingleOrDefault();
                                        double kk = double.Parse(tienBiTru.SoTien.ToString());
                                        //var tienBiTru = _db.LoaiXes.Local.Where(i => i.ID.Equals(loaiXe)).SingleOrDefault();

                                        txtDu.Text = (money - kk).ToString();
                                        RFIDManage edit = _db.RFIDManages.Find(click);
                                        if (edit != null)
                                        {
                                            edit.RFID_Money = double.Parse(txtDu.Text);
                                            _db.SaveChanges();
                                            MessageBox.Show(@"Edit success", @"Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                        else
                                        {
                                            MessageBox.Show(@"Can't not Edit  RFID", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
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
            { submit(); }
        }
    }



}

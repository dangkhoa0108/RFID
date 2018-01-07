using System;
using System.Linq;
using System.Windows.Forms;

namespace DATN
{
    public partial class FrmRfid : Form
    {
        RFIDEntities _db = new RFIDEntities();
        public FrmRfid()
        {
            InitializeComponent();
            LoadData();
            BindingData();
        }
        private void tbRFID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                tbRFIDName.Focus();
        }

        private void tbRFIDName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                tbCarID.Focus();
        }

        private void tbCarID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                tbMoney.Focus();
        }

        private void tbMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                tbAddress.Focus();
        }

        private void tbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnSearch.Focus();
        }

        private void tbAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnAdd.Focus();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
            string data = serialPort1.ReadLine();
            tbRFID.ResetText();
            tbRFID.Text = data;
            serialPort1.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbSearch.Text))
            {
                LoadData();
            }
            else
            {
                Search();
                BindingData();
            }

        }

        #region methods
        void LoadData()
        {
            try
            {
                var listRfid = _db.RFIDManages.Select(u => new
                {
                    u.RFID,
                    u.RFID_Name,
                    u.RFID_Address,
                    u.RFID_CarID,
                    u.RFID_Money,
                    u.LoaiXe.LoaiXe1
                });
                dgvRFID.DataSource = listRfid.ToList();

                var listLoaiXe = _db.LoaiXes.ToList();
                if (listLoaiXe.Count <= 0) return;
                cbLoaiXe.DataSource = listLoaiXe;
                cbLoaiXe.DisplayMember = "LoaiXe1";
                cbLoaiXe.ValueMember = "ID";
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        void BindingData()
        {
            tbRFID.DataBindings.Clear();
            tbRFIDName.DataBindings.Clear();
            tbCarID.DataBindings.Clear();
            tbMoney.DataBindings.Clear();
            tbAddress.DataBindings.Clear();
            cbLoaiXe.DataBindings.Clear();
            tbRFID.DataBindings.Add(new Binding("Text", dgvRFID.DataSource, "RFID"));
            tbRFIDName.DataBindings.Add(new Binding("Text", dgvRFID.DataSource, "RFID_Name"));
            tbCarID.DataBindings.Add(new Binding("Text", dgvRFID.DataSource, "RFID_CarID"));
            tbMoney.DataBindings.Add(new Binding("Text", dgvRFID.DataSource, "RFID_Money", true, DataSourceUpdateMode.OnPropertyChanged));
            tbAddress.DataBindings.Add(new Binding("Text", dgvRFID.DataSource, "RFID_Address"));
            cbLoaiXe.DataBindings.Add(new Binding("Text", dgvRFID.DataSource, "LoaiXe1"));
        }

        void Add()
        {
            try
            {
                string i = tbRFID.Text;
                var check = _db.RFIDManages.SingleOrDefault(u => u.RFID.Equals(i));
                if (check == null)
                {
                    RFIDManage newRfid = new RFIDManage
                    {
                        RFID = tbRFID.Text,
                        RFID_Name = tbRFIDName.Text,
                        RFID_Address = tbAddress.Text,
                        RFID_CarID = tbCarID.Text,
                        RFID_Money = double.Parse(tbMoney.Text),
                        RFID_LoaiXe = int.Parse(cbLoaiXe.SelectedValue.ToString())
                    };
                    _db.RFIDManages.Add(newRfid);
                    _db.SaveChanges();
                    MessageBox.Show(@"Add success", @"Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    BindingData();
                }
                else
                {
                    MessageBox.Show(@"RFID already!", @"Warring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
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
                string id = dgvRFID.SelectedCells[0].OwningRow.Cells["RFID"].Value.ToString();
                RFIDManage edit = _db.RFIDManages.Find(id);
                if (edit != null)
                {
                    edit.RFID_Name = tbRFIDName.Text;
                    edit.RFID_Address = tbAddress.Text;
                    edit.RFID_Money = int.Parse(tbMoney.Text);
                    edit.RFID_CarID = tbCarID.Text;
                    edit.RFID_LoaiXe = int.Parse(cbLoaiXe.SelectedValue.ToString());
                    _db.SaveChanges();
                    MessageBox.Show(@"Edit success", @"Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    BindingData();
                }
                else
                {
                    MessageBox.Show(@"Can't not Edit  RFID", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                string id = dgvRFID.SelectedCells[0].OwningRow.Cells["RFID"].Value.ToString();
                var del = _db.RFIDManages.Find(id);
                if (del != null)
                {
                    _db.RFIDManages.Remove(del);
                    _db.SaveChanges();
                    MessageBox.Show(@"Delete success", @"Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    BindingData();
                }
                else
                {
                    MessageBox.Show(@"Delete Error", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                string textRfid = tbSearch.Text;
                var checkString = _db.RFIDManages.Where(i => i.RFID_Name.Equals(textRfid)
                                                             || i.RFID_Address.Equals(textRfid) ||
                                                             i.RFID_CarID.Contains(textRfid) || i.RFID.Contains(textRfid) ||
                                                             i.LoaiXe.LoaiXe1.Contains(textRfid)).Select(u => new
                                                             {
                                                                 u.RFID,
                                                                 u.RFID_Name,
                                                                 u.RFID_Address,
                                                                 u.RFID_CarID,
                                                                 u.RFID_Money,
                                                                 u.LoaiXe.LoaiXe1
                                                             });

                if (checkString.ToList().Count > 0)
                {
                    dgvRFID.DataSource = checkString.ToList();
                    BindingData();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        #endregion

        private void FrmRfid_FormClosed(object sender, FormClosedEventArgs e)
        {
            var frmMain = new FrmQlHeThong();
            frmMain.Show();
            Hide();
        }
    }
}

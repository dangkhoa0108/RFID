using System;
using System.Linq;
using System.Windows.Forms;

namespace DATN
{
    public partial class FrmRfid : Form
    {
        readonly RFIDEntities _db = new RFIDEntities();
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
            Search();
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
                    u.RFID_Money
                });
                dgvRFID.DataSource = listRfid.ToList();
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
            tbRFID.DataBindings.Add(new Binding("Text", dgvRFID.DataSource, "RFID"));
            tbRFIDName.DataBindings.Add(new Binding("Text", dgvRFID.DataSource, "RFID_Name"));
            tbCarID.DataBindings.Add(new Binding("Text", dgvRFID.DataSource, "RFID_CarID"));
            tbMoney.DataBindings.Add(new Binding("Text",dgvRFID.DataSource, "RFID_Money", true, DataSourceUpdateMode.OnPropertyChanged));
            tbAddress.DataBindings.Add(new Binding("Text", dgvRFID.DataSource, "RFID_Address"));
        }

        void Add()
        {
            try
            {
                int i = int.Parse(tbRFID.Text);
                var check = _db.RFIDManages.SingleOrDefault(u => u.RFID==i);
                if (check==null)
                {
                    RFIDManage newRfid= new RFIDManage
                    {
                        RFID= int.Parse(tbRFID.Text),
                        RFID_Name=tbRFIDName.Text,
                        RFID_Address=tbAddress.Text,
                        RFID_CarID=tbCarID.Text,
                        RFID_Money= double.Parse(tbMoney.Text)
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
                int id = int.Parse(dgvRFID.SelectedCells[0].OwningRow.Cells["RFID"].Value.ToString());
                RFIDManage edit = _db.RFIDManages.Find(id);
                if (edit != null)
                {
                    edit.RFID_Name = tbRFIDName.Text;
                    edit.RFID_Address = tbAddress.Text;
                    edit.RFID_Money = int.Parse(tbMoney.Text);
                    edit.RFID_CarID = tbCarID.Text;
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
            int id = int.Parse(dgvRFID.SelectedCells[0].OwningRow.Cells["RFID"].Value.ToString());
            var del = _db.RFIDManages.Find(id);
            if (del != null)
            {
                _db.RFIDManages.Remove(del);
                _db.SaveChanges();
                MessageBox.Show(@"Delete success", @"Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                BindingData();
            }
        }

        void Search()
        {
            int id = int.Parse(tbSearch.Text);
            var check = _db.RFIDManages.Where(i => i.RFID == id).ToList();
            dgvRFID.DataSource = check;

        }

        #endregion
    }
}

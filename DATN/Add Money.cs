using System;
using System.Linq;
using System.Windows.Forms;

namespace DATN
{
    public partial class Add_Money : Form
    {
        RFIDEntities _db = new RFIDEntities();
        public Add_Money()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var check = _db.RFIDManages.SingleOrDefault(i => i.RFID.Equals(LoginInfo.RFID));
                if (check != null)
                {
                    var id = LoginInfo.RFID;
                    var money = _db.RFIDManages.Find(id);
                    double? oldMoney = money.RFID_Money;
                    money.RFID_Money = double.Parse(txtSoTien.Text)+oldMoney;
                    _db.SaveChanges();
                    MessageBox.Show(@"Nạp tiền thành công");
                    Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}

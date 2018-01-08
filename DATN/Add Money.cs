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
                var check = _db.RFIDManages.Where(i => i.RFID.Equals(LoginInfo.RFID)).SingleOrDefault();
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

namespace DATN
{
    partial class FrmRfid
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbRFID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbRFIDName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCarID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMoney = new System.Windows.Forms.TextBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.picBoxRFIDTag = new System.Windows.Forms.PictureBox();
            this.dgvRFID = new System.Windows.Forms.DataGridView();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.lbAddress = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbLoaiXe = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.RFID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RFID_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RFID_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RFID_Money = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RFID_CarID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiXe1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRFIDTag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRFID)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(4, 238);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(81, 29);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Get Data";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(91, 238);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(66, 29);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(163, 238);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(53, 29);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(222, 238);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(57, 29);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(977, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ MÃ RFID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã RFID";
            // 
            // tbRFID
            // 
            this.tbRFID.Location = new System.Drawing.Point(91, 43);
            this.tbRFID.Name = "tbRFID";
            this.tbRFID.Size = new System.Drawing.Size(199, 20);
            this.tbRFID.TabIndex = 2;
            this.tbRFID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRFID_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên Đăng Ký";
            // 
            // tbRFIDName
            // 
            this.tbRFIDName.Location = new System.Drawing.Point(91, 69);
            this.tbRFIDName.Name = "tbRFIDName";
            this.tbRFIDName.Size = new System.Drawing.Size(199, 20);
            this.tbRFIDName.TabIndex = 4;
            this.tbRFIDName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRFIDName_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Biển Số";
            // 
            // tbCarID
            // 
            this.tbCarID.Location = new System.Drawing.Point(91, 95);
            this.tbCarID.Name = "tbCarID";
            this.tbCarID.Size = new System.Drawing.Size(199, 20);
            this.tbCarID.TabIndex = 6;
            this.tbCarID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCarID_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Số Tiền";
            // 
            // tbMoney
            // 
            this.tbMoney.Location = new System.Drawing.Point(91, 121);
            this.tbMoney.Name = "tbMoney";
            this.tbMoney.Size = new System.Drawing.Size(199, 20);
            this.tbMoney.TabIndex = 8;
            this.tbMoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMoney_KeyPress);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(91, 212);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(199, 20);
            this.tbSearch.TabIndex = 9;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            this.tbSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSearch_KeyPress);
            // 
            // picBoxRFIDTag
            // 
            this.picBoxRFIDTag.Image = global::DATN.Properties.Resources.rfid_tag;
            this.picBoxRFIDTag.Location = new System.Drawing.Point(4, 276);
            this.picBoxRFIDTag.Name = "picBoxRFIDTag";
            this.picBoxRFIDTag.Size = new System.Drawing.Size(286, 141);
            this.picBoxRFIDTag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxRFIDTag.TabIndex = 5;
            this.picBoxRFIDTag.TabStop = false;
            // 
            // dgvRFID
            // 
            this.dgvRFID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRFID.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RFID,
            this.RFID_Name,
            this.RFID_Address,
            this.RFID_Money,
            this.RFID_CarID,
            this.LoaiXe1});
            this.dgvRFID.Location = new System.Drawing.Point(313, 43);
            this.dgvRFID.Name = "dgvRFID";
            this.dgvRFID.Size = new System.Drawing.Size(652, 374);
            this.dgvRFID.TabIndex = 15;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(91, 148);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(199, 20);
            this.tbAddress.TabIndex = 17;
            this.tbAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAddress_KeyPress);
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddress.Location = new System.Drawing.Point(7, 150);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(49, 15);
            this.lbAddress.TabIndex = 16;
            this.lbAddress.Text = "Địa Chỉ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "Loại Xe";
            // 
            // cbLoaiXe
            // 
            this.cbLoaiXe.FormattingEnabled = true;
            this.cbLoaiXe.Location = new System.Drawing.Point(91, 178);
            this.cbLoaiXe.Name = "cbLoaiXe";
            this.cbLoaiXe.Size = new System.Drawing.Size(199, 21);
            this.cbLoaiXe.TabIndex = 19;
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM12";
            // 
            // RFID
            // 
            this.RFID.DataPropertyName = "RFID";
            this.RFID.HeaderText = "RFID";
            this.RFID.Name = "RFID";
            this.RFID.ReadOnly = true;
            // 
            // RFID_Name
            // 
            this.RFID_Name.DataPropertyName = "RFID_Name";
            this.RFID_Name.HeaderText = "Tên Đăng Ký";
            this.RFID_Name.Name = "RFID_Name";
            // 
            // RFID_Address
            // 
            this.RFID_Address.DataPropertyName = "RFID_Address";
            this.RFID_Address.HeaderText = "Địa Chỉ";
            this.RFID_Address.Name = "RFID_Address";
            // 
            // RFID_Money
            // 
            this.RFID_Money.DataPropertyName = "RFID_Money";
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.RFID_Money.DefaultCellStyle = dataGridViewCellStyle1;
            this.RFID_Money.HeaderText = "Số Tiền";
            this.RFID_Money.Name = "RFID_Money";
            // 
            // RFID_CarID
            // 
            this.RFID_CarID.DataPropertyName = "RFID_CarID";
            this.RFID_CarID.HeaderText = "Biển Số";
            this.RFID_CarID.Name = "RFID_CarID";
            // 
            // LoaiXe1
            // 
            this.LoaiXe1.DataPropertyName = "LoaiXe1";
            this.LoaiXe1.HeaderText = "Loại Xe";
            this.LoaiXe1.Name = "LoaiXe1";
            // 
            // FrmRfid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(977, 431);
            this.Controls.Add(this.cbLoaiXe);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.dgvRFID);
            this.Controls.Add(this.picBoxRFIDTag);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.tbMoney);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbCarID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbRFIDName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbRFID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRfid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmQLMaRFID";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmRfid_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRFIDTag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRFID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbRFID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbRFIDName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCarID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbMoney;
        private System.Windows.Forms.PictureBox picBoxRFIDTag;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.DataGridView dgvRFID;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbLoaiXe;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RFID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RFID_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn RFID_Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn RFID_Money;
        private System.Windows.Forms.DataGridViewTextBoxColumn RFID_CarID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiXe1;
    }
}
namespace DATN
{
    partial class FrmQLLanDuong
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picBoxConnecting = new System.Windows.Forms.PictureBox();
            this.lblTrangthai = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblday = new System.Windows.Forms.Label();
            this.picBoxTime = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.picBoxBarrier = new System.Windows.Forms.PictureBox();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnMo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDu = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lstRFID = new System.Windows.Forms.ListBox();
            this.txtSoTien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBienSo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenDangKy = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaRFID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxConnecting)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTime)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBarrier)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(873, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ LÀN ĐƯỜNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picBoxConnecting);
            this.groupBox1.Controls.Add(this.lblTrangthai);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(552, 91);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "KẾT NỐI MÁY TÍNH";
            // 
            // picBoxConnecting
            // 
            this.picBoxConnecting.Image = global::DATN.Properties.Resources.tutorial_serial_data_sensor;
            this.picBoxConnecting.Location = new System.Drawing.Point(367, 22);
            this.picBoxConnecting.Name = "picBoxConnecting";
            this.picBoxConnecting.Size = new System.Drawing.Size(179, 63);
            this.picBoxConnecting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxConnecting.TabIndex = 3;
            this.picBoxConnecting.TabStop = false;
            // 
            // lblTrangthai
            // 
            this.lblTrangthai.Location = new System.Drawing.Point(131, 52);
            this.lblTrangthai.Name = "lblTrangthai";
            this.lblTrangthai.Size = new System.Drawing.Size(103, 23);
            this.lblTrangthai.TabIndex = 3;
            this.lblTrangthai.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Trạng thái";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Khaki;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button2.Location = new System.Drawing.Point(8, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Ngắt";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button1.Location = new System.Drawing.Point(9, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Kết nối";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblday);
            this.groupBox2.Controls.Add(this.picBoxTime);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(562, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(311, 91);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "NGÀY GIỜ HỆ THỐNG";
            // 
            // lblday
            // 
            this.lblday.AutoSize = true;
            this.lblday.Location = new System.Drawing.Point(148, 41);
            this.lblday.Name = "lblday";
            this.lblday.Size = new System.Drawing.Size(44, 17);
            this.lblday.TabIndex = 1;
            this.lblday.Text = "label9";
            // 
            // picBoxTime
            // 
            this.picBoxTime.Image = global::DATN.Properties.Resources.Blacksmith_Stylized_Numbers_Wall_Clock___Black_517797;
            this.picBoxTime.Location = new System.Drawing.Point(6, 22);
            this.picBoxTime.Name = "picBoxTime";
            this.picBoxTime.Size = new System.Drawing.Size(112, 63);
            this.picBoxTime.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxTime.TabIndex = 0;
            this.picBoxTime.TabStop = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.PowderBlue;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(552, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "THÔNG TIN KHÁCH HÀNG";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.PowderBlue;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(562, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(311, 33);
            this.label8.TabIndex = 4;
            this.label8.Text = "BẢNG ĐIỀU KHIỂN";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.picBoxBarrier);
            this.groupBox3.Controls.Add(this.btnDong);
            this.groupBox3.Controls.Add(this.btnMo);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(562, 176);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(311, 182);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ĐIỀU KHIỂN BARRIER";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // picBoxBarrier
            // 
            this.picBoxBarrier.Image = global::DATN.Properties.Resources.barrier_systems_1;
            this.picBoxBarrier.Location = new System.Drawing.Point(6, 22);
            this.picBoxBarrier.Name = "picBoxBarrier";
            this.picBoxBarrier.Size = new System.Drawing.Size(139, 75);
            this.picBoxBarrier.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxBarrier.TabIndex = 1;
            this.picBoxBarrier.TabStop = false;
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.SandyBrown;
            this.btnDong.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDong.Location = new System.Drawing.Point(230, 54);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 43);
            this.btnDong.TabIndex = 1;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnMo
            // 
            this.btnMo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnMo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMo.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMo.Location = new System.Drawing.Point(151, 54);
            this.btnMo.Name = "btnMo";
            this.btnMo.Size = new System.Drawing.Size(75, 43);
            this.btnMo.TabIndex = 0;
            this.btnMo.Text = "Mở";
            this.btnMo.UseVisualStyleBackColor = false;
            this.btnMo.Click += new System.EventHandler(this.btnMo_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.txtDu);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.lstRFID);
            this.panel1.Controls.Add(this.txtSoTien);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtBienSo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtTenDangKy);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtMaRFID);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(4, 176);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 185);
            this.panel1.TabIndex = 20;
            // 
            // txtDu
            // 
            this.txtDu.Location = new System.Drawing.Point(87, 111);
            this.txtDu.Name = "txtDu";
            this.txtDu.Size = new System.Drawing.Size(126, 20);
            this.txtDu.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "Số Dư";
            // 
            // lstRFID
            // 
            this.lstRFID.FormattingEnabled = true;
            this.lstRFID.Location = new System.Drawing.Point(237, 4);
            this.lstRFID.Name = "lstRFID";
            this.lstRFID.Size = new System.Drawing.Size(309, 173);
            this.lstRFID.TabIndex = 8;
            this.lstRFID.Click += new System.EventHandler(this.lstRFID_Click);
            // 
            // txtSoTien
            // 
            this.txtSoTien.Location = new System.Drawing.Point(87, 80);
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Size = new System.Drawing.Size(126, 20);
            this.txtSoTien.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tổng";
            // 
            // txtBienSo
            // 
            this.txtBienSo.Location = new System.Drawing.Point(87, 54);
            this.txtBienSo.Name = "txtBienSo";
            this.txtBienSo.Size = new System.Drawing.Size(126, 20);
            this.txtBienSo.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Biển Số";
            // 
            // txtTenDangKy
            // 
            this.txtTenDangKy.Location = new System.Drawing.Point(87, 28);
            this.txtTenDangKy.Name = "txtTenDangKy";
            this.txtTenDangKy.Size = new System.Drawing.Size(126, 20);
            this.txtTenDangKy.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tên Đăng Ký";
            // 
            // txtMaRFID
            // 
            this.txtMaRFID.Location = new System.Drawing.Point(87, 2);
            this.txtMaRFID.Name = "txtMaRFID";
            this.txtMaRFID.Size = new System.Drawing.Size(126, 20);
            this.txtMaRFID.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mã RFID";
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM12";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmQLLanDuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 373);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FrmQLLanDuong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmQLLanDuong";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmQLLanDuong_FormClosed);
            this.Load += new System.EventHandler(this.FrmQLLanDuong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxConnecting)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTime)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBarrier)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblTrangthai;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSoTien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBienSo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenDangKy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaRFID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox picBoxBarrier;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnMo;
        private System.Windows.Forms.PictureBox picBoxConnecting;
        private System.Windows.Forms.PictureBox picBoxTime;
        private System.Windows.Forms.ListBox lstRFID;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label lblday;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtDu;
        private System.Windows.Forms.Label label9;
    }
}
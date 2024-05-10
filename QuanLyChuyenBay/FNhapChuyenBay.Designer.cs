namespace QuanLyChuyenBay
{
    partial class FNhapChuyenBay
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label4 = new System.Windows.Forms.Label();
            this.btnChon = new System.Windows.Forms.Button();
            this.btnLoc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNgay = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgXemChuyenBay = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNoiDi = new System.Windows.Forms.ComboBox();
            this.txtNoiDen = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NgayKhoiHanh = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.NgayDenDuKien = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaMB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgXemChuyenBay)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(210, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 42;
            this.label4.Text = "Mã máy bay";
            // 
            // btnChon
            // 
            this.btnChon.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnChon.Location = new System.Drawing.Point(394, 77);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(66, 34);
            this.btnChon.TabIndex = 38;
            this.btnChon.Text = "Chọn";
            this.btnChon.UseVisualStyleBackColor = false;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // btnLoc
            // 
            this.btnLoc.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnLoc.Location = new System.Drawing.Point(635, 103);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(66, 34);
            this.btnLoc.TabIndex = 37;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = false;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "Chọn ngày";
            // 
            // txtNgay
            // 
            this.txtNgay.Location = new System.Drawing.Point(358, 109);
            this.txtNgay.Name = "txtNgay";
            this.txtNgay.Size = new System.Drawing.Size(268, 26);
            this.txtNgay.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(335, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 36);
            this.label1.TabIndex = 34;
            this.label1.Text = "Nhập các chuyến bay";
            // 
            // dtgXemChuyenBay
            // 
            this.dtgXemChuyenBay.AllowUserToAddRows = false;
            this.dtgXemChuyenBay.AllowUserToDeleteRows = false;
            this.dtgXemChuyenBay.AllowUserToResizeColumns = false;
            this.dtgXemChuyenBay.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dtgXemChuyenBay.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgXemChuyenBay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgXemChuyenBay.BackgroundColor = System.Drawing.Color.White;
            this.dtgXemChuyenBay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgXemChuyenBay.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgXemChuyenBay.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgXemChuyenBay.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgXemChuyenBay.ColumnHeadersHeight = 34;
            this.dtgXemChuyenBay.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgXemChuyenBay.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgXemChuyenBay.EnableHeadersVisualStyles = false;
            this.dtgXemChuyenBay.GridColor = System.Drawing.Color.LightGray;
            this.dtgXemChuyenBay.Location = new System.Drawing.Point(71, 270);
            this.dtgXemChuyenBay.MultiSelect = false;
            this.dtgXemChuyenBay.Name = "dtgXemChuyenBay";
            this.dtgXemChuyenBay.RowHeadersVisible = false;
            this.dtgXemChuyenBay.RowHeadersWidth = 25;
            this.dtgXemChuyenBay.RowTemplate.Height = 28;
            this.dtgXemChuyenBay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgXemChuyenBay.Size = new System.Drawing.Size(824, 237);
            this.dtgXemChuyenBay.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 40;
            this.label3.Text = "Nơi đi";
            // 
            // txtNoiDi
            // 
            this.txtNoiDi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtNoiDi.FormattingEnabled = true;
            this.txtNoiDi.Items.AddRange(new object[] {
            "Hà Nội",
            "Hải Phòng",
            "Thanh Hóa",
            "Nghệ An",
            "Quảng Bình",
            "Huế",
            "Đà Nẵng",
            "Quảng Nam",
            "Bình Định",
            "Gia Lai",
            "Phú Yên",
            "Nha Trang",
            "Đà Lạt",
            "TP.HCM",
            "Cần Thơ",
            "Kiên Giang",
            "Cà Mau",
            "Phú Quốc"});
            this.txtNoiDi.Location = new System.Drawing.Point(115, 15);
            this.txtNoiDi.Name = "txtNoiDi";
            this.txtNoiDi.Size = new System.Drawing.Size(114, 28);
            this.txtNoiDi.TabIndex = 43;
            // 
            // txtNoiDen
            // 
            this.txtNoiDen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtNoiDen.FormattingEnabled = true;
            this.txtNoiDen.Items.AddRange(new object[] {
            "Hà Nội",
            "Hải Phòng",
            "Thanh Hóa",
            "Nghệ An",
            "Quảng Bình",
            "Huế",
            "Đà Nẵng",
            "Quảng Nam",
            "Bình Định",
            "Gia Lai",
            "Phú Yên",
            "Nha Trang",
            "Đà Lạt",
            "TP.HCM",
            "Cần Thơ",
            "Kiên Giang",
            "Cà Mau",
            "Phú Quốc"});
            this.txtNoiDen.Location = new System.Drawing.Point(115, 46);
            this.txtNoiDen.Name = "txtNoiDen";
            this.txtNoiDen.Size = new System.Drawing.Size(114, 28);
            this.txtNoiDen.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 44;
            this.label5.Text = "Nơi đến";
            // 
            // NgayKhoiHanh
            // 
            this.NgayKhoiHanh.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.NgayKhoiHanh.Location = new System.Drawing.Point(406, 10);
            this.NgayKhoiHanh.Name = "NgayKhoiHanh";
            this.NgayKhoiHanh.Size = new System.Drawing.Size(146, 26);
            this.NgayKhoiHanh.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(250, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 20);
            this.label6.TabIndex = 47;
            this.label6.Text = "Thời gian khởi hành";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(239, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 20);
            this.label7.TabIndex = 49;
            this.label7.Text = "Thời gian đến dự kiến";
            // 
            // NgayDenDuKien
            // 
            this.NgayDenDuKien.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.NgayDenDuKien.Location = new System.Drawing.Point(406, 45);
            this.NgayDenDuKien.Name = "NgayDenDuKien";
            this.NgayDenDuKien.Size = new System.Drawing.Size(146, 26);
            this.NgayDenDuKien.TabIndex = 48;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaMB);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.NgayDenDuKien);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.NgayKhoiHanh);
            this.groupBox1.Controls.Add(this.txtNoiDen);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtNoiDi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnChon);
            this.groupBox1.Location = new System.Drawing.Point(149, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(667, 121);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            // 
            // txtMaMB
            // 
            this.txtMaMB.Enabled = false;
            this.txtMaMB.Location = new System.Drawing.Point(309, 81);
            this.txtMaMB.Name = "txtMaMB";
            this.txtMaMB.Size = new System.Drawing.Size(79, 26);
            this.txtMaMB.TabIndex = 52;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Location = new System.Drawing.Point(578, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 34);
            this.button1.TabIndex = 51;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FNhapChuyenBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 549);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNgay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgXemChuyenBay);
            this.Name = "FNhapChuyenBay";
            this.Text = "FNhapChuyenBay";
            this.Load += new System.EventHandler(this.FNhapChuyenBay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgXemChuyenBay)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker txtNgay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgXemChuyenBay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox txtNoiDi;
        private System.Windows.Forms.ComboBox txtNoiDen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker NgayKhoiHanh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker NgayDenDuKien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtMaMB;
    }
}
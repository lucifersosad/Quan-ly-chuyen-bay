namespace QuanLyChuyenBay
{
    partial class FTimKiemChuyenBay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FTimKiemChuyenBay));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboDiemDen = new System.Windows.Forms.ComboBox();
            this.cboDiemDi = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpThoiGianDi = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTimChuyenBay = new System.Windows.Forms.Button();
            this.dtgTimKiem = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTimKiem)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Location = new System.Drawing.Point(1, -7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1161, 221);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(283, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Điểm đến";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Điểm đi";
            // 
            // cboDiemDen
            // 
            this.cboDiemDen.FormattingEnabled = true;
            this.cboDiemDen.Items.AddRange(new object[] {
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
            "Cà Mau"});
            this.cboDiemDen.Location = new System.Drawing.Point(391, 47);
            this.cboDiemDen.Name = "cboDiemDen";
            this.cboDiemDen.Size = new System.Drawing.Size(163, 28);
            this.cboDiemDen.TabIndex = 5;
            // 
            // cboDiemDi
            // 
            this.cboDiemDi.FormattingEnabled = true;
            this.cboDiemDi.Items.AddRange(new object[] {
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
            "Cà Mau"});
            this.cboDiemDi.Location = new System.Drawing.Point(111, 46);
            this.cboDiemDi.Name = "cboDiemDi";
            this.cboDiemDi.Size = new System.Drawing.Size(163, 28);
            this.cboDiemDi.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(594, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Thời gian đi";
            // 
            // dtpThoiGianDi
            // 
            this.dtpThoiGianDi.Location = new System.Drawing.Point(598, 48);
            this.dtpThoiGianDi.Name = "dtpThoiGianDi";
            this.dtpThoiGianDi.Size = new System.Drawing.Size(271, 26);
            this.dtpThoiGianDi.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpThoiGianDi);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cboDiemDi);
            this.groupBox2.Controls.Add(this.cboDiemDen);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(130, 228);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(885, 93);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // btnTimChuyenBay
            // 
            this.btnTimChuyenBay.BackColor = System.Drawing.Color.LightBlue;
            this.btnTimChuyenBay.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimChuyenBay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTimChuyenBay.Location = new System.Drawing.Point(465, 327);
            this.btnTimChuyenBay.Name = "btnTimChuyenBay";
            this.btnTimChuyenBay.Size = new System.Drawing.Size(200, 47);
            this.btnTimChuyenBay.TabIndex = 7;
            this.btnTimChuyenBay.Text = "Tìm chuyến bay";
            this.btnTimChuyenBay.UseVisualStyleBackColor = false;
            this.btnTimChuyenBay.Click += new System.EventHandler(this.btnTimChuyenBay_Click);
            // 
            // dtgTimKiem
            // 
            this.dtgTimKiem.AllowUserToAddRows = false;
            this.dtgTimKiem.AllowUserToDeleteRows = false;
            this.dtgTimKiem.AllowUserToResizeColumns = false;
            this.dtgTimKiem.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dtgTimKiem.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgTimKiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgTimKiem.BackgroundColor = System.Drawing.Color.White;
            this.dtgTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgTimKiem.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgTimKiem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgTimKiem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgTimKiem.ColumnHeadersHeight = 34;
            this.dtgTimKiem.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgTimKiem.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgTimKiem.EnableHeadersVisualStyles = false;
            this.dtgTimKiem.GridColor = System.Drawing.Color.LightGray;
            this.dtgTimKiem.Location = new System.Drawing.Point(39, 392);
            this.dtgTimKiem.MultiSelect = false;
            this.dtgTimKiem.Name = "dtgTimKiem";
            this.dtgTimKiem.ReadOnly = true;
            this.dtgTimKiem.RowHeadersVisible = false;
            this.dtgTimKiem.RowHeadersWidth = 25;
            this.dtgTimKiem.RowTemplate.Height = 28;
            this.dtgTimKiem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgTimKiem.Size = new System.Drawing.Size(1097, 200);
            this.dtgTimKiem.TabIndex = 17;
            this.dtgTimKiem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgTimKiem_CellClick);
            // 
            // FTimKiemChuyenBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1164, 633);
            this.Controls.Add(this.dtgTimKiem);
            this.Controls.Add(this.btnTimChuyenBay);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FTimKiemChuyenBay";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTimKiem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboDiemDen;
        private System.Windows.Forms.ComboBox cboDiemDi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpThoiGianDi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTimChuyenBay;
        private System.Windows.Forms.DataGridView dtgTimKiem;
    }
}


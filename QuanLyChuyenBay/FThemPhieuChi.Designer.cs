namespace QuanLyChuyenBay
{
    partial class FThemPhieuChi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_MaPhieuChi = new System.Windows.Forms.TextBox();
            this.txt_MaMayBay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_TenPhi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_SoTienChi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtp_NgayXuatPhieu = new System.Windows.Forms.DateTimePicker();
            this.btn_ThemPC = new System.Windows.Forms.Button();
            this.btn_SuaPC = new System.Windows.Forms.Button();
            this.btn_XoaPC = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_ThoatPC = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(275, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thêm phiếu chi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã phiếu chi:";
            // 
            // txt_MaPhieuChi
            // 
            this.txt_MaPhieuChi.Location = new System.Drawing.Point(149, 82);
            this.txt_MaPhieuChi.Name = "txt_MaPhieuChi";
            this.txt_MaPhieuChi.Size = new System.Drawing.Size(175, 22);
            this.txt_MaPhieuChi.TabIndex = 3;
            // 
            // txt_MaMayBay
            // 
            this.txt_MaMayBay.Location = new System.Drawing.Point(149, 123);
            this.txt_MaMayBay.Name = "txt_MaMayBay";
            this.txt_MaMayBay.Size = new System.Drawing.Size(175, 22);
            this.txt_MaMayBay.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã máy bay:";
            // 
            // txt_TenPhi
            // 
            this.txt_TenPhi.Location = new System.Drawing.Point(149, 167);
            this.txt_TenPhi.Name = "txt_TenPhi";
            this.txt_TenPhi.Size = new System.Drawing.Size(175, 22);
            this.txt_TenPhi.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tên phí:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(372, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ngày xuất phiếu:";
            // 
            // txt_SoTienChi
            // 
            this.txt_SoTienChi.Location = new System.Drawing.Point(507, 120);
            this.txt_SoTienChi.Name = "txt_SoTienChi";
            this.txt_SoTienChi.Size = new System.Drawing.Size(176, 22);
            this.txt_SoTienChi.TabIndex = 11;
            this.txt_SoTienChi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ChiNhapSo_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(372, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Số tiền chi: ";
            // 
            // dtp_NgayXuatPhieu
            // 
            this.dtp_NgayXuatPhieu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgayXuatPhieu.Location = new System.Drawing.Point(507, 78);
            this.dtp_NgayXuatPhieu.Name = "dtp_NgayXuatPhieu";
            this.dtp_NgayXuatPhieu.Size = new System.Drawing.Size(176, 22);
            this.dtp_NgayXuatPhieu.TabIndex = 12;
            // 
            // btn_ThemPC
            // 
            this.btn_ThemPC.Location = new System.Drawing.Point(149, 223);
            this.btn_ThemPC.Name = "btn_ThemPC";
            this.btn_ThemPC.Size = new System.Drawing.Size(69, 46);
            this.btn_ThemPC.TabIndex = 13;
            this.btn_ThemPC.Text = "Thêm";
            this.btn_ThemPC.UseVisualStyleBackColor = true;
            this.btn_ThemPC.Click += new System.EventHandler(this.btn_ThemPC_Click);
            // 
            // btn_SuaPC
            // 
            this.btn_SuaPC.Location = new System.Drawing.Point(269, 223);
            this.btn_SuaPC.Name = "btn_SuaPC";
            this.btn_SuaPC.Size = new System.Drawing.Size(69, 46);
            this.btn_SuaPC.TabIndex = 14;
            this.btn_SuaPC.Text = "Sửa";
            this.btn_SuaPC.UseVisualStyleBackColor = true;
            this.btn_SuaPC.Click += new System.EventHandler(this.btn_SuaPC_Click);
            // 
            // btn_XoaPC
            // 
            this.btn_XoaPC.Location = new System.Drawing.Point(394, 223);
            this.btn_XoaPC.Name = "btn_XoaPC";
            this.btn_XoaPC.Size = new System.Drawing.Size(69, 46);
            this.btn_XoaPC.TabIndex = 15;
            this.btn_XoaPC.Text = "Xóa";
            this.btn_XoaPC.UseVisualStyleBackColor = true;
            this.btn_XoaPC.Click += new System.EventHandler(this.btn_XoaPC_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(36, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(682, 150);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaPhieuChi";
            this.Column1.HeaderText = "Mã phiếu chi";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MaMB";
            this.Column2.HeaderText = "Mã máy bay";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TenPhi";
            this.Column3.HeaderText = "Tên phí";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "NgayXuatPhieu";
            this.Column4.HeaderText = "Ngày xuất phiếu";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "SoTienChi";
            this.Column5.HeaderText = "Số tiền chi";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // btn_ThoatPC
            // 
            this.btn_ThoatPC.Location = new System.Drawing.Point(507, 223);
            this.btn_ThoatPC.Name = "btn_ThoatPC";
            this.btn_ThoatPC.Size = new System.Drawing.Size(69, 46);
            this.btn_ThoatPC.TabIndex = 17;
            this.btn_ThoatPC.Text = "Thoát";
            this.btn_ThoatPC.UseVisualStyleBackColor = true;
            this.btn_ThoatPC.Click += new System.EventHandler(this.btn_ThoatPC_Click);
            // 
            // FThemPhieuChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_ThoatPC);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_XoaPC);
            this.Controls.Add(this.btn_SuaPC);
            this.Controls.Add(this.btn_ThemPC);
            this.Controls.Add(this.dtp_NgayXuatPhieu);
            this.Controls.Add(this.txt_SoTienChi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_TenPhi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_MaMayBay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_MaPhieuChi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FThemPhieuChi";
            this.Text = "FThemPhieuChi";
            this.Load += new System.EventHandler(this.FThemPhieuChi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_MaPhieuChi;
        private System.Windows.Forms.TextBox txt_MaMayBay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_TenPhi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_SoTienChi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtp_NgayXuatPhieu;
        private System.Windows.Forms.Button btn_ThemPC;
        private System.Windows.Forms.Button btn_SuaPC;
        private System.Windows.Forms.Button btn_XoaPC;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btn_ThoatPC;
    }
}
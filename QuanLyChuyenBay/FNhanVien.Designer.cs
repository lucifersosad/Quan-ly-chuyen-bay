namespace QuanLyChuyenBay
{
    partial class FNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FNhanVien));
            this.panelHienThi = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPhanCong = new System.Windows.Forms.Button();
            this.btnLichSuLamViec = new System.Windows.Forms.Button();
            this.btnXemTienLuong = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHienThi
            // 
            this.panelHienThi.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panelHienThi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelHienThi.BackgroundImage")));
            this.panelHienThi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelHienThi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelHienThi.Location = new System.Drawing.Point(0, 78);
            this.panelHienThi.Name = "panelHienThi";
            this.panelHienThi.Size = new System.Drawing.Size(1164, 555);
            this.panelHienThi.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panel1.Controls.Add(this.btnPhanCong);
            this.panel1.Controls.Add(this.btnLichSuLamViec);
            this.panel1.Controls.Add(this.btnXemTienLuong);
            this.panel1.Controls.Add(this.btnDangXuat);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1167, 79);
            this.panel1.TabIndex = 2;
            // 
            // btnPhanCong
            // 
            this.btnPhanCong.BackColor = System.Drawing.Color.Transparent;
            this.btnPhanCong.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPhanCong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhanCong.ImageKey = "(none)";
            this.btnPhanCong.Location = new System.Drawing.Point(322, 3);
            this.btnPhanCong.Name = "btnPhanCong";
            this.btnPhanCong.Size = new System.Drawing.Size(164, 75);
            this.btnPhanCong.TabIndex = 11;
            this.btnPhanCong.Text = "Xem ca làm việc";
            this.btnPhanCong.UseVisualStyleBackColor = false;
            this.btnPhanCong.Click += new System.EventHandler(this.btnPhanCong_Click);
            // 
            // btnLichSuLamViec
            // 
            this.btnLichSuLamViec.BackColor = System.Drawing.Color.Transparent;
            this.btnLichSuLamViec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLichSuLamViec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLichSuLamViec.ImageKey = "(none)";
            this.btnLichSuLamViec.Location = new System.Drawing.Point(646, 3);
            this.btnLichSuLamViec.Name = "btnLichSuLamViec";
            this.btnLichSuLamViec.Size = new System.Drawing.Size(164, 75);
            this.btnLichSuLamViec.TabIndex = 10;
            this.btnLichSuLamViec.Text = "Lịch sử làm việc";
            this.btnLichSuLamViec.UseVisualStyleBackColor = false;
            this.btnLichSuLamViec.Click += new System.EventHandler(this.btnLichSuLamViec_Click);
            // 
            // btnXemTienLuong
            // 
            this.btnXemTienLuong.BackColor = System.Drawing.Color.Transparent;
            this.btnXemTienLuong.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXemTienLuong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXemTienLuong.ImageKey = "(none)";
            this.btnXemTienLuong.Location = new System.Drawing.Point(484, 3);
            this.btnXemTienLuong.Name = "btnXemTienLuong";
            this.btnXemTienLuong.Size = new System.Drawing.Size(164, 75);
            this.btnXemTienLuong.TabIndex = 9;
            this.btnXemTienLuong.Text = "Xem tiền lương";
            this.btnXemTienLuong.UseVisualStyleBackColor = false;
            this.btnXemTienLuong.Click += new System.EventHandler(this.btnXemTienLuong_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDangXuat.Location = new System.Drawing.Point(1009, 20);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(130, 41);
            this.btnDangXuat.TabIndex = 6;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // FNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 633);
            this.Controls.Add(this.panelHienThi);
            this.Controls.Add(this.panel1);
            this.Name = "FNhanVien";
            this.Text = "FNhanVien";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHienThi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button btnLichSuLamViec;
        private System.Windows.Forms.Button btnXemTienLuong;
        private System.Windows.Forms.Button btnPhanCong;
    }
}
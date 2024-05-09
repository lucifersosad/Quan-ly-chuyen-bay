namespace QuanLyChuyenBay
{
    partial class FXemThongTinKH
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
            this.rbtnTuDat = new System.Windows.Forms.RadioButton();
            this.rbtnDatDum = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.txtGioiTinh = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtNgaySinh = new System.Windows.Forms.TextBox();
            this.btnTiepTheo = new System.Windows.Forms.Button();
            this.lblBaoLoi = new System.Windows.Forms.Label();
            this.lblLoiSDT = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rbtnTuDat
            // 
            this.rbtnTuDat.AutoSize = true;
            this.rbtnTuDat.Location = new System.Drawing.Point(179, 52);
            this.rbtnTuDat.Name = "rbtnTuDat";
            this.rbtnTuDat.Size = new System.Drawing.Size(177, 24);
            this.rbtnTuDat.TabIndex = 0;
            this.rbtnTuDat.TabStop = true;
            this.rbtnTuDat.Text = "Đặt vé cho bản thân";
            this.rbtnTuDat.UseVisualStyleBackColor = true;
            this.rbtnTuDat.CheckedChanged += new System.EventHandler(this.rbtnTuDat_CheckedChanged);
            // 
            // rbtnDatDum
            // 
            this.rbtnDatDum.AutoSize = true;
            this.rbtnDatDum.Location = new System.Drawing.Point(806, 52);
            this.rbtnDatDum.Name = "rbtnDatDum";
            this.rbtnDatDum.Size = new System.Drawing.Size(171, 24);
            this.rbtnDatDum.TabIndex = 1;
            this.rbtnDatDum.TabStop = true;
            this.rbtnDatDum.Text = "Đặt cho người khác";
            this.rbtnDatDum.UseVisualStyleBackColor = true;
            this.rbtnDatDum.CheckedChanged += new System.EventHandler(this.rbtnDatDum_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(361, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(432, 51);
            this.label2.TabIndex = 3;
            this.label2.Text = "Thông tin khách hàng";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(350, 207);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(191, 26);
            this.txtHoTen.TabIndex = 4;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(350, 400);
            this.txtSDT.MaxLength = 10;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(191, 26);
            this.txtSDT.TabIndex = 8;
            this.txtSDT.TextChanged += new System.EventHandler(this.txtSDT_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Họ và Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(209, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ngày sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(209, 404);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = "Số điện thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(609, 400);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 22);
            this.label5.TabIndex = 18;
            this.label5.Text = "Căn cước công dân";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(609, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 22);
            this.label6.TabIndex = 17;
            this.label6.Text = "Giới tính";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(609, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 22);
            this.label7.TabIndex = 16;
            this.label7.Text = "Địa chỉ";
            // 
            // txtCCCD
            // 
            this.txtCCCD.Location = new System.Drawing.Point(806, 398);
            this.txtCCCD.MaxLength = 12;
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(191, 26);
            this.txtCCCD.TabIndex = 15;
            this.txtCCCD.TextChanged += new System.EventHandler(this.txtCCCD_TextChanged);
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.Location = new System.Drawing.Point(806, 297);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Size = new System.Drawing.Size(191, 26);
            this.txtGioiTinh.TabIndex = 14;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(806, 205);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(191, 26);
            this.txtDiaChi.TabIndex = 13;
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.Location = new System.Drawing.Point(350, 299);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(191, 26);
            this.txtNgaySinh.TabIndex = 6;
            // 
            // btnTiepTheo
            // 
            this.btnTiepTheo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTiepTheo.Location = new System.Drawing.Point(841, 495);
            this.btnTiepTheo.Name = "btnTiepTheo";
            this.btnTiepTheo.Size = new System.Drawing.Size(156, 48);
            this.btnTiepTheo.TabIndex = 19;
            this.btnTiepTheo.Text = "Tiếp theo";
            this.btnTiepTheo.UseVisualStyleBackColor = false;
            this.btnTiepTheo.Click += new System.EventHandler(this.btnTiepTheo_Click);
            // 
            // lblBaoLoi
            // 
            this.lblBaoLoi.AutoSize = true;
            this.lblBaoLoi.Location = new System.Drawing.Point(807, 432);
            this.lblBaoLoi.Name = "lblBaoLoi";
            this.lblBaoLoi.Size = new System.Drawing.Size(0, 20);
            this.lblBaoLoi.TabIndex = 20;
            // 
            // lblLoiSDT
            // 
            this.lblLoiSDT.AutoSize = true;
            this.lblLoiSDT.Location = new System.Drawing.Point(356, 432);
            this.lblLoiSDT.Name = "lblLoiSDT";
            this.lblLoiSDT.Size = new System.Drawing.Size(0, 20);
            this.lblLoiSDT.TabIndex = 21;
            // 
            // FXemThongTinKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 633);
            this.Controls.Add(this.lblLoiSDT);
            this.Controls.Add(this.lblBaoLoi);
            this.Controls.Add(this.btnTiepTheo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCCCD);
            this.Controls.Add(this.txtGioiTinh);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtNgaySinh);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbtnDatDum);
            this.Controls.Add(this.rbtnTuDat);
            this.Name = "FXemThongTinKH";
            this.Text = "FXemThongTinKH";
            this.Load += new System.EventHandler(this.FXemThongTinKH_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnTuDat;
        private System.Windows.Forms.RadioButton rbtnDatDum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.TextBox txtGioiTinh;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtNgaySinh;
        private System.Windows.Forms.Button btnTiepTheo;
        private System.Windows.Forms.Label lblBaoLoi;
        private System.Windows.Forms.Label lblLoiSDT;
    }
}
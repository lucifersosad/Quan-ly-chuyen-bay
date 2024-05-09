namespace QuanLyChuyenBay
{
    partial class FSoDuTaiKhoan
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
            this.txtSoDu = new System.Windows.Forms.Label();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbNganHang = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoTienNap = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSoTaiKhoan = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(324, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số dư hiện tại:";
            // 
            // txtSoDu
            // 
            this.txtSoDu.AutoSize = true;
            this.txtSoDu.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDu.Location = new System.Drawing.Point(543, 52);
            this.txtSoDu.Name = "txtSoDu";
            this.txtSoDu.Size = new System.Drawing.Size(0, 32);
            this.txtSoDu.TabIndex = 1;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnXacNhan.Location = new System.Drawing.Point(496, 340);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(107, 43);
            this.btnXacNhan.TabIndex = 3;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(476, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nạp thêm tiền";
            // 
            // cbNganHang
            // 
            this.cbNganHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNganHang.FormattingEnabled = true;
            this.cbNganHang.Location = new System.Drawing.Point(433, 182);
            this.cbNganHang.Name = "cbNganHang";
            this.cbNganHang.Size = new System.Drawing.Size(267, 28);
            this.cbNganHang.TabIndex = 5;
            this.cbNganHang.SelectedIndexChanged += new System.EventHandler(this.cbNganHang_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(306, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ngân hàng";
            // 
            // txtSoTienNap
            // 
            this.txtSoTienNap.Location = new System.Drawing.Point(433, 298);
            this.txtSoTienNap.Name = "txtSoTienNap";
            this.txtSoTienNap.Size = new System.Drawing.Size(267, 26);
            this.txtSoTienNap.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(261, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "Số tiền cần nạp";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(289, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 26);
            this.label6.TabIndex = 9;
            this.label6.Text = "Số tài khoản";
            // 
            // txtSoTaiKhoan
            // 
            this.txtSoTaiKhoan.Location = new System.Drawing.Point(433, 240);
            this.txtSoTaiKhoan.Name = "txtSoTaiKhoan";
            this.txtSoTaiKhoan.ReadOnly = true;
            this.txtSoTaiKhoan.Size = new System.Drawing.Size(267, 26);
            this.txtSoTaiKhoan.TabIndex = 10;
            // 
            // FSoDuTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 497);
            this.Controls.Add(this.txtSoTaiKhoan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSoTienNap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbNganHang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.txtSoDu);
            this.Controls.Add(this.label1);
            this.Name = "FSoDuTaiKhoan";
            this.Text = "Số tài khoản";
            this.Load += new System.EventHandler(this.FSoDuTaiKhoan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtSoDu;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbNganHang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoTienNap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSoTaiKhoan;
    }
}
namespace QuanLyChuyenBay
{
    partial class FNhapPhanCong
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNgay = new System.Windows.Forms.DateTimePicker();
            this.dtgNhapPhanCong = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtMaChuyenBay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgNhapPhanCong)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(359, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 36);
            this.label1.TabIndex = 19;
            this.label1.Text = "Phân công nhân viên";
            // 
            // btnLoc
            // 
            this.btnLoc.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnLoc.Location = new System.Drawing.Point(666, 125);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(66, 34);
            this.btnLoc.TabIndex = 25;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = false;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Chọn ngày";
            // 
            // txtNgay
            // 
            this.txtNgay.Location = new System.Drawing.Point(389, 131);
            this.txtNgay.Name = "txtNgay";
            this.txtNgay.Size = new System.Drawing.Size(268, 26);
            this.txtNgay.TabIndex = 23;
            // 
            // dtgNhapPhanCong
            // 
            this.dtgNhapPhanCong.AllowUserToAddRows = false;
            this.dtgNhapPhanCong.AllowUserToDeleteRows = false;
            this.dtgNhapPhanCong.AllowUserToResizeColumns = false;
            this.dtgNhapPhanCong.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dtgNhapPhanCong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgNhapPhanCong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgNhapPhanCong.BackgroundColor = System.Drawing.Color.White;
            this.dtgNhapPhanCong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgNhapPhanCong.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgNhapPhanCong.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgNhapPhanCong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgNhapPhanCong.ColumnHeadersHeight = 34;
            this.dtgNhapPhanCong.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgNhapPhanCong.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgNhapPhanCong.EnableHeadersVisualStyles = false;
            this.dtgNhapPhanCong.GridColor = System.Drawing.Color.LightGray;
            this.dtgNhapPhanCong.Location = new System.Drawing.Point(151, 225);
            this.dtgNhapPhanCong.MultiSelect = false;
            this.dtgNhapPhanCong.Name = "dtgNhapPhanCong";
            this.dtgNhapPhanCong.RowHeadersVisible = false;
            this.dtgNhapPhanCong.RowHeadersWidth = 25;
            this.dtgNhapPhanCong.RowTemplate.Height = 28;
            this.dtgNhapPhanCong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgNhapPhanCong.Size = new System.Drawing.Size(783, 237);
            this.dtgNhapPhanCong.TabIndex = 18;
            this.dtgNhapPhanCong.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dtgNhapPhanCong_CellBeginEdit);
            this.dtgNhapPhanCong.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgNhapPhanCong_CellEndEdit);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAdd.Location = new System.Drawing.Point(693, 170);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(66, 34);
            this.btnAdd.TabIndex = 26;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtMaChuyenBay
            // 
            this.txtMaChuyenBay.Location = new System.Drawing.Point(409, 174);
            this.txtMaChuyenBay.Name = "txtMaChuyenBay";
            this.txtMaChuyenBay.Size = new System.Drawing.Size(83, 26);
            this.txtMaChuyenBay.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Mã chuyến bay";
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Location = new System.Drawing.Point(604, 174);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(83, 26);
            this.txtMaNhanVien.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(498, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "Mã nhân viên";
            // 
            // FNhapPhanCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 535);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMaNhanVien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaChuyenBay);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnLoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNgay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgNhapPhanCong);
            this.Name = "FNhapPhanCong";
            this.Text = "FNhapPhanCong";
            ((System.ComponentModel.ISupportInitialize)(this.dtgNhapPhanCong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker txtNgay;
        private System.Windows.Forms.DataGridView dtgNhapPhanCong;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtMaChuyenBay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.Label label4;
    }
}
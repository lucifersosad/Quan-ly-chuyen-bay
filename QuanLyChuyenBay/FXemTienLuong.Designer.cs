namespace QuanLyChuyenBay
{
    partial class FXemTienLuong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtThoiGianCuoi = new System.Windows.Forms.DateTimePicker();
            this.txtThoiGianDau = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgTimKiem = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTimKiem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(467, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xem tiền lương theo khoảng thời gian";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button1.Location = new System.Drawing.Point(639, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 34);
            this.button1.TabIndex = 24;
            this.button1.Text = "Lọc";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(380, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 22);
            this.label3.TabIndex = 23;
            this.label3.Text = "đến";
            // 
            // txtThoiGianCuoi
            // 
            this.txtThoiGianCuoi.Location = new System.Drawing.Point(424, 117);
            this.txtThoiGianCuoi.Name = "txtThoiGianCuoi";
            this.txtThoiGianCuoi.Size = new System.Drawing.Size(200, 26);
            this.txtThoiGianCuoi.TabIndex = 22;
            // 
            // txtThoiGianDau
            // 
            this.txtThoiGianDau.Location = new System.Drawing.Point(171, 117);
            this.txtThoiGianDau.Name = "txtThoiGianDau";
            this.txtThoiGianDau.Size = new System.Drawing.Size(200, 26);
            this.txtThoiGianDau.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(136, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 22);
            this.label2.TabIndex = 20;
            this.label2.Text = "Từ";
            // 
            // dtgTimKiem
            // 
            this.dtgTimKiem.AllowUserToAddRows = false;
            this.dtgTimKiem.AllowUserToDeleteRows = false;
            this.dtgTimKiem.AllowUserToResizeColumns = false;
            this.dtgTimKiem.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dtgTimKiem.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgTimKiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgTimKiem.BackgroundColor = System.Drawing.Color.White;
            this.dtgTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgTimKiem.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgTimKiem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgTimKiem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgTimKiem.ColumnHeadersHeight = 34;
            this.dtgTimKiem.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgTimKiem.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtgTimKiem.EnableHeadersVisualStyles = false;
            this.dtgTimKiem.GridColor = System.Drawing.Color.LightGray;
            this.dtgTimKiem.Location = new System.Drawing.Point(51, 190);
            this.dtgTimKiem.MultiSelect = false;
            this.dtgTimKiem.Name = "dtgTimKiem";
            this.dtgTimKiem.ReadOnly = true;
            this.dtgTimKiem.RowHeadersVisible = false;
            this.dtgTimKiem.RowHeadersWidth = 25;
            this.dtgTimKiem.RowTemplate.Height = 28;
            this.dtgTimKiem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgTimKiem.Size = new System.Drawing.Size(770, 200);
            this.dtgTimKiem.TabIndex = 25;
            // 
            // FXemTienLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 508);
            this.Controls.Add(this.dtgTimKiem);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtThoiGianCuoi);
            this.Controls.Add(this.txtThoiGianDau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FXemTienLuong";
            this.Text = "FXemTienLuong";
            ((System.ComponentModel.ISupportInitialize)(this.dtgTimKiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker txtThoiGianCuoi;
        private System.Windows.Forms.DateTimePicker txtThoiGianDau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgTimKiem;
    }
}
﻿namespace QuanLyChuyenBay
{
    partial class FCaLamViec
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
            this.dtgPhanCong = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNgay = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLoc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPhanCong)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgPhanCong
            // 
            this.dtgPhanCong.AllowUserToAddRows = false;
            this.dtgPhanCong.AllowUserToDeleteRows = false;
            this.dtgPhanCong.AllowUserToResizeColumns = false;
            this.dtgPhanCong.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dtgPhanCong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgPhanCong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgPhanCong.BackgroundColor = System.Drawing.Color.White;
            this.dtgPhanCong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgPhanCong.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgPhanCong.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgPhanCong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgPhanCong.ColumnHeadersHeight = 34;
            this.dtgPhanCong.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgPhanCong.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtgPhanCong.EnableHeadersVisualStyles = false;
            this.dtgPhanCong.GridColor = System.Drawing.Color.LightGray;
            this.dtgPhanCong.Location = new System.Drawing.Point(79, 175);
            this.dtgPhanCong.MultiSelect = false;
            this.dtgPhanCong.Name = "dtgPhanCong";
            this.dtgPhanCong.ReadOnly = true;
            this.dtgPhanCong.RowHeadersVisible = false;
            this.dtgPhanCong.RowHeadersWidth = 25;
            this.dtgPhanCong.RowTemplate.Height = 28;
            this.dtgPhanCong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPhanCong.Size = new System.Drawing.Size(694, 200);
            this.dtgPhanCong.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(266, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 32);
            this.label1.TabIndex = 19;
            this.label1.Text = "BẢNG PHÂN CÔNG";
            // 
            // txtNgay
            // 
            this.txtNgay.Location = new System.Drawing.Point(272, 130);
            this.txtNgay.Name = "txtNgay";
            this.txtNgay.Size = new System.Drawing.Size(268, 26);
            this.txtNgay.TabIndex = 20;
            this.txtNgay.ValueChanged += new System.EventHandler(this.txtNgay_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Chọn ngày";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnLoc
            // 
            this.btnLoc.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnLoc.Location = new System.Drawing.Point(549, 124);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(66, 34);
            this.btnLoc.TabIndex = 22;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = false;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // FCaLamViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 492);
            this.Controls.Add(this.btnLoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNgay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgPhanCong);
            this.Name = "FCaLamViec";
            this.Text = "FCaLamViec";
            ((System.ComponentModel.ISupportInitialize)(this.dtgPhanCong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgPhanCong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker txtNgay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLoc;
    }
}
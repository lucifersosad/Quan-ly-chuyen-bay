namespace QuanLyChuyenBay
{
    partial class FThongKeMayBay
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
            this.dtgInMayBay = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgInMayBay)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(358, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Các máy bay đang hoạt động";
            // 
            // dtgInMayBay
            // 
            this.dtgInMayBay.AllowUserToAddRows = false;
            this.dtgInMayBay.AllowUserToDeleteRows = false;
            this.dtgInMayBay.AllowUserToResizeColumns = false;
            this.dtgInMayBay.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dtgInMayBay.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgInMayBay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgInMayBay.BackgroundColor = System.Drawing.Color.White;
            this.dtgInMayBay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgInMayBay.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgInMayBay.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgInMayBay.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgInMayBay.ColumnHeadersHeight = 34;
            this.dtgInMayBay.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgInMayBay.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgInMayBay.EnableHeadersVisualStyles = false;
            this.dtgInMayBay.GridColor = System.Drawing.Color.LightGray;
            this.dtgInMayBay.Location = new System.Drawing.Point(23, 121);
            this.dtgInMayBay.MultiSelect = false;
            this.dtgInMayBay.Name = "dtgInMayBay";
            this.dtgInMayBay.ReadOnly = true;
            this.dtgInMayBay.RowHeadersVisible = false;
            this.dtgInMayBay.RowHeadersWidth = 25;
            this.dtgInMayBay.RowTemplate.Height = 28;
            this.dtgInMayBay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgInMayBay.Size = new System.Drawing.Size(1097, 334);
            this.dtgInMayBay.TabIndex = 18;
            // 
            // FThongKeMayBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 497);
            this.Controls.Add(this.dtgInMayBay);
            this.Controls.Add(this.label1);
            this.Name = "FThongKeMayBay";
            this.Text = "FThongKeVeNgay";
            this.Load += new System.EventHandler(this.FThongKeMayBay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgInMayBay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgInMayBay;
    }
}
namespace QuanLyChuyenBay
{
    partial class FChonMayBay
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
            this.dtgTimKiem = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTimKiem)).BeginInit();
            this.SuspendLayout();
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
            this.dtgTimKiem.Location = new System.Drawing.Point(78, 103);
            this.dtgTimKiem.MultiSelect = false;
            this.dtgTimKiem.Name = "dtgTimKiem";
            this.dtgTimKiem.ReadOnly = true;
            this.dtgTimKiem.RowHeadersVisible = false;
            this.dtgTimKiem.RowHeadersWidth = 25;
            this.dtgTimKiem.RowTemplate.Height = 28;
            this.dtgTimKiem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgTimKiem.Size = new System.Drawing.Size(637, 264);
            this.dtgTimKiem.TabIndex = 18;
            this.dtgTimKiem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgTimKiem_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(272, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 32);
            this.label1.TabIndex = 19;
            this.label1.Text = "CHỌN MÁY BAY";
            // 
            // FChonMayBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgTimKiem);
            this.Name = "FChonMayBay";
            this.Text = "FChonMayBay";
            this.Load += new System.EventHandler(this.FChonMayBay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgTimKiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgTimKiem;
        private System.Windows.Forms.Label label1;
    }
}
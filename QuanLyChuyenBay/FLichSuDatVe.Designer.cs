namespace QuanLyChuyenBay
{
    partial class FLichSuDatVe
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
            this.dtgLichSuDatVe = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLichSuDatVe)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgLichSuDatVe
            // 
            this.dtgLichSuDatVe.AllowUserToAddRows = false;
            this.dtgLichSuDatVe.AllowUserToDeleteRows = false;
            this.dtgLichSuDatVe.AllowUserToResizeColumns = false;
            this.dtgLichSuDatVe.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dtgLichSuDatVe.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgLichSuDatVe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgLichSuDatVe.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtgLichSuDatVe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgLichSuDatVe.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgLichSuDatVe.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgLichSuDatVe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgLichSuDatVe.ColumnHeadersHeight = 34;
            this.dtgLichSuDatVe.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgLichSuDatVe.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgLichSuDatVe.EnableHeadersVisualStyles = false;
            this.dtgLichSuDatVe.GridColor = System.Drawing.Color.LightGray;
            this.dtgLichSuDatVe.Location = new System.Drawing.Point(12, 12);
            this.dtgLichSuDatVe.MultiSelect = false;
            this.dtgLichSuDatVe.Name = "dtgLichSuDatVe";
            this.dtgLichSuDatVe.ReadOnly = true;
            this.dtgLichSuDatVe.RowHeadersVisible = false;
            this.dtgLichSuDatVe.RowHeadersWidth = 25;
            this.dtgLichSuDatVe.RowTemplate.Height = 28;
            this.dtgLichSuDatVe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgLichSuDatVe.Size = new System.Drawing.Size(1144, 555);
            this.dtgLichSuDatVe.TabIndex = 22;
            this.dtgLichSuDatVe.DoubleClick += new System.EventHandler(this.dtgLichSuDatVe_DoubleClick);
            // 
            // FLichSuDatVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 633);
            this.Controls.Add(this.dtgLichSuDatVe);
            this.Name = "FLichSuDatVe";
            this.Text = "FLichSuDatVe";
            this.Load += new System.EventHandler(this.FLichSuDatVe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgLichSuDatVe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgLichSuDatVe;
    }
}
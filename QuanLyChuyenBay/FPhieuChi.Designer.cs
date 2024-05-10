namespace QuanLyChuyenBay
{
    partial class FPhieuChi
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
            this.btn_ThemPhieuChi = new System.Windows.Forms.Button();
            this.btn_XemPhieuChi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(294, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phiếu chi";
            // 
            // btn_ThemPhieuChi
            // 
            this.btn_ThemPhieuChi.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_ThemPhieuChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemPhieuChi.Location = new System.Drawing.Point(176, 147);
            this.btn_ThemPhieuChi.Name = "btn_ThemPhieuChi";
            this.btn_ThemPhieuChi.Size = new System.Drawing.Size(167, 59);
            this.btn_ThemPhieuChi.TabIndex = 1;
            this.btn_ThemPhieuChi.Text = "Thêm phiếu chi";
            this.btn_ThemPhieuChi.UseVisualStyleBackColor = false;
            this.btn_ThemPhieuChi.Click += new System.EventHandler(this.btn_ThemPhieuChi_Click);
            // 
            // btn_XemPhieuChi
            // 
            this.btn_XemPhieuChi.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_XemPhieuChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XemPhieuChi.Location = new System.Drawing.Point(384, 147);
            this.btn_XemPhieuChi.Name = "btn_XemPhieuChi";
            this.btn_XemPhieuChi.Size = new System.Drawing.Size(164, 59);
            this.btn_XemPhieuChi.TabIndex = 2;
            this.btn_XemPhieuChi.Text = "Xem phiếu chi";
            this.btn_XemPhieuChi.UseVisualStyleBackColor = false;
            this.btn_XemPhieuChi.Click += new System.EventHandler(this.btn_XemPhieuChi_Click);
            // 
            // FPhieuChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_XemPhieuChi);
            this.Controls.Add(this.btn_ThemPhieuChi);
            this.Controls.Add(this.label1);
            this.Name = "FPhieuChi";
            this.Text = "FPhieuChi";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ThemPhieuChi;
        private System.Windows.Forms.Button btn_XemPhieuChi;
    }
}
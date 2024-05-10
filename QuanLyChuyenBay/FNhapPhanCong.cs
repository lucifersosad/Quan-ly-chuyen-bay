using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyChuyenBay
{
    public partial class FNhapPhanCong : Form
    {
        public FNhapPhanCong()
        {
            InitializeComponent();
        }

        private string oldMaChuyenBay;
        private string oldMaNhanVien;

        private void btnLoc_Click(object sender, EventArgs e)
        {
            DBConnection conn = new DBConnection();
            dtgNhapPhanCong.DataSource = conn.NhapPhanCong(txtNgay.Value.ToString("yyyy/MM/dd"));
            dtgNhapPhanCong.Columns[0].Width = 100;
            dtgNhapPhanCong.Columns[0].HeaderText = "Mã chuyến bay";
            dtgNhapPhanCong.Columns[1].Width = 100;
            dtgNhapPhanCong.Columns[1].HeaderText = "Mã nhân viên";
            dtgNhapPhanCong.Columns[2].Width = 150;
            dtgNhapPhanCong.Columns[2].HeaderText = "Trạng thái";
        }

        private void dtgNhapPhanCong_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            int row = dtgNhapPhanCong.CurrentCell.RowIndex;
            oldMaChuyenBay = dtgNhapPhanCong.Rows[row].Cells[0].Value.ToString();
            oldMaNhanVien = dtgNhapPhanCong.Rows[row].Cells[1].Value.ToString();
        }

        private void dtgNhapPhanCong_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            DBConnection conn = new DBConnection();
            int row = dtgNhapPhanCong.CurrentCell.RowIndex;
            string MaCB = dtgNhapPhanCong.Rows[row].Cells[0].Value.ToString();
            string MaNV = dtgNhapPhanCong.Rows[row].Cells[1].Value.ToString();
            string TrangThai = dtgNhapPhanCong.Rows[row].Cells[2].Value.ToString();
            conn.UpdatePhanCong(oldMaChuyenBay, oldMaNhanVien, MaCB, MaNV, TrangThai);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                DBConnection conn = new DBConnection();
                conn.AddPhanCong(cboMaCB.Text, cboMaNV.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void FNhapPhanCong_Load(object sender, EventArgs e)
        {
            loadChuyenBay();
            loadNhanVien();
        }

        private void loadChuyenBay()
        {
            DBConnection conn = new DBConnection();
            DataSet ds = conn.XemChuyenBay();
            DataTable dt = ds.Tables[0];

            cboMaCB.DataSource = dt;
            cboMaCB.DisplayMember = "MaChuyenBay";
            cboMaCB.ValueMember = "MaChuyenBay";
        }

        private void loadNhanVien()
        {
            DBConnection conn = new DBConnection();
            DataSet ds = conn.XemNhanVien();
            DataTable dt = ds.Tables[0];

            cboMaNV.DataSource = dt;
            cboMaNV.DisplayMember = "MaNV";
            cboMaNV.ValueMember = "MaNV";
        }
    }
}

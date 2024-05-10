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
    public partial class FThemPhieuChi : Form
    {
        public FThemPhieuChi()
        {
            InitializeComponent();
        }
        DBConnection db = new DBConnection();

        public void LoadDuLieu()
        {
            string sql = "select * from PhieuChi";
            dataGridView1.DataSource = db.TaoBang(sql);
        }

        private void btn_ThemPC_Click(object sender, EventArgs e)
        {
            string s = "Select * from PhieuChi Where MaPhieuChi = '" + txt_MaPhieuChi.Text + "'";
            DataTable dt = new DataTable();

            dt = db.TaoBang(s);
            if (dt.Rows.Count != 0)
            {
                MessageBox.Show("Dữ liệu đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(txt_MaPhieuChi.Text == "" || txt_TenPhi.Text == "" || txt_MaMayBay.Text == "" || txt_SoTienChi.Text == "")
            {
                MessageBox.Show("Không được để thông tin trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                db.ThemPhieuChi(txt_MaPhieuChi.Text,txt_MaMayBay.Text,txt_TenPhi.Text,dtp_NgayXuatPhieu.Text,txt_SoTienChi.Text);
                txt_MaPhieuChi.ResetText();
                txt_MaMayBay.ResetText();
                txt_TenPhi.ResetText();
                txt_SoTienChi.ResetText();
                LoadDuLieu();
            }    
        }

        private void btn_SuaPC_Click(object sender, EventArgs e)
        {
            string s = "Select * from PhieuChi Where MaPhieuChi = '" + txt_MaPhieuChi.Text + "'";
            DataTable dt = new DataTable();

            dt = db.TaoBang(s);
            if (txt_MaPhieuChi.Text == "" || txt_TenPhi.Text == "" || txt_MaMayBay.Text == "" || txt_SoTienChi.Text == "")
            {
                MessageBox.Show("Không được để thông tin trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                db.SuaPhieuChi(txt_MaPhieuChi.Text, txt_MaMayBay.Text, txt_TenPhi.Text, dtp_NgayXuatPhieu.Text, txt_SoTienChi.Text);
                txt_MaPhieuChi.ResetText();
                txt_MaMayBay.ResetText();
                txt_TenPhi.ResetText();
                txt_SoTienChi.ResetText();
                LoadDuLieu();
                txt_MaPhieuChi.ReadOnly = false;
                btn_ThemPC.Enabled = true;
            }
        }

        private void btn_XoaPC_Click(object sender, EventArgs e)
        {
            string s = "Select * from PhieuChi Where MaPhieuChi = '" + txt_MaPhieuChi.Text + "'";
            DataTable dt = new DataTable();

            dt = db.TaoBang(s);
            if (dt.Rows.Count != 0)
            {
                db.XoaPhieuChi(txt_MaPhieuChi.Text);
                txt_MaPhieuChi.ResetText();
                txt_MaMayBay.ResetText();
                txt_TenPhi.ResetText();
                txt_SoTienChi.ResetText();
                txt_MaPhieuChi.ReadOnly = false;
                btn_ThemPC.Enabled = true;
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadDuLieu();  
        }

        private void btn_ThoatPC_Click(object sender, EventArgs e)
        {
            DialogResult trl;
            trl = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (trl == DialogResult.Yes)
            {
                FPhieuChi PC = new FPhieuChi();               
                this.Close();
            }
        }

        private void FThemPhieuChi_Load(object sender, EventArgs e)
        {
            LoadDuLieu();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable bang = new DataTable();
            bang = (DataTable)dataGridView1.DataSource;

            DataRow hang = bang.Rows[e.RowIndex];
            txt_MaPhieuChi.Text = hang["MaPhieuChi"].ToString();
            txt_MaMayBay.Text = hang["MaMB"].ToString();
            txt_TenPhi.Text = hang["TenPhi"].ToString();
            dtp_NgayXuatPhieu.Text = hang["NgayXuatPhieu"].ToString();
            txt_SoTienChi.Text = hang["SoTienChi"].ToString();
            txt_MaPhieuChi.ReadOnly = true;
            btn_ThemPC.Enabled = false;

        }
        private void ChiNhapSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Vui lòng nhập số tự nhiên! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
            }
        }
        
    }
}

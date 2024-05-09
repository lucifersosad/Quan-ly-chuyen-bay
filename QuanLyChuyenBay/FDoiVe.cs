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
    public partial class FDoiVe : Form
    {
        public FDoiVe()
        {
            InitializeComponent();
        }
     
        public FDoiVe(ModelDatVe datVe)
        {
            this.DatVe = datVe;
            InitializeComponent();
        }
        public FDoiVe(string maVe, string MaCB)
        {
            this.mave = maVe;
            this.MaCB = MaCB;
            this.luucb = MaCB;
            InitializeComponent();
        }
        ModelDatVe DatVe = new ModelDatVe();
        private System.Windows.Forms.Button lastClickedButton = null;
        string luucb;
        string mave;
        string MaCB;

        public void Button_Click(object sender, EventArgs e)
        {
            var currentButton = sender as System.Windows.Forms.Button;
            currentButton.BackColor = Color.LightBlue;
            if (lastClickedButton != null && lastClickedButton != currentButton)
            {
                lastClickedButton.BackColor = Color.White;
            }
            lastClickedButton = currentButton;

        }

        private void FDoiVe_Load(object sender, EventArgs e)
        {
            string cb;
            DBConnection conn = new DBConnection();
            DataSet dt = new DataSet();
            if (mave == null)
                cb = DatVe.GetMaCB();
            else
                cb = MaCB;
            dt = conn.InThongTinVe(cb);
            txtMaChuyenBay.Text = dt.Tables[0].Rows[0][0].ToString();
            txtNoiDi.Text = dt.Tables[0].Rows[0][1].ToString();
            txtNoiDen.Text = dt.Tables[0].Rows[0][2].ToString();
            DateTime ThoiGianKH = (DateTime)dt.Tables[0].Rows[0][3];
            txtThoiGianKH.Text = ThoiGianKH.ToString("dd/MM/yyyy");
            DateTime ThoiGianDen = (DateTime)dt.Tables[0].Rows[0][4];
            txtThoiGianDen.Text = ThoiGianDen.ToString("dd/MM/yyyy");
            txtHang.Text = dt.Tables[0].Rows[0][10].ToString();
            //----------------
            string ghe = conn.LayGhe(cb);
            int TongSoGhe = ghe.Length;
            foreach (Control button in this.panel1.Controls)
            {
                if (button is System.Windows.Forms.Button btn)
                {
                    string stt = button.Text;
                    int sothutu = Int32.Parse(stt) - 1;
                    if (sothutu < TongSoGhe)
                    {
                        if (ghe[sothutu] == '1')
                        {
                            button.BackColor = Color.Red;
                            button.Enabled = false;
                            button.Visible = true;
                        }
                        else
                        {
                            button.Visible = true;
                            button.BackColor = Color.White;
                            button.Enabled = true;
                        }
                    }
                    else button.Visible = false;
                }
            }
        }

        private void btnChonChuyenBay_Click(object sender, EventArgs e)
        {
            FTimKiemChuyenBay timKiemChuyenBay = new FTimKiemChuyenBay();
            timKiemChuyenBay.ShowDialog();
            this.MaCB = timKiemChuyenBay.MaCB;
            FDoiVe_Load(sender,e);
        }

        private void btnGuiYeuCau_Click(object sender, EventArgs e)
        {
            int soghe=0;
            DBConnection conn = new DBConnection();
            foreach (Control button in this.panel1.Controls)
            {
                if (button is System.Windows.Forms.Button btn)
                {
                    if (button.BackColor == Color.LightBlue)
                    {
                       soghe=Int32.Parse(button.Text);
                       break;
                    } 
                }
            }
            if (soghe != 0 && MaCB == luucb)
            {
                conn.DoiVe(soghe, "Khong", mave);

            }
            else if (soghe == 0 && MaCB != luucb)
            {
                conn.DoiVe(0, MaCB, mave);
            }
            else if(soghe!=0 && MaCB != luucb)
            {
                conn.DoiVe(soghe, MaCB, mave);
            }
            else
            {
                MessageBox.Show("Thông tin vé của bạn không có sự thay đổi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            MessageBox.Show("Gửi yêu cầu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();


        }
    }
}


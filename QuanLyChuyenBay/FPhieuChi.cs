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
    public partial class FPhieuChi : Form
    {
        public FPhieuChi()
        {
            InitializeComponent();
        }
        

        private void btn_ThemPhieuChi_Click(object sender, EventArgs e)
        {
            this.Hide();
            FThemPhieuChi themPC = new FThemPhieuChi();
            themPC.ShowDialog();
            this.Close();
        }

        private void btn_XemPhieuChi_Click(object sender, EventArgs e)
        {
            this.Hide();
            FXemPhieuChi xemPC = new FXemPhieuChi();
            xemPC.ShowDialog();
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChuyenBay
{
    public class ModelDatVe
    {
        private string maNguoiDat;
        private string maNguoiDi;
        private string maCB;
        private int soGhe;
        private string loaiVe;
        private Dictionary<string, int> maDV;
        


        public ModelDatVe()
        {
        }

        public ModelDatVe(string maNguoiDat, string maNguoiDi, string maCB, int soGhe, string loaiVe)
        {
            this.maNguoiDat = maNguoiDat;
            this.maNguoiDi = maNguoiDi;
            this.maCB = maCB;
            this.soGhe = soGhe;
            this.loaiVe = loaiVe;
        }

        public void SetMaNguoiDat(string maNguoiDat)
        {
            this.maNguoiDat = maNguoiDat;
        }

        public string GetMaNguoiDat()
        {
            return maNguoiDat;
        }

        public void SetMaNguoiDi(string maNguoiDi)
        {
            this.maNguoiDi = maNguoiDi;
        }

        public string GetMaNguoiDi()
        {
            return maNguoiDi;
        }

        public void SetMaCB(string maCB)
        {
            this.maCB = maCB;
        }

        public string GetMaCB()
        {
            return maCB;
        }

        public void SetSoGhe(int soGhe)
        {
            this.soGhe = soGhe;
        }

        public int GetSoGhe()
        {
            return soGhe;
        }

        public void SetLoaiVe(string loaiVe)
        {
            this.loaiVe = loaiVe;
        }

        public string GetLoaiVe()
        {
            return loaiVe;
        }
        public void SetmaDV(Dictionary<string, int> maDV)
        {
            this.maDV = maDV;
        }

        public Dictionary<string, int> GetmaDV()
        {
            return maDV;
        }
    }
}

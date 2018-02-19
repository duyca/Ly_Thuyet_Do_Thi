using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KS.Model
{
    class DichVuSuDung
    {
        public DichVuSuDung(int maSuDung, string tenDichVu, float donGia, int soLuong)
        {
            this.maSuDung = maSuDung;
            this.donGia = donGia;
            this.soLuong = soLuong;
            this.tenDichVu = tenDichVu;
        }
        public int maSuDung { get; set; }
        public string tenDichVu { get; set; }
        public float donGia { get; set; }
        public int soLuong { get; set; }
    }
}

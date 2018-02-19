using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KS.Model
{
    class ThongTinThue
    {
        public int maPhieu { get; set; }
        public int maPhong { get; set; }
        public int maLoaiPhong { get; set; }
        public float tienQuaGio { get; set; }
        public float donGia { get; set; }
        public float keTiep { get; set; }
        public int maHinhThuc { get; set; }
        public string tenHinhThuc { get; set; }
        public int maKhachHang { get; set; }
        public string tenKhachHang { get; set; }
        public DateTime gioVao { get; set; }
    }
}

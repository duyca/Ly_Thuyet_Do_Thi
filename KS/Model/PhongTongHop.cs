using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KS.Model
{
    class PhongTongHop
    {
        public PhongTongHop()
        {

        }
        public PhongTongHop(Phong phong, LoaiPhong loaiPhong)
        {
            this.phong = phong;
            this.loaiPhong = loaiPhong;
        }
        public Phong phong { get; set; }
        public LoaiPhong loaiPhong { get; set; }
    }
}

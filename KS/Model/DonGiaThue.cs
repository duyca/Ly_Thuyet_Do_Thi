using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KS.Model
{
    class DonGiaThue
    {
        public DonGiaThue()
        {
        }
        public DonGiaThue(float donGia, float keTiep, float tienQuaGio)
        {
            this.donGia = donGia;
            this.keTiep = keTiep;
            this.tienQuaGio = tienQuaGio;
        }
        public float donGia { get; set; }
        public float keTiep { get; set; }
        public float tienQuaGio { get; set; }
    }
}

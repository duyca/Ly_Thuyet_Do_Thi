using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KS.Model;

namespace KS.Controllers
{
    class ctrlDonGia
    {
        public static DonGiaThue LayDonGia(int maLoaiPhong, int maHinhThuc)
        {

            DonGiaThue donGia = new DonGiaThue();
            using (var ctx = new KSEntities())
            {
                try
                {
                    var dongia = ctx.sp_LayDonGia(maLoaiPhong, maHinhThuc).FirstOrDefault();
                    donGia.donGia = (float)dongia.donGia;
                    donGia.keTiep = (float)dongia.keTiep;
                    donGia.tienQuaGio = (float)dongia.tienQuaGio;
                    return donGia;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KS.Model;

namespace KS.Controllers
{
    class ctrlDichVu
    {
        public static List<DichVu> LayDanhSachDichVu()
        {

            List<DichVu> ListSV = new List<DichVu>();
            using (var ctx = new KSEntities())
            {
                try
                {
                    var Servicses = ctx.sp_LayDanhSachDichVu();
                    foreach (var item in Servicses)
                    {
                        DichVu dv = new DichVu();
                        dv.maDichVu = item.maDichVu;
                        dv.tenDichVu = item.tenDichVu;
                        dv.donGia = item.donGia;
                        ListSV.Add(dv);
                    }
                    return ListSV;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}

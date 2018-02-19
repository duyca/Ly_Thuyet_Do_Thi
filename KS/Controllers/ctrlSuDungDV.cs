using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KS.Model;

namespace KS.Controllers
{
    class ctrlSuDungDV
    {
        public static List<DichVuSuDung> GetListSVUseByRentID(int RentID)
        {
            List<DichVuSuDung> list = new List<DichVuSuDung>();
            using (var ctx = new KSEntities())
            {
                try
                {
                    var DichVuSuDung = ctx.sp_DanhSachSuDungDV(RentID).ToList();
                    foreach (var dv in DichVuSuDung)
                    {
                        DichVuSuDung SD = new DichVuSuDung(dv.maSuDung, dv.tenDichVu, (float)dv.donGia, (int)dv.soLuong);
                        list.Add(SD);
                    }
                    return list;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
        public static void GiamDichVuSuDung(int maSuDung)
        {
            using (var ctx = new KSEntities())
            {
                try
                {
                    ctx.sp_GiamDichVuSuDung(maSuDung);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
        public static void ThemDichVuSuDung(int maDichVu, int maPhieuThue)
        {
            using (var ctx = new KSEntities())
            {
                try
                {
                    ctx.sp_ThemDichVuSuDung(maDichVu, maPhieuThue);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
        public static void XoaDichVuSuDung(int maSuDung)
        {
            using (var ctx = new KSEntities())
            {
                try
                {
                    ctx.sp_XoaSuDungDichVu(maSuDung);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}

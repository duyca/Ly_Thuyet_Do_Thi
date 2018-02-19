using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KS.Model;

namespace KS.Controllers
{
    class ctrlKhachHang
    {
        public static KhachHang GetGuestByID(int ID)
        {

            using (var ctx = new KSEntities())
            {
                try
                {
                    return (ctx.KhachHangs.First(x => x.maKH == ID));
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
        public static int ThemKhachHang(KhachHang khach)
        {

            using (var ctx = new KSEntities())
            {
                try
                {
                    ctx.KhachHangs.Add(khach);
                    ctx.SaveChanges();
                    return khach.maKH;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
        public static KhachHang TimKhachHangBangCMND(string cmnd)
        {

            using (var ctx = new KSEntities())
            {
                try
                {
                    var khach = ctx.sp_TimKhachHangByCMND(cmnd).FirstOrDefault();
                    if (khach!=null)
                    {
                        KhachHang KH = new KhachHang();
                        KH.tenKhachHang = khach.tenKhachHang;
                        KH.soCMND = khach.soCMND;
                        KH.soDienThoai = khach.soDienThoai;
                        KH.maKH = khach.maKH;
                        KH.soXe = khach.soXe;
                        return KH;
                    }
                    return null;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}

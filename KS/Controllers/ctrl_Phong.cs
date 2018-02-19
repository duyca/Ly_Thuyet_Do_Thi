using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KS.Model;

namespace KS.Controllers
{
    class ctrl_Phong
    {
        public static List<PhongTongHop> GetListRoom()
        {
            List<PhongTongHop> ListRoom = new List<PhongTongHop>();
            using (var ctx = new KSEntities())
            {
                try
                {
                    var Rooms = ctx.sp_LayDanhSachPhong();
                    foreach (var item in Rooms)
                    {
                        LoaiPhong lp = new LoaiPhong();
                        Phong p = new Phong();
                        p.maLoaiPhong = item.maLoaiPhong;
                        p.maPhong = item.maPhong;
                        p.soPhong = item.soPhong;
                        p.trangThai = item.trangThai;
                        lp.maLoaiPhong= (int)item.maLoaiPhong;
                        lp.tenLoaiPhong = item.tenLoaiPhong;
                        PhongTongHop pth = new PhongTongHop(p, lp);
                        ListRoom.Add(pth);
                    }
                    return ListRoom;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }


        }
    }
}

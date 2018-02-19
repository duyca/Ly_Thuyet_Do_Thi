using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KS.Model;

namespace KS.Controllers
{
    class ctrlHinhThuc
    {
        public static List<HinhThuc> LayDanhSachHinhThuc()
        {
            using (var ctx = new KSEntities())
            {
                List<HinhThuc> DsHinhThuc = new List<HinhThuc>();
                var listHinhThuc = ctx.sp_LayDanhSachHinhThuc().ToList();
                foreach (var item in listHinhThuc)
                {
                    HinhThuc ht = new HinhThuc();
                    ht.tenHinhThuc = item.tenHinhThuc;
                    ht.maHinhThuc = item.maHinhThuc;
                    DsHinhThuc.Add(ht);
                }
                return DsHinhThuc;
            }
        }
    }
}

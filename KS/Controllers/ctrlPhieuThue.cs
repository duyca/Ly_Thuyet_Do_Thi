using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KS.Model;

namespace KS.Controllers
{
    class ctrlPhieuThue
    {
        public static ThongTinThue LayThongTinThueBangMaPhong(int ID)
        {
            ThongTinThue info = new ThongTinThue();
            using (var ctx = new KSEntities())
            {
                try
                {
                    var rentInfo = ctx.sp_LayThongTinPhieuThue(ID).FirstOrDefault();
                    info.donGia = (float)rentInfo.donGia;
                    info.keTiep = (float)rentInfo.keTiep;
                    info.gioVao = (DateTime)rentInfo.gioVao;
                    info.tenHinhThuc = rentInfo.tenHinhThuc;
                    info.tenKhachHang = rentInfo.tenKhachHang;
                    info.maKhachHang = (int)rentInfo.maKhachHang;
                    info.maHinhThuc = (int)rentInfo.maHinhThuc;
                    info.maPhieu = (int)rentInfo.maPhieu;
                    info.tienQuaGio = (int)rentInfo.tienQuaGio;
                    return info;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
        public static float TinhTien(ThongTinThue info, float tienDichVu)
        {
            float tongTien = tienDichVu;
            using (var ctx = new KSEntities())
            {
                DateTime timeNow = DateTime.Now;
                DonGiaThue DonGiaThue = new DonGiaThue();
                TimeSpan thoiGian = timeNow - (DateTime)info.gioVao;
                List<Setting> dsCaiDat = ctx.Settings.ToList();
                double ThoiGianThem = 0;
                double hetGioQuaDem = 12;
                foreach (Setting set in dsCaiDat)
                {
                    if (set.KeySetting == "thoiGianThem")
                    {
                        ThoiGianThem = (double)set.valueSetting;
                    }
                    else if(set.KeySetting == "hetGioQuaDem")
                    {
                        hetGioQuaDem = (double)set.valueSetting;
                    }
                }
                switch (info.maHinhThuc)
                {
                    case 1:// o gio
                        {
                            int tongSoGio = thoiGian.Days * 24 + thoiGian.Hours;
                            
                            if (thoiGian.Minutes > ThoiGianThem)
                            {
                                tongSoGio += 1;
                            }
                            if (tongSoGio >= 1)
                            {
                                tongTien += info.keTiep * (tongSoGio - 1) + info.donGia;
                            }
                            else
                            {
                                tongTien += info.donGia;
                            }
                            break;
                        }
                    case 2: // qua dem
                        {
                            int tongSoGio = thoiGian.Days * 24 + thoiGian.Hours;
                            DateTime temp = new DateTime((int)info.gioVao.Year, (int)info.gioVao.Month, (int)info.gioVao.Day, (int)hetGioQuaDem, 0,0);
                            if ((temp < (DateTime)info.gioVao))
                            {
                                temp = temp.AddDays(1);
                            }
                            tongTien += info.donGia;
                            if (DateTime.Now > temp)
                            {
                                TimeSpan ThoiGianDu = DateTime.Now - temp;
                                tongTien += ThoiGianDu.Hours * info.tienQuaGio;
                                if (ThoiGianDu.Minutes > ThoiGianThem)
                                {
                                    tongTien += info.tienQuaGio;
                                }
                            }
                            break;
                        }
                    case 3: // thue ngay
                        {
                            int tongSoNgay = thoiGian.Days;
                            if (tongSoNgay > 0)
                            {
                                tongTien += tongSoNgay * info.donGia;
                                float TienQuaGio = 0;
                                int tongSoGio = thoiGian.Hours;
                                if (thoiGian.Minutes > ThoiGianThem)
                                {
                                    tongSoGio += 1;
                                }
                                TienQuaGio += (float)info.tienQuaGio * tongSoGio;
                                if (TienQuaGio > info.donGia)
                                {
                                    tongTien += info.donGia;
                                }
                                else
                                {
                                    tongTien += TienQuaGio;
                                }
                            }
                            else
                            {
                                tongTien += info.donGia;
                            }
                            break;
                        }
                }
            }
            return tongTien;
        }
        public static void ThemPhieuThue(PhieuThue phieu)
        {
            using (var ctx = new KSEntities())
            {
                try
                {
                    ctx.PhieuThues.Add(phieu);
                    ctx.sp_DoiTrangThaiPhong(phieu.maPhong, 1);
                    ctx.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}

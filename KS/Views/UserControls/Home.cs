using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KS.Views.Pop_Ups;
using KS.Model;
using KS.Controllers;

namespace KS.Views.UserControls
{
    public partial class Home : UserControl
    {
        ThongTinThue phieuThue = new ThongTinThue();
        public bool Rent = false;
        public bool checkout = false;
        public Home()
        {
            InitializeComponent();
            setting();
            LoadData();
        }
        private void setting()
        {
            dgv_ListService.Columns.Add(new DataGridViewImageColumn()
            {
                Image = Properties.Resources.Plus_32px,
                Name = "Plus",
                HeaderText = ""
            });
            dgv_RoomListService.Columns.Add(new DataGridViewImageColumn()
            {
                Image = Properties.Resources.Minus_32px,
                Name = "Minus",
                HeaderText = ""
            });
            dgv_ListService.Columns["Plus"].FillWeight = 20;
            dgv_RoomListService.Columns["Minus"].FillWeight = 20;
        }
        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            HomePage parent = (this.Parent).FindForm() as HomePage;
            if (lv_ListRoom.SelectedItems != null && !Rent)
            {
                if (lv_ListRoom.SelectedItems[0].ImageIndex == 0)
                {
                    Phong p = new Phong();
                    p.maPhong = int.Parse(lv_ListRoom.SelectedItems[0].Name);
                    LoaiPhong lp = (LoaiPhong)lv_ListRoom.SelectedItems[0].Tag;
                    p.maLoaiPhong = lp.maLoaiPhong;
                    Rent rent = new Rent(parent, p, lp);
                    rent.Show();
                    Rent = true;
                }
                else
                {
                    CheckOut checkout_form = new CheckOut(parent);
                    checkout_form.Show();
                    this.checkout = true;
                }
                
            }
        }

        private void dgv_ListService_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            //I supposed the image column is at index 1
            if (e.ColumnIndex == dgv_ListService.Columns["Plus"].Index)
                e.Value = Properties.Resources.Plus_32px;
        }

        private void dgv_ListService_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            //I supposed your button column is at index 0
            if (e.ColumnIndex == dgv_ListService.Columns["Plus"].Index)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = Properties.Resources.Plus_32px.Width;
                var h = Properties.Resources.Plus_32px.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;
                e.Graphics.DrawImage(Properties.Resources.Plus_32px, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void dgv_ListService_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == dgv_ListService.Columns["Plus"].Index)
            {
                int rowID = dgv_ListService.SelectedRows[0].Index;
                int CellID = dgv_ListService.Columns["maDichVu"].Index;
                int MaDV = (int)dgv_ListService.Rows[rowID].Cells[CellID].Value;
                if (phieuThue.maPhieu != -1)
                {
                    ctrlSuDungDV.ThemDichVuSuDung(MaDV, phieuThue.maPhieu);
                    dgv_ListRoomSV_LoadData(phieuThue.maPhieu);
                    txtTotal.Text = ctrlPhieuThue.TinhTien(phieuThue, TinhTienDichVu()).ToString("###,###,### VNĐ");
                }
            }
        }

        private void dgv_ListRoomSV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            //I supposed the image column is at index 1
            if (e.ColumnIndex == dgv_RoomListService.Columns["Minus"].Index)
                e.Value = Properties.Resources.Minus_32px;
        }

        private void dgv_ListRoomSV_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            //I supposed your button column is at index 0
            if (e.ColumnIndex == dgv_RoomListService.Columns["Minus"].Index)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = Properties.Resources.Minus_32px.Width;
                var h = Properties.Resources.Minus_32px.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;
                e.Graphics.DrawImage(Properties.Resources.Minus_32px, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void dgv_ListRoomSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == dgv_RoomListService.Columns["Minus"].Index)
            {
                int SVrowIndex = dgv_RoomListService.SelectedRows[0].Index;
                int SVCellIndex = dgv_RoomListService.Columns["maSuDung"].Index;
                int maSuDung =int.Parse(dgv_RoomListService.Rows[SVrowIndex].Cells[SVCellIndex].Value.ToString());
                int soluong = int.Parse(dgv_RoomListService.Rows[SVrowIndex].Cells[dgv_RoomListService.Columns["soLuong"].Index].Value.ToString());
                if (soluong > 1)
                {
                    ctrlSuDungDV.GiamDichVuSuDung(maSuDung);
                }
                else
                {
                    ctrlSuDungDV.XoaDichVuSuDung(maSuDung);
                }
                dgv_ListRoomSV_LoadData(phieuThue.maPhieu);
                if (dgv_RoomListService.Rows.Count > SVrowIndex)
                {
                    dgv_RoomListService.Rows[SVrowIndex].Selected = true;
                }
                txtTotal.Text = ctrlPhieuThue.TinhTien(phieuThue, TinhTienDichVu()).ToString("###,###,### VNĐ");
            }
        }
        public void LoadData()
        {
            lv_ListRoom.Clear();
            List<PhongTongHop> DS_Phong = new List<PhongTongHop>();
            DS_Phong = ctrl_Phong.GetListRoom();
            foreach (PhongTongHop pth in DS_Phong)
            {
                ListViewItem item = new ListViewItem();
                item.Text = pth.phong.soPhong;
                item.Name = pth.phong.maPhong.ToString();
                item.Tag = pth.loaiPhong;
                if (pth.phong.trangThai == 0)
                {
                    item.ImageIndex = 0;
                }
                else
                {
                    item.ImageIndex = 1;
                }
                lv_ListRoom.Items.Add(item);
            }
            List<DichVu> DS_DV = new List<DichVu>();
            DS_DV = ctrlDichVu.LayDanhSachDichVu();
            dgv_ListService.DataSource = DS_DV;
            dgv_ListService.ClearSelection();
        }
        private void lv_ListRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            clearText();
            if (lv_ListRoom.SelectedItems.Count > 0)
            {
                if (lv_ListRoom.SelectedItems[0].ImageIndex == 1)
                {
                    txtRoomNumber.Text = lv_ListRoom.SelectedItems[0].Text;
                    int roomID = int.Parse(lv_ListRoom.SelectedItems[0].Name);
                    LoaiPhong lp = (LoaiPhong)lv_ListRoom.SelectedItems[0].Tag;
                    int roomType = lp.maLoaiPhong;
                    ThongTinThue info = ctrlPhieuThue.LayThongTinThueBangMaPhong(roomID);

                    phieuThue = info;
                    info.maPhong = roomID;
                    info.maLoaiPhong = roomType;
                    txtGuestName.Text = info.tenKhachHang;
                    txtRentType.Text = info.tenHinhThuc;
                    txtCheckInTime.Text = info.gioVao.ToString("dd/MM/yyyy HH:mm");
                    TimeSpan timespan = DateTime.Now - (DateTime)info.gioVao;
                    if (timespan.Days != 0)
                    {
                        txtTime.Text += " "+ timespan.Days + " Ngày";
                    }
                    if (timespan.Hours != 0)
                    {
                        txtTime.Text += " " + timespan.Hours + " Giờ";
                    }
                    txtTime.Text += " " + timespan.Minutes + " Phút";
                    if (info.maHinhThuc == 1)
                    {
                        txtDonGia.Text = info.donGia.ToString("###,###") + " - " + info.keTiep.ToString("###,###") + " VNĐ";
                    }
                    else
                    {
                        txtDonGia.Text = info.donGia.ToString("###,###");
                    }
                    
                    dgv_ListRoomSV_LoadData(phieuThue.maPhieu);
                    //var watch = System.Diagnostics.Stopwatch.StartNew();
                    txtTotal.Text = ctrlPhieuThue.TinhTien(info, TinhTienDichVu()).ToString("###,###,### VNĐ");
                    //watch.Stop();
                    //var elapsedMs = watch.ElapsedMilliseconds;
                    //MessageBox.Show(elapsedMs.ToString());
                }
                else
                {
                    phieuThue.maPhieu = -1;
                    dgv_ListRoomSV_LoadData(-1);
                }
            }
        }
        private void dgv_ListRoomSV_LoadData(int ID)
        {
            List<DichVuSuDung> SDDV = new List<DichVuSuDung>();
            SDDV = ctrlSuDungDV.GetListSVUseByRentID(ID);
            dgv_RoomListService.DataSource = SDDV;
            dgv_RoomListService.ClearSelection();
        }
        private void clearText()
        {
            txtRoomNumber.Text = "";
            txtRentType.Text = "";
            txtGuestName.Text = "";
            txtTime.Text = "";
            txtTotal.Text = "";
            txtCheckInTime.Text = "";
            txtDonGia.Text = "";
        }
        private float TinhTienDichVu()
        {
            float Tong = 0;
            int donGiaIndex = dgv_RoomListService.Columns["donGia"].Index;
            int soLuongIndex = dgv_RoomListService.Columns["soLuong"].Index;
            foreach (DataGridViewRow r in dgv_RoomListService.Rows)
            {
                {
                    Tong += Convert.ToInt32(r.Cells[donGiaIndex].Value)* Convert.ToInt32(r.Cells[soLuongIndex].Value);
                }
            }
            return Tong;
        }
    }
}

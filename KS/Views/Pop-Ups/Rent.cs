using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KS.Model;
using KS.Controllers;

namespace KS.Views.Pop_Ups
{
    public partial class Rent : Form
    {
        private HomePage parent;
        private PhongTongHop pth;
        private int maKhach = -1;
        public Rent(HomePage Parent, Phong p, LoaiPhong lp)
        {
            this.pth = new PhongTongHop(p, lp);
            this.parent = Parent;
            InitializeComponent();
            this.KeyPreview = true;
            loadData();
        }
        private void loadData()
        {
            List<HinhThuc> DsHinhThuc = new List<HinhThuc>();
            DsHinhThuc = ctrlHinhThuc.LayDanhSachHinhThuc();
            cbbHinhThuc.DataSource = DsHinhThuc;
            cbbHinhThuc.DisplayMember = "tenHinhThuc";
            cbbHinhThuc.ValueMember = "maHinhThuc";
            txtRoomType.Text = DateTime.Now.ToShortDateString();
            txtRoomType.Text = pth.loaiPhong.tenLoaiPhong;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            close();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            close();
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            PhieuThue phieu = new PhieuThue();
            phieu.maPhong = pth.phong.maPhong;
            int maHinhThuc = (int)cbbHinhThuc.SelectedValue;
            var dgia = ctrlDonGia.LayDonGia(pth.loaiPhong.maLoaiPhong, maHinhThuc);
            if (validateKH() && maKhach == -1) // Co nhap khach hang
            {
                KhachHang khach = new KhachHang();
                khach.tenKhachHang = txtGuestName.Text;
                khach.soCMND = txtID.Text;
                khach.soDienThoai = txtPhone.Text;
                int maKH = ctrlKhachHang.ThemKhachHang(khach);
                phieu.maKhachHang = maKH;
                phieu.gioVao = DateTime.Now;
                phieu.maHinhThuc = maHinhThuc;
            }
            else // chua nhap khach hang
            {
                phieu.maKhachHang = 1;
                phieu.gioVao = DateTime.Now;
                phieu.maHinhThuc = maHinhThuc;
                MessageBox.Show(phieu.maHinhThuc.ToString());
            }
            phieu.donGia = dgia.donGia;
            phieu.keTiep = dgia.keTiep;
            phieu.tienQuaGio = dgia.tienQuaGio;
            ctrlPhieuThue.ThemPhieuThue(phieu);
            parent.home1.LoadData();
            close();
        }
        private void close()
        {
            parent.home1.Rent = false;
            this.Close();
        }

        private void Rent_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.close();
            }
        }
        private bool validateKH()
        {
            if (txtGuestName.Text == "" || txtID.Text == "")
            {
                return false;
            }
            return true;
        }
        private void txtID_KeyUp(object sender, KeyEventArgs e)
        {
            KhachHang khach = ctrlKhachHang.TimKhachHangBangCMND(txtID.Text);
            if (khach != null)
            {
                txtGuestName.Text = khach.tenKhachHang;
                txtPhone.Text = khach.soDienThoai;
                maKhach = khach.maKH;
            }
            else
            {
                maKhach = -1;
                txtGuestName.Text = "";
                txtPhone.Text = "";
            }
        }
    }
}

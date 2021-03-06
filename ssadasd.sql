USE [KS]
GO
/****** Object:  Table [dbo].[DichVu]    Script Date: 2/19/2018 5:07:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DichVu](
	[maDichVu] [int] IDENTITY(1,1) NOT NULL,
	[tenDichVu] [nvarchar](50) NULL,
	[donGia] [float] NULL,
	[Active] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[maDichVu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DonGia]    Script Date: 2/19/2018 5:07:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonGia](
	[maLoaiPhong] [int] NOT NULL,
	[maHinhThuc] [int] NOT NULL,
	[donGia] [float] NULL,
	[keTiep] [float] NULL,
	[tienQuaGio] [float] NULL,
 CONSTRAINT [PK_DonGia] PRIMARY KEY CLUSTERED 
(
	[maLoaiPhong] ASC,
	[maHinhThuc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HinhThuc]    Script Date: 2/19/2018 5:07:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HinhThuc](
	[maHinhThuc] [int] IDENTITY(1,1) NOT NULL,
	[tenHinhThuc] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[maHinhThuc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 2/19/2018 5:07:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[maHD] [int] IDENTITY(1,1) NOT NULL,
	[maPhieu] [int] NULL,
	[tongTien] [float] NULL,
	[ngayLap] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[maHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 2/19/2018 5:07:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[maKH] [int] IDENTITY(1,1) NOT NULL,
	[tenKhachHang] [nvarchar](80) NULL,
	[soXe] [varchar](32) NULL,
	[soCMND] [varchar](12) NULL,
	[soDienThoai] [varchar](12) NULL,
PRIMARY KEY CLUSTERED 
(
	[maKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiPhong]    Script Date: 2/19/2018 5:07:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiPhong](
	[maLoaiPhong] [int] IDENTITY(1,1) NOT NULL,
	[tenLoaiPhong] [nvarchar](30) NULL,
	[Active] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[maLoaiPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 2/19/2018 5:07:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[pass] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuThue]    Script Date: 2/19/2018 5:07:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuThue](
	[maPhieu] [int] IDENTITY(1,1) NOT NULL,
	[maPhong] [int] NULL,
	[maHinhThuc] [int] NULL,
	[maKhachHang] [int] NULL,
	[gioVao] [datetime] NULL,
	[gioTra] [datetime] NULL,
	[donGia] [float] NULL,
	[keTiep] [float] NULL,
	[tienQuaGio] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[maPhieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Phong]    Script Date: 2/19/2018 5:07:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phong](
	[maPhong] [int] IDENTITY(1,1) NOT NULL,
	[soPhong] [nvarchar](80) NULL,
	[maLoaiPhong] [int] NULL,
	[trangThai] [tinyint] NULL,
	[Active] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[maPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Setting]    Script Date: 2/19/2018 5:07:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Setting](
	[KeySetting] [nvarchar](50) NOT NULL,
	[valueSetting] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[KeySetting] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SuDungDichVu]    Script Date: 2/19/2018 5:07:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SuDungDichVu](
	[maSuDung] [int] IDENTITY(1,1) NOT NULL,
	[maDichVu] [int] NULL,
	[maPhieuThue] [int] NULL,
	[donGia] [float] NOT NULL,
	[soLuong] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[maSuDung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[DichVu] ON 

INSERT [dbo].[DichVu] ([maDichVu], [tenDichVu], [donGia], [Active]) VALUES (1, N'Nước Suối', 10000, 1)
INSERT [dbo].[DichVu] ([maDichVu], [tenDichVu], [donGia], [Active]) VALUES (2, N'Nước Ngọt', 15000, 1)
INSERT [dbo].[DichVu] ([maDichVu], [tenDichVu], [donGia], [Active]) VALUES (3, N'Helliken', 25000, 1)
INSERT [dbo].[DichVu] ([maDichVu], [tenDichVu], [donGia], [Active]) VALUES (4, N'Bao', 5000, 1)
INSERT [dbo].[DichVu] ([maDichVu], [tenDichVu], [donGia], [Active]) VALUES (5, N'Phụ Thu', 5000, 1)
SET IDENTITY_INSERT [dbo].[DichVu] OFF
INSERT [dbo].[DonGia] ([maLoaiPhong], [maHinhThuc], [donGia], [keTiep], [tienQuaGio]) VALUES (1, 1, 60000, 10000, 10000)
INSERT [dbo].[DonGia] ([maLoaiPhong], [maHinhThuc], [donGia], [keTiep], [tienQuaGio]) VALUES (1, 2, 150000, 15000, 10000)
INSERT [dbo].[DonGia] ([maLoaiPhong], [maHinhThuc], [donGia], [keTiep], [tienQuaGio]) VALUES (1, 3, 250000, 250000, 10000)
INSERT [dbo].[DonGia] ([maLoaiPhong], [maHinhThuc], [donGia], [keTiep], [tienQuaGio]) VALUES (1, 4, 2000000, 2000000, 10000)
INSERT [dbo].[DonGia] ([maLoaiPhong], [maHinhThuc], [donGia], [keTiep], [tienQuaGio]) VALUES (2, 1, 80000, 20000, 10000)
INSERT [dbo].[DonGia] ([maLoaiPhong], [maHinhThuc], [donGia], [keTiep], [tienQuaGio]) VALUES (2, 2, 180000, 180000, 10000)
INSERT [dbo].[DonGia] ([maLoaiPhong], [maHinhThuc], [donGia], [keTiep], [tienQuaGio]) VALUES (2, 3, 300000, 300000, 10000)
INSERT [dbo].[DonGia] ([maLoaiPhong], [maHinhThuc], [donGia], [keTiep], [tienQuaGio]) VALUES (2, 4, 3000000, 3000000, 10000)
INSERT [dbo].[DonGia] ([maLoaiPhong], [maHinhThuc], [donGia], [keTiep], [tienQuaGio]) VALUES (3, 1, 40000, 10000, 10000)
INSERT [dbo].[DonGia] ([maLoaiPhong], [maHinhThuc], [donGia], [keTiep], [tienQuaGio]) VALUES (3, 2, 120000, 120000, 10000)
INSERT [dbo].[DonGia] ([maLoaiPhong], [maHinhThuc], [donGia], [keTiep], [tienQuaGio]) VALUES (3, 3, 200000, 200000, 10000)
INSERT [dbo].[DonGia] ([maLoaiPhong], [maHinhThuc], [donGia], [keTiep], [tienQuaGio]) VALUES (3, 4, 1800000, 1800000, 10000)
SET IDENTITY_INSERT [dbo].[HinhThuc] ON 

INSERT [dbo].[HinhThuc] ([maHinhThuc], [tenHinhThuc]) VALUES (1, N'Thuê Giờ')
INSERT [dbo].[HinhThuc] ([maHinhThuc], [tenHinhThuc]) VALUES (2, N'Qua Đêm')
INSERT [dbo].[HinhThuc] ([maHinhThuc], [tenHinhThuc]) VALUES (3, N'Thuê Ngày')
INSERT [dbo].[HinhThuc] ([maHinhThuc], [tenHinhThuc]) VALUES (4, N'Thuê Tháng')
SET IDENTITY_INSERT [dbo].[HinhThuc] OFF
SET IDENTITY_INSERT [dbo].[KhachHang] ON 

INSERT [dbo].[KhachHang] ([maKH], [tenKhachHang], [soXe], [soCMND], [soDienThoai]) VALUES (1, N'nobita', N'1', N'123123123', N'123123123123')
SET IDENTITY_INSERT [dbo].[KhachHang] OFF
SET IDENTITY_INSERT [dbo].[LoaiPhong] ON 

INSERT [dbo].[LoaiPhong] ([maLoaiPhong], [tenLoaiPhong], [Active]) VALUES (1, N'Phòng Đơn', 1)
INSERT [dbo].[LoaiPhong] ([maLoaiPhong], [tenLoaiPhong], [Active]) VALUES (2, N'Phòng Đôi', 1)
INSERT [dbo].[LoaiPhong] ([maLoaiPhong], [tenLoaiPhong], [Active]) VALUES (3, N'Phòng Quạt', 1)
SET IDENTITY_INSERT [dbo].[LoaiPhong] OFF
SET IDENTITY_INSERT [dbo].[PhieuThue] ON 

INSERT [dbo].[PhieuThue] ([maPhieu], [maPhong], [maHinhThuc], [maKhachHang], [gioVao], [gioTra], [donGia], [keTiep], [tienQuaGio]) VALUES (1, 2, 1, 1, CAST(N'2018-02-15T00:00:00.000' AS DateTime), CAST(N'2018-03-15T00:00:00.000' AS DateTime), 50000, 10000, 10000)
INSERT [dbo].[PhieuThue] ([maPhieu], [maPhong], [maHinhThuc], [maKhachHang], [gioVao], [gioTra], [donGia], [keTiep], [tienQuaGio]) VALUES (2, 2, 2, 1, CAST(N'2018-02-17T23:00:00.000' AS DateTime), NULL, 150000, 150000, 10000)
INSERT [dbo].[PhieuThue] ([maPhieu], [maPhong], [maHinhThuc], [maKhachHang], [gioVao], [gioTra], [donGia], [keTiep], [tienQuaGio]) VALUES (3, 3, 1, 1, CAST(N'2018-02-18T16:00:00.000' AS DateTime), NULL, 60000, 10000, 10000)
INSERT [dbo].[PhieuThue] ([maPhieu], [maPhong], [maHinhThuc], [maKhachHang], [gioVao], [gioTra], [donGia], [keTiep], [tienQuaGio]) VALUES (4, 4, 3, 1, CAST(N'2018-02-17T01:00:00.000' AS DateTime), NULL, 200000, 200000, 10000)
INSERT [dbo].[PhieuThue] ([maPhieu], [maPhong], [maHinhThuc], [maKhachHang], [gioVao], [gioTra], [donGia], [keTiep], [tienQuaGio]) VALUES (6, 1, 1, 1, CAST(N'2018-02-19T14:27:58.130' AS DateTime), NULL, 60000, 10000, 10000)
SET IDENTITY_INSERT [dbo].[PhieuThue] OFF
SET IDENTITY_INSERT [dbo].[Phong] ON 

INSERT [dbo].[Phong] ([maPhong], [soPhong], [maLoaiPhong], [trangThai], [Active]) VALUES (1, N'101', 1, 1, 1)
INSERT [dbo].[Phong] ([maPhong], [soPhong], [maLoaiPhong], [trangThai], [Active]) VALUES (2, N'102', 2, 1, 1)
INSERT [dbo].[Phong] ([maPhong], [soPhong], [maLoaiPhong], [trangThai], [Active]) VALUES (3, N'103', 2, 1, 1)
INSERT [dbo].[Phong] ([maPhong], [soPhong], [maLoaiPhong], [trangThai], [Active]) VALUES (4, N'104', 3, 1, 1)
INSERT [dbo].[Phong] ([maPhong], [soPhong], [maLoaiPhong], [trangThai], [Active]) VALUES (5, N'201', 2, 0, 1)
SET IDENTITY_INSERT [dbo].[Phong] OFF
INSERT [dbo].[Setting] ([KeySetting], [valueSetting]) VALUES (N'hetGioQuaDem', 12)
INSERT [dbo].[Setting] ([KeySetting], [valueSetting]) VALUES (N'thoiGianThem', 15)
SET IDENTITY_INSERT [dbo].[SuDungDichVu] ON 

INSERT [dbo].[SuDungDichVu] ([maSuDung], [maDichVu], [maPhieuThue], [donGia], [soLuong]) VALUES (22, 2, 3, 15000, 2)
INSERT [dbo].[SuDungDichVu] ([maSuDung], [maDichVu], [maPhieuThue], [donGia], [soLuong]) VALUES (25, 1, 6, 10000, 3)
INSERT [dbo].[SuDungDichVu] ([maSuDung], [maDichVu], [maPhieuThue], [donGia], [soLuong]) VALUES (26, 4, 3, 5000, 1)
SET IDENTITY_INSERT [dbo].[SuDungDichVu] OFF
ALTER TABLE [dbo].[DonGia]  WITH CHECK ADD FOREIGN KEY([maHinhThuc])
REFERENCES [dbo].[HinhThuc] ([maHinhThuc])
GO
ALTER TABLE [dbo].[DonGia]  WITH CHECK ADD FOREIGN KEY([maLoaiPhong])
REFERENCES [dbo].[LoaiPhong] ([maLoaiPhong])
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([maPhieu])
REFERENCES [dbo].[PhieuThue] ([maPhieu])
GO
ALTER TABLE [dbo].[PhieuThue]  WITH CHECK ADD FOREIGN KEY([maHinhThuc])
REFERENCES [dbo].[HinhThuc] ([maHinhThuc])
GO
ALTER TABLE [dbo].[PhieuThue]  WITH CHECK ADD FOREIGN KEY([maKhachHang])
REFERENCES [dbo].[KhachHang] ([maKH])
GO
ALTER TABLE [dbo].[PhieuThue]  WITH CHECK ADD FOREIGN KEY([maPhong])
REFERENCES [dbo].[Phong] ([maPhong])
GO
ALTER TABLE [dbo].[Phong]  WITH CHECK ADD FOREIGN KEY([maLoaiPhong])
REFERENCES [dbo].[LoaiPhong] ([maLoaiPhong])
GO
ALTER TABLE [dbo].[SuDungDichVu]  WITH CHECK ADD FOREIGN KEY([maDichVu])
REFERENCES [dbo].[DichVu] ([maDichVu])
GO
ALTER TABLE [dbo].[SuDungDichVu]  WITH CHECK ADD FOREIGN KEY([maPhieuThue])
REFERENCES [dbo].[PhieuThue] ([maPhieu])
GO
/****** Object:  StoredProcedure [dbo].[sp_DanhSachSuDungDV]    Script Date: 2/19/2018 5:07:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_DanhSachSuDungDV]
	@maPhieuThue  int
as
BEGIN 
BEGIN TRY 
	BEGIN TRANSACTION
		SELECT sddv.soLuong, sddv.donGia, dv.tenDichVu, sddv.maSuDung
		FROM dbo.SuDungDichVu sddv
		INNER JOIN dbo.DichVu dv ON dv.maDichVu = sddv.maDichVu
		WHERE maPhieuThue = @maPhieuThue
	COMMIT
END TRY
BEGIN CATCH
RETURN NULL
END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[sp_DoiTrangThaiPhong]    Script Date: 2/19/2018 5:07:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[sp_DoiTrangThaiPhong]
	@maPhong INT,
	@trangThai TINYINT
as
BEGIN 
BEGIN TRY 
	BEGIN TRANSACTION
		UPDATE dbo.Phong SET trangThai = @trangThai WHERE maPhong = @maPhong
	COMMIT
END TRY
BEGIN CATCH
RETURN NULL
END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[sp_GiamDichVuSuDung]    Script Date: 2/19/2018 5:07:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[sp_GiamDichVuSuDung]
	@masuDung int
as
BEGIN 
BEGIN TRY 
	BEGIN TRANSACTION
		UPDATE dbo.SuDungDichVu SET soLuong = soLuong - 1 WHERE @masuDung = SuDungDichVu.maSuDung
	COMMIT
END TRY
BEGIN CATCH
RETURN NULL
END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[sp_LayDanhSachCaiDat]    Script Date: 2/19/2018 5:07:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_LayDanhSachCaiDat]
as
BEGIN 
BEGIN TRY 
	BEGIN TRANSACTION
		SELECT * FROM dbo.Setting st 
	COMMIT
END TRY
BEGIN CATCH
RETURN NULL
END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[sp_LayDanhSachDichVu]    Script Date: 2/19/2018 5:07:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[sp_LayDanhSachDichVu]
as
BEGIN 
BEGIN TRY 
	BEGIN TRANSACTION
		SELECT maDichVu, tenDichVu, donGia
		FROM dbo.DichVu
		WHERE Active = 1
	COMMIT
END TRY
BEGIN CATCH
RETURN NULL
END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[sp_LayDanhSachHinhThuc]    Script Date: 2/19/2018 5:07:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_LayDanhSachHinhThuc]
as
BEGIN 
BEGIN TRY 
	BEGIN TRANSACTION
		SELECT * FROM dbo.HinhThuc
	COMMIT
END TRY
BEGIN CATCH
RETURN NULL
END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[sp_LayDanhSachPhong]    Script Date: 2/19/2018 5:07:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sp_LayDanhSachPhong]
as
BEGIN 
BEGIN TRY 
	BEGIN TRANSACTION
		SELECT p.maPhong, p.soPhong, p.trangThai, p.maLoaiPhong, lp.tenLoaiPhong
		FROM dbo.Phong p INNER JOIN dbo.LoaiPhong lp ON lp.maLoaiPhong = p.maLoaiPhong
		WHERE p.Active = 1 AND lp.Active = 1
	COMMIT
END TRY
BEGIN CATCH
RETURN NULL
END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[sp_LayDonGia]    Script Date: 2/19/2018 5:07:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_LayDonGia]
	@maHinhThuc INT,
	@maLoaiPhong INT
as
BEGIN 
BEGIN TRY 
	BEGIN TRANSACTION
		SELECT dg.donGia, dg.keTiep, dg.tienQuaGio FROM dbo.DonGia dg WHERE dg.maLoaiPhong = @maLoaiPhong AND dg.maHinhThuc = @maHinhThuc
	COMMIT
END TRY
BEGIN CATCH
RETURN NULL
END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[sp_LayLoaiPhongCuaPhong]    Script Date: 2/19/2018 5:07:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[sp_LayLoaiPhongCuaPhong]
	@maPhong INT
as
BEGIN 
BEGIN TRY 
	BEGIN TRANSACTION
		SELECT maLoaiPhong
		FROM dbo.Phong
		WHERE Active = 1 AND maPhong = @maPhong
	COMMIT
END TRY
BEGIN CATCH
RETURN NULL
END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[sp_LayThoiGianThem]    Script Date: 2/19/2018 5:07:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_LayThoiGianThem]
as
BEGIN 
BEGIN TRY 
	BEGIN TRANSACTION
		SELECT st.valueSetting FROM dbo.Setting st WHERE st.KeySetting = 'thoiGianThem'
	COMMIT
END TRY
BEGIN CATCH
RETURN NULL
END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[sp_LayThongTinPhieuThue]    Script Date: 2/19/2018 5:07:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_LayThongTinPhieuThue]
    @maPhong     int
AS
begin 
    BEGIN TRANSACTION
		BEGIN TRY 
			SELECT pt.maPhieu,pt.gioVao, pt.donGia,pt.keTiep, pt.maHinhThuc,ht.tenHinhThuc,pt.maKhachHang,kh.tenKhachHang,pt.tienQuaGio
			FROM dbo.PhieuThue pt 
				INNER JOIN dbo.KhachHang kh ON kh.maKH = pt.maKhachHang
				INNER JOIN dbo.HinhThuc ht ON ht.maHinhThuc = pt.maHinhThuc
			 WHERE pt.maPhong = @maPhong AND gioTra is NULL
		END TRY
		BEGIN CATCH
			RETURN NULL
		END CATCH
	COMMIT TRANSACTION
end
GO
/****** Object:  StoredProcedure [dbo].[sp_ThemDichVuSuDung]    Script Date: 2/19/2018 5:07:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[sp_ThemDichVuSuDung]
	@maDichVu INT,
    @maPhieuThue int
as
BEGIN 
BEGIN TRY 
	BEGIN TRANSACTION
	DECLARE @maSuDung INT
		IF EXISTS(SELECT * FROM dbo.SuDungDichVu WHERE maDichVu = @maDichVu AND maPhieuThue = @maPhieuThue)
			BEGIN
				SET @maSuDung = (SELECT maSuDung FROM dbo.SuDungDichVu WHERE maDichVu = @maDichVu AND maPhieuThue = @maPhieuThue)
				UPDATE dbo.SuDungDichVu SET soLuong += 1 WHERE maSuDung = @maSuDung
			END
        ELSE
			BEGIN
				DECLARE @donGia FLOAT 
				SELECT @donGia = donGia FROM dbo.DichVu WHERE maDichVu = @maDichVu
				INSERT INTO dbo.SuDungDichVu
				(
				    maDichVu,
				    maPhieuThue,
				    soLuong,
				    donGia
				)
				VALUES
				(   @maDichVu,  -- maDichVu - int
				    @maPhieuThue,  -- maPhieuThue - int
				    1,  -- soLuong - int
				    @donGia -- donGia - float
				    )
			END
	COMMIT
END TRY
BEGIN CATCH
RETURN NULL
END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[sp_TimKhachHangByCMND]    Script Date: 2/19/2018 5:07:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_TimKhachHangByCMND]
	@soCMND varchar(12)
as
BEGIN 
BEGIN TRY 
	BEGIN TRANSACTION
		SELECT * FROM dbo.KhachHang WHERE soCMND = @soCMND
	COMMIT
END TRY
BEGIN CATCH
RETURN NULL
END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[sp_XoaSuDungDichVu]    Script Date: 2/19/2018 5:07:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[sp_XoaSuDungDichVu]
	@masuDung int
as
BEGIN 
BEGIN TRY 
	BEGIN TRANSACTION
		DELETE dbo.SuDungDichVu WHERE @masuDung = masuDung
	COMMIT
END TRY
BEGIN CATCH
RETURN NULL
END CATCH
END
GO

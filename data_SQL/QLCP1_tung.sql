USE [master]
GO
/****** Object:  Database [QuanLiCaPhe]    Script Date: 5/31/2019 11:31:57 PM ******/
CREATE DATABASE [QuanLiCaPhe]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLiCaPhe', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\QuanLiCaPhe.mdf' , SIZE = 3136KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QuanLiCaPhe_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\QuanLiCaPhe_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QuanLiCaPhe] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLiCaPhe].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLiCaPhe] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLiCaPhe] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLiCaPhe] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLiCaPhe] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLiCaPhe] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLiCaPhe] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QuanLiCaPhe] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLiCaPhe] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLiCaPhe] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLiCaPhe] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLiCaPhe] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLiCaPhe] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLiCaPhe] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLiCaPhe] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLiCaPhe] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLiCaPhe] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QuanLiCaPhe] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLiCaPhe] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLiCaPhe] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLiCaPhe] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLiCaPhe] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLiCaPhe] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLiCaPhe] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLiCaPhe] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLiCaPhe] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLiCaPhe] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLiCaPhe] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLiCaPhe] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLiCaPhe] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [QuanLiCaPhe]
GO
/****** Object:  Table [dbo].[LoaiMon]    Script Date: 5/31/2019 11:31:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiMon](
	[MaLoaiMon] [nvarchar](50) NOT NULL,
	[TenLoaiMon] [nvarchar](50) NULL,
 CONSTRAINT [PK_LoaiMon] PRIMARY KEY CLUSTERED 
(
	[MaLoaiMon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblBan]    Script Date: 5/31/2019 11:31:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblBan](
	[MaBan] [varchar](3) NOT NULL,
	[SoBan] [int] NOT NULL,
	[Khu] [nvarchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblBanCoKhach]    Script Date: 5/31/2019 11:31:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblBanCoKhach](
	[MaBan] [varchar](3) NULL,
	[SoBan] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblBangLuong]    Script Date: 5/31/2019 11:31:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblBangLuong](
	[STT] [int] IDENTITY(1,1) NOT NULL,
	[Thang] [int] NOT NULL,
	[MaNV] [varchar](5) NOT NULL,
	[TenNV] [nvarchar](50) NOT NULL,
	[TongGioLam] [float] NOT NULL,
	[MucLuong] [money] NOT NULL,
	[TienLuong] [money] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[STT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblBanSDNhieu]    Script Date: 5/31/2019 11:31:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblBanSDNhieu](
	[MaBan] [varchar](3) NULL,
	[SoBan] [int] NOT NULL,
	[LuotSD] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblChamCongNV]    Script Date: 5/31/2019 11:31:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblChamCongNV](
	[MaNV] [varchar](5) NOT NULL,
	[TenNV] [nvarchar](50) NOT NULL,
	[CaLam] [nvarchar](30) NOT NULL,
	[Ngay] [datetime] NOT NULL,
	[SoGioLam] [float] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblCTDoanhThu]    Script Date: 5/31/2019 11:31:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblCTDoanhThu](
	[Ngay] [datetime] NOT NULL,
	[MaMon] [varchar](5) NOT NULL,
	[SoLuongBan] [int] NOT NULL,
	[TongTien] [money] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblCTHoaDon]    Script Date: 5/31/2019 11:31:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblCTHoaDon](
	[MaHD] [int] NOT NULL,
	[MaMon] [varchar](5) NOT NULL,
	[TenMon] [nvarchar](50) NOT NULL,
	[SoLuong] [int] NOT NULL,
	[DonGia] [money] NOT NULL,
	[ThanhTien] [money] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblCTNhapNL]    Script Date: 5/31/2019 11:31:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblCTNhapNL](
	[MaPhieuNhap] [int] NOT NULL,
	[MaNL] [varchar](5) NOT NULL,
	[TenNL] [nvarchar](50) NOT NULL,
	[SoLuong] [int] NOT NULL,
	[DonViTinh] [nvarchar](50) NULL,
	[DonGia] [money] NOT NULL,
	[ThanhTien] [money] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblCTOder]    Script Date: 5/31/2019 11:31:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblCTOder](
	[MaOder] [int] NULL,
	[MaBan] [varchar](3) NOT NULL,
	[MaMon] [varchar](5) NOT NULL,
	[SoLuong] [int] NOT NULL,
	[DonViTinh] [nvarchar](30) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblCTXuatNL]    Script Date: 5/31/2019 11:31:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblCTXuatNL](
	[MaPhieuXuat] [int] NOT NULL,
	[MaNL] [varchar](5) NOT NULL,
	[TenNL] [nvarchar](50) NOT NULL,
	[SoLuong] [int] NOT NULL,
	[DonViTinh] [nvarchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblDoanhThu]    Script Date: 5/31/2019 11:31:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDoanhThu](
	[Ngay] [datetime] NOT NULL,
	[DoanhThu] [money] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Ngay] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblDSMon]    Script Date: 5/31/2019 11:31:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblDSMon](
	[MaMon] [varchar](5) NOT NULL,
	[TenMon] [nvarchar](50) NOT NULL,
	[Nhom] [nvarchar](50) NOT NULL,
	[DonGia] [money] NOT NULL,
	[DonViTinh] [nvarchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaMon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblHoaDon]    Script Date: 5/31/2019 11:31:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblHoaDon](
	[MaHD] [int] IDENTITY(1,1) NOT NULL,
	[MaOder] [int] NOT NULL,
	[MaBan] [varchar](3) NOT NULL,
	[Ngay] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblLoaiMon]    Script Date: 5/31/2019 11:31:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblLoaiMon](
	[MaLoaiMon] [nvarchar](50) NOT NULL,
	[TenLoaiMon] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLoaiMon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblNguyenLieu]    Script Date: 5/31/2019 11:31:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblNguyenLieu](
	[MaNL] [varchar](5) NOT NULL,
	[TenNL] [nvarchar](50) NOT NULL,
	[DonGia] [money] NOT NULL,
	[DonViTinh] [nvarchar](50) NOT NULL,
	[SoLuongCon] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblNhanVien]    Script Date: 5/31/2019 11:31:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblNhanVien](
	[MaNV] [varchar](5) NOT NULL,
	[TenNV] [nvarchar](50) NOT NULL,
	[NgaySinh] [datetime] NOT NULL,
	[GioiTinh] [nvarchar](30) NOT NULL,
	[TrinhDoHocVan] [nvarchar](30) NULL,
	[ChucVu] [nvarchar](30) NOT NULL,
	[SoCMND] [char](11) NOT NULL,
	[DiaChi] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblNhapNL]    Script Date: 5/31/2019 11:31:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblNhapNL](
	[MaPhieuNhap] [int] NOT NULL,
	[NgayNhap] [datetime] NOT NULL,
	[TongTien] [money] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhieuNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblOder]    Script Date: 5/31/2019 11:31:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblOder](
	[MaOder] [int] NOT NULL,
	[MaBan] [varchar](3) NOT NULL,
	[MaNV] [varchar](5) NOT NULL,
	[Ngay] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaOder] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblUser]    Script Date: 5/31/2019 11:31:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblUser](
	[MaUser] [varchar](5) NOT NULL,
	[PassWord] [varchar](10) NOT NULL,
	[TenThuNgan] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblXuatNL]    Script Date: 5/31/2019 11:31:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblXuatNL](
	[MaPhieuXuat] [int] NOT NULL,
	[NgayXuat] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhieuXuat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[tblBan] ([MaBan], [SoBan], [Khu]) VALUES (N'B1', 1, N'A')
INSERT [dbo].[tblBan] ([MaBan], [SoBan], [Khu]) VALUES (N'B2', 2, N'A')
INSERT [dbo].[tblBan] ([MaBan], [SoBan], [Khu]) VALUES (N'B3', 3, N'A')
INSERT [dbo].[tblBan] ([MaBan], [SoBan], [Khu]) VALUES (N'B4', 4, N'A')
INSERT [dbo].[tblBan] ([MaBan], [SoBan], [Khu]) VALUES (N'B5', 5, N'A')
INSERT [dbo].[tblBan] ([MaBan], [SoBan], [Khu]) VALUES (N'B6', 6, N'A')
INSERT [dbo].[tblBanCoKhach] ([MaBan], [SoBan]) VALUES (N'B2', 2)
SET IDENTITY_INSERT [dbo].[tblBangLuong] ON 

INSERT [dbo].[tblBangLuong] ([STT], [Thang], [MaNV], [TenNV], [TongGioLam], [MucLuong], [TienLuong]) VALUES (1, 23, N'NV1', N'Lê Hải Sơn', 41, 12000.0000, 492000.0000)
SET IDENTITY_INSERT [dbo].[tblBangLuong] OFF
INSERT [dbo].[tblBanSDNhieu] ([MaBan], [SoBan], [LuotSD]) VALUES (N'B1', 1, 6)
INSERT [dbo].[tblBanSDNhieu] ([MaBan], [SoBan], [LuotSD]) VALUES (N'B2', 2, 1)
INSERT [dbo].[tblChamCongNV] ([MaNV], [TenNV], [CaLam], [Ngay], [SoGioLam]) VALUES (N'NV1', N'Lê Hải Sơn', N'Ca Sáng', CAST(0x0000AA5600000000 AS DateTime), 8)
INSERT [dbo].[tblChamCongNV] ([MaNV], [TenNV], [CaLam], [Ngay], [SoGioLam]) VALUES (N'NV1', N'Lê Hải Sơn', N'Ca Sáng', CAST(0x0000AA5500000000 AS DateTime), 8)
INSERT [dbo].[tblChamCongNV] ([MaNV], [TenNV], [CaLam], [Ngay], [SoGioLam]) VALUES (N'NV1', N'Lê Hải Sơn', N'Ca Sáng', CAST(0x0000AA5400000000 AS DateTime), 8)
INSERT [dbo].[tblChamCongNV] ([MaNV], [TenNV], [CaLam], [Ngay], [SoGioLam]) VALUES (N'NV1', N'Lê Hải Sơn', N'Ca Sáng', CAST(0x0000AA5300000000 AS DateTime), 8)
INSERT [dbo].[tblCTOder] ([MaOder], [MaBan], [MaMon], [SoLuong], [DonViTinh]) VALUES (4, N'B2', N'CF001', 3, N'')
INSERT [dbo].[tblDoanhThu] ([Ngay], [DoanhThu]) VALUES (CAST(0x0000AA5B00000000 AS DateTime), 0.0000)
INSERT [dbo].[tblDoanhThu] ([Ngay], [DoanhThu]) VALUES (CAST(0x0000AA5E00000000 AS DateTime), 0.0000)
INSERT [dbo].[tblDSMon] ([MaMon], [TenMon], [Nhom], [DonGia], [DonViTinh]) VALUES (N'M001', N'Cà phê', N'Cà phê', 20000.0000, N'Cốc')
SET IDENTITY_INSERT [dbo].[tblHoaDon] ON 

INSERT [dbo].[tblHoaDon] ([MaHD], [MaOder], [MaBan], [Ngay]) VALUES (1, 1, N'B1', CAST(0x0000AA5B00000000 AS DateTime))
INSERT [dbo].[tblHoaDon] ([MaHD], [MaOder], [MaBan], [Ngay]) VALUES (2, 2, N'B1', CAST(0x0000AA5B00000000 AS DateTime))
INSERT [dbo].[tblHoaDon] ([MaHD], [MaOder], [MaBan], [Ngay]) VALUES (8, 3, N'B1', CAST(0x0000AA5B00000000 AS DateTime))
INSERT [dbo].[tblHoaDon] ([MaHD], [MaOder], [MaBan], [Ngay]) VALUES (9, 3, N'B1', CAST(0x0000AA5B00000000 AS DateTime))
INSERT [dbo].[tblHoaDon] ([MaHD], [MaOder], [MaBan], [Ngay]) VALUES (13, 4, N'B2', CAST(0x0000AA5E00000000 AS DateTime))
SET IDENTITY_INSERT [dbo].[tblHoaDon] OFF
INSERT [dbo].[tblNhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [TrinhDoHocVan], [ChucVu], [SoCMND], [DiaChi]) VALUES (N'NV1', N'Lê Hải Sơn', CAST(0x00008C8400000000 AS DateTime), N'Nam', N'Đại Học', N'Quản Lý', N'013492957  ', N'Hà Nội')
INSERT [dbo].[tblNhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [TrinhDoHocVan], [ChucVu], [SoCMND], [DiaChi]) VALUES (N'NV2', N'Đinh Xuân Dũng', CAST(0x00008C6D00000000 AS DateTime), N'Nam', N'Đại học', N'Pha Chế', N'012343544  ', N'Quảng Ninh')
INSERT [dbo].[tblNhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [TrinhDoHocVan], [ChucVu], [SoCMND], [DiaChi]) VALUES (N'NV3', N'Phạm Văn Tùng', CAST(0x00008C9600000000 AS DateTime), N'Nam', N'Cấp 3', N'Giữ Xe', N'013492945  ', N'Nam Định')
INSERT [dbo].[tblNhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [TrinhDoHocVan], [ChucVu], [SoCMND], [DiaChi]) VALUES (N'NV4', N'Trần Văn Vận', CAST(0x00008C7200000000 AS DateTime), N'Nam', N'Tiểu Học', N'Tạp Vụ', N'024857463  ', N'Cà Mau')
INSERT [dbo].[tblNhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [TrinhDoHocVan], [ChucVu], [SoCMND], [DiaChi]) VALUES (N'NV5', N'Luci', CAST(0x00008F7700000000 AS DateTime), N'Nữ', N'Cao Đẳng', N'Thu Ngân', N'014536287  ', N'Hà Đông')
INSERT [dbo].[tblNhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [TrinhDoHocVan], [ChucVu], [SoCMND], [DiaChi]) VALUES (N'NV6', N'Lâm Bảo Ngọc', CAST(0x00005BFE00000000 AS DateTime), N'Nữ', N'Tiến sí', N'Quản Lý', N'013454643  ', N'Hà Nội')
INSERT [dbo].[tblNhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [TrinhDoHocVan], [ChucVu], [SoCMND], [DiaChi]) VALUES (N'NV7', N'Trần Bình Trọng', CAST(0x00008D1B00000000 AS DateTime), N'Nam', N'Đại học', N'Pha Chế', N'014325444  ', N'Hà Nam')
INSERT [dbo].[tblNhapNL] ([MaPhieuNhap], [NgayNhap], [TongTien]) VALUES (0, CAST(0x0000AA5600000000 AS DateTime), 0.0000)
INSERT [dbo].[tblOder] ([MaOder], [MaBan], [MaNV], [Ngay]) VALUES (1, N'B1', N'NV1', CAST(0x0000AA5B00000000 AS DateTime))
INSERT [dbo].[tblOder] ([MaOder], [MaBan], [MaNV], [Ngay]) VALUES (2, N'B1', N'NV1', CAST(0x0000AA5B00000000 AS DateTime))
INSERT [dbo].[tblOder] ([MaOder], [MaBan], [MaNV], [Ngay]) VALUES (3, N'B1', N'NV1', CAST(0x0000AA5B00000000 AS DateTime))
INSERT [dbo].[tblOder] ([MaOder], [MaBan], [MaNV], [Ngay]) VALUES (4, N'B2', N'NV1', CAST(0x0000AA5E00000000 AS DateTime))
INSERT [dbo].[tblUser] ([MaUser], [PassWord], [TenThuNgan]) VALUES (N'Admin', N'1', N'Hải Sơn')
INSERT [dbo].[tblUser] ([MaUser], [PassWord], [TenThuNgan]) VALUES (N'tungg', N'1234', N'Minh Tùng')
ALTER TABLE [dbo].[tblBanCoKhach]  WITH CHECK ADD FOREIGN KEY([MaBan])
REFERENCES [dbo].[tblBan] ([MaBan])
GO
ALTER TABLE [dbo].[tblBangLuong]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[tblNhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[tblBanSDNhieu]  WITH CHECK ADD FOREIGN KEY([MaBan])
REFERENCES [dbo].[tblBan] ([MaBan])
GO
ALTER TABLE [dbo].[tblChamCongNV]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[tblNhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[tblCTDoanhThu]  WITH CHECK ADD FOREIGN KEY([MaMon])
REFERENCES [dbo].[tblDSMon] ([MaMon])
GO
ALTER TABLE [dbo].[tblCTDoanhThu]  WITH CHECK ADD FOREIGN KEY([Ngay])
REFERENCES [dbo].[tblDoanhThu] ([Ngay])
GO
ALTER TABLE [dbo].[tblCTHoaDon]  WITH CHECK ADD FOREIGN KEY([MaMon])
REFERENCES [dbo].[tblDSMon] ([MaMon])
GO
ALTER TABLE [dbo].[tblCTNhapNL]  WITH CHECK ADD FOREIGN KEY([MaPhieuNhap])
REFERENCES [dbo].[tblNhapNL] ([MaPhieuNhap])
GO
ALTER TABLE [dbo].[tblCTNhapNL]  WITH CHECK ADD FOREIGN KEY([MaNL])
REFERENCES [dbo].[tblNguyenLieu] ([MaNL])
GO
ALTER TABLE [dbo].[tblCTOder]  WITH CHECK ADD FOREIGN KEY([MaBan])
REFERENCES [dbo].[tblBan] ([MaBan])
GO
ALTER TABLE [dbo].[tblCTOder]  WITH CHECK ADD FOREIGN KEY([MaOder])
REFERENCES [dbo].[tblOder] ([MaOder])
GO
ALTER TABLE [dbo].[tblCTXuatNL]  WITH CHECK ADD FOREIGN KEY([MaPhieuXuat])
REFERENCES [dbo].[tblXuatNL] ([MaPhieuXuat])
GO
ALTER TABLE [dbo].[tblCTXuatNL]  WITH CHECK ADD FOREIGN KEY([MaNL])
REFERENCES [dbo].[tblNguyenLieu] ([MaNL])
GO
ALTER TABLE [dbo].[tblHoaDon]  WITH CHECK ADD FOREIGN KEY([MaBan])
REFERENCES [dbo].[tblBan] ([MaBan])
GO
ALTER TABLE [dbo].[tblOder]  WITH CHECK ADD FOREIGN KEY([MaBan])
REFERENCES [dbo].[tblBan] ([MaBan])
GO
ALTER TABLE [dbo].[tblOder]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[tblNhanVien] ([MaNV])
GO
USE [master]
GO
ALTER DATABASE [QuanLiCaPhe] SET  READ_WRITE 
GO

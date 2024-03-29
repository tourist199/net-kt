USE [master]
GO
/****** Object:  Database [QLSV]    Script Date: 12/1/2019 1:10:41 AM ******/
CREATE DATABASE [QLSV]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLSV', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\QLSV.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QLSV_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\QLSV_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QLSV] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLSV].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLSV] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLSV] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLSV] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLSV] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLSV] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLSV] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLSV] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLSV] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLSV] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLSV] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLSV] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLSV] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLSV] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLSV] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLSV] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLSV] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLSV] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLSV] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLSV] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLSV] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLSV] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLSV] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLSV] SET RECOVERY FULL 
GO
ALTER DATABASE [QLSV] SET  MULTI_USER 
GO
ALTER DATABASE [QLSV] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLSV] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLSV] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLSV] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QLSV] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'QLSV', N'ON'
GO
USE [QLSV]
GO
/****** Object:  Table [dbo].[CNTT]    Script Date: 12/1/2019 1:10:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CNTT](
	[id_sv] [int] NULL,
	[pascal] [float] NULL,
	[csharp] [float] NULL,
	[sql] [float] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DiemVan]    Script Date: 12/1/2019 1:10:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DiemVan](
	[id_sv] [int] NOT NULL,
	[vanhoccd] [float] NULL,
	[vanhochd] [float] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SinhVien]    Script Date: 12/1/2019 1:10:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SinhVien](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[hoten] [nvarchar](50) NULL,
	[ngaysinh] [date] NULL,
	[gioitinh] [bit] NULL,
	[khoa] [nvarchar](50) NULL,
 CONSTRAINT [PK_SinhVien] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[VatLy]    Script Date: 12/1/2019 1:10:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VatLy](
	[id_sv] [int] NOT NULL,
	[cohoc] [float] NULL,
	[quanghoc] [float] NULL,
	[dien] [float] NULL,
	[vlhatnhat] [float] NULL
) ON [PRIMARY]

GO
INSERT [dbo].[CNTT] ([id_sv], [pascal], [csharp], [sql]) VALUES (11, 2, 3, 2)
INSERT [dbo].[CNTT] ([id_sv], [pascal], [csharp], [sql]) VALUES (12, 5, 6, 7)
INSERT [dbo].[DiemVan] ([id_sv], [vanhoccd], [vanhochd]) VALUES (2, 5, 9)
INSERT [dbo].[DiemVan] ([id_sv], [vanhoccd], [vanhochd]) VALUES (6, 9, 10)
SET IDENTITY_INSERT [dbo].[SinhVien] ON 

INSERT [dbo].[SinhVien] ([id], [hoten], [ngaysinh], [gioitinh], [khoa]) VALUES (1, N'khanh', CAST(N'1997-10-13' AS Date), 1, N'vatly')
INSERT [dbo].[SinhVien] ([id], [hoten], [ngaysinh], [gioitinh], [khoa]) VALUES (2, N'hoang', CAST(N'1997-10-14' AS Date), 0, N'van')
INSERT [dbo].[SinhVien] ([id], [hoten], [ngaysinh], [gioitinh], [khoa]) VALUES (3, N'hoang1', CAST(N'1997-10-14' AS Date), 0, N'van')
INSERT [dbo].[SinhVien] ([id], [hoten], [ngaysinh], [gioitinh], [khoa]) VALUES (4, N'hoang1', CAST(N'1997-10-14' AS Date), 0, N'van')
INSERT [dbo].[SinhVien] ([id], [hoten], [ngaysinh], [gioitinh], [khoa]) VALUES (5, N'hoang3', CAST(N'1997-10-14' AS Date), 0, N'van')
INSERT [dbo].[SinhVien] ([id], [hoten], [ngaysinh], [gioitinh], [khoa]) VALUES (6, N'hoang11', CAST(N'1997-10-10' AS Date), 1, N'van')
INSERT [dbo].[SinhVien] ([id], [hoten], [ngaysinh], [gioitinh], [khoa]) VALUES (7, N'vcas', CAST(N'2019-12-01' AS Date), 0, N'van')
INSERT [dbo].[SinhVien] ([id], [hoten], [ngaysinh], [gioitinh], [khoa]) VALUES (8, N'popp', CAST(N'2019-12-01' AS Date), 1, N'van')
INSERT [dbo].[SinhVien] ([id], [hoten], [ngaysinh], [gioitinh], [khoa]) VALUES (10, N'khanh2', CAST(N'2019-12-03' AS Date), 0, N'vatly')
INSERT [dbo].[SinhVien] ([id], [hoten], [ngaysinh], [gioitinh], [khoa]) VALUES (11, N'khanh4', CAST(N'2019-12-01' AS Date), 1, N'cntt')
INSERT [dbo].[SinhVien] ([id], [hoten], [ngaysinh], [gioitinh], [khoa]) VALUES (12, N'khanh5', CAST(N'2019-12-01' AS Date), 1, N'cntt')
SET IDENTITY_INSERT [dbo].[SinhVien] OFF
INSERT [dbo].[VatLy] ([id_sv], [cohoc], [quanghoc], [dien], [vlhatnhat]) VALUES (1, 5, 6, 7, 8)
INSERT [dbo].[VatLy] ([id_sv], [cohoc], [quanghoc], [dien], [vlhatnhat]) VALUES (10, 1.3999999761581421, 3, 5, 9)
ALTER TABLE [dbo].[CNTT]  WITH CHECK ADD  CONSTRAINT [FK_CNTT_SinhVien] FOREIGN KEY([id_sv])
REFERENCES [dbo].[SinhVien] ([id])
GO
ALTER TABLE [dbo].[CNTT] CHECK CONSTRAINT [FK_CNTT_SinhVien]
GO
ALTER TABLE [dbo].[DiemVan]  WITH CHECK ADD  CONSTRAINT [FK_DiemVan_SinhVien] FOREIGN KEY([id_sv])
REFERENCES [dbo].[SinhVien] ([id])
GO
ALTER TABLE [dbo].[DiemVan] CHECK CONSTRAINT [FK_DiemVan_SinhVien]
GO
ALTER TABLE [dbo].[VatLy]  WITH CHECK ADD  CONSTRAINT [FK_VatLy_SinhVien] FOREIGN KEY([id_sv])
REFERENCES [dbo].[SinhVien] ([id])
GO
ALTER TABLE [dbo].[VatLy] CHECK CONSTRAINT [FK_VatLy_SinhVien]
GO
USE [master]
GO
ALTER DATABASE [QLSV] SET  READ_WRITE 
GO

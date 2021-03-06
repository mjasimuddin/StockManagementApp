USE [master]
GO
/****** Object:  Database [StockManagementSystemApp]    Script Date: 5/19/2018 7:36:09 PM ******/
CREATE DATABASE [StockManagementSystemApp]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'StockManagementSystemApp', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\StockManagementSystemApp.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'StockManagementSystemApp_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\StockManagementSystemApp_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [StockManagementSystemApp] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [StockManagementSystemApp].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [StockManagementSystemApp] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [StockManagementSystemApp] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [StockManagementSystemApp] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [StockManagementSystemApp] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [StockManagementSystemApp] SET ARITHABORT OFF 
GO
ALTER DATABASE [StockManagementSystemApp] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [StockManagementSystemApp] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [StockManagementSystemApp] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [StockManagementSystemApp] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [StockManagementSystemApp] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [StockManagementSystemApp] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [StockManagementSystemApp] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [StockManagementSystemApp] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [StockManagementSystemApp] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [StockManagementSystemApp] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [StockManagementSystemApp] SET  DISABLE_BROKER 
GO
ALTER DATABASE [StockManagementSystemApp] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [StockManagementSystemApp] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [StockManagementSystemApp] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [StockManagementSystemApp] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [StockManagementSystemApp] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [StockManagementSystemApp] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [StockManagementSystemApp] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [StockManagementSystemApp] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [StockManagementSystemApp] SET  MULTI_USER 
GO
ALTER DATABASE [StockManagementSystemApp] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [StockManagementSystemApp] SET DB_CHAINING OFF 
GO
ALTER DATABASE [StockManagementSystemApp] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [StockManagementSystemApp] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [StockManagementSystemApp]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 5/19/2018 7:36:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](50) NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Company]    Script Date: 5/19/2018 7:36:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Company](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CompanyName] [nvarchar](50) NULL,
 CONSTRAINT [PK_Company] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Items]    Script Date: 5/19/2018 7:36:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Items](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CategoryId] [int] NULL,
	[CompanyId] [int] NULL,
	[ItemName] [nvarchar](50) NULL,
	[ReorderLevel] [int] NULL,
 CONSTRAINT [PK_Items] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Login]    Script Date: 5/19/2018 7:36:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[UserName] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[StockIn]    Script Date: 5/19/2018 7:36:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StockIn](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ItemId] [int] NULL,
	[AvailableQuantity] [int] NULL,
	[StokInQuantity] [int] NULL,
 CONSTRAINT [PK_StockIn] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[StockOut]    Script Date: 5/19/2018 7:36:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[StockOut](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ItemId] [int] NULL,
	[Quantity] [int] NULL,
	[Type] [varchar](1) NOT NULL,
 CONSTRAINT [PK_StokOut] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[ItemWithCompany]    Script Date: 5/19/2018 7:36:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[ItemWithCompany]
as
SELECT c.Id AS CompanyId,c.CompanyName,i.Id,i.ItemName,i.ReorderLevel FROM Items AS i
INNER JOIN Company AS c ON i.CompanyId=c.Id




GO
/****** Object:  View [dbo].[StockOutWithItems]    Script Date: 5/19/2018 7:36:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE VIEW [dbo].[StockOutWithItems]
as
SELECT c.Id AS CompanyId,si.StokInQuantity AS StockIn,c.CompanyName,i.Id,i.ItemName,i.ReorderLevel,so.Quantity,so.ItemId AS ItemId FROM Items AS i
INNER JOIN Company AS c ON i.CompanyId=c.Id
INNER JOIN StockIn AS si ON si.ItemId=i.Id
INNER JOIN StockOut AS so ON so.ItemId=i.Id



GO
/****** Object:  View [dbo].[ViewItemSummary]    Script Date: 5/19/2018 7:36:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[ViewItemSummary]
as
SELECT i.ItemName,com.CompanyName, ctg.CategoryName,i.ReorderLevel,si.AvailableQuantity FROM Items AS i
INNER JOIN Company AS com ON i.CompanyId=com.Id
INNER JOIN StockIn AS si ON si.ItemId=i.Id
INNER JOIN StockOut AS so ON so.ItemId=i.Id
INNER JOIN Category AS ctg ON i.CategoryId=ctg.Id
GO
/****** Object:  View [dbo].[ViewSalesReport]    Script Date: 5/19/2018 7:36:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE VIEW [dbo].[ViewSalesReport]
as
SELECT i.Id,i.ItemName,so.Quantity,so.ItemId AS ItemId FROM Items AS i
INNER JOIN StockOut AS so ON so.ItemId=i.Id




GO
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([Id], [CategoryName]) VALUES (1, N'Stationary')
INSERT [dbo].[Category] ([Id], [CategoryName]) VALUES (2, N'Cosmetic Items')
INSERT [dbo].[Category] ([Id], [CategoryName]) VALUES (3, N'Electronics')
INSERT [dbo].[Category] ([Id], [CategoryName]) VALUES (4, N'Kitchen Item')
SET IDENTITY_INSERT [dbo].[Category] OFF
SET IDENTITY_INSERT [dbo].[Company] ON 

INSERT [dbo].[Company] ([Id], [CompanyName]) VALUES (1, N'RFL')
INSERT [dbo].[Company] ([Id], [CompanyName]) VALUES (2, N'Walton')
INSERT [dbo].[Company] ([Id], [CompanyName]) VALUES (3, N'Nova')
INSERT [dbo].[Company] ([Id], [CompanyName]) VALUES (4, N'Unilever')
INSERT [dbo].[Company] ([Id], [CompanyName]) VALUES (5, N'Bitm')
SET IDENTITY_INSERT [dbo].[Company] OFF
SET IDENTITY_INSERT [dbo].[Items] ON 

INSERT [dbo].[Items] ([Id], [CategoryId], [CompanyId], [ItemName], [ReorderLevel]) VALUES (8, 1, 1, N'Plastic', 1)
INSERT [dbo].[Items] ([Id], [CategoryId], [CompanyId], [ItemName], [ReorderLevel]) VALUES (9, 2, 2, N'LED TV', 2)
INSERT [dbo].[Items] ([Id], [CategoryId], [CompanyId], [ItemName], [ReorderLevel]) VALUES (10, 1, 1, N'Busket', 6)
INSERT [dbo].[Items] ([Id], [CategoryId], [CompanyId], [ItemName], [ReorderLevel]) VALUES (11, 2, 3, N'Nova Tv', 5)
INSERT [dbo].[Items] ([Id], [CategoryId], [CompanyId], [ItemName], [ReorderLevel]) VALUES (12, 1, 4, N'Water Jar', 4)
INSERT [dbo].[Items] ([Id], [CategoryId], [CompanyId], [ItemName], [ReorderLevel]) VALUES (13, 3, 2, N'Reprejarator', 7)
INSERT [dbo].[Items] ([Id], [CategoryId], [CompanyId], [ItemName], [ReorderLevel]) VALUES (14, 3, 2, N'Charger Fan', 8)
INSERT [dbo].[Items] ([Id], [CategoryId], [CompanyId], [ItemName], [ReorderLevel]) VALUES (15, 1, 3, N'Table Box', 4)
INSERT [dbo].[Items] ([Id], [CategoryId], [CompanyId], [ItemName], [ReorderLevel]) VALUES (16, 2, 4, N'Lax ', 5)
INSERT [dbo].[Items] ([Id], [CategoryId], [CompanyId], [ItemName], [ReorderLevel]) VALUES (17, 2, 5, N'Office Accessories', 5)
SET IDENTITY_INSERT [dbo].[Items] OFF
INSERT [dbo].[Login] ([UserName], [Password]) VALUES (N'admin', N'admin@123')
SET IDENTITY_INSERT [dbo].[StockIn] ON 

INSERT [dbo].[StockIn] ([Id], [ItemId], [AvailableQuantity], [StokInQuantity]) VALUES (11, 16, NULL, 5)
INSERT [dbo].[StockIn] ([Id], [ItemId], [AvailableQuantity], [StokInQuantity]) VALUES (12, 17, NULL, 5)
INSERT [dbo].[StockIn] ([Id], [ItemId], [AvailableQuantity], [StokInQuantity]) VALUES (13, 15, NULL, 5)
INSERT [dbo].[StockIn] ([Id], [ItemId], [AvailableQuantity], [StokInQuantity]) VALUES (14, 17, NULL, 6)
INSERT [dbo].[StockIn] ([Id], [ItemId], [AvailableQuantity], [StokInQuantity]) VALUES (15, 9, NULL, 10)
INSERT [dbo].[StockIn] ([Id], [ItemId], [AvailableQuantity], [StokInQuantity]) VALUES (16, 9, 0, 10)
INSERT [dbo].[StockIn] ([Id], [ItemId], [AvailableQuantity], [StokInQuantity]) VALUES (17, 10, 0, 10)
INSERT [dbo].[StockIn] ([Id], [ItemId], [AvailableQuantity], [StokInQuantity]) VALUES (18, 9, 0, 5)
INSERT [dbo].[StockIn] ([Id], [ItemId], [AvailableQuantity], [StokInQuantity]) VALUES (19, 9, 9, 2)
INSERT [dbo].[StockIn] ([Id], [ItemId], [AvailableQuantity], [StokInQuantity]) VALUES (20, 17, 17, 5)
SET IDENTITY_INSERT [dbo].[StockIn] OFF
SET IDENTITY_INSERT [dbo].[StockOut] ON 

INSERT [dbo].[StockOut] ([Id], [ItemId], [Quantity], [Type]) VALUES (1, 15, 2, N'S')
INSERT [dbo].[StockOut] ([Id], [ItemId], [Quantity], [Type]) VALUES (2, 17, 3, N'S')
INSERT [dbo].[StockOut] ([Id], [ItemId], [Quantity], [Type]) VALUES (3, 9, 2, N'S')
INSERT [dbo].[StockOut] ([Id], [ItemId], [Quantity], [Type]) VALUES (4, 8, 2, N'')
INSERT [dbo].[StockOut] ([Id], [ItemId], [Quantity], [Type]) VALUES (37, 9, 3, N'S')
INSERT [dbo].[StockOut] ([Id], [ItemId], [Quantity], [Type]) VALUES (38, 11, 3, N'D')
INSERT [dbo].[StockOut] ([Id], [ItemId], [Quantity], [Type]) VALUES (39, 16, 2, N'L')
INSERT [dbo].[StockOut] ([Id], [ItemId], [Quantity], [Type]) VALUES (40, 13, 3, N'S')
INSERT [dbo].[StockOut] ([Id], [ItemId], [Quantity], [Type]) VALUES (41, 13, 3, N'D')
INSERT [dbo].[StockOut] ([Id], [ItemId], [Quantity], [Type]) VALUES (42, 13, 3, N'L')
INSERT [dbo].[StockOut] ([Id], [ItemId], [Quantity], [Type]) VALUES (43, 10, 2, N'S')
INSERT [dbo].[StockOut] ([Id], [ItemId], [Quantity], [Type]) VALUES (44, 16, 2, N'S')
SET IDENTITY_INSERT [dbo].[StockOut] OFF
ALTER TABLE [dbo].[Items]  WITH CHECK ADD  CONSTRAINT [FK_Items_Category] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Category] ([Id])
GO
ALTER TABLE [dbo].[Items] CHECK CONSTRAINT [FK_Items_Category]
GO
ALTER TABLE [dbo].[Items]  WITH CHECK ADD  CONSTRAINT [FK_Items_Company] FOREIGN KEY([CompanyId])
REFERENCES [dbo].[Company] ([Id])
GO
ALTER TABLE [dbo].[Items] CHECK CONSTRAINT [FK_Items_Company]
GO
ALTER TABLE [dbo].[StockIn]  WITH CHECK ADD  CONSTRAINT [FK_StockIn_Items] FOREIGN KEY([ItemId])
REFERENCES [dbo].[Items] ([Id])
GO
ALTER TABLE [dbo].[StockIn] CHECK CONSTRAINT [FK_StockIn_Items]
GO
ALTER TABLE [dbo].[StockOut]  WITH CHECK ADD  CONSTRAINT [FK_StockOut_StockOut] FOREIGN KEY([Id])
REFERENCES [dbo].[StockOut] ([Id])
GO
ALTER TABLE [dbo].[StockOut] CHECK CONSTRAINT [FK_StockOut_StockOut]
GO
ALTER TABLE [dbo].[StockOut]  WITH CHECK ADD  CONSTRAINT [FK_StokOut_StokOut] FOREIGN KEY([ItemId])
REFERENCES [dbo].[Items] ([Id])
GO
ALTER TABLE [dbo].[StockOut] CHECK CONSTRAINT [FK_StokOut_StokOut]
GO
USE [master]
GO
ALTER DATABASE [StockManagementSystemApp] SET  READ_WRITE 
GO

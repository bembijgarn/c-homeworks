create database [Hardware]
GO

USE [Hardware]
GO

CREATE TABLE [dbo].[Manufacturers](
	[ManufacturerId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK__Manufact__A25C5AA650412E4A] PRIMARY KEY CLUSTERED 
(
	[ManufacturerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Products]    Script Date: 09/02/2018 13:56:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ProductId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Price] [real] NOT NULL,
	[ManufacturerId] [int] NOT NULL,
 CONSTRAINT [PK__Products__B40CC6CD38AD7183] PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Manufacturers] ON 

INSERT [dbo].[Manufacturers] ([ManufacturerId], [Name]) VALUES (1, N'Sony')
INSERT [dbo].[Manufacturers] ([ManufacturerId], [Name]) VALUES (2, N'Creative Labs')
INSERT [dbo].[Manufacturers] ([ManufacturerId], [Name]) VALUES (3, N'Hewlett-Packard')
INSERT [dbo].[Manufacturers] ([ManufacturerId], [Name]) VALUES (4, N'Iomega')
INSERT [dbo].[Manufacturers] ([ManufacturerId], [Name]) VALUES (5, N'Fujitsu')
INSERT [dbo].[Manufacturers] ([ManufacturerId], [Name]) VALUES (6, N'Western Digital')
INSERT [dbo].[Manufacturers] ([ManufacturerId], [Name]) VALUES (7, N'IBM')
INSERT [dbo].[Manufacturers] ([ManufacturerId], [Name]) VALUES (8, N'Genius')
INSERT [dbo].[Manufacturers] ([ManufacturerId], [Name]) VALUES (9, N'Dell')
INSERT [dbo].[Manufacturers] ([ManufacturerId], [Name]) VALUES (10, N'Intel')
INSERT [dbo].[Manufacturers] ([ManufacturerId], [Name]) VALUES (11, N'AMD')
INSERT [dbo].[Manufacturers] ([ManufacturerId], [Name]) VALUES (12, N'GIGABYTE')
INSERT [dbo].[Manufacturers] ([ManufacturerId], [Name]) VALUES (13, N'Asus')
SET IDENTITY_INSERT [dbo].[Manufacturers] OFF
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([ProductId], [Name], [Price], [ManufacturerId]) VALUES (1, N'Hard drive', 240, 5)
INSERT [dbo].[Products] ([ProductId], [Name], [Price], [ManufacturerId]) VALUES (2, N'Memory', 120, 6)
INSERT [dbo].[Products] ([ProductId], [Name], [Price], [ManufacturerId]) VALUES (3, N'SSD drive', 70, 4)
INSERT [dbo].[Products] ([ProductId], [Name], [Price], [ManufacturerId]) VALUES (4, N'Flash drive', 19, 6)
INSERT [dbo].[Products] ([ProductId], [Name], [Price], [ManufacturerId]) VALUES (5, N'Monitor', 240, 1)
INSERT [dbo].[Products] ([ProductId], [Name], [Price], [ManufacturerId]) VALUES (6, N'DVD drive', 39, 2)
INSERT [dbo].[Products] ([ProductId], [Name], [Price], [ManufacturerId]) VALUES (7, N'CD drive', 23, 2)
INSERT [dbo].[Products] ([ProductId], [Name], [Price], [ManufacturerId]) VALUES (8, N'Printer', 170, 3)
INSERT [dbo].[Products] ([ProductId], [Name], [Price], [ManufacturerId]) VALUES (9, N'Toner cartridge', 66, 3)
INSERT [dbo].[Products] ([ProductId], [Name], [Price], [ManufacturerId]) VALUES (10, N'DVD burner', 180, 2)
INSERT [dbo].[Products] ([ProductId], [Name], [Price], [ManufacturerId]) VALUES (11, N'Monitor', 310, 9)
INSERT [dbo].[Products] ([ProductId], [Name], [Price], [ManufacturerId]) VALUES (12, N'Laptop', 434, 9)
INSERT [dbo].[Products] ([ProductId], [Name], [Price], [ManufacturerId]) VALUES (13, N'Memory', 174, 9)
INSERT [dbo].[Products] ([ProductId], [Name], [Price], [ManufacturerId]) VALUES (14, N'CPU i3', 137, 10)
INSERT [dbo].[Products] ([ProductId], [Name], [Price], [ManufacturerId]) VALUES (15, N'CPU i5', 218, 10)
INSERT [dbo].[Products] ([ProductId], [Name], [Price], [ManufacturerId]) VALUES (16, N'CPU i7', 347, 10)
INSERT [dbo].[Products] ([ProductId], [Name], [Price], [ManufacturerId]) VALUES (17, N'CPU G4400', 54, 10)
INSERT [dbo].[Products] ([ProductId], [Name], [Price], [ManufacturerId]) VALUES (18, N'Motherboard', 57, 13)
INSERT [dbo].[Products] ([ProductId], [Name], [Price], [ManufacturerId]) VALUES (19, N'LaserJet Printer', 95, 3)
INSERT [dbo].[Products] ([ProductId], [Name], [Price], [ManufacturerId]) VALUES (20, N'Printer', 38, 1)
SET IDENTITY_INSERT [dbo].[Products] OFF
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [fk_Manufacturers_Code] FOREIGN KEY([ManufacturerId])
REFERENCES [dbo].[Manufacturers] ([ManufacturerId])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [fk_Manufacturers_Code]
GO

--1
Select pr.Name,pr.Price from Products pr where ManufacturerId in (Select ManufacturerId from Manufacturers where Name = 'Hewlett-Packard')
--2
Select pr.Name,pr.Price From Products pr where ManufacturerId in (Select ManufacturerId from Manufacturers where Name != 'Fujitsu')
--3
Select pr.Name,pr.Price from Products pr where ManufacturerId in (Select ManufacturerId from Manufacturers where Name in ('Sony','Fujitsu','IBM','Intel'))
--4 
Select ma.Name from Manufacturers ma where ManufacturerId in (Select ManufacturerId from Products where Price > 200)
--5
Select pr.Name From Products pr where ManufacturerId in (Select ManufacturerId from Manufacturers where name not in ('Genius','Dell'))
--6
Select ma.Name from Manufacturers ma where ManufacturerId in (Select ManufacturerId from Products where Name LIKE '%drive%')
--7
Select * from Manufacturers
Select * from Products
Select Count(ManufacturerId) as MoreThanAvgPrice from Products where ManufacturerId = 10 AND  Price >  (Select avg(Price) from Products where ManufacturerId = 10  )
SELECT COUNT(*) AS MoreThanAvgPrice
/*
FROM Products
WHERE Price > 
(SELECT AVG(Price) 
FROM Products 
WHERE ManufacturerId = 10)
AND 
ManufacturerId IN
(SELECT ManufacturerId FROM 
Manufacturers
WHERE ManufacturerId = 10)
*/

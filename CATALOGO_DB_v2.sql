/*
 Navicat Premium Data Transfer

 Source Server         : UTN
 Source Server Type    : SQL Server
 Source Server Version : 15002080
 Source Host           : CAS1\SQLEXPRESS:1433
 Source Catalog        : CATALOGO_DB
 Source Schema         : dbo

 Target Server Type    : SQL Server
 Target Server Version : 15002080
 File Encoding         : 65001

 Date: 01/05/2021 20:20:18
*/


-- ----------------------------
-- Table structure for ARTICULOS
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[ARTICULOS]') AND type IN ('U'))
	DROP TABLE [dbo].[ARTICULOS]
GO

CREATE TABLE [dbo].[ARTICULOS] (
  [Id] int  IDENTITY(1,1) NOT NULL,
  [Codigo] varchar(50) COLLATE Modern_Spanish_CI_AS  NULL,
  [Nombre] varchar(50) COLLATE Modern_Spanish_CI_AS  NULL,
  [Descripcion] varchar(150) COLLATE Modern_Spanish_CI_AS  NULL,
  [IdMarca] int  NULL,
  [IdCategoria] int  NULL,
  [ImagenUrl] varchar(1000) COLLATE Modern_Spanish_CI_AS  NULL,
  [Precio] money  NULL
)
GO

ALTER TABLE [dbo].[ARTICULOS] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of ARTICULOS
-- ----------------------------
SET IDENTITY_INSERT [dbo].[ARTICULOS] ON
GO

INSERT INTO [dbo].[ARTICULOS] ([Id], [Codigo], [Nombre], [Descripcion], [IdMarca], [IdCategoria], [ImagenUrl], [Precio]) VALUES (N'1', N'S01', N'Galaxy S10', N'Una canoa cara', N'1', N'1', N'https://images.samsung.com/is/image/samsung/co-galaxy-s10-sm-g970-sm-g970fzyjcoo-frontcanaryyellow-thumb-149016542', N'69.9990')
GO

INSERT INTO [dbo].[ARTICULOS] ([Id], [Codigo], [Nombre], [Descripcion], [IdMarca], [IdCategoria], [ImagenUrl], [Precio]) VALUES (N'2', N'M03', N'Moto G Play 7ma Gen', N'Ya siete de estos?', N'1', N'5', N'https://www.motorola.cl/arquivos/moto-g7-play-img-product.png?v=636862863804700000', N'15699.0000')
GO

INSERT INTO [dbo].[ARTICULOS] ([Id], [Codigo], [Nombre], [Descripcion], [IdMarca], [IdCategoria], [ImagenUrl], [Precio]) VALUES (N'3', N'S99', N'Play 4', N'Ya no se cuantas versiones hay', N'3', N'3', N'https://www.euronics.cz/image/product/800x800/532620.jpg', N'35000.0000')
GO

INSERT INTO [dbo].[ARTICULOS] ([Id], [Codigo], [Nombre], [Descripcion], [IdMarca], [IdCategoria], [ImagenUrl], [Precio]) VALUES (N'4', N'S56', N'Bravia 55', N'Alta tele', N'3', N'2', N'https://intercompras.com/product_thumb_keepratio_2.php?img=images/product/SONY_KDL-55W950A.jpg&w=650&h=450', N'49500.0000')
GO

INSERT INTO [dbo].[ARTICULOS] ([Id], [Codigo], [Nombre], [Descripcion], [IdMarca], [IdCategoria], [ImagenUrl], [Precio]) VALUES (N'5', N'A23', N'Apple TV', N'lindo loro', N'2', N'3', N'https://www.pngarea.com/pngs/667/4666186_apple-tablet-png-ipad-transparent-apple-png-download.png', N'7850.0000')
GO

SET IDENTITY_INSERT [dbo].[ARTICULOS] OFF
GO


-- ----------------------------
-- Table structure for CATEGORIAS
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[CATEGORIAS]') AND type IN ('U'))
	DROP TABLE [dbo].[CATEGORIAS]
GO

CREATE TABLE [dbo].[CATEGORIAS] (
  [Id] int  IDENTITY(1,1) NOT NULL,
  [Descripcion] varchar(50) COLLATE Modern_Spanish_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[CATEGORIAS] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of CATEGORIAS
-- ----------------------------
SET IDENTITY_INSERT [dbo].[CATEGORIAS] ON
GO

INSERT INTO [dbo].[CATEGORIAS] ([Id], [Descripcion]) VALUES (N'1', N'Celulares')
GO

INSERT INTO [dbo].[CATEGORIAS] ([Id], [Descripcion]) VALUES (N'2', N'Televisores')
GO

INSERT INTO [dbo].[CATEGORIAS] ([Id], [Descripcion]) VALUES (N'3', N'Media')
GO

INSERT INTO [dbo].[CATEGORIAS] ([Id], [Descripcion]) VALUES (N'4', N'Audio')
GO

INSERT INTO [dbo].[CATEGORIAS] ([Id], [Descripcion]) VALUES (N'5', N'Celulares')
GO

INSERT INTO [dbo].[CATEGORIAS] ([Id], [Descripcion]) VALUES (N'6', N'Televisores')
GO

INSERT INTO [dbo].[CATEGORIAS] ([Id], [Descripcion]) VALUES (N'7', N'Media')
GO

INSERT INTO [dbo].[CATEGORIAS] ([Id], [Descripcion]) VALUES (N'8', N'Audio')
GO

SET IDENTITY_INSERT [dbo].[CATEGORIAS] OFF
GO


-- ----------------------------
-- Table structure for MARCAS
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[MARCAS]') AND type IN ('U'))
	DROP TABLE [dbo].[MARCAS]
GO

CREATE TABLE [dbo].[MARCAS] (
  [Id] int  IDENTITY(1,1) NOT NULL,
  [Descripcion] varchar(50) COLLATE Modern_Spanish_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[MARCAS] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of MARCAS
-- ----------------------------
SET IDENTITY_INSERT [dbo].[MARCAS] ON
GO

INSERT INTO [dbo].[MARCAS] ([Id], [Descripcion]) VALUES (N'1', N'Samsung')
GO

INSERT INTO [dbo].[MARCAS] ([Id], [Descripcion]) VALUES (N'2', N'Apple')
GO

INSERT INTO [dbo].[MARCAS] ([Id], [Descripcion]) VALUES (N'3', N'Sony')
GO

INSERT INTO [dbo].[MARCAS] ([Id], [Descripcion]) VALUES (N'4', N'Huawei')
GO

INSERT INTO [dbo].[MARCAS] ([Id], [Descripcion]) VALUES (N'5', N'Motorola')
GO

INSERT INTO [dbo].[MARCAS] ([Id], [Descripcion]) VALUES (N'6', N'Samsung')
GO

INSERT INTO [dbo].[MARCAS] ([Id], [Descripcion]) VALUES (N'7', N'Apple')
GO

INSERT INTO [dbo].[MARCAS] ([Id], [Descripcion]) VALUES (N'8', N'Sony')
GO

INSERT INTO [dbo].[MARCAS] ([Id], [Descripcion]) VALUES (N'9', N'Huawei')
GO

INSERT INTO [dbo].[MARCAS] ([Id], [Descripcion]) VALUES (N'10', N'Motorola')
GO

SET IDENTITY_INSERT [dbo].[MARCAS] OFF
GO


-- ----------------------------
-- Auto increment value for ARTICULOS
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[ARTICULOS]', RESEED, 5)
GO


-- ----------------------------
-- Primary Key structure for table ARTICULOS
-- ----------------------------
ALTER TABLE [dbo].[ARTICULOS] ADD CONSTRAINT [PK_ARTICULOS] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for CATEGORIAS
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[CATEGORIAS]', RESEED, 8)
GO


-- ----------------------------
-- Primary Key structure for table CATEGORIAS
-- ----------------------------
ALTER TABLE [dbo].[CATEGORIAS] ADD CONSTRAINT [PK_CATEGORIAS] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for MARCAS
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[MARCAS]', RESEED, 10)
GO


-- ----------------------------
-- Primary Key structure for table MARCAS
-- ----------------------------
ALTER TABLE [dbo].[MARCAS] ADD CONSTRAINT [PK_MARCAS] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


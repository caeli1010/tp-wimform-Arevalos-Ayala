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

 Date: 29/04/2021 16:41:44
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

INSERT INTO [dbo].[ARTICULOS] ([Id], [Codigo], [Nombre], [Descripcion], [IdMarca], [IdCategoria], [ImagenUrl], [Precio]) VALUES (N'5', N'A23', N'Apple TV', N'lindo loro', N'2', N'3', N'https://static.wikia.nocookie.net/apple/images/2/27/Appletv.png/revision/latest?cb=20191101230040&path-prefix=es', N'7850.0000')
GO

INSERT INTO [dbo].[ARTICULOS] ([Id], [Codigo], [Nombre], [Descripcion], [IdMarca], [IdCategoria], [ImagenUrl], [Precio]) VALUES (N'6', N'TECL', N'teclado genius', N'tecaldo muy caro', N'3', N'2', N'https://intercompras.com/product_thumb_keepratio_2.php?img=images/product/SONY_KDL-55W950A.jpg&w=650&h=450', N'145.5100')
GO

INSERT INTO [dbo].[ARTICULOS] ([Id], [Codigo], [Nombre], [Descripcion], [IdMarca], [IdCategoria], [ImagenUrl], [Precio]) VALUES (N'7', N'termin', N'Termo ', N'termon de Acero inoxidable', N'2', N'1', N'https://http2.mlstatic.com/D_NQ_NP_818360-MLA45030247503_022021-O.jpg', N'.0000')
GO

INSERT INTO [dbo].[ARTICULOS] ([Id], [Codigo], [Nombre], [Descripcion], [IdMarca], [IdCategoria], [ImagenUrl], [Precio]) VALUES (N'8', N'cel', N'celular k2017', N'el peor celu de la historia', N'2', N'1', N'https://http2.mlstatic.com/D_NQ_NP_818360-MLA45030247503_022021-O.jpg', N'1515155.0000')
GO

SET IDENTITY_INSERT [dbo].[ARTICULOS] OFF
GO


-- ----------------------------
-- Table structure for ARTICULOS_copy1
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[ARTICULOS_copy1]') AND type IN ('U'))
	DROP TABLE [dbo].[ARTICULOS_copy1]
GO

CREATE TABLE [dbo].[ARTICULOS_copy1] (
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

ALTER TABLE [dbo].[ARTICULOS_copy1] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of ARTICULOS_copy1
-- ----------------------------
SET IDENTITY_INSERT [dbo].[ARTICULOS_copy1] ON
GO

INSERT INTO [dbo].[ARTICULOS_copy1] ([Id], [Codigo], [Nombre], [Descripcion], [IdMarca], [IdCategoria], [ImagenUrl], [Precio]) VALUES (N'1', N'S01', N'Galaxy S10', N'Una canoa cara', N'1', N'1', N'https://images.samsung.com/is/image/samsung/co-galaxy-s10-sm-g970-sm-g970fzyjcoo-frontcanaryyellow-thumb-149016542', N'69.9990')
GO

INSERT INTO [dbo].[ARTICULOS_copy1] ([Id], [Codigo], [Nombre], [Descripcion], [IdMarca], [IdCategoria], [ImagenUrl], [Precio]) VALUES (N'2', N'M03', N'Moto G Play 7ma Gen', N'Ya siete de estos?', N'1', N'5', N'https://www.motorola.cl/arquivos/moto-g7-play-img-product.png?v=636862863804700000', N'15699.0000')
GO

INSERT INTO [dbo].[ARTICULOS_copy1] ([Id], [Codigo], [Nombre], [Descripcion], [IdMarca], [IdCategoria], [ImagenUrl], [Precio]) VALUES (N'3', N'S99', N'Play 4', N'Ya no se cuantas versiones hay', N'3', N'3', N'https://www.euronics.cz/image/product/800x800/532620.jpg', N'35000.0000')
GO

INSERT INTO [dbo].[ARTICULOS_copy1] ([Id], [Codigo], [Nombre], [Descripcion], [IdMarca], [IdCategoria], [ImagenUrl], [Precio]) VALUES (N'4', N'S56', N'Bravia 55', N'Alta tele', N'3', N'2', N'https://intercompras.com/product_thumb_keepratio_2.php?img=images/product/SONY_KDL-55W950A.jpg&w=650&h=450', N'49500.0000')
GO

INSERT INTO [dbo].[ARTICULOS_copy1] ([Id], [Codigo], [Nombre], [Descripcion], [IdMarca], [IdCategoria], [ImagenUrl], [Precio]) VALUES (N'5', N'A23', N'Apple TV', N'lindo loro', N'2', N'3', N'https://static.wikia.nocookie.net/apple/images/2/27/Appletv.png/revision/latest?cb=20191101230040&path-prefix=es', N'7850.0000')
GO

SET IDENTITY_INSERT [dbo].[ARTICULOS_copy1] OFF
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

SET IDENTITY_INSERT [dbo].[MARCAS] OFF
GO


-- ----------------------------
-- Auto increment value for ARTICULOS
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[ARTICULOS]', RESEED, 8)
GO


-- ----------------------------
-- Primary Key structure for table ARTICULOS
-- ----------------------------
ALTER TABLE [dbo].[ARTICULOS] ADD CONSTRAINT [PK_ARTICULOS] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for ARTICULOS_copy1
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[ARTICULOS_copy1]', RESEED, 5)
GO


-- ----------------------------
-- Primary Key structure for table ARTICULOS_copy1
-- ----------------------------
ALTER TABLE [dbo].[ARTICULOS_copy1] ADD CONSTRAINT [PK_ARTICULOS_copy1] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for CATEGORIAS
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[CATEGORIAS]', RESEED, 4)
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
DBCC CHECKIDENT ('[dbo].[MARCAS]', RESEED, 5)
GO


-- ----------------------------
-- Primary Key structure for table MARCAS
-- ----------------------------
ALTER TABLE [dbo].[MARCAS] ADD CONSTRAINT [PK_MARCAS] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


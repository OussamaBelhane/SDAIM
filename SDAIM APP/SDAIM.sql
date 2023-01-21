
/****** Object:  Table [dbo].[Catégorie]    ******/
CREATE DATABASE [SDAIM]
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
USE [SDAIM]
CREATE TABLE [dbo].[Catégorie](
	[id_cat] [int] IDENTITY(1,1) NOT NULL,
	[nom_cat] [varchar](50) NULL,
	[image_cat] [image] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_cat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employés]     ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employés](
	[id_employé] [int] IDENTITY(1,1) NOT NULL,
	[Nom] [varchar](50) NULL,
	[Prénom] [varchar](50) NULL,
	[num_tel] [varchar](50) NULL,
	[CIN] [varchar](50) NULL,
	[Département] [varchar](50) NULL,
	[image_emp] [image] NULL,
	[Type] [varchar](50) NULL,
	[Salaire] [money] NULL,
	[Prix_h] [money] NULL,
	[nbr_h] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_employé] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Fournisseurs]     ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fournisseurs](
	[id_four] [int] IDENTITY(1,1) NOT NULL,
	[nom_four] [varchar](50) NULL,
	[phone_four] [varchar](50) NULL,
	[email_four] [varchar](150) NULL,
	[image_four] [image] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_four] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Project]     ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Project](
	[id_pro] [int] IDENTITY(1,1) NOT NULL,
	[pro_nom] [varchar](50) NULL,
	[pro_date] [date] NULL,
	[pro_qte] [float] NULL,
	[pro_price] [float] NULL,
	[pro_désignation] [varchar](50) NULL,
	[pro_ttc] [float] NULL,
 CONSTRAINT [PK_Project1] PRIMARY KEY CLUSTERED 
(
	[id_pro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Project_info]     ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Project_info](
	[id_proi] [int] IDENTITY(1,1) NOT NULL,
	[pro_nom] [varchar](50) NULL,
	[pro_date] [date] NULL,
	[pro_price] [float] NULL,
 CONSTRAINT [PK_Project_info] PRIMARY KEY CLUSTERED 
(
	[id_proi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Project_m]     ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Project_m](
	[id_mpro] [int] IDENTITY(1,1) NOT NULL,
	[nomp_mpro] [varchar](50) NULL,
	[nom_mpro] [varchar](50) NULL,
	[prix_mpro] [float] NULL,
	[date_mpro] [date] NULL,
 CONSTRAINT [PK_Project_m] PRIMARY KEY CLUSTERED 
(
	[id_mpro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[project_p]     ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[project_p](
	[id_ppro] [int] IDENTITY(1,1) NOT NULL,
	[nom_ppro] [varchar](50) NULL,
	[pt_ppro] [float] NULL,
	[p_ppro] [float] NULL,
	[g_ppro] [float] NULL,
	[date_ppro] [date] NULL,
 CONSTRAINT [PK_project_p] PRIMARY KEY CLUSTERED 
(
	[id_ppro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Purchase]     ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Purchase](
	[id_pur] [int] IDENTITY(1,1) NOT NULL,
	[id_cat] [int] NULL,
	[id_four] [int] NULL,
	[Désignation] [nvarchar](50) NULL,
	[Unité] [nvarchar](50) NULL,
	[Catégorie] [nvarchar](50) NULL,
	[Fournisseur] [nvarchar](50) NULL,
	[Prix.U.H.T] [float] NULL,
	[T.V.A] [float] NULL,
	[Poids] [float] NULL,
	[Quantité] [float] NULL,
	[Total.H.T] [float] NULL,
	[Total.T.V.A] [float] NULL,
	[Total.T.C] [float] NULL,
 CONSTRAINT [PK_Purchase] PRIMARY KEY CLUSTERED 
(
	[id_pur] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Salaire]     ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Salaire](
	[id_salaire] [int] IDENTITY(1,1) NOT NULL,
	[Nom] [varchar](50) NULL,
	[Prénom] [varchar](50) NULL,
	[num_tel] [varchar](50) NULL,
	[CIN] [varchar](50) NULL,
	[Département] [varchar](50) NULL,
	[image_emp] [image] NULL,
	[Type] [varchar](50) NULL,
	[Salaire] [float] NULL,
	[Prix_h] [float] NULL,
	[nbr_h] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_salaire] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[stock]     ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[stock](
	[id_sto] [int] IDENTITY(1,1) NOT NULL,
	[id_cat] [int] NULL,
	[id_four] [int] NULL,
	[Désignation] [nvarchar](50) NULL,
	[Unité] [nvarchar](50) NULL,
	[Catégorie] [nvarchar](50) NULL,
	[Fournisseur] [nvarchar](50) NULL,
	[Prix.U.H.T] [float] NULL,
	[T.V.A] [float] NULL,
	[Poids] [float] NULL,
	[Quantité] [float] NULL,
	[Total.H.T] [float] NULL,
	[Total.T.V.A] [float] NULL,
	[Total.T.C] [float] NULL,
 CONSTRAINT [PK_stock] PRIMARY KEY CLUSTERED 
(
	[id_sto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[user]    ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[user](
	[id_user] [int] IDENTITY(1,1) NOT NULL,
	[user] [varchar](50) NULL,
	[pwd] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_user] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Purchase]  WITH CHECK ADD  CONSTRAINT [FK_Purchase_Catégorie] FOREIGN KEY([id_cat])
REFERENCES [dbo].[Catégorie] ([id_cat])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Purchase] CHECK CONSTRAINT [FK_Purchase_Catégorie]
GO
ALTER TABLE [dbo].[Purchase]  WITH CHECK ADD  CONSTRAINT [FK_Purchase_Fournisseurs] FOREIGN KEY([id_four])
REFERENCES [dbo].[Fournisseurs] ([id_four])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Purchase] CHECK CONSTRAINT [FK_Purchase_Fournisseurs]
GO
ALTER TABLE [dbo].[stock]  WITH CHECK ADD  CONSTRAINT [FK_stock_Catégorie] FOREIGN KEY([id_cat])
REFERENCES [dbo].[Catégorie] ([id_cat])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[stock] CHECK CONSTRAINT [FK_stock_Catégorie]
GO
ALTER TABLE [dbo].[stock]  WITH CHECK ADD  CONSTRAINT [FK_stock_Fournisseurs] FOREIGN KEY([id_four])
REFERENCES [dbo].[Fournisseurs] ([id_four])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[stock] CHECK CONSTRAINT [FK_stock_Fournisseurs]
GO

INSERT INTO [dbo].[user]
           ([user]
           ,[pwd])
     VALUES
           ('admin','admin'),('','')
GO

USE [master]
GO
ALTER DATABASE [SDAIM] SET  READ_WRITE 
GO

USE [SHOP]
GO

/****** Object:  Table [dbo].[ShopItems]    Script Date: 2/26/2023 11:09:51 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ShopItems](
	[Id] [int] NOT NULL,
	[SkuId] [int] NOT NULL,
	[CategoryId] [int] NOT NULL,
	[Name] [nvarchar](255) NOT NULL,
	[Description] [nvarchar](1000) NULL,
 CONSTRAINT [PK_ShopItems] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[ShopItems]  WITH CHECK ADD  CONSTRAINT [FK_ShopItems_ShopItemCategories] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[ShopItemCategories] ([Id])
GO

ALTER TABLE [dbo].[ShopItems] CHECK CONSTRAINT [FK_ShopItems_ShopItemCategories]
GO

ALTER TABLE [dbo].[ShopItems]  WITH CHECK ADD  CONSTRAINT [FK_ShopItems_StockKeepingUnits] FOREIGN KEY([SkuId])
REFERENCES [dbo].[StockKeepingUnits] ([id])
GO

ALTER TABLE [dbo].[ShopItems] CHECK CONSTRAINT [FK_ShopItems_StockKeepingUnits]
GO


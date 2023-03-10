USE [SHOP]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Prices](
	[ShopItemId] [int] NOT NULL,
	[DateTime] [datetime2] NOT NULL,
	[Price] [money] NOT NULL,
 CONSTRAINT [PK_Prices] PRIMARY KEY CLUSTERED 
(
	[ShopItemId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


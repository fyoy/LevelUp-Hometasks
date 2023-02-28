USE [SHOP]
GO

/****** Object:  Table [dbo].[Shipments]    Script Date: 2/26/2023 11:05:53 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Shipments](
	[Id] [int] NOT NULL,
	[StockId] [int] NOT NULL,
	[SkuId] [int] NOT NULL,
	[Amount] [float] NOT NULL,
	[DeliveryDate] [datetime2](7) NOT NULL,
	[CargoInfo] [nvarchar](255) NULL,
 CONSTRAINT [PK_Shipments] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Shipments]  WITH CHECK ADD  CONSTRAINT [FK_Shipments_StockKeepingUnits] FOREIGN KEY([SkuId])
REFERENCES [dbo].[StockKeepingUnits] ([id])
GO

ALTER TABLE [dbo].[Shipments] CHECK CONSTRAINT [FK_Shipments_StockKeepingUnits]
GO

ALTER TABLE [dbo].[Shipments]  WITH CHECK ADD  CONSTRAINT [FK_Shipments_Stocks] FOREIGN KEY([StockId])
REFERENCES [dbo].[Stocks] ([Id])
GO

ALTER TABLE [dbo].[Shipments] CHECK CONSTRAINT [FK_Shipments_Stocks]
GO


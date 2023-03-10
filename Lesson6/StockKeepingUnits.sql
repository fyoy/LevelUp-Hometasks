USE [SHOP]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[StockKeepingUnits](
	[id] [int] NOT NULL,
	[StockId] [int] NOT NULL,
	[Name] [nvarchar](255) NOT NULL,
	[Description] [nvarchar](1000) NULL,
	[Amount] [int] NOT NULL,
 CONSTRAINT [PK_StockKeepingUnits] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[StockKeepingUnits]  WITH CHECK ADD  CONSTRAINT [FK_StockKeepingUnits_Stocks] FOREIGN KEY([StockId])
REFERENCES [dbo].[Stocks] ([Id])
GO

ALTER TABLE [dbo].[StockKeepingUnits] CHECK CONSTRAINT [FK_StockKeepingUnits_Stocks]
GO


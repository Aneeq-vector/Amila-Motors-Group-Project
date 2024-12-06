CREATE TABLE [dbo].[StockTbl]
(
	[PartId] INT NOT NULL PRIMARY KEY IDENTITY(100, 1), 
    [PartName] VARCHAR(50) NOT NULL, 
    [PartQty] INT NOT NULL, 
    [PartPrice] INT NOT NULL
)

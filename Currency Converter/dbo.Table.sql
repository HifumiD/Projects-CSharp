CREATE TABLE [dbo].[Currency_Master]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Ammount] FLOAT NULL, 
    [CurrencyName] NVARCHAR(50) NULL
	PRIMARY KEY CLUSTERED ([Id] ASC)
)

CREATE TABLE [dbo].[Currency_Master] (
    [Id]           INT NOT NULL,
    [Amount]      FLOAT (53)    NULL,
    [CurrencyName] NVARCHAR(50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


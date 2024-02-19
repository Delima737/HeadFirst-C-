CREATE TABLE [dbo].[Table]
(
	[ContactId] INT NOT NULL PRIMARY KEY, 
    [Name] NCHAR(10) NULL, 
    [Company] NVARCHAR(50) NULL, 
    [Telephone] NVARCHAR(50) NULL, 
    [Email] NVARCHAR(50) NULL, 
    [Client] BIT NULL, 
    [LastCall] DATETIME NULL
)

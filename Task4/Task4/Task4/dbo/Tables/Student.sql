CREATE TABLE [dbo].[Student]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FirstName] NVARCHAR(50) NULL, 
    [LastName] NVARCHAR(50) NULL, 
    [PhoneNumber] NCHAR(10) NULL, 
    [Address] NVARCHAR(50) NULL,
    Fk_ClassId INT FOREIGN KEY REFERENCES Class(Id)
)

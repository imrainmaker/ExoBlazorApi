CREATE TABLE [dbo].[Game]
(
	[Id] INT IDENTITY,
	[Titre] Nvarchar(250) NOT NULL,
	[Genre] Nvarchar(250) NOT NULL,
	[DateDeSortie] DATE NOT NULL,
	[Note] INT NOT NULL,
    CONSTRAINT PK_GAME_Id PRIMARY KEY(Id)
)

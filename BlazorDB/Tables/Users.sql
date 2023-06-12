CREATE TABLE [dbo].[User]
(
	[Id] INT IDENTITY,
	[Nom] Nvarchar(250) NOT NULL,
    [Prenom] Nvarchar(250)NOT NULL,
    [Email] Nvarchar(250)NOT NULL,
    [Password] VARBINARY(64)NOT NULL,
    [Salt] NVARCHAR(20)NOT NULL,
    [Role] INT NOT NULL,
    CONSTRAINT UK_USER_EMAIL UNIQUE(Email),
    CONSTRAINT PK_USER_Id PRIMARY KEY(Id)
)

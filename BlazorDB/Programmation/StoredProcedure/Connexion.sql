CREATE PROCEDURE [dbo].[Connexion]
    @mail NVARCHAR(250), 
    @passwd NVARCHAR(20)
AS
BEGIN
    DECLARE @Pepper NVARCHAR(128) = '%0Pepper0%'

    SELECT Id, Nom, Prenom, Email,[Role] 
    FROM [Users]
    WHERE Email = @mail AND [Password] = HASHBYTES('SHA2_512', Salt + @passwd + @Pepper);
END
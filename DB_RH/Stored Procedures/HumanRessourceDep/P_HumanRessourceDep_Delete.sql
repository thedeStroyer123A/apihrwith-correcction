CREATE PROCEDURE [dbo].[P_HumanRessourceDep_Delete]
	@Id_HR uniqueidentifier
AS
BEGIN
	DELETE HumanRessourseDep
	WHERE Id_HR = @Id_HR;
END

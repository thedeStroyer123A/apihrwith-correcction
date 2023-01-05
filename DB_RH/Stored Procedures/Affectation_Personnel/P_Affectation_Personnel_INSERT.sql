CREATE PROCEDURE [dbo].[Affectation_Personnel_INSERT]
	@Date_Affectation_Personnel DATETIME,
	@Id_RH UNIQUEIDENTIFIER,
	@Id_Em INT
AS
BEGIN
	INSERT INTO Affectation_Personnel(Date_Affectation_Personnel,Id_RH,Id_Em)
	VALUES(@Date_Affectation_Personnel,@Id_RH,@Id_Em)
END

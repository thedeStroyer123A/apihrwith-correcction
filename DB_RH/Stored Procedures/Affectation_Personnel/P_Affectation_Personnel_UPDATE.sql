CREATE PROCEDURE [dbo].[Affectation_Personnel_UPDATE]
	@Id_num INT,
	@Date_Affectation_Personnel DATETIME,
	@Id_RH UNIQUEIDENTIFIER,
	@Id_Em INT
AS
BEGIN
	UPDATE Affectation_Personnel
	SET [Date_Affectation_Personnel] = @Date_Affectation_Personnel , Id_RH = @Id_RH , Id_Em = @Id_Em
	WHERE Id_num = @Id_num
END

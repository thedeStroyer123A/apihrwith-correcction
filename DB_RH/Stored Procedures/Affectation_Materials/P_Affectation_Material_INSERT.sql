CREATE PROCEDURE [dbo].[P_Affectation_Materials_INSERT]
	@Date_Affectation_Material DATETIME,
	@Id_Material INT,
	@Id_HR UNIQUEIDENTIFIER
AS
BEGIN
	INSERT INTO [Affectation_Materials](Date_Affectation_Material , Id_Material , Id_HR)
	VALUES(@Date_Affectation_Material,@Id_Material,@Id_HR)
END

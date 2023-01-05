﻿CREATE PROCEDURE [dbo].[P_HumanRessourceDep_UPDATE]
	@Id_HR UniqueIdentifier,
	@HRDepartmentName VARCHAR(50),
	@RH_manager_Id INT,
	@Location_Id INT,
	@email VARCHAR(50),
	@IsAdmin BIT 
AS
BEGIN
	UPDATE HumanRessourseDep
	SET [HRDepartmentName]=@HRDepartmentName , RH_manager_Id = @RH_manager_Id,Location_Id = @Location_Id,email = @email , IsAdmin = @IsAdmin
	WHERE Id_HR = @Id_HR
END
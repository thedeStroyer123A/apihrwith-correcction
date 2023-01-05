CREATE PROCEDURE [dbo].[P_HumanRessourceDep_INSERT]
	@HRDepartmentName VARCHAR(50),
	@RH_manager_Id INT,
	@Location_Id  INT,
	@email VARCHAR(50),
	@IsAdmin BIT

AS
BEGIN
	INSERT INTO HumanRessourseDep(HRDepartmentName,RH_manager_Id,Location_Id,email,IsAdmin)
	VALUES(@HRDepartmentName,@RH_manager_Id,@Location_Id,@email,@IsAdmin)
END

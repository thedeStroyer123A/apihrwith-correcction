CREATE TABLE [dbo].[HumanRessourseDep]
(
	Id_HR UNIQUEIDENTIFIER	NOT NULL DEFAULT NEWSEQUENTIALID(),
	HRDepartmentName VARCHAR(50) NOT NULL,
	RH_manager_Id INT,
	Location_Id  INT,
	email VARCHAR(60) NOT NULL,
	IsAdmin BIT default(0) NOT NULL,
	PRIMARY KEY(Id_HR),
	UNIQUE(RH_manager_Id),
	UNIQUE(email)
)

CREATE TABLE [dbo].[HumanRessourceDep]
(
	Id_HR INT IDENTITY,
	HRDepartmentName VARCHAR(50) NOT NULL,
	RH_manager_Id INT,
	Location_Id  INT,
	email VARCHAR(60) NOT NULL,
	IsAdmin BIT default(0) NOT NULL,
	PRIMARY KEY(Id_HR),
	UNIQUE(RH_manager_Id),
	UNIQUE(email)
)

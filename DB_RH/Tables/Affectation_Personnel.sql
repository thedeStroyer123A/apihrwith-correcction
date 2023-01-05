CREATE TABLE [dbo].[Affectation_Personnel]
(
	[Id_num] INT NOT NULL  IDENTITY(1,1),
	Date_Affectation_Personnel DATETIME,
	Id_RH  UNIQUEIDENTIFIER,
	Id_Em INT,
	PRIMARY KEY(Id_num),
	FOREIGN KEY(Id_RH)  REFERENCES HumanRessourseDep(Id_HR),
	FOREIGN KEY (Id_Em) REFERENCES Employés(Id_Em)


)

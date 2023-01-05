CREATE PROCEDURE [dbo].[P_ControlCheck_Update]
	@Id INT,
	@EndDateTraining DATE ,
	@BeginingDateTraining DATE ,
	@Passed BIT,
	@Failed BIT,
	@Id_HR  UNIQUEIDENTIFIER,
	@Id_Trained_Employee INT
AS
BEGIN
	UPDATE ControlCheck
	SET [EndDateTraining] = @EndDateTraining ,BeginingDateTraining = @BeginingDateTraining ,Passed = @Passed ,Failed = @Failed ,Id_HR = @Id_HR ,Id_Trained_Employee = @Id_Trained_Employee
	WHERE Id = @Id
END

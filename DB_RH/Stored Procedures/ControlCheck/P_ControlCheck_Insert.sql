CREATE PROCEDURE [dbo].[P_ControlCheck_Insert]
	@EndDateTraining DATE ,
	@BeginingDateTraining DATE ,
	@Passed BIT,
	@Failed BIT,
	@Id_HR UNIQUEIDENTIFIER,
	@Id_Trained_Employee INT
AS
BEGIN
	INSERT INTO ControlCheck(EndDateTraining , BeginingDateTraining ,Passed,Failed, Id_HR ,Id_Trained_Employee)
	VALUES(@EndDateTraining ,@BeginingDateTraining ,@Passed ,@Failed ,@Id_HR ,@Id_Trained_Employee)
END

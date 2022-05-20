CREATE PROCEDURE [dbo].[Delete]
	@studentId int,
	@firstName nvarchar(50),
	@lastName nvarchar(50),
	@phoneNumber nchar(10),
	@address nvarchar(50),
	@classId int
AS
BEGIN
	DELETE FROM Student
	WHERE Id = @studentId
END
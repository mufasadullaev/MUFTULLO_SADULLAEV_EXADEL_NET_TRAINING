CREATE PROCEDURE [dbo].[Update]
	@studentId int,
	@firstName nvarchar(50),
	@lastName nvarchar(50),
	@phoneNumber nchar(10),
	@address nvarchar(50),
	@classId int
AS
BEGIN
	UPDATE Student
	SET FirstName = @firstName,
		LastName = @lastName,
		PhoneNumber = @phoneNumber,
		Address = @address,
		Fk_ClassId = @classId
	WHERE Id = @studentId
END

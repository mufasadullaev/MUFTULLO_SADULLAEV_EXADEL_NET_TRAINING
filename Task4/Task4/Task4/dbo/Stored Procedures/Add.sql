CREATE PROCEDURE [dbo].[Add]
	@studentId int,
	@firstName nvarchar(50),
	@lastName nvarchar(50),
	@phoneNumber nchar(10),
	@address nvarchar(50),
	@classId int
AS
BEGIN TRY
	INSERT INTO Student (FirstName, LastName, PhoneNumber, Address, Fk_ClassId)
	VALUES (@firstName, @lastName, @phoneNumber, @address, @classId)
END TRY
BEGIN CATCH
	SELECT
		ERROR_NUMBER() AS ErrorNumber,
		ERROR_MESSAGE() AS ErrorMessage;
END CATCH
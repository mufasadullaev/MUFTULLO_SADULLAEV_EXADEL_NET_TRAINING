CREATE VIEW [dbo].[AllStudents]
	AS 
	SELECT s.FirstName, s.LastName, s.PhoneNumber, s.Address, c.Number, c.Letter
	FROM Student s
	LEFT JOIN Class c ON s.Fk_ClassId = c.Id

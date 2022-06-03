CREATE FUNCTION dbo.FullName (@studentid int)
RETURNS nvarchar(50)
AS
BEGIN
	RETURN (
	SELECT CONCAT(FirstName, ' ', LastName) AS FullName
	FROM dbo.Student
	);
END

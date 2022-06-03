CREATE TRIGGER [AfterAddTrigger]
ON dbo.Student
AFTER INSERT
AS
UPDATE Student SET FirstName = UPPER(FirstName)
WHERE FirstName IN (SELECT FirstName FROM inserted)

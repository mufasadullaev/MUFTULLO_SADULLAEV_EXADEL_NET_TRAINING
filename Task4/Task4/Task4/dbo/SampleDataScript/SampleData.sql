use taskDb
INSERT INTO dbo.Class (Number, Letter)
VALUES (6, 'B'),
	(7, 'C'),
	(8, 'D'),
	(9, 'E')
INSERT INTO dbo.Student (FirstName, LastName, PhoneNumber, Address)
VALUES ('John', 'Doe', '9989139969', '3-20, 39-Chilanzar distr., Tashkent', 9),
	('Marshall', 'Mathers', '9989700096', '7-20, 3-Yunusobod distr., Tashkent', 12),
	('Nikita', 'Levis', '9989196930', '3-10, 9-Mirzo distr., Tashkent', 9),
	('Anne', 'Sadullaeva', '9989077777', '3-23, 59-Yashnabod distr., Tashkent', 10)
INSERT INTO dbo.Subject (Name)
VALUES ('Biology'),
	('Mathematics'),
	('Physics'),
	('Law')
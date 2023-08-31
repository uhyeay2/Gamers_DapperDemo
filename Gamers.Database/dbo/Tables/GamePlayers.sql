CREATE TABLE [dbo].[GamePlayers]
(
	Id INT PRIMARY KEY IDENTITY(1, 1),
	FirstName VARCHAR(50),
	LastName VARCHAR(50),
	Email VARCHAR(50),
	Gender VARCHAR(50),
	IpAddress VARCHAR(20)
)

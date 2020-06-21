USE Cynthia
GO

CREATE TABLE FiverrItem (

	id int NOT NULL IDENTITY PRIMARY KEY,
	client nvarchar(20) NOT NULL UNIQUE,
	intPriority int NOT NULL,
	nvcDescription nvarchar(100) NOT NULL UNIQUE,
	dtmDeadline nvarchar(20) UNIQUE,
	bitIsDone bit NOT NULL
	);
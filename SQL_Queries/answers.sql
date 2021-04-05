-- Paste your answers for each question in the appropriate spot below. (Keep the number headings)

--CREATE DATABASE StudentsDb

-- #1
--Create Table Students(
--Id int PRIMARY KEY NOT NULL IDENTITY(1,1),
--FirstName NVARCHAR(20),
--LastName NVARCHAR(20),
--Email NVARCHAR(30),
--Phone NVARCHAR(30)
--)

-- #2
--INSERT INTO Students
--VALUES('Jane', 'Doe', 'Jane@example.com', '313-555-0001') 
--INSERT INTO Students
--VALUES('James', 'Smith', 'James@example.com', '313-555-0002') 
--INSERT INTO Students
--VALUES('Susan', 'Jones', 'susan@example.com', '313-555-0003') 
--INSERT INTO Students
--VALUES('Javier', 'Rodriguez', 'javier@example.com', '313-555-0004') 
--INSERT INTO Students
--VALUES('DeAndre', 'Taylor', 'deandre@example.com', '313-555-0005') 

-- #3
--UPDATE Students
--Set Lastname = 'Chirpus'
--Where Id = 4;

-- #4
--DELETE FROM Students WHERE Id = 5;

-- #5
--SELECT * FROM Students 
--WHERE FirstName = 'James'; 

-- #6
--SELECT * FROM Students
--WHERE FirstName LIKE 'J%' AND Id > 3;

-- #7
--Create Table Assignments(
--Id int PRIMARY KEY NOT NULL IDENTITY(1,1),
--Title NVARCHAR(40),
--Score tinyint,
--StudentId int FOREIGN KEY REFERENCES Students(Id)
--)

-- #8
--INSERT INTO Assignments
--VALUES('Geography Quiz', '85', '1') 
--INSERT INTO Assignments
--VALUES('US States Worksheet', '10', '1') 
--INSERT INTO Assignments
--VALUES('Geography Quiz', '92', '4') 

-- #9
--SELECT Title, Score, Students.FirstName, Students.LastName
--FROM Assignments 
--INNER JOIN Students ON Assignments.StudentId = Students.Id;

-- #10
--SELECT Students.FirstName, Students.LastName
--FROM Students
--INNER JOIN Assignments ON Assignments.StudentId = Students.Id
--WHERE Title = 'Geography Quiz' AND Score > 90;
--
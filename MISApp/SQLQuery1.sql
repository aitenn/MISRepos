CREATE DATABASE MIS;

GO

USE MIS;

GO

CREATE TABLE Classes
(
Id INT PRIMARY KEY,
[Name] NVARCHAR(30) NOT NULL,
[Year] INT NOT NULL
)

GO

CREATE TABLE Grades
(
Id INT PRIMARY KEY,
Mark INT,
[Percentage] INT
)

GO

CREATE TABLE Students

(
Id INT PRIMARY KEY,
[Name] NVARCHAR(30),
Surname NVARCHAR(30),
ClassId INT REFERENCES Classes (Id)
)

GO

CREATE TABLE StudentsGradesDates
(
Id INT PRIMARY KEY,
[Date] DATE,
StudentId INT REFERENCES Students (Id),
GradeId INT REFERENCES Grades (Id)

)

GO

CREATE TABLE Subjects
(
Id INT PRIMARY KEY,
[Name] NVARCHAR(50)
)

GO

CREATE TABLE Gradebooks
(
Id INT PRIMARY KEY,
SubjectId INT REFERENCES Subjects (Id),
StudentsGradesDatesId INT REFERENCES StudentsGradesDates (Id)
)

GO



CREATE TABLE Teachers
(
Id INT PRIMARY KEY,
[Name] NVARCHAR(30),
Surname NVARCHAR(30),
Email NVARCHAR(50),
ClassId INT REFERENCES Classes (Id)
)

GO

CREATE TABLE Feedbacks
(
Id INT PRIMARY KEY,
TeacherId INT REFERENCES Teachers (Id),
StudentId INT REFERENCES Students (Id)
)

GO

CREATE TABLE StudentsAbsences

(
Id INT PRIMARY KEY,

)

GO

CREATE TABLE Registers
(
Id INT PRIMARY KEY,
[Date] DATE,
ClassId INT REFERENCES Classes (Id),

)

GO





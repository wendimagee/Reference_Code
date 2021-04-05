CREATE DATABASE CountriesDB;
USE CountriesDb
CREATE TABLE Country(
	Id int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	[Name] nvarchar(40) NOT NULL,
	Continent nvarchar(40) NOT NULL,
); 
INSERT INTO Country 
VALUES('China', 'Asia'),
('India', 'Asia'),
('USA', 'North America');
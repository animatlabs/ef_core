﻿CREATE OR ALTER PROCEDURE GetAllCourses
AS
BEGIN
	SELECT [C].*
	FROM dbo.Courses C
END
GO

CREATE OR ALTER PROCEDURE GetAllStudents
AS
BEGIN
	SELECT [S].*
	FROM dbo.Students S
END
GO
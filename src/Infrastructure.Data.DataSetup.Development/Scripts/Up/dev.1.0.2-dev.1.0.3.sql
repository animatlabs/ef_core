﻿BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220807152446_dev.1.0.3')
BEGIN
    EXEC(N'CREATE OR ALTER PROCEDURE GetAllCourses
    AS
    BEGIN
    	SELECT [C].*
    	FROM dbo.Courses C
    END')
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220807152446_dev.1.0.3')
BEGIN
    EXEC(N'CREATE OR ALTER PROCEDURE GetAllStudents
    AS
    BEGIN
    	SELECT [S].*
    	FROM dbo.Students S
    END')
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220807152446_dev.1.0.3')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20220807152446_dev.1.0.3', N'6.0.7');
END;
GO

COMMIT;
GO


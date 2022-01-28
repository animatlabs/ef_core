﻿BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220128222040_dev.1.0.1')
BEGIN
    ALTER TABLE [Students] ADD [MiddleName] nvarchar(50) NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220128222040_dev.1.0.1')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20220128222040_dev.1.0.1', N'6.0.1');
END;
GO

COMMIT;
GO


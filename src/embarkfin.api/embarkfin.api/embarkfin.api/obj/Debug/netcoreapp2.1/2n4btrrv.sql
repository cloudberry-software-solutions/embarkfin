IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Disposal] (
    [DisposalId] int NOT NULL IDENTITY,
    [Disposed_Date] datetime2 NOT NULL,
    [Disposal_Price] float NOT NULL,
    CONSTRAINT [PK_Disposal] PRIMARY KEY ([DisposalId])
);

GO

CREATE TABLE [Location] (
    [LocationId] int NOT NULL IDENTITY,
    [Longitude] bigint NOT NULL,
    [Latitude] bigint NOT NULL,
    [Date_Captured] datetime2 NOT NULL,
    CONSTRAINT [PK_Location] PRIMARY KEY ([LocationId])
);

GO

CREATE TABLE [Login] (
    [id] int NOT NULL IDENTITY,
    [created_at] datetime2 NOT NULL,
    [updated_at] datetime2 NOT NULL,
    [User_Name] nvarchar(max) NULL,
    [Password] nvarchar(max) NULL,
    CONSTRAINT [PK_Login] PRIMARY KEY ([id])
);

GO

CREATE TABLE [Asset] (
    [id] int NOT NULL IDENTITY,
    [created_at] datetime2 NOT NULL,
    [updated_at] datetime2 NOT NULL,
    [Serial_Number] nvarchar(max) NULL,
    [Date_Purchased] datetime2 NOT NULL,
    [Period] bigint NOT NULL,
    [Purchase_Price] float NOT NULL,
    [DisposalId] int NOT NULL,
    [LocationId] int NOT NULL,
    CONSTRAINT [PK_Asset] PRIMARY KEY ([id]),
    CONSTRAINT [FK_Asset_Disposal_DisposalId] FOREIGN KEY ([DisposalId]) REFERENCES [Disposal] ([DisposalId]) ON DELETE CASCADE,
    CONSTRAINT [FK_Asset_Location_LocationId] FOREIGN KEY ([LocationId]) REFERENCES [Location] ([LocationId]) ON DELETE CASCADE
);

GO

CREATE INDEX [IX_Asset_DisposalId] ON [Asset] ([DisposalId]);

GO

CREATE INDEX [IX_Asset_LocationId] ON [Asset] ([LocationId]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20190525075702_InitialMigration', N'2.1.8-servicing-32085');

GO

ALTER TABLE [Asset] DROP CONSTRAINT [FK_Asset_Disposal_DisposalId];

GO

ALTER TABLE [Asset] DROP CONSTRAINT [FK_Asset_Location_LocationId];

GO

DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Asset]') AND [c].[name] = N'Purchase_Price');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Asset] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [Asset] ALTER COLUMN [Purchase_Price] float NULL;

GO

DECLARE @var1 sysname;
SELECT @var1 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Asset]') AND [c].[name] = N'Period');
IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [Asset] DROP CONSTRAINT [' + @var1 + '];');
ALTER TABLE [Asset] ALTER COLUMN [Period] bigint NULL;

GO

DECLARE @var2 sysname;
SELECT @var2 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Asset]') AND [c].[name] = N'LocationId');
IF @var2 IS NOT NULL EXEC(N'ALTER TABLE [Asset] DROP CONSTRAINT [' + @var2 + '];');
ALTER TABLE [Asset] ALTER COLUMN [LocationId] int NULL;

GO

DECLARE @var3 sysname;
SELECT @var3 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Asset]') AND [c].[name] = N'DisposalId');
IF @var3 IS NOT NULL EXEC(N'ALTER TABLE [Asset] DROP CONSTRAINT [' + @var3 + '];');
ALTER TABLE [Asset] ALTER COLUMN [DisposalId] int NULL;

GO

DECLARE @var4 sysname;
SELECT @var4 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Asset]') AND [c].[name] = N'Date_Purchased');
IF @var4 IS NOT NULL EXEC(N'ALTER TABLE [Asset] DROP CONSTRAINT [' + @var4 + '];');
ALTER TABLE [Asset] ALTER COLUMN [Date_Purchased] datetime2 NULL;

GO

ALTER TABLE [Asset] ADD CONSTRAINT [FK_Asset_Disposal_DisposalId] FOREIGN KEY ([DisposalId]) REFERENCES [Disposal] ([DisposalId]) ON DELETE NO ACTION;

GO

ALTER TABLE [Asset] ADD CONSTRAINT [FK_Asset_Location_LocationId] FOREIGN KEY ([LocationId]) REFERENCES [Location] ([LocationId]) ON DELETE NO ACTION;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20190525080424_updateInitialMigration', N'2.1.8-servicing-32085');

GO


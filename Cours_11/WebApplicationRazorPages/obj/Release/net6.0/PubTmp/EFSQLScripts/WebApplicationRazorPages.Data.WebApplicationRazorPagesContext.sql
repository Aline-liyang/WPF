IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221104202858_InitialCreate')
BEGIN
    CREATE TABLE [Employe] (
        [EmployeID] int NOT NULL IDENTITY,
        [Nom] nvarchar(max) NOT NULL,
        [Prenom] nvarchar(max) NOT NULL,
        [Titre] nvarchar(max) NOT NULL,
        [DateDeNaissance] datetime2 NOT NULL,
        [DateEmbauche] datetime2 NOT NULL,
        [Adresse] nvarchar(max) NOT NULL,
        [Province] nvarchar(max) NOT NULL,
        [CodePostal] nvarchar(max) NOT NULL,
        [Pays] nvarchar(max) NOT NULL,
        [Telephone] nvarchar(max) NOT NULL,
        [Extension] nvarchar(max) NOT NULL,
        [Notes] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_Employe] PRIMARY KEY ([EmployeID])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221104202858_InitialCreate')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20221104202858_InitialCreate', N'6.0.10');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221108201224_InitialCreate2')
BEGIN
    CREATE TABLE [Client] (
        [ClientID] nvarchar(450) NOT NULL,
        [NomCompagnie] nvarchar(max) NOT NULL,
        [NomContact] nvarchar(max) NULL,
        [TitreContact] nvarchar(max) NULL,
        [Adresse] nvarchar(max) NULL,
        [Province] nvarchar(max) NULL,
        [CodePostal] nvarchar(max) NULL,
        [Pays] nvarchar(max) NULL,
        [Telephone] nvarchar(max) NULL,
        [Fax] nvarchar(max) NULL,
        CONSTRAINT [PK_Client] PRIMARY KEY ([ClientID])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221108201224_InitialCreate2')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20221108201224_InitialCreate2', N'6.0.10');
END;
GO

COMMIT;
GO


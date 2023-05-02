BEGIN TRANSACTION;
GO

DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Personagens]') AND [c].[name] = N'Nome');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Personagens] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [Personagens] ALTER COLUMN [Nome] nvarchar(max) NULL;
GO

ALTER TABLE [Personagens] ADD [FotoPersonagem] varbinary(max) NULL;
GO

ALTER TABLE [Personagens] ADD [UsuarioId] int NULL;
GO

DECLARE @var1 sysname;
SELECT @var1 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Armas]') AND [c].[name] = N'Nome');
IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [Armas] DROP CONSTRAINT [' + @var1 + '];');
ALTER TABLE [Armas] ALTER COLUMN [Nome] nvarchar(max) NULL;
GO

CREATE TABLE [Usuarios] (
    [Id] int NOT NULL IDENTITY,
    [Username] nvarchar(max) NULL,
    [PasswordHash] varbinary(max) NULL,
    [PasswordSalt] varbinary(max) NULL,
    [Foto] varbinary(max) NULL,
    [Latitude] float NULL,
    [Longitude] float NULL,
    [DataAcesso] datetime2 NULL,
    [Perfil] nvarchar(max) NULL DEFAULT N'Jogador',
    [Email] nvarchar(max) NULL,
    CONSTRAINT [PK_Usuarios] PRIMARY KEY ([Id])
);
GO

UPDATE [Personagens] SET [FotoPersonagem] = NULL, [UsuarioId] = NULL
WHERE [Id] = 1;
SELECT @@ROWCOUNT;

GO

UPDATE [Personagens] SET [FotoPersonagem] = NULL, [UsuarioId] = NULL
WHERE [Id] = 2;
SELECT @@ROWCOUNT;

GO

UPDATE [Personagens] SET [FotoPersonagem] = NULL, [UsuarioId] = NULL
WHERE [Id] = 3;
SELECT @@ROWCOUNT;

GO

UPDATE [Personagens] SET [FotoPersonagem] = NULL, [UsuarioId] = NULL
WHERE [Id] = 4;
SELECT @@ROWCOUNT;

GO

UPDATE [Personagens] SET [FotoPersonagem] = NULL, [UsuarioId] = NULL
WHERE [Id] = 5;
SELECT @@ROWCOUNT;

GO

UPDATE [Personagens] SET [FotoPersonagem] = NULL, [UsuarioId] = NULL
WHERE [Id] = 6;
SELECT @@ROWCOUNT;

GO

UPDATE [Personagens] SET [FotoPersonagem] = NULL, [UsuarioId] = NULL
WHERE [Id] = 7;
SELECT @@ROWCOUNT;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'DataAcesso', N'Email', N'Foto', N'Latitude', N'Longitude', N'PasswordHash', N'PasswordSalt', N'Perfil', N'Username') AND [object_id] = OBJECT_ID(N'[Usuarios]'))
    SET IDENTITY_INSERT [Usuarios] ON;
INSERT INTO [Usuarios] ([Id], [DataAcesso], [Email], [Foto], [Latitude], [Longitude], [PasswordHash], [PasswordSalt], [Perfil], [Username])
VALUES (1, NULL, N'seuEmail@gmail.com', NULL, -23.520024100000001E0, -46.596497999999997E0, 0xD51583B23EF54EB35C855E30DA2CA0DF266F396A3D4B0442CB57C117FB8DC1C85614365B5A55C686A9ACB8DB3870628698E07EF3D4E7358121815678A3A63C90, 0x7FE67CE07084F089DC12CC93AB975D41EB53D218EF8FE42C7EDCC176333912ADD0979CFB1C6622223461C7347EBDCC26B249829E6B67BF1EC246E9CCB7630CD805DCDDDE1E926D4C93199D066655FEEE07D98F03FF82600518143109BB498DD368C5E987961FA8284989FD6B42BEAF59C96496A53962A5E3A92068D1D02A3A1F, N'Admin', N'UsuarioAdmin');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'DataAcesso', N'Email', N'Foto', N'Latitude', N'Longitude', N'PasswordHash', N'PasswordSalt', N'Perfil', N'Username') AND [object_id] = OBJECT_ID(N'[Usuarios]'))
    SET IDENTITY_INSERT [Usuarios] OFF;
GO

CREATE INDEX [IX_Personagens_UsuarioId] ON [Personagens] ([UsuarioId]);
GO

ALTER TABLE [Personagens] ADD CONSTRAINT [FK_Personagens_Usuarios_UsuarioId] FOREIGN KEY ([UsuarioId]) REFERENCES [Usuarios] ([Id]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20230419001403_MigracaoUsuario', N'7.0.5');
GO

COMMIT;
GO


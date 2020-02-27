IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Quizzes] (
    [QuizID] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NULL,
    [Creator] nvarchar(max) NULL,
    [PCCS] bit NOT NULL,
    CONSTRAINT [PK_Quizzes] PRIMARY KEY ([QuizID])
);

GO

CREATE TABLE [Questions] (
    [QuestionID] int NOT NULL IDENTITY,
    [QuizID] int NOT NULL,
    [QuestionName] nvarchar(200) NULL,
    [Question1] nvarchar(max) NULL,
    [Question2] nvarchar(max) NULL,
    [Question3] nvarchar(max) NULL,
    [Question4] nvarchar(max) NULL,
    [CorrectAnswer] int NOT NULL,
    CONSTRAINT [PK_Questions] PRIMARY KEY ([QuestionID]),
    CONSTRAINT [FK_Questions_Quizzes_QuizID] FOREIGN KEY ([QuizID]) REFERENCES [Quizzes] ([QuizID]) ON DELETE CASCADE
);

GO

CREATE INDEX [IX_Questions_QuizID] ON [Questions] ([QuizID]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200207231558_Initial', N'2.1.14-servicing-32113');

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200227002322_DBTEST', N'2.1.14-servicing-32113');

GO


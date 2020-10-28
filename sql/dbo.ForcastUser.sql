CREATE TABLE [dbo].[ForcastUser] (
    [Id]           INT   IDENTITY (1, 1) NOT NULL,
    [usName]       TEXT  NOT NULL,
    [usSurname]    TEXT  NOT NULL,
    [usUsername]   TEXT  NOT NULL,
    [usEmail]      NTEXT NOT NULL,
    [usPassword]    TEXT  NOT NULL,
    [isNormalUser] BIT   NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


CREATE TABLE [dbo].[Weather] (
    [Id]            INT       NOT NULL IDENTITY,
    [City]          CHAR (20) NULL,
    [sDate]         DATE      NULL,
    [Humidity]      INT       NULL,
    [MaxTemp]       INT       NULL,
    [MinTemp]       INT       NULL,
    [Precipitation] INT       NULL,
    [WindSpeed]     INT       NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


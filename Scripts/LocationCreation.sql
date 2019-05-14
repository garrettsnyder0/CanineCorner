CREATE TABLE [dbo].[Location] (
    [ID]      INT            IDENTITY (1, 1) NOT NULL,
    [LocName] NVARCHAR (MAX) NULL,
    [LocType] NVARCHAR (MAX) NULL,
    [ZipCode] INT            NOT NULL,
    [Rating]  INT            NOT NULL,
    CONSTRAINT [PK_Location] PRIMARY KEY CLUSTERED ([ID] ASC)
);
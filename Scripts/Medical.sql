CREATE TABLE [dbo].[Medical] (
    [ID]            INT            IDENTITY (1, 1) NOT NULL,
    [User]          NVARCHAR (MAX) NULL,
    [DogName]       NVARCHAR (MAX) NULL,
    [MedName]       NVARCHAR (MAX) NULL,
    [Periodicity]   NVARCHAR (MAX) NULL,
    [LastDateGiven] DATETIME2 (7)  NOT NULL,
    CONSTRAINT [PK_Medical] PRIMARY KEY CLUSTERED ([ID] ASC)
);
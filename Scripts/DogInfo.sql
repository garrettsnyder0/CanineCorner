CREATE TABLE [dbo].[DogInfo] (
    [ID]        INT            IDENTITY (1, 1) NOT NULL,
    [User]      NVARCHAR (MAX) NULL,
    [DogName]   NVARCHAR (MAX) NULL,
    [Breed]     NVARCHAR (MAX) NULL,
    [Weight]    INT            NOT NULL,
    [Height]    INT            NOT NULL,
    [DoB]       DATETIME2 (7)  NOT NULL,
    [TodayDate] DATETIME2 (7)  NOT NULL,
    CONSTRAINT [PK_DogInfo] PRIMARY KEY CLUSTERED ([ID] ASC)
);
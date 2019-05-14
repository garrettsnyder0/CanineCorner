CREATE TABLE [dbo].[BreedInfo] (
    [ID]           INT            IDENTITY (1, 1) NOT NULL,
    [Breed]        NVARCHAR (MAX) NULL,
    [adaptability] INT            NOT NULL,
    [friendliness] INT            NOT NULL,
    [health]       INT            NOT NULL,
    [grooming]     INT            NOT NULL,
    [training]     INT            NOT NULL,
    [exercise]     INT            NOT NULL,
    CONSTRAINT [PK_BreedInfo] PRIMARY KEY CLUSTERED ([ID] ASC)
);

CREATE TABLE [dbo].[Adaptibility] (
    [ID]           INT IDENTITY (1, 1) NOT NULL,
    [Overall]      INT NOT NULL,
    [Apartment]    INT NOT NULL,
    [NoviceOwners] INT NOT NULL,
    [Sensitivity]  INT NOT NULL,
    [Alone]        INT NOT NULL,
    [ColdWeather]  INT NOT NULL,
    [HotWeather]   INT NOT NULL,
    CONSTRAINT [PK_Adaptibility] PRIMARY KEY CLUSTERED ([ID] ASC)
);

CREATE TABLE [dbo].[Friendliness] (
    [ID]            INT IDENTITY (1, 1) NOT NULL,
    [Overall]       INT NOT NULL,
    [WithFamily]    INT NOT NULL,
    [WithKids]      INT NOT NULL,
    [OtherDogs]     INT NOT NULL,
    [WithStrangers] INT NOT NULL,
    CONSTRAINT [PK_Friendliness] PRIMARY KEY CLUSTERED ([ID] ASC)
);

CREATE TABLE [dbo].[Health] (
    [ID]         INT IDENTITY (1, 1) NOT NULL,
    [Overall]    INT NOT NULL,
    [General]    INT NOT NULL,
    [WeightGain] INT NOT NULL,
    [Size]       INT NOT NULL,
    CONSTRAINT [PK_Health] PRIMARY KEY CLUSTERED ([ID] ASC)
);

CREATE TABLE [dbo].[Grooming] (
    [ID]       INT IDENTITY (1, 1) NOT NULL,
    [Overall]  INT NOT NULL,
    [Shedding] INT NOT NULL,
    [Drool]    INT NOT NULL,
    [Easiness] INT NOT NULL,
    CONSTRAINT [PK_Grooming] PRIMARY KEY CLUSTERED ([ID] ASC)
);

CREATE TABLE [dbo].[Training] (
    [ID]           INT IDENTITY (1, 1) NOT NULL,
    [Overall]      INT NOT NULL,
    [Easiness]     INT NOT NULL,
    [Intelligence] INT NOT NULL,
    [Mouthiness]   INT NOT NULL,
    [PreyDrive]    INT NOT NULL,
    [Barking]      INT NOT NULL,
    [Wanderlust]   INT NOT NULL,
    CONSTRAINT [PK_Training] PRIMARY KEY CLUSTERED ([ID] ASC)
);

CREATE TABLE [dbo].[Exercise] (
    [ID]           INT IDENTITY (1, 1) NOT NULL,
    [Overall]      INT NOT NULL,
    [EnergyLevel]  INT NOT NULL,
    [Intensity]    INT NOT NULL,
    [ExerciseNeed] INT NOT NULL,
    [Playfulness]  INT NOT NULL,
    CONSTRAINT [PK_Exercise] PRIMARY KEY CLUSTERED ([ID] ASC)
);
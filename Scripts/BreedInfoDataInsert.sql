SET IDENTITY_INSERT [dbo].[BreedInfo] ON
INSERT INTO [dbo].[BreedInfo] ([ID], [Breed], [adaptability], [friendliness], [health], [grooming], [training], [exercise]) VALUES (1, N'German Shepherd', 3, 4, 4, 4, 4, 5)
INSERT INTO [dbo].[BreedInfo] ([ID], [Breed], [adaptability], [friendliness], [health], [grooming], [training], [exercise]) VALUES (2, N'Siberian Husky', 3, 5, 3, 3, 4, 5)
INSERT INTO [dbo].[BreedInfo] ([ID], [Breed], [adaptability], [friendliness], [health], [grooming], [training], [exercise]) VALUES (3, N'Border Collie', 3, 4, 3, 3, 4, 5)
INSERT INTO [dbo].[BreedInfo] ([ID], [Breed], [adaptability], [friendliness], [health], [grooming], [training], [exercise]) VALUES (4, N'Great Pyrenees', 3, 4, 4, 4, 4, 5)
INSERT INTO [dbo].[BreedInfo] ([ID], [Breed], [adaptability], [friendliness], [health], [grooming], [training], [exercise]) VALUES (5, N'Golden Retriever', 3, 5, 4, 4, 4, 4)
INSERT INTO [dbo].[BreedInfo] ([ID], [Breed], [adaptability], [friendliness], [health], [grooming], [training], [exercise]) VALUES (6, N'Labrador Retriever', 3, 4, 4, 4, 4, 5)
INSERT INTO [dbo].[BreedInfo] ([ID], [Breed], [adaptability], [friendliness], [health], [grooming], [training], [exercise]) VALUES (7, N'Chihuahua', 3, 4, 3, 2, 3, 3)
INSERT INTO [dbo].[BreedInfo] ([ID], [Breed], [adaptability], [friendliness], [health], [grooming], [training], [exercise]) VALUES (8, N'French Bulldog', 3, 4, 3, 4, 3, 4)
SET IDENTITY_INSERT [dbo].[BreedInfo] OFF

SET IDENTITY_INSERT [dbo].[Adaptibility] ON
INSERT INTO [dbo].[Adaptibility] ([ID], [Overall], [Apartment], [NoviceOwners], [Sensitivity], [Alone], [ColdWeather], [HotWeather]) VALUES (1, 3, 3, 2, 5, 2, 4, 3)
INSERT INTO [dbo].[Adaptibility] ([ID], [Overall], [Apartment], [NoviceOwners], [Sensitivity], [Alone], [ColdWeather], [HotWeather]) VALUES (2, 3, 2, 1, 4, 1, 5, 3)
INSERT INTO [dbo].[Adaptibility] ([ID], [Overall], [Apartment], [NoviceOwners], [Sensitivity], [Alone], [ColdWeather], [HotWeather]) VALUES (3, 3, 2, 2, 5, 1, 4, 4)
INSERT INTO [dbo].[Adaptibility] ([ID], [Overall], [Apartment], [NoviceOwners], [Sensitivity], [Alone], [ColdWeather], [HotWeather]) VALUES (4, 3, 1, 1, 4, 3, 5, 3)
INSERT INTO [dbo].[Adaptibility] ([ID], [Overall], [Apartment], [NoviceOwners], [Sensitivity], [Alone], [ColdWeather], [HotWeather]) VALUES (5, 3, 2, 3, 5, 1, 3, 3)
INSERT INTO [dbo].[Adaptibility] ([ID], [Overall], [Apartment], [NoviceOwners], [Sensitivity], [Alone], [ColdWeather], [HotWeather]) VALUES (6, 3, 1, 3, 5, 2, 3, 3)
INSERT INTO [dbo].[Adaptibility] ([ID], [Overall], [Apartment], [NoviceOwners], [Sensitivity], [Alone], [ColdWeather], [HotWeather]) VALUES (7, 3, 5, 4, 5, 1, 1, 2)
INSERT INTO [dbo].[Adaptibility] ([ID], [Overall], [Apartment], [NoviceOwners], [Sensitivity], [Alone], [ColdWeather], [HotWeather]) VALUES (8, 3, 5, 5, 3, 1, 2, 1)
SET IDENTITY_INSERT [dbo].[Adaptibility] OFF

SET IDENTITY_INSERT [dbo].[Exercise] ON
INSERT INTO [dbo].[Exercise] ([ID], [Overall], [EnergyLevel], [Intensity], [ExerciseNeed], [Playfulness]) VALUES (1, 5, 5, 5, 5, 5)
INSERT INTO [dbo].[Exercise] ([ID], [Overall], [EnergyLevel], [Intensity], [ExerciseNeed], [Playfulness]) VALUES (2, 5, 5, 3, 5, 5)
INSERT INTO [dbo].[Exercise] ([ID], [Overall], [EnergyLevel], [Intensity], [ExerciseNeed], [Playfulness]) VALUES (3, 5, 5, 3, 5, 5)
INSERT INTO [dbo].[Exercise] ([ID], [Overall], [EnergyLevel], [Intensity], [ExerciseNeed], [Playfulness]) VALUES (4, 5, 5, 5, 5, 4)
INSERT INTO [dbo].[Exercise] ([ID], [Overall], [EnergyLevel], [Intensity], [ExerciseNeed], [Playfulness]) VALUES (5, 4, 5, 2, 5, 5)
INSERT INTO [dbo].[Exercise] ([ID], [Overall], [EnergyLevel], [Intensity], [ExerciseNeed], [Playfulness]) VALUES (6, 5, 5, 5, 5, 5)
INSERT INTO [dbo].[Exercise] ([ID], [Overall], [EnergyLevel], [Intensity], [ExerciseNeed], [Playfulness]) VALUES (7, 3, 3, 2, 1, 4)
INSERT INTO [dbo].[Exercise] ([ID], [Overall], [EnergyLevel], [Intensity], [ExerciseNeed], [Playfulness]) VALUES (8, 4, 3, 4, 2, 5)
SET IDENTITY_INSERT [dbo].[Exercise] OFF

SET IDENTITY_INSERT [dbo].[Friendliness] ON
INSERT INTO [dbo].[Friendliness] ([ID], [Overall], [WithFamily], [WithKids], [OtherDogs], [WithStrangers]) VALUES (1, 4, 5, 5, 2, 4)
INSERT INTO [dbo].[Friendliness] ([ID], [Overall], [WithFamily], [WithKids], [OtherDogs], [WithStrangers]) VALUES (2, 5, 5, 5, 5, 5)
INSERT INTO [dbo].[Friendliness] ([ID], [Overall], [WithFamily], [WithKids], [OtherDogs], [WithStrangers]) VALUES (3, 4, 5, 4, 3, 5)
INSERT INTO [dbo].[Friendliness] ([ID], [Overall], [WithFamily], [WithKids], [OtherDogs], [WithStrangers]) VALUES (4, 4, 5, 4, 4, 3)
INSERT INTO [dbo].[Friendliness] ([ID], [Overall], [WithFamily], [WithKids], [OtherDogs], [WithStrangers]) VALUES (5, 5, 5, 5, 5, 5)
INSERT INTO [dbo].[Friendliness] ([ID], [Overall], [WithFamily], [WithKids], [OtherDogs], [WithStrangers]) VALUES (6, 5, 5, 5, 5, 5)
INSERT INTO [dbo].[Friendliness] ([ID], [Overall], [WithFamily], [WithKids], [OtherDogs], [WithStrangers]) VALUES (7, 4, 5, 5, 2, 2)
INSERT INTO [dbo].[Friendliness] ([ID], [Overall], [WithFamily], [WithKids], [OtherDogs], [WithStrangers]) VALUES (8, 4, 5, 4, 4, 4)
SET IDENTITY_INSERT [dbo].[Friendliness] OFF

SET IDENTITY_INSERT [dbo].[Grooming] ON
INSERT INTO [dbo].[Grooming] ([ID], [Overall], [Shedding], [Drool], [Easiness]) VALUES (1, 4, 5, 1, 5)
INSERT INTO [dbo].[Grooming] ([ID], [Overall], [Shedding], [Drool], [Easiness]) VALUES (2, 3, 3, 3, 2)
INSERT INTO [dbo].[Grooming] ([ID], [Overall], [Shedding], [Drool], [Easiness]) VALUES (3, 3, 3, 1, 3)
INSERT INTO [dbo].[Grooming] ([ID], [Overall], [Shedding], [Drool], [Easiness]) VALUES (4, 4, 5, 2, 4)
INSERT INTO [dbo].[Grooming] ([ID], [Overall], [Shedding], [Drool], [Easiness]) VALUES (5, 4, 5, 4, 2)
INSERT INTO [dbo].[Grooming] ([ID], [Overall], [Shedding], [Drool], [Easiness]) VALUES (6, 4, 5, 3, 5)
INSERT INTO [dbo].[Grooming] ([ID], [Overall], [Shedding], [Drool], [Easiness]) VALUES (7, 2, 2, 1, 5)
INSERT INTO [dbo].[Grooming] ([ID], [Overall], [Shedding], [Drool], [Easiness]) VALUES (8, 3, 3, 1, 5)
SET IDENTITY_INSERT [dbo].[Grooming] OFF

SET IDENTITY_INSERT [dbo].[Health] ON
INSERT INTO [dbo].[Health] ([ID], [Overall], [General], [WeightGain], [Size]) VALUES (1, 4, 4, 2, 4)
INSERT INTO [dbo].[Health] ([ID], [Overall], [General], [WeightGain], [Size]) VALUES (2, 3, 4, 2, 3)
INSERT INTO [dbo].[Health] ([ID], [Overall], [General], [WeightGain], [Size]) VALUES (3, 3, 2, 3, 3)
INSERT INTO [dbo].[Health] ([ID], [Overall], [General], [WeightGain], [Size]) VALUES (4, 4, 2, 4, 5)
INSERT INTO [dbo].[Health] ([ID], [Overall], [General], [WeightGain], [Size]) VALUES (5, 4, 2, 5, 3)
INSERT INTO [dbo].[Health] ([ID], [Overall], [General], [WeightGain], [Size]) VALUES (6, 4, 3, 5, 4)
INSERT INTO [dbo].[Health] ([ID], [Overall], [General], [WeightGain], [Size]) VALUES (7, 2, 2, 3, 1)
INSERT INTO [dbo].[Health] ([ID], [Overall], [General], [WeightGain], [Size]) VALUES (8, 3, 2, 4, 2)
SET IDENTITY_INSERT [dbo].[Health] OFF

SET IDENTITY_INSERT [dbo].[Training] ON
INSERT INTO [dbo].[Training] ([ID], [Overall], [Easiness], [Intelligence], [Mouthiness], [PreyDrive], [Barking], [Wanderlust]) VALUES (1, 4, 5, 5, 5, 4, 4, 2)
INSERT INTO [dbo].[Training] ([ID], [Overall], [Easiness], [Intelligence], [Mouthiness], [PreyDrive], [Barking], [Wanderlust]) VALUES (2, 4, 2, 3, 4, 3, 5, 5)
INSERT INTO [dbo].[Training] ([ID], [Overall], [Easiness], [Intelligence], [Mouthiness], [PreyDrive], [Barking], [Wanderlust]) VALUES (3, 4, 5, 5, 3, 3, 2, 3)
INSERT INTO [dbo].[Training] ([ID], [Overall], [Easiness], [Intelligence], [Mouthiness], [PreyDrive], [Barking], [Wanderlust]) VALUES (4, 4, 1, 4, 2, 5, 5, 5)
INSERT INTO [dbo].[Training] ([ID], [Overall], [Easiness], [Intelligence], [Mouthiness], [PreyDrive], [Barking], [Wanderlust]) VALUES (5, 4, 5, 5, 5, 3, 3, 2)
INSERT INTO [dbo].[Training] ([ID], [Overall], [Easiness], [Intelligence], [Mouthiness], [PreyDrive], [Barking], [Wanderlust]) VALUES (6, 4, 5, 5, 5, 2, 4, 3)
INSERT INTO [dbo].[Training] ([ID], [Overall], [Easiness], [Intelligence], [Mouthiness], [PreyDrive], [Barking], [Wanderlust]) VALUES (7, 3, 4, 4, 3, 3, 3, 2)
INSERT INTO [dbo].[Training] ([ID], [Overall], [Easiness], [Intelligence], [Mouthiness], [PreyDrive], [Barking], [Wanderlust]) VALUES (8, 3, 4, 3, 3, 2, 3, 2)
SET IDENTITY_INSERT [dbo].[Training] OFF
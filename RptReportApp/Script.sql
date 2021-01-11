CREATE TABLE [dbo].[Datas] (
    [Id]                                INT           IDENTITY (1, 1) NOT NULL,
    [EnrolleeNumber]                    NVARCHAR (50) NULL,
    [Company]                           NVARCHAR (50) NULL,
    [Hospital]                          NVARCHAR (50) NULL,
    [LastName]                          NVARCHAR (50) NULL,
    [OtherName]                         NVARCHAR (50) NULL,
    [Plan]                              NVARCHAR (50) NULL,
    [FeeForService]                     NVARCHAR (50) NULL,
    [Capitation]                        NVARCHAR (50) NULL,
    [PremiumPerIndividual]              NVARCHAR (50) NULL,
    [CommissionPerIndividualPercentage] NVARCHAR (50) NULL,
    [Date]                              NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


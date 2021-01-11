CREATE TABLE [dbo].[Datas] (
    [Id]                                INT           IDENTITY (1, 1) NOT NULL,
    [EnrolleeNumber]                    NVARCHAR (50) NULL,
    [Company]                           NVARCHAR (50) NULL,
    [Hospital]                          NVARCHAR (50) NULL,
    [LastName]                          NVARCHAR (50) NULL,
    [OtherName]                         NVARCHAR (50) NULL,
    [Plan]                              NVARCHAR (50) NULL,
    [FeeForService]                     DECIMAL (18)  NULL,
    [Capitation]                        DECIMAL (18)  NULL,
    [PremiumPerIndividual]              DECIMAL (18)  NULL,
    [CommissionPerIndividualPercentage] DECIMAL (18)  NULL,
    [Date]                              DATETIME NULL,
    [Address1]                          NVARCHAR (50) NULL,
    [Address2]                          NVARCHAR (50) NULL,
    [State]                             NVARCHAR (50) NULL,
    [PhoneNumber]                       NVARCHAR (50) NULL,
    [Gender]                            NVARCHAR (50) NULL,
    [Email]                             NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


CREATE TABLE [dbo].[Table] (
    [Id]       INT           IDENTITY (1, 1) NOT NULL,
    [Name]     NVARCHAR (50) NOT NULL,
    [Position] NVARCHAR (50) NULL,
    [Pick]     NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


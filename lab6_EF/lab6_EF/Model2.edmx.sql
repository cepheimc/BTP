
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 01/10/2018 00:46:06
-- Generated from EDMX file: C:\Users\Alina\Source\Repos\BTP\lab6_EF\lab6_EF\Model2.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Model.Route];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_RouteBus]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Buss] DROP CONSTRAINT [FK_RouteBus];
GO
IF OBJECT_ID(N'[dbo].[FK_RouteLink]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Links] DROP CONSTRAINT [FK_RouteLink];
GO
IF OBJECT_ID(N'[dbo].[FK_LinkStation_Link]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[LinkStation] DROP CONSTRAINT [FK_LinkStation_Link];
GO
IF OBJECT_ID(N'[dbo].[FK_LinkStation_Station]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[LinkStation] DROP CONSTRAINT [FK_LinkStation_Station];
GO
IF OBJECT_ID(N'[dbo].[FK_StationLink]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Links] DROP CONSTRAINT [FK_StationLink];
GO
IF OBJECT_ID(N'[dbo].[FK_StationLink1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Links] DROP CONSTRAINT [FK_StationLink1];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Routes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Routes];
GO
IF OBJECT_ID(N'[dbo].[Stations]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Stations];
GO
IF OBJECT_ID(N'[dbo].[Buss]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Buss];
GO
IF OBJECT_ID(N'[dbo].[Links]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Links];
GO
IF OBJECT_ID(N'[dbo].[LinkStation]', 'U') IS NOT NULL
    DROP TABLE [dbo].[LinkStation];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Routes'
CREATE TABLE [dbo].[Routes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [count] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Stations'
CREATE TABLE [dbo].[Stations] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Buss'
CREATE TABLE [dbo].[Buss] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [number] nvarchar(max)  NOT NULL,
    [RouteId] int  NOT NULL
);
GO

-- Creating table 'Links'
CREATE TABLE [dbo].[Links] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [time] nvarchar(max)  NOT NULL,
    [RouteId] int  NOT NULL,
    [StationId] int  NOT NULL,
    [StationId1] int  NOT NULL
);
GO

-- Creating table 'LinkStation'
CREATE TABLE [dbo].[LinkStation] (
    [Linkss_Id] int  NOT NULL,
    [Stationss_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Routes'
ALTER TABLE [dbo].[Routes]
ADD CONSTRAINT [PK_Routes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Stations'
ALTER TABLE [dbo].[Stations]
ADD CONSTRAINT [PK_Stations]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Buss'
ALTER TABLE [dbo].[Buss]
ADD CONSTRAINT [PK_Buss]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Links'
ALTER TABLE [dbo].[Links]
ADD CONSTRAINT [PK_Links]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Linkss_Id], [Stationss_Id] in table 'LinkStation'
ALTER TABLE [dbo].[LinkStation]
ADD CONSTRAINT [PK_LinkStation]
    PRIMARY KEY CLUSTERED ([Linkss_Id], [Stationss_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [RouteId] in table 'Buss'
ALTER TABLE [dbo].[Buss]
ADD CONSTRAINT [FK_RouteBus]
    FOREIGN KEY ([RouteId])
    REFERENCES [dbo].[Routes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_RouteBus'
CREATE INDEX [IX_FK_RouteBus]
ON [dbo].[Buss]
    ([RouteId]);
GO

-- Creating foreign key on [RouteId] in table 'Links'
ALTER TABLE [dbo].[Links]
ADD CONSTRAINT [FK_RouteLink]
    FOREIGN KEY ([RouteId])
    REFERENCES [dbo].[Routes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_RouteLink'
CREATE INDEX [IX_FK_RouteLink]
ON [dbo].[Links]
    ([RouteId]);
GO

-- Creating foreign key on [Linkss_Id] in table 'LinkStation'
ALTER TABLE [dbo].[LinkStation]
ADD CONSTRAINT [FK_LinkStation_Link]
    FOREIGN KEY ([Linkss_Id])
    REFERENCES [dbo].[Links]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Stationss_Id] in table 'LinkStation'
ALTER TABLE [dbo].[LinkStation]
ADD CONSTRAINT [FK_LinkStation_Station]
    FOREIGN KEY ([Stationss_Id])
    REFERENCES [dbo].[Stations]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_LinkStation_Station'
CREATE INDEX [IX_FK_LinkStation_Station]
ON [dbo].[LinkStation]
    ([Stationss_Id]);
GO

-- Creating foreign key on [StationId] in table 'Links'
ALTER TABLE [dbo].[Links]
ADD CONSTRAINT [FK_StationLink]
    FOREIGN KEY ([StationId])
    REFERENCES [dbo].[Stations]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_StationLink'
CREATE INDEX [IX_FK_StationLink]
ON [dbo].[Links]
    ([StationId]);
GO

-- Creating foreign key on [StationId1] in table 'Links'
ALTER TABLE [dbo].[Links]
ADD CONSTRAINT [FK_StationLink1]
    FOREIGN KEY ([StationId1])
    REFERENCES [dbo].[Stations]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_StationLink1'
CREATE INDEX [IX_FK_StationLink1]
ON [dbo].[Links]
    ([StationId1]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------
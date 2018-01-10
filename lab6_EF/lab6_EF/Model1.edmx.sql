
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 12/29/2017 13:51:08
-- Generated from EDMX file: C:\Users\Alina\Source\Repos\BTP\lab6_EF\lab6_EF\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ModelFirst.Route];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'RouteSet'
CREATE TABLE [dbo].[RouteSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [count] nvarchar(max)  NOT NULL,
    [xxx] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'BusSet'
CREATE TABLE [dbo].[BusSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [number] nvarchar(max)  NOT NULL,
    [RouteId] int  NOT NULL
);
GO

-- Creating table 'StationsSet'
CREATE TABLE [dbo].[StationsSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [nameS] nvarchar(max)  NOT NULL,
    [RouteId] int  NOT NULL
);
GO

-- Creating table 'LinkSet'
CREATE TABLE [dbo].[LinkSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [time] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'StationsLink'
CREATE TABLE [dbo].[StationsLink] (
    [Stations_Id] int  NOT NULL,
    [Link_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'RouteSet'
ALTER TABLE [dbo].[RouteSet]
ADD CONSTRAINT [PK_RouteSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'BusSet'
ALTER TABLE [dbo].[BusSet]
ADD CONSTRAINT [PK_BusSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'StationsSet'
ALTER TABLE [dbo].[StationsSet]
ADD CONSTRAINT [PK_StationsSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'LinkSet'
ALTER TABLE [dbo].[LinkSet]
ADD CONSTRAINT [PK_LinkSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Stations_Id], [Link_Id] in table 'StationsLink'
ALTER TABLE [dbo].[StationsLink]
ADD CONSTRAINT [PK_StationsLink]
    PRIMARY KEY CLUSTERED ([Stations_Id], [Link_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Stations_Id] in table 'StationsLink'
ALTER TABLE [dbo].[StationsLink]
ADD CONSTRAINT [FK_StationsLink_Stations]
    FOREIGN KEY ([Stations_Id])
    REFERENCES [dbo].[StationsSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Link_Id] in table 'StationsLink'
ALTER TABLE [dbo].[StationsLink]
ADD CONSTRAINT [FK_StationsLink_Link]
    FOREIGN KEY ([Link_Id])
    REFERENCES [dbo].[LinkSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_StationsLink_Link'
CREATE INDEX [IX_FK_StationsLink_Link]
ON [dbo].[StationsLink]
    ([Link_Id]);
GO

-- Creating foreign key on [RouteId] in table 'BusSet'
ALTER TABLE [dbo].[BusSet]
ADD CONSTRAINT [FK_RouteBus]
    FOREIGN KEY ([RouteId])
    REFERENCES [dbo].[RouteSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_RouteBus'
CREATE INDEX [IX_FK_RouteBus]
ON [dbo].[BusSet]
    ([RouteId]);
GO

-- Creating foreign key on [RouteId] in table 'StationsSet'
ALTER TABLE [dbo].[StationsSet]
ADD CONSTRAINT [FK_RouteStations]
    FOREIGN KEY ([RouteId])
    REFERENCES [dbo].[RouteSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_RouteStations'
CREATE INDEX [IX_FK_RouteStations]
ON [dbo].[StationsSet]
    ([RouteId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------
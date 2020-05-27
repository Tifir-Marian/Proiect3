
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/22/2020 22:20:44
-- Generated from EDMX file: F:\Facultate\C#\IncercareProiect3\DataBase\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [MyPhotos];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Photos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Photos];
GO
IF OBJECT_ID(N'[dbo].[Folders]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Folders];
GO
IF OBJECT_ID(N'[dbo].[PhotoPlacements]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PhotoPlacements];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Photos'
CREATE TABLE [dbo].[Photos] (
    [Id] nvarchar(max)  NOT NULL,
    [CreationDate] datetime  NOT NULL,
    [TypeOfPhoto] nvarchar(max)  NOT NULL,
    [Location] nvarchar(max)  NOT NULL,
    [Path] nvarchar(max)  NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Folders'
CREATE TABLE [dbo].[Folders] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [CreationDate] datetime  NOT NULL
);
GO

-- Creating table 'PhotoPlacements'
CREATE TABLE [dbo].[PhotoPlacements] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Photo_ID] bigint  NOT NULL,
    [Folder_ID] bigint  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Photos'
ALTER TABLE [dbo].[Photos]
ADD CONSTRAINT [PK_Photos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Folders'
ALTER TABLE [dbo].[Folders]
ADD CONSTRAINT [PK_Folders]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PhotoPlacements'
ALTER TABLE [dbo].[PhotoPlacements]
ADD CONSTRAINT [PK_PhotoPlacements]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------
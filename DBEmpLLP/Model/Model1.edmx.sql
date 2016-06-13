
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/14/2016 13:27:58
-- Generated from EDMX file: F:\作业\小实训（U3D应用）\刘立普月考\刘立普月考\DBEmpLLP\Model\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [DBEmpLLP];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_emp_dept]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[emp] DROP CONSTRAINT [FK_emp_dept];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[dept]', 'U') IS NOT NULL
    DROP TABLE [dbo].[dept];
GO
IF OBJECT_ID(N'[dbo].[emp]', 'U') IS NOT NULL
    DROP TABLE [dbo].[emp];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'dept'
CREATE TABLE [dbo].[dept] (
    [DId] int IDENTITY(1,1) NOT NULL,
    [DName] nvarchar(max)  NOT NULL,
    [Ddrre] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'emp'
CREATE TABLE [dbo].[emp] (
    [EId] int IDENTITY(1,1) NOT NULL,
    [EName] nvarchar(max)  NOT NULL,
    [Ezhiw] nvarchar(max)  NOT NULL,
    [ETime] nvarchar(max)  NOT NULL,
    [Ejiben] int  NOT NULL,
    [Ejiangjin] int  NOT NULL,
    [Eddre] varchar(50)  NOT NULL,
    [DId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [DId] in table 'dept'
ALTER TABLE [dbo].[dept]
ADD CONSTRAINT [PK_dept]
    PRIMARY KEY CLUSTERED ([DId] ASC);
GO

-- Creating primary key on [EId] in table 'emp'
ALTER TABLE [dbo].[emp]
ADD CONSTRAINT [PK_emp]
    PRIMARY KEY CLUSTERED ([EId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [DId] in table 'emp'
ALTER TABLE [dbo].[emp]
ADD CONSTRAINT [FK_emp_dept]
    FOREIGN KEY ([DId])
    REFERENCES [dbo].[dept]
        ([DId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_emp_dept'
CREATE INDEX [IX_FK_emp_dept]
ON [dbo].[emp]
    ([DId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------
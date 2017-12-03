
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 12/01/2017 17:20:17
-- Generated from EDMX file: D:\Restaurante\BibliotecaSQL\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Restaurante];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_detalle_pedido_menu]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[detalle_pedido] DROP CONSTRAINT [FK_detalle_pedido_menu];
GO
IF OBJECT_ID(N'[dbo].[FK_detalle_pedido_pedido]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[detalle_pedido] DROP CONSTRAINT [FK_detalle_pedido_pedido];
GO
IF OBJECT_ID(N'[dbo].[FK_pedido_cliente]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[pedido] DROP CONSTRAINT [FK_pedido_cliente];
GO
IF OBJECT_ID(N'[dbo].[FK_venta_pedido]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[venta] DROP CONSTRAINT [FK_venta_pedido];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[cliente]', 'U') IS NOT NULL
    DROP TABLE [dbo].[cliente];
GO
IF OBJECT_ID(N'[dbo].[detalle_pedido]', 'U') IS NOT NULL
    DROP TABLE [dbo].[detalle_pedido];
GO
IF OBJECT_ID(N'[dbo].[menu]', 'U') IS NOT NULL
    DROP TABLE [dbo].[menu];
GO
IF OBJECT_ID(N'[dbo].[pedido]', 'U') IS NOT NULL
    DROP TABLE [dbo].[pedido];
GO
IF OBJECT_ID(N'[dbo].[sysdiagrams]', 'U') IS NOT NULL
    DROP TABLE [dbo].[sysdiagrams];
GO
IF OBJECT_ID(N'[dbo].[usuario]', 'U') IS NOT NULL
    DROP TABLE [dbo].[usuario];
GO
IF OBJECT_ID(N'[dbo].[venta]', 'U') IS NOT NULL
    DROP TABLE [dbo].[venta];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'cliente'
CREATE TABLE [dbo].[cliente] (
    [id_cliente] int IDENTITY(1,1) NOT NULL,
    [nombre] varchar(50)  NULL,
    [rut] varchar(50)  NULL
);
GO

-- Creating table 'detalle_pedido'
CREATE TABLE [dbo].[detalle_pedido] (
    [id_detalle] int IDENTITY(1,1) NOT NULL,
    [pedido_id] int  NULL,
    [menu_id] int  NULL
);
GO

-- Creating table 'menu'
CREATE TABLE [dbo].[menu] (
    [id_menu] int IDENTITY(1,1) NOT NULL,
    [descripcion] varchar(50)  NULL,
    [precio] int  NULL
);
GO

-- Creating table 'pedido'
CREATE TABLE [dbo].[pedido] (
    [id_pedido] int IDENTITY(1,1) NOT NULL,
    [descripcion] varchar(50)  NOT NULL,
    [cliente_id] int  NULL
);
GO

-- Creating table 'usuario'
CREATE TABLE [dbo].[usuario] (
    [username] varchar(50)  NOT NULL,
    [password] varchar(50)  NOT NULL,
    [id] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'sysdiagrams'
CREATE TABLE [dbo].[sysdiagrams] (
    [name] nvarchar(128)  NOT NULL,
    [principal_id] int  NOT NULL,
    [diagram_id] int IDENTITY(1,1) NOT NULL,
    [version] int  NULL,
    [definition] varbinary(max)  NULL
);
GO

-- Creating table 'venta'
CREATE TABLE [dbo].[venta] (
    [id_venta] int  NOT NULL,
    [subtotal] int  NULL,
    [propina] int  NOT NULL,
    [total] int  NULL,
    [pedido_id] int  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [id_cliente] in table 'cliente'
ALTER TABLE [dbo].[cliente]
ADD CONSTRAINT [PK_cliente]
    PRIMARY KEY CLUSTERED ([id_cliente] ASC);
GO

-- Creating primary key on [id_detalle] in table 'detalle_pedido'
ALTER TABLE [dbo].[detalle_pedido]
ADD CONSTRAINT [PK_detalle_pedido]
    PRIMARY KEY CLUSTERED ([id_detalle] ASC);
GO

-- Creating primary key on [id_menu] in table 'menu'
ALTER TABLE [dbo].[menu]
ADD CONSTRAINT [PK_menu]
    PRIMARY KEY CLUSTERED ([id_menu] ASC);
GO

-- Creating primary key on [id_pedido] in table 'pedido'
ALTER TABLE [dbo].[pedido]
ADD CONSTRAINT [PK_pedido]
    PRIMARY KEY CLUSTERED ([id_pedido] ASC);
GO

-- Creating primary key on [id] in table 'usuario'
ALTER TABLE [dbo].[usuario]
ADD CONSTRAINT [PK_usuario]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [diagram_id] in table 'sysdiagrams'
ALTER TABLE [dbo].[sysdiagrams]
ADD CONSTRAINT [PK_sysdiagrams]
    PRIMARY KEY CLUSTERED ([diagram_id] ASC);
GO

-- Creating primary key on [id_venta] in table 'venta'
ALTER TABLE [dbo].[venta]
ADD CONSTRAINT [PK_venta]
    PRIMARY KEY CLUSTERED ([id_venta] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [cliente_id] in table 'pedido'
ALTER TABLE [dbo].[pedido]
ADD CONSTRAINT [FK_pedido_cliente]
    FOREIGN KEY ([cliente_id])
    REFERENCES [dbo].[cliente]
        ([id_cliente])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_pedido_cliente'
CREATE INDEX [IX_FK_pedido_cliente]
ON [dbo].[pedido]
    ([cliente_id]);
GO

-- Creating foreign key on [menu_id] in table 'detalle_pedido'
ALTER TABLE [dbo].[detalle_pedido]
ADD CONSTRAINT [FK_detalle_pedido_menu]
    FOREIGN KEY ([menu_id])
    REFERENCES [dbo].[menu]
        ([id_menu])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_detalle_pedido_menu'
CREATE INDEX [IX_FK_detalle_pedido_menu]
ON [dbo].[detalle_pedido]
    ([menu_id]);
GO

-- Creating foreign key on [pedido_id] in table 'detalle_pedido'
ALTER TABLE [dbo].[detalle_pedido]
ADD CONSTRAINT [FK_detalle_pedido_pedido]
    FOREIGN KEY ([pedido_id])
    REFERENCES [dbo].[pedido]
        ([id_pedido])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_detalle_pedido_pedido'
CREATE INDEX [IX_FK_detalle_pedido_pedido]
ON [dbo].[detalle_pedido]
    ([pedido_id]);
GO

-- Creating foreign key on [pedido_id] in table 'venta'
ALTER TABLE [dbo].[venta]
ADD CONSTRAINT [FK_venta_pedido]
    FOREIGN KEY ([pedido_id])
    REFERENCES [dbo].[pedido]
        ([id_pedido])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_venta_pedido'
CREATE INDEX [IX_FK_venta_pedido]
ON [dbo].[venta]
    ([pedido_id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------
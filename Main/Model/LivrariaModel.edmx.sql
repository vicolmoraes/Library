
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/05/2017 21:35:52
-- Generated from EDMX file: C:\Users\Note\Documents\Livraria\Main\Model\LivrariaModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [livrariaDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_EditoraLivro]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Livro] DROP CONSTRAINT [FK_EditoraLivro];
GO
IF OBJECT_ID(N'[dbo].[FK_LivroItem]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Item] DROP CONSTRAINT [FK_LivroItem];
GO
IF OBJECT_ID(N'[dbo].[FK_ItemPedido]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Item] DROP CONSTRAINT [FK_ItemPedido];
GO
IF OBJECT_ID(N'[dbo].[FK_PedidoCliente]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pedido] DROP CONSTRAINT [FK_PedidoCliente];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Editora]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Editora];
GO
IF OBJECT_ID(N'[dbo].[Livro]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Livro];
GO
IF OBJECT_ID(N'[dbo].[Item]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Item];
GO
IF OBJECT_ID(N'[dbo].[Pedido]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Pedido];
GO
IF OBJECT_ID(N'[dbo].[Cliente]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Cliente];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Editora'
CREATE TABLE [dbo].[Editora] (
    [IdEditora] int IDENTITY(1,1) NOT NULL,
    [NomeEditora] nvarchar(max)  NOT NULL,
    [TelefoneEditora] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Livro'
CREATE TABLE [dbo].[Livro] (
    [IdLivro] int IDENTITY(1,1) NOT NULL,
    [IdEditora] int  NOT NULL,
    [NomeLivro] nvarchar(max)  NOT NULL,
    [Categoria] nvarchar(max)  NOT NULL,
    [Preco] float  NOT NULL,
    [Edicao] nvarchar(max)  NOT NULL,
    [Autor] nvarchar(max)  NOT NULL,
    [Estoque] int  NOT NULL
);
GO

-- Creating table 'Item'
CREATE TABLE [dbo].[Item] (
    [IdItem] int IDENTITY(1,1) NOT NULL,
    [IdLivro] int  NOT NULL,
    [IdPedido] int  NOT NULL,
    [Quantidade] int  NOT NULL
);
GO

-- Creating table 'Pedido'
CREATE TABLE [dbo].[Pedido] (
    [IdPedido] int IDENTITY(1,1) NOT NULL,
    [IdCliente] int  NOT NULL,
    [DataPedido] datetime  NOT NULL,
    [ValorPedido] float  NOT NULL
);
GO

-- Creating table 'Cliente'
CREATE TABLE [dbo].[Cliente] (
    [IdCliente] int IDENTITY(1,1) NOT NULL,
    [NomeCliente] nvarchar(max)  NOT NULL,
    [TelefoneCliente] nvarchar(max)  NOT NULL,
    [CPF] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [IdEditora] in table 'Editora'
ALTER TABLE [dbo].[Editora]
ADD CONSTRAINT [PK_Editora]
    PRIMARY KEY CLUSTERED ([IdEditora] ASC);
GO

-- Creating primary key on [IdLivro] in table 'Livro'
ALTER TABLE [dbo].[Livro]
ADD CONSTRAINT [PK_Livro]
    PRIMARY KEY CLUSTERED ([IdLivro] ASC);
GO

-- Creating primary key on [IdItem] in table 'Item'
ALTER TABLE [dbo].[Item]
ADD CONSTRAINT [PK_Item]
    PRIMARY KEY CLUSTERED ([IdItem] ASC);
GO

-- Creating primary key on [IdPedido] in table 'Pedido'
ALTER TABLE [dbo].[Pedido]
ADD CONSTRAINT [PK_Pedido]
    PRIMARY KEY CLUSTERED ([IdPedido] ASC);
GO

-- Creating primary key on [IdCliente] in table 'Cliente'
ALTER TABLE [dbo].[Cliente]
ADD CONSTRAINT [PK_Cliente]
    PRIMARY KEY CLUSTERED ([IdCliente] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [IdEditora] in table 'Livro'
ALTER TABLE [dbo].[Livro]
ADD CONSTRAINT [FK_EditoraLivro]
    FOREIGN KEY ([IdEditora])
    REFERENCES [dbo].[Editora]
        ([IdEditora])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EditoraLivro'
CREATE INDEX [IX_FK_EditoraLivro]
ON [dbo].[Livro]
    ([IdEditora]);
GO

-- Creating foreign key on [IdLivro] in table 'Item'
ALTER TABLE [dbo].[Item]
ADD CONSTRAINT [FK_LivroItem]
    FOREIGN KEY ([IdLivro])
    REFERENCES [dbo].[Livro]
        ([IdLivro])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_LivroItem'
CREATE INDEX [IX_FK_LivroItem]
ON [dbo].[Item]
    ([IdLivro]);
GO

-- Creating foreign key on [IdPedido] in table 'Item'
ALTER TABLE [dbo].[Item]
ADD CONSTRAINT [FK_ItemPedido]
    FOREIGN KEY ([IdPedido])
    REFERENCES [dbo].[Pedido]
        ([IdPedido])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ItemPedido'
CREATE INDEX [IX_FK_ItemPedido]
ON [dbo].[Item]
    ([IdPedido]);
GO

-- Creating foreign key on [IdCliente] in table 'Pedido'
ALTER TABLE [dbo].[Pedido]
ADD CONSTRAINT [FK_PedidoCliente]
    FOREIGN KEY ([IdCliente])
    REFERENCES [dbo].[Cliente]
        ([IdCliente])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PedidoCliente'
CREATE INDEX [IX_FK_PedidoCliente]
ON [dbo].[Pedido]
    ([IdCliente]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------
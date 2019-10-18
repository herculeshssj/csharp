-- Script de criação da base de dados usada neste projeto

USE [master];

CREATE DATABASE [livraria];

ALTER DATABASE [livraria] SET COMPATIBILITY_LEVEL = 100;

USE [livraria];

CREATE TABLE [dbo].[Editoras](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](255) NOT NULL,
	[Email] [varchar](255) NOT NULL,
 CONSTRAINT [PK_Editoras] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
));

CREATE TABLE [dbo].[Livros](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Titulo] [varchar](255) NOT NULL,
	[Preco] [float] NOT NULL,
	[EditoraId] [bigint] NOT NULL,
 CONSTRAINT [PK_Livros] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
));

ALTER TABLE [dbo].[Livros]  WITH CHECK ADD  CONSTRAINT [FK_Livros_Editoras] FOREIGN KEY([EditoraId])
REFERENCES [dbo].[Editoras] ([Id]);

ALTER TABLE [dbo].[Livros] CHECK CONSTRAINT [FK_Livros_Editoras];

-- insert into Editoras (Nome, Email) values ('Oreilly','oreilly@email.com');
-- insert into Editoras (Nome, Email) values ('Wrox','wrox@email.com');
-- insert into Editoras (Nome, Email) values ('Apress','apress@email.com');

-- insert into Livros(Titulo,Preco,EditoraId) values ('Aprendendo C#', 89.90, 1);
-- insert into Livros(Titulo,Preco,EditoraId) values ('Introdução a JSF 2', 122.90, 2);
-- insert into Livros(Titulo,Preco,EditoraId) values ('JSF 2 Avançado', 149.90, 3);

select * from editoras;
select * from Livros;
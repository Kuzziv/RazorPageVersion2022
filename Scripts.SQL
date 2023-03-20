--Create database RazorPageVersion2022DB;

--go

use RazorPageVersion2022DB;

--drop table Item;
--drop table Users;

CREATE TABLE [dbo].[Item] (
    [Id]    INT IDENTITY(1,1) PRIMARY KEY,
    [Name]  VARCHAR (50) NOT NULL,
    [Price] FLOAT (53)   NOT NULL
);


CREATE TABLE [dbo].[Users] (
    [Id]       INT IDENTITY(1,1) PRIMARY KEY,
    [UserName] VARCHAR (50)  NOT NULL,
    [Password] VARCHAR (200) NOT NULL
);


INSERT INTO [dbo].[Item] ([Id], [Name], [Price]) VALUES (N'PC', 5999)
INSERT INTO [dbo].[Item] ([Id], [Name], [Price]) VALUES (N'Skærm', 1999)
INSERT INTO [dbo].[Item] ([Id], [Name], [Price]) VALUES (N'Tastatur', 999)
INSERT INTO [dbo].[Item] ([Id], [Name], [Price]) VALUES (N'Mus', 850)


INSERT INTO [dbo].[Users] ([Id], [UserName], [Password]) VALUES (N'mads', N'1234')
INSERT INTO [dbo].[Users] ([Id], [UserName], [Password]) VALUES (N'geja', N'1234')
INSERT INTO [dbo].[Users] ([Id], [UserName], [Password]) VALUES (N'kuzziv', N'1234')
INSERT INTO [dbo].[Users] ([Id], [UserName], [Password]) VALUES (N'admin', N'1234')

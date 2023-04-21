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



INSERT INTO [dbo].[Users] ([Id], [UserName], [Password]) VALUES (N'admin', N'AQAAAAEAACcQAAAAEDyrGlFLkfP0FQriZWMjaUcj2tg41aWZzhDNAG1B6F1dkCXQ4CVgWXoklI3rblh3Cw==')
INSERT INTO [dbo].[Users] ([Id], [UserName], [Password]) VALUES (N'chris', N'AQAAAAEAACcQAAAAEOBNVxJuB1JVhS+68GYuHZLHGO706nj/zaj9y1ornMIP07XTCIUzbliox8QRLcNS1g==')
INSERT INTO [dbo].[Users] ([Id], [UserName], [Password]) VALUES (N'geja', N'AQAAAAEAACcQAAAAEE/MurlvQ5wNDoZaZfwbRzoWzzT6hbc7Hs9kitYpaH3Qrf8uP4wZ2cjjDIJbSvcwKA==')
INSERT INTO [dbo].[Users] ([Id], [UserName], [Password]) VALUES (N'kuzziv', N'AQAAAAEAACcQAAAAEFSFX+3AQRfM6Qud8xAKHL3RcHsLWGomP2No1Tlvd+gV/VMvAcRnEn8SucJ/OY9ifA==')
INSERT INTO [dbo].[Users] ([Id], [UserName], [Password]) VALUES (N'mads', N'AQAAAAEAACcQAAAAELdpka09pu0qUXzxmjLppZxaAdYJcavVLiVG024Hr5JRRUJMNL3hAzB6EEDJnGLeew==')
INSERT INTO [dbo].[Users] ([Id], [UserName], [Password]) VALUES (N'Tito', N'AQAAAAEAACcQAAAAEFNrwY/qTjmMKDS7JQApJ0OXwD8kn5ZZDVn6+okSPrC1CswZPEFJkxROpSfKX/fngg==')

SET IDENTITY_INSERT [dbo].[Users] ON
INSERT INTO [dbo].[Users] ([Id], [UserName], [Password]) VALUES (1, 'admin', 'AQAAAAEAACcQAAAAEDyrGlFLkfP0FQriZWMjaUcj2tg41aWZzhDNAG1B6F1dkCXQ4CVgWXoklI3rblh3Cw==')
INSERT INTO [dbo].[Users] ([Id], [UserName], [Password]) VALUES (2, 'chris', 'AQAAAAEAACcQAAAAEOBNVxJuB1JVhS+68GYuHZLHGO706nj/zaj9y1ornMIP07XTCIUzbliox8QRLcNS1g==')
INSERT INTO [dbo].[Users] ([Id], [UserName], [Password]) VALUES (3, 'geja', 'AQAAAAEAACcQAAAAEE/MurlvQ5wNDoZaZfwbRzoWzzT6hbc7Hs9kitYpaH3Qrf8uP4wZ2cjjDIJbSvcwKA==')
INSERT INTO [dbo].[Users] ([Id], [UserName], [Password]) VALUES (4, 'kuzziv', 'AQAAAAEAACcQAAAAEFSFX+3AQRfM6Qud8xAKHL3RcHsLWGomP2No1Tlvd+gV/VMvAcRnEn8SucJ/OY9ifA==')
INSERT INTO [dbo].[Users] ([Id], [UserName], [Password]) VALUES (5, 'mads', 'AQAAAAEAACcQAAAAELdpka09pu0qUXzxmjLppZxaAdYJcavVLiVG024Hr5JRRUJMNL3hAzB6EEDJnGLeew==')
INSERT INTO [dbo].[Users] ([Id], [UserName], [Password]) VALUES (6, 'Tito', 'AQAAAAEAACcQAAAAEFNrwY/qTjmMKDS7JQApJ0OXwD8kn5ZZDVn6+okSPrC1CswZPEFJkxROpSfKX/fngg==')
SET IDENTITY_INSERT [dbo].[Users] OFF

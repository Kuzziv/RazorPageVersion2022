--Create database RazorPageVersion2022DB;

--go

use RazorPageVersion2022DB;

--drop table Item;
--drop table Users;

CREATE TABLE [dbo].[Items] (
    [Id]    INT             IDENTITY (1, 1) NOT NULL,
    [Name]  NVARCHAR (100)  NOT NULL,
    [Price] DECIMAL (18, 2) NOT NULL,
    CONSTRAINT [PK_Items] PRIMARY KEY CLUSTERED ([Id] ASC)
);



CREATE TABLE [dbo].[Users] (
    [UserId]   INT            IDENTITY (1, 1) NOT NULL,
    [UserName] NVARCHAR (20)  NOT NULL,
    [Password] NVARCHAR (MAX) NOT NULL,
    CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED ([UserId] ASC)
);


SET IDENTITY_INSERT [dbo].[Items] ON
INSERT INTO [dbo].[Items] ([Id], [Name], [Price]) VALUES (1, N'PC', CAST(5999.00 AS Decimal(18, 2)))
INSERT INTO [dbo].[Items] ([Id], [Name], [Price]) VALUES (2, N'Skræm', CAST(1999.00 AS Decimal(18, 2)))
INSERT INTO [dbo].[Items] ([Id], [Name], [Price]) VALUES (3, N'Tastatur', CAST(999.00 AS Decimal(18, 2)))
INSERT INTO [dbo].[Items] ([Id], [Name], [Price]) VALUES (4, N'Mus', CAST(550.00 AS Decimal(18, 2)))
INSERT INTO [dbo].[Items] ([Id], [Name], [Price]) VALUES (5, N'Headset', CAST(1850.00 AS Decimal(18, 2)))
INSERT INTO [dbo].[Items] ([Id], [Name], [Price]) VALUES (9, N'CPU 3900x', CAST(2700.99 AS Decimal(18, 2)))
INSERT INTO [dbo].[Items] ([Id], [Name], [Price]) VALUES (10, N'RTX 3070TI', CAST(5850.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[Items] OFF


SET IDENTITY_INSERT [dbo].[Users] ON
INSERT INTO [dbo].[Users] ([UserId], [UserName], [Password]) VALUES (1, N'admin', N'AQAAAAEAACcQAAAAEDyrGlFLkfP0FQriZWMjaUcj2tg41aWZzhDNAG1B6F1dkCXQ4CVgWXoklI3rblh3Cw==')
INSERT INTO [dbo].[Users] ([UserId], [UserName], [Password]) VALUES (2, N'chris', N'AQAAAAEAACcQAAAAEOBNVxJuB1JVhS+68GYuHZLHGO706nj/zaj9y1ornMIP07XTCIUzbliox8QRLcNS1g==')
INSERT INTO [dbo].[Users] ([UserId], [UserName], [Password]) VALUES (3, N'geja', N'AQAAAAEAACcQAAAAEE/MurlvQ5wNDoZaZfwbRzoWzzT6hbc7Hs9kitYpaH3Qrf8uP4wZ2cjjDIJbSvcwKA==')
INSERT INTO [dbo].[Users] ([UserId], [UserName], [Password]) VALUES (4, N'kuzziv', N'AQAAAAEAACcQAAAAEFSFX+3AQRfM6Qud8xAKHL3RcHsLWGomP2No1Tlvd+gV/VMvAcRnEn8SucJ/OY9ifA==')
INSERT INTO [dbo].[Users] ([UserId], [UserName], [Password]) VALUES (5, N'mads', N'AQAAAAEAACcQAAAAELdpka09pu0qUXzxmjLppZxaAdYJcavVLiVG024Hr5JRRUJMNL3hAzB6EEDJnGLeew==')
INSERT INTO [dbo].[Users] ([UserId], [UserName], [Password]) VALUES (6, N'Tito', N'AQAAAAEAACcQAAAAEFNrwY/qTjmMKDS7JQApJ0OXwD8kn5ZZDVn6+okSPrC1CswZPEFJkxROpSfKX/fngg==')
INSERT INTO [dbo].[Users] ([UserId], [UserName], [Password]) VALUES (7, N'Mano', N'AQAAAAEAACcQAAAAEPENhLY6JHHNHuxz4a7on8puRkBWa6oFhx4trjI5IXdZwQJAsKiCV7tV0MhYq99OvA==')
INSERT INTO [dbo].[Users] ([UserId], [UserName], [Password]) VALUES (8, N'zohan', N'AQAAAAEAACcQAAAAEErAl0ADGbxiWtxmpuB/wPJM08gbY8ZwP19wGSlu5YG+J3NrNEEi3QP20oMcTp6RJA==')
SET IDENTITY_INSERT [dbo].[Users] OFF

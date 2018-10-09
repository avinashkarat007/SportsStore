CREATE TABLE [dbo].[Products] (
    [ProductID]     INT             IDENTITY (1, 1) NOT NULL,
    [Name]          NVARCHAR (100)  NOT NULL,
    [Description]   NVARCHAR (500)  NOT NULL,
    [Category]      NVARCHAR (50)   NOT NULL,
    [Price]         DECIMAL (16, 2) NOT NULL,
    PRIMARY KEY CLUSTERED ([ProductID] ASC)
);


ALTER TABLE [dbo].[Products]
ADD [ImageData] VARBINARY (MAX) NULL,
[ImageMimeType] VARCHAR (50) NULL;


SET IDENTITY_INSERT [dbo].[Products] ON
INSERT INTO [dbo].[Products] ([ProductID], [Name], [Description], [Category], [Price], [ImageData], [ImageMimeType]) VALUES (1, N'Green Kayak ', N'A boat for one person', N'WaterSports', CAST(275.00 AS Decimal(16, 2)), <SQLVARIANT>, NULL)
INSERT INTO [dbo].[Products] ([ProductID], [Name], [Description], [Category], [Price], [ImageData], [ImageMimeType]) VALUES (4, N'Lifejacket', N'Protective and fashionable', N'WaterSports', CAST(48.95 AS Decimal(16, 2)), <SQLVARIANT>, NULL)
INSERT INTO [dbo].[Products] ([ProductID], [Name], [Description], [Category], [Price], [ImageData], [ImageMimeType]) VALUES (5, N'Foot Ball', N'FIFA-approved size and weight', N'Soccer', CAST(20.56 AS Decimal(16, 2)), <SQLVARIANT>, NULL)
INSERT INTO [dbo].[Products] ([ProductID], [Name], [Description], [Category], [Price], [ImageData], [ImageMimeType]) VALUES (7, N'Thinking Cap', N'Improve your brain efficiency by 75%', N'Chess', CAST(15.88 AS Decimal(16, 2)), <SQLVARIANT>, NULL)
INSERT INTO [dbo].[Products] ([ProductID], [Name], [Description], [Category], [Price], [ImageData], [ImageMimeType]) VALUES (8, N'Chess Board', N'A fun game for the family', N'Chess', CAST(29.47 AS Decimal(16, 2)), <SQLVARIANT>, NULL)
INSERT INTO [dbo].[Products] ([ProductID], [Name], [Description], [Category], [Price], [ImageData], [ImageMimeType]) VALUES (9, N'Carroms Board', N'A fun game', N'Carroms', CAST(2500.00 AS Decimal(16, 2)), <SQLVARIANT>, NULL)
INSERT INTO [dbo].[Products] ([ProductID], [Name], [Description], [Category], [Price], [ImageData], [ImageMimeType]) VALUES (11, N'Baseball Bat', N'bat', N'Baseball', CAST(78.00 AS Decimal(16, 2)), <SQLVARIANT>, NULL)
INSERT INTO [dbo].[Products] ([ProductID], [Name], [Description], [Category], [Price], [ImageData], [ImageMimeType]) VALUES (12, N'Cricket Helmet', N'helmet', N'Cricket', CAST(234.00 AS Decimal(16, 2)), <SQLVARIANT>, NULL)
INSERT INTO [dbo].[Products] ([ProductID], [Name], [Description], [Category], [Price], [ImageData], [ImageMimeType]) VALUES (13, N'Stumps', N'stumps used for cricket', N'Cricket', CAST(458.00 AS Decimal(16, 2)), <SQLVARIANT>, NULL)
INSERT INTO [dbo].[Products] ([ProductID], [Name], [Description], [Category], [Price], [ImageData], [ImageMimeType]) VALUES (14, N'Swimming Shorts', N'shorts', N'Swimming', CAST(789.00 AS Decimal(16, 2)), <Binary Data>, N'image/jpeg')
SET IDENTITY_INSERT [dbo].[Products] OFF

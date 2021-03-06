USE [master]
GO
/****** Object:  Database [HiTechDB]    Script Date: 2017-04-18 1:05:37 PM ******/
CREATE DATABASE [HiTechDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'UsersEmployeesDB', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL12.MSSQLSERVER2014\MSSQL\DATA\UsersEmployeesDB.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'UsersEmployeesDB_log', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL12.MSSQLSERVER2014\MSSQL\DATA\UsersEmployeesDB_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [HiTechDB] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HiTechDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [HiTechDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [HiTechDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [HiTechDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [HiTechDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [HiTechDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [HiTechDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [HiTechDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [HiTechDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [HiTechDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [HiTechDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [HiTechDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [HiTechDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [HiTechDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [HiTechDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [HiTechDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [HiTechDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [HiTechDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [HiTechDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [HiTechDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [HiTechDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [HiTechDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [HiTechDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [HiTechDB] SET RECOVERY FULL 
GO
ALTER DATABASE [HiTechDB] SET  MULTI_USER 
GO
ALTER DATABASE [HiTechDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [HiTechDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [HiTechDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [HiTechDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [HiTechDB] SET DELAYED_DURABILITY = DISABLED 
GO
USE [HiTechDB]
GO
/****** Object:  Table [dbo].[Authors]    Script Date: 2017-04-18 1:05:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Authors](
	[AuthorID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Authors] PRIMARY KEY CLUSTERED 
(
	[AuthorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Categories]    Script Date: 2017-04-18 1:05:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[CategoryID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryDescription] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Clients]    Script Date: 2017-04-18 1:05:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clients](
	[ClientID] [int] IDENTITY(1,1) NOT NULL,
	[ClientName] [nvarchar](100) NOT NULL,
	[ClientStreet] [nvarchar](50) NOT NULL,
	[ClientCity] [nvarchar](50) NOT NULL,
	[ClientPostalCode] [nvarchar](50) NOT NULL,
	[ClientPhone] [nvarchar](50) NOT NULL,
	[ClientFax] [nvarchar](50) NOT NULL,
	[ClientMaxCredits] [int] NOT NULL,
 CONSTRAINT [PK_Clients] PRIMARY KEY CLUSTERED 
(
	[ClientID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Employees]    Script Date: 2017-04-18 1:05:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Employees](
	[EmployeeID] [int] IDENTITY(1111,1) NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[JobTitle] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Employeees] PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[OrderLine]    Script Date: 2017-04-18 1:05:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderLine](
	[OrderID] [int] NOT NULL,
	[ProductISBN] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[Price] [int] NULL,
 CONSTRAINT [PK_OrderLine] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC,
	[ProductISBN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Orders]    Script Date: 2017-04-18 1:05:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[OrderID] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeID] [int] NOT NULL,
	[ClientID] [int] NOT NULL,
	[OrderDate] [date] NOT NULL,
	[DeliverDate] [date] NULL,
	[ShippingDate] [date] NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Products]    Script Date: 2017-04-18 1:05:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ProductISBN] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](100) NOT NULL,
	[UnitPrice] [int] NOT NULL,
	[YearPublished] [int] NOT NULL,
	[QuantityOnHand] [int] NULL,
	[Type] [nvarchar](50) NOT NULL,
	[Category] [int] NOT NULL,
	[PublisherID] [int] NOT NULL,
	[AuthorID] [int] NOT NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[ProductISBN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Publishers]    Script Date: 2017-04-18 1:05:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Publishers](
	[PublisherID] [int] IDENTITY(1,1) NOT NULL,
	[PublisherName] [nvarchar](100) NOT NULL,
	[PublisherDescription] [nvarchar](max) NULL,
 CONSTRAINT [PK_Publishers] PRIMARY KEY CLUSTERED 
(
	[PublisherID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Users]    Script Date: 2017-04-18 1:05:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Users](
	[UserName] [varchar](10) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[EmployeeID] [int] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Authors] ON 

INSERT [dbo].[Authors] ([AuthorID], [FirstName], [LastName]) VALUES (1, N'J. K.', N'Rolling')
INSERT [dbo].[Authors] ([AuthorID], [FirstName], [LastName]) VALUES (2, N'Stephen', N'King')
INSERT [dbo].[Authors] ([AuthorID], [FirstName], [LastName]) VALUES (3, N'William', N'Shakespeare')
INSERT [dbo].[Authors] ([AuthorID], [FirstName], [LastName]) VALUES (4, N'Jane', N'Austen')
INSERT [dbo].[Authors] ([AuthorID], [FirstName], [LastName]) VALUES (5, N'Mark', N'Twain')
INSERT [dbo].[Authors] ([AuthorID], [FirstName], [LastName]) VALUES (6, N'Charles', N'Dickens')
INSERT [dbo].[Authors] ([AuthorID], [FirstName], [LastName]) VALUES (7, N'Oscar', N'Wilde')
INSERT [dbo].[Authors] ([AuthorID], [FirstName], [LastName]) VALUES (8, N'Edgar', N'Allan Poe')
INSERT [dbo].[Authors] ([AuthorID], [FirstName], [LastName]) VALUES (9, N'Gabriel ', N'Garcia Marquez')
INSERT [dbo].[Authors] ([AuthorID], [FirstName], [LastName]) VALUES (10, N'Dan', N'Brown')
SET IDENTITY_INSERT [dbo].[Authors] OFF
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([CategoryID], [CategoryDescription]) VALUES (1, N'Romance')
INSERT [dbo].[Categories] ([CategoryID], [CategoryDescription]) VALUES (2, N'Fiction')
INSERT [dbo].[Categories] ([CategoryID], [CategoryDescription]) VALUES (3, N'Science')
INSERT [dbo].[Categories] ([CategoryID], [CategoryDescription]) VALUES (4, N'Educational')
INSERT [dbo].[Categories] ([CategoryID], [CategoryDescription]) VALUES (5, N'VideoGames')
INSERT [dbo].[Categories] ([CategoryID], [CategoryDescription]) VALUES (6, N'Development')
INSERT [dbo].[Categories] ([CategoryID], [CategoryDescription]) VALUES (7, N'Essay')
INSERT [dbo].[Categories] ([CategoryID], [CategoryDescription]) VALUES (8, N'Dictionary')
INSERT [dbo].[Categories] ([CategoryID], [CategoryDescription]) VALUES (9, N'Drama')
INSERT [dbo].[Categories] ([CategoryID], [CategoryDescription]) VALUES (10, N'Mystery')
INSERT [dbo].[Categories] ([CategoryID], [CategoryDescription]) VALUES (11, N'Horror')
INSERT [dbo].[Categories] ([CategoryID], [CategoryDescription]) VALUES (12, N'Science Fiction ')
INSERT [dbo].[Categories] ([CategoryID], [CategoryDescription]) VALUES (13, N'History ')
INSERT [dbo].[Categories] ([CategoryID], [CategoryDescription]) VALUES (14, N'Math')
INSERT [dbo].[Categories] ([CategoryID], [CategoryDescription]) VALUES (15, N'Encyclopedia')
INSERT [dbo].[Categories] ([CategoryID], [CategoryDescription]) VALUES (16, N'Art')
INSERT [dbo].[Categories] ([CategoryID], [CategoryDescription]) VALUES (17, N'Cookbook')
INSERT [dbo].[Categories] ([CategoryID], [CategoryDescription]) VALUES (18, N'Diaries')
INSERT [dbo].[Categories] ([CategoryID], [CategoryDescription]) VALUES (19, N'Journal')
INSERT [dbo].[Categories] ([CategoryID], [CategoryDescription]) VALUES (20, N'Fantasy')
INSERT [dbo].[Categories] ([CategoryID], [CategoryDescription]) VALUES (21, N'Authobiographies')
INSERT [dbo].[Categories] ([CategoryID], [CategoryDescription]) VALUES (22, N'Biographies')
INSERT [dbo].[Categories] ([CategoryID], [CategoryDescription]) VALUES (23, N'Satire')
SET IDENTITY_INSERT [dbo].[Categories] OFF
SET IDENTITY_INSERT [dbo].[Clients] ON 

INSERT [dbo].[Clients] ([ClientID], [ClientName], [ClientStreet], [ClientCity], [ClientPostalCode], [ClientPhone], [ClientFax], [ClientMaxCredits]) VALUES (1, N'LaSalle', N'Saint Catherine', N'Montreal', N'H3N2B3', N'4560983478', N'9873452398', 45)
INSERT [dbo].[Clients] ([ClientID], [ClientName], [ClientStreet], [ClientCity], [ClientPostalCode], [ClientPhone], [ClientFax], [ClientMaxCredits]) VALUES (2, N'Concordia', N'guy', N'Montreal', N'J2N4M2', N'6780983478', N'4560981234', 78)
INSERT [dbo].[Clients] ([ClientID], [ClientName], [ClientStreet], [ClientCity], [ClientPostalCode], [ClientPhone], [ClientFax], [ClientMaxCredits]) VALUES (3, N'Dawson', N'Saint Catherine', N'Montreal', N'H8N2B1', N'6789098765', N'7868970890', 15)
SET IDENTITY_INSERT [dbo].[Clients] OFF
SET IDENTITY_INSERT [dbo].[Employees] ON 

INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [LastName], [JobTitle]) VALUES (2112, N'Henry', N'Brown', N'MIS Manager')
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [LastName], [JobTitle]) VALUES (2113, N'Thomas', N'Moore', N'Sales Manager')
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [LastName], [JobTitle]) VALUES (2114, N'Peter', N'Wang', N'Inventory Controller')
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [LastName], [JobTitle]) VALUES (2115, N'Mary', N'Brown', N'Order Clerk')
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [LastName], [JobTitle]) VALUES (2116, N'Jennifer', N'Bouchard', N'Order Clerk')
SET IDENTITY_INSERT [dbo].[Employees] OFF
INSERT [dbo].[OrderLine] ([OrderID], [ProductISBN], [Quantity], [Price]) VALUES (1, 1, 34, 302600)
INSERT [dbo].[OrderLine] ([OrderID], [ProductISBN], [Quantity], [Price]) VALUES (2, 1, 90, 801000)
INSERT [dbo].[OrderLine] ([OrderID], [ProductISBN], [Quantity], [Price]) VALUES (3, 2, 9, 900)
INSERT [dbo].[OrderLine] ([OrderID], [ProductISBN], [Quantity], [Price]) VALUES (4, 4, 89, 1335)
SET IDENTITY_INSERT [dbo].[Orders] ON 

INSERT [dbo].[Orders] ([OrderID], [EmployeeID], [ClientID], [OrderDate], [DeliverDate], [ShippingDate]) VALUES (1, 2116, 2, CAST(N'2017-04-15' AS Date), CAST(N'2017-04-28' AS Date), CAST(N'2017-04-27' AS Date))
INSERT [dbo].[Orders] ([OrderID], [EmployeeID], [ClientID], [OrderDate], [DeliverDate], [ShippingDate]) VALUES (2, 2116, 3, CAST(N'2017-04-16' AS Date), CAST(N'2017-04-20' AS Date), CAST(N'2017-04-19' AS Date))
INSERT [dbo].[Orders] ([OrderID], [EmployeeID], [ClientID], [OrderDate], [DeliverDate], [ShippingDate]) VALUES (3, 2115, 3, CAST(N'2017-04-18' AS Date), CAST(N'2017-05-06' AS Date), CAST(N'2017-05-05' AS Date))
INSERT [dbo].[Orders] ([OrderID], [EmployeeID], [ClientID], [OrderDate], [DeliverDate], [ShippingDate]) VALUES (4, 2115, 1, CAST(N'2017-04-18' AS Date), CAST(N'2017-06-10' AS Date), CAST(N'2017-06-09' AS Date))
SET IDENTITY_INSERT [dbo].[Orders] OFF
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([ProductISBN], [Title], [UnitPrice], [YearPublished], [QuantityOnHand], [Type], [Category], [PublisherID], [AuthorID]) VALUES (1, N'Office', 8900, 1990, 3, N'Software', 6, 3, 5)
INSERT [dbo].[Products] ([ProductISBN], [Title], [UnitPrice], [YearPublished], [QuantityOnHand], [Type], [Category], [PublisherID], [AuthorID]) VALUES (2, N'Harry Potter', 100, 1990, 78, N'Book', 2, 1, 1)
INSERT [dbo].[Products] ([ProductISBN], [Title], [UnitPrice], [YearPublished], [QuantityOnHand], [Type], [Category], [PublisherID], [AuthorID]) VALUES (3, N'c++', 95, 1987, 7, N'Book', 4, 7, 6)
INSERT [dbo].[Products] ([ProductISBN], [Title], [UnitPrice], [YearPublished], [QuantityOnHand], [Type], [Category], [PublisherID], [AuthorID]) VALUES (4, N'little prince', 15, 2001, 9, N'Book', 20, 5, 5)
SET IDENTITY_INSERT [dbo].[Products] OFF
SET IDENTITY_INSERT [dbo].[Publishers] ON 

INSERT [dbo].[Publishers] ([PublisherID], [PublisherName], [PublisherDescription]) VALUES (1, N'Pearson', N'Education')
INSERT [dbo].[Publishers] ([PublisherID], [PublisherName], [PublisherDescription]) VALUES (2, N'The Woodbrdge Company', NULL)
INSERT [dbo].[Publishers] ([PublisherID], [PublisherName], [PublisherDescription]) VALUES (3, N'Microsoft', NULL)
INSERT [dbo].[Publishers] ([PublisherID], [PublisherName], [PublisherDescription]) VALUES (4, N'Oxford', N'University Press')
INSERT [dbo].[Publishers] ([PublisherID], [PublisherName], [PublisherDescription]) VALUES (5, N'Cambridge', N'University Press')
INSERT [dbo].[Publishers] ([PublisherID], [PublisherName], [PublisherDescription]) VALUES (6, N'Penguin', NULL)
INSERT [dbo].[Publishers] ([PublisherID], [PublisherName], [PublisherDescription]) VALUES (7, N'Bloomsbury', NULL)
INSERT [dbo].[Publishers] ([PublisherID], [PublisherName], [PublisherDescription]) VALUES (8, N'HarperCollins', NULL)
SET IDENTITY_INSERT [dbo].[Publishers] OFF
INSERT [dbo].[Users] ([UserName], [Password], [EmployeeID]) VALUES (N'HBrown', N'henBrown', 2112)
INSERT [dbo].[Users] ([UserName], [Password], [EmployeeID]) VALUES (N'JBouchard', N'jennBouchard', 2116)
INSERT [dbo].[Users] ([UserName], [Password], [EmployeeID]) VALUES (N'MBrown', N'marBrown', 2115)
INSERT [dbo].[Users] ([UserName], [Password], [EmployeeID]) VALUES (N'PWang', N'petWang', 2114)
INSERT [dbo].[Users] ([UserName], [Password], [EmployeeID]) VALUES (N'TMoore', N'thomMoore', 2113)
/****** Object:  Index [Unique_EmployeesIDUsers]    Script Date: 2017-04-18 1:05:38 PM ******/
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [Unique_EmployeesIDUsers] UNIQUE NONCLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[OrderLine]  WITH CHECK ADD  CONSTRAINT [FK_OrderLine_Orders] FOREIGN KEY([OrderID])
REFERENCES [dbo].[Orders] ([OrderID])
GO
ALTER TABLE [dbo].[OrderLine] CHECK CONSTRAINT [FK_OrderLine_Orders]
GO
ALTER TABLE [dbo].[OrderLine]  WITH CHECK ADD  CONSTRAINT [FK_OrderLine_Products] FOREIGN KEY([ProductISBN])
REFERENCES [dbo].[Products] ([ProductISBN])
GO
ALTER TABLE [dbo].[OrderLine] CHECK CONSTRAINT [FK_OrderLine_Products]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Clients] FOREIGN KEY([ClientID])
REFERENCES [dbo].[Clients] ([ClientID])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Clients]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Employees] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employees] ([EmployeeID])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Employees]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Authors] FOREIGN KEY([AuthorID])
REFERENCES [dbo].[Authors] ([AuthorID])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Authors]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Categories] FOREIGN KEY([Category])
REFERENCES [dbo].[Categories] ([CategoryID])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Categories]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Publishers] FOREIGN KEY([PublisherID])
REFERENCES [dbo].[Publishers] ([PublisherID])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Publishers]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Employees] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employees] ([EmployeeID])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Employees]
GO
USE [master]
GO
ALTER DATABASE [HiTechDB] SET  READ_WRITE 
GO

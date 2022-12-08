USE [master]
GO
/****** Object:  Database [PersonalAccountant]    Script Date: 12/8/2022 2:11:42 AM ******/
CREATE DATABASE [PersonalAccountant]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PersonalAccountant', FILENAME = N'F:\New folder\MSSQL11.MSSQLSERVER\MSSQL\DATA\PersonalAccountant.mdf' , SIZE = 4160KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'PersonalAccountant_log', FILENAME = N'F:\New folder\MSSQL11.MSSQLSERVER\MSSQL\DATA\PersonalAccountant_log.ldf' , SIZE = 1040KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [PersonalAccountant] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PersonalAccountant].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PersonalAccountant] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PersonalAccountant] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PersonalAccountant] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PersonalAccountant] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PersonalAccountant] SET ARITHABORT OFF 
GO
ALTER DATABASE [PersonalAccountant] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [PersonalAccountant] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [PersonalAccountant] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PersonalAccountant] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PersonalAccountant] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PersonalAccountant] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PersonalAccountant] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PersonalAccountant] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PersonalAccountant] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PersonalAccountant] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PersonalAccountant] SET  ENABLE_BROKER 
GO
ALTER DATABASE [PersonalAccountant] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PersonalAccountant] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PersonalAccountant] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PersonalAccountant] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PersonalAccountant] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PersonalAccountant] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PersonalAccountant] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PersonalAccountant] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [PersonalAccountant] SET  MULTI_USER 
GO
ALTER DATABASE [PersonalAccountant] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PersonalAccountant] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PersonalAccountant] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PersonalAccountant] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [PersonalAccountant]
GO
/****** Object:  StoredProcedure [dbo].[EepensesGetAll]    Script Date: 12/8/2022 2:11:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EepensesGetAll]
As
SELECT 
      Items as 'Items'
      ,Quantity as'Quantity'
      ,Price as 'Price'
	  ,Price*Quantity as 'Item_Total_Price'
	  ,AddedDate as 'AddedDate'
  FROM Expenses

GO
/****** Object:  StoredProcedure [dbo].[EepensesSelectTotal]    Script Date: 12/8/2022 2:11:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[EepensesSelectTotal]
As
SELECT 
      Items as 'Items'
      ,Quantity as'Quantity'
      ,Price as 'Price'
	  ,Price*Quantity as 'Item_Total_Price'
	  ,AddedDate as 'AddedDate'
  FROM Expenses

GO
/****** Object:  StoredProcedure [dbo].[EmployeeDelete]    Script Date: 12/8/2022 2:11:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EmployeeDelete] @empName varchar(80)
As
Delete from Employee
WHERE EmployeeName=@empName


GO
/****** Object:  StoredProcedure [dbo].[EmployeeGetAll]    Script Date: 12/8/2022 2:11:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EmployeeGetAll]
As
SELECT 
      EmployeeId as 'EmployeeId'
      ,EmployeeName as 'EmployeeName'
      ,Gender as'Gender'
      ,Salary as 'Salary'
      ,Phone as 'Phone'
  FROM Employee

GO
/****** Object:  StoredProcedure [dbo].[EmployeeInsert]    Script Date: 12/8/2022 2:11:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EmployeeInsert] @empName varchar(250),@gender varchar(10),@salary real ,@phon_Num varchar(50)
AS
insert into Employee values (@empName,@gender,@salary,@phon_Num)


GO
/****** Object:  StoredProcedure [dbo].[EmployeeReset]    Script Date: 12/8/2022 2:11:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EmployeeReset]
As
Delete from Employee
Truncate table Employee;
GO
/****** Object:  StoredProcedure [dbo].[EmployeeUpdate]    Script Date: 12/8/2022 2:11:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EmployeeUpdate] @empName varchar(250),@gender varchar(10),@salary real ,@phon_Num varchar(50)
AS


UPDATE [dbo].[Employee]
   SET EmployeeName=@empName,
       Gender=@gender,
       Salary = @salary,
       Phone =@phon_Num
	   where EmployeeName=@empName or
       Gender=@gender or
       Salary = @salary or
       Phone =@phon_Num;


GO
/****** Object:  StoredProcedure [dbo].[ExpensesDelete]    Script Date: 12/8/2022 2:11:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ExpensesDelete] @item nvarchar(250)
As
Delete from Expenses
WHERE Items=@item


GO
/****** Object:  StoredProcedure [dbo].[ExpensesInsert]    Script Date: 12/8/2022 2:11:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ExpensesInsert] @item nvarchar(250),@quantity int,@price int ,@addedDate Date
AS
insert into Expenses values (@item,@quantity,@price,@addedDate)


GO
/****** Object:  StoredProcedure [dbo].[ExpensesReset]    Script Date: 12/8/2022 2:11:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ExpensesReset]
As
Delete from Expenses


GO
/****** Object:  StoredProcedure [dbo].[ExpensesUpdate]    Script Date: 12/8/2022 2:11:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ExpensesUpdate] @item nvarchar(250),@quantity int,@price int ,@addedDate Date
AS


UPDATE [dbo].[Expenses]
   SET Items=@item,
       Quantity =@quantity,
       Price = @price,
	   AddedDate = @addedDate
	   where Items=@item or Quantity=@quantity or Price = @price or
	   AddedDate = @addedDate ;

GO
/****** Object:  StoredProcedure [dbo].[RevenueDelete]    Script Date: 12/8/2022 2:11:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[RevenueDelete] @item nvarchar(250)
As
Delete from Revenue
WHERE Items=@item


GO
/****** Object:  StoredProcedure [dbo].[RevenueGetAll]    Script Date: 12/8/2022 2:11:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RevenueGetAll]
As
SELECT 
      Items as 'Items'
      ,Quantity as'Quantity'
      ,Price as 'Price'
      ,Price*Quantity as 'Item_Total_Price'
	  ,AddedDate as 'AddedDate'
  FROM Revenue

GO
/****** Object:  StoredProcedure [dbo].[RevenueInsert]    Script Date: 12/8/2022 2:11:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RevenueInsert] @item nvarchar(250),@quantity int,@price int ,@addedDate Date
AS
insert into Revenue values (@item,@quantity,@price,@addedDate)


GO
/****** Object:  StoredProcedure [dbo].[RevenueReset]    Script Date: 12/8/2022 2:11:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[RevenueReset]
As
Delete from Revenue

GO
/****** Object:  StoredProcedure [dbo].[RevenueUpdate]    Script Date: 12/8/2022 2:11:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RevenueUpdate] @item nvarchar(250),@quantity int,@price int ,@addedDate Date
AS


UPDATE [dbo].[Revenue]
   SET Items=@item,
       Quantity =@quantity,
       Price = @price,
	   AddedDate = @addedDate
	   where Items=@item or
       Quantity =@quantity or
       Price = @price or
	   AddedDate = @addedDate;

GO
/****** Object:  Table [dbo].[Employee]    Script Date: 12/8/2022 2:11:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Employee](
	[EmployeeId] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeName] [varchar](80) NOT NULL,
	[Gender] [varchar](10) NULL,
	[Salary] [real] NOT NULL,
	[Phone] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[EmployeeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Expenses]    Script Date: 12/8/2022 2:11:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Expenses](
	[Items] [nvarchar](250) NOT NULL,
	[Quantity] [int] NOT NULL,
	[Price] [int] NOT NULL,
	[AddedDate] [date] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Revenue]    Script Date: 12/8/2022 2:11:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Revenue](
	[Items] [nvarchar](250) NOT NULL,
	[Quantity] [int] NOT NULL,
	[Price] [int] NOT NULL,
	[AddedDate] [date] NOT NULL
) ON [PRIMARY]

GO
USE [master]
GO
ALTER DATABASE [PersonalAccountant] SET  READ_WRITE 
GO

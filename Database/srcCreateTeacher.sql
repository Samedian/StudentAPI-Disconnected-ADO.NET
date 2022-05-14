USE [Samarth]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Teacher](
	c [int] IDENTITY(1,1) NOT NULL,
	[TeacherName] [varchar](20) NOT NULL,
	[TeacherAge] [int] NOT NULL,
	[TeacherSalary] [decimal](10, 2) NOT NULL,
) 
Go

ALTER TABLE [dbo].[Teacher] ADD PRIMARY KEY([dbo].[Teacher])
GO



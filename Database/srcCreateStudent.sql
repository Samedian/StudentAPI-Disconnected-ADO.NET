USE [Samarth]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Student](
	[StudentId] [int] IDENTITY(1,1) NOT NULL,
	[StudentName] [varchar](20) NOT NULL,
	[StudentAge] [int] NOT NULL,
	[TeacherId] [int] NULL,
) 
GO

ALTER TABLE [dbo].[Student] ADD PRIMARY KEY([StudentId])
Go;

ALTER TABLE [dbo].[Student]  WITH CHECK ADD FOREIGN KEY([TeacherId])
REFERENCES [dbo].[Teacher] ([TeacherId])
GO



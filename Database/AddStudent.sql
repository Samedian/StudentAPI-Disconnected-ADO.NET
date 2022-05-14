USE [Samarth]
GO

CREATE PROCEDURE [dbo].[AddStudent] @StudentName varchar(20),@Age int,@TeacherId int
As
INSERT INTO STUDENT Values(@StudentName,@Age,@TeacherId);

GO



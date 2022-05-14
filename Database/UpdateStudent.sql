USE [Samarth]
GO

CREATE PROCEDURE [dbo].[UpdateStudent] @Id int,@Name varchar(20),@Age int,@TeacherId int
AS
Update STUDENT Set StudentName =@Name,StudentAge=@Age,TeacherId=@TeacherId where StudentId=@Id;

GO



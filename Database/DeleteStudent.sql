USE [Samarth]
GO
Create procedure [dbo].[DeleteStudent] @id int
as
Delete from Student where StudentId = @id;

GO



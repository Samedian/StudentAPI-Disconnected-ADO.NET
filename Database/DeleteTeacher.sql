USE [Samarth]
GO

CREATE PROCEDURE [dbo].[DeleteTeacher] @id int
as
Delete from Teacher where TeacherId = @id;

GO



USE [Samarth]
GO

CREATE PROCEDURE [dbo].[AddTeacher] @Name varchar(20) ,@Age int ,@Salary decimal(10,2)
AS
INSERT INTO Teacher Values(@Name,@Age,@Salary);

GO



USE [Samarth]
GO

CREATE PROCEDURE [dbo].[UpdateTeacher] @Id int ,@Name varchar(20), @Age int,@Salary decimal(10,2) 
As
Update Teacher Set TeacherName=@Name ,TeacherAge =@Age, TeacherSalary= @Salary where TeacherId=@id;

GO



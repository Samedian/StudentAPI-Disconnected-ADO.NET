using ASPNetCoreWebAPI.Model;
using DataAcessLayer;
using System;
using System.Collections.Generic;

namespace BussinessLayer
{
    public class StudentBL
    {
        public bool AddStudent(Student student)
        {
            bool result;
            StudentDAL studentDAL = new StudentDAL();
            result = studentDAL.AddStudent(student);

            return result;
        }

        public bool DeleteStudent(int StudentId)
        {
            bool result;
            StudentDAL studentDAL = new StudentDAL();
            result = studentDAL.DeleteStudent(StudentId);

            return result;
        }

        public bool UpdateStudent(Student student)
        {
            bool result;
            StudentDAL studentDAL = new StudentDAL();
            result = studentDAL.UpdateStudent(student);

            return result;
        }

        public List<Student> GetStudents()
        {
            StudentDAL studentDAL = new StudentDAL();
            List<Student> students = studentDAL.GetStudents();
            return students;
        }
    }
}

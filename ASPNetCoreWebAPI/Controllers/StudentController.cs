using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using ASPNetCoreWebAPI.Model;
using BussinessLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASPNetCoreWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {

        public IActionResult Get()
        {
            try
            {
                StudentBL studentBL = new StudentBL();
                List<Student> students = studentBL.GetStudents();
                if (students.Count == 0)
                    return NotFound("No List Found");

                return Ok(students);
            }catch(Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpGet("GetStudent")]
        public IActionResult Get(int id)
        { 

             StudentBL studentBL = new StudentBL();
             List<Student> students = studentBL.GetStudents();

             var _oStudent = students.Find(s => s.StudentId == id);
             //var _oStudent = students.SingleOrDefault(x => x.StudentId == id);

             if(_oStudent==null)
                return NotFound("No List Found");

              return Ok(_oStudent);
        }

        [HttpPost]
        public IActionResult Save(Student student)
        {

            StudentBL studentBL = new StudentBL();
            studentBL.AddStudent(student);

            List<Student> students = studentBL.GetStudents();

            if (students.Count == 0)
                return NotFound("No List Found");

            return Ok(students);

        }
        [HttpDelete]
        public IActionResult DeleteStudent(int id)
        {

            StudentBL studentBL = new StudentBL();
            studentBL.DeleteStudent(id);

            List<Student> students = studentBL.GetStudents();

            if (students.Count == 0)
                return NotFound("No List Found");

            return Ok(students);
            
        }

        [HttpPut]
        public IActionResult UpdateStudent(Student student)
        {
            StudentBL studentBL = new StudentBL();
            studentBL.UpdateStudent(student);
            List<Student> students = studentBL.GetStudents();

            var _oStudent = students.Find(s => s.StudentId == student.StudentId);

            if (_oStudent == null)
                return NotFound("No List Found");

            return Ok(_oStudent);

        }
    }
}

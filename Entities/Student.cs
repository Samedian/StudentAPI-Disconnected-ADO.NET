using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCoreWebAPI.Model
{
    public class Student
    {
        public int StudentId { get; set; }

        public string StudentName { get; set; }

        public int StudentAge { get; set; }

        public int TeacherId { get; set; }

    }
}

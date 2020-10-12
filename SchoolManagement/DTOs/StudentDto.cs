using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagement.DTOs
{
    public class StudentDto
    {
        public StudentDto() { }

        public int StudentID { get; set; }
        public string studetName { get; set; }
        public float feeBalance { get; set; }
        public CourseDto Courses { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagement.Models
{
    public class Student
    {
        public int StudentID { get; set; }

        [Required]
        [MaxLength(250)]
        public string studetName { get; set; }

        [Required]
        public float feeBalance { get; set; }

        public int CoursesID { get; set; }
        public Courses Courses { get; set; }
    }
}

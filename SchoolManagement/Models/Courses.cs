using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagement.Models
{
    public class Courses
    {
        public int CoursesID { get; set; }

        [Required]
        [MaxLength(250)]
        public string courseName { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}

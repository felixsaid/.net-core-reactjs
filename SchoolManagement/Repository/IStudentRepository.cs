using SchoolManagement.DTOs;
using SchoolManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagement.Repository
{
    public interface IStudentRepository
    {
        public Student CreateStudent(Student studentItem);
        public List<StudentDto> GetAllStudents();
        public StudentDto GetStudentByID(int StudentId);
        public Student UpdateStudent(int StudentId, Student studentItem);
        public int DeleteStudent(int StudentId);
        public Student SearchStudentByCourseName(string CourseName);

    }
}

using SchoolManagement.DTOs;
using SchoolManagement.Models;
using SchoolManagement.Repository;
using SchoolManagement.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagement.DataManager
{
    public class StudentDataManager : IStudentRepository
    {
        readonly StudentDatabaseContext _context;

        public StudentDataManager(StudentDatabaseContext context)
        {
            _context = context;
        }
        public Student CreateStudent(Student studentItem)
        {
            _context.Add(studentItem);
            _context.SaveChanges();

            return studentItem;
        }


        public List<StudentDto> GetAllStudents()
        {
            var _students = (from s in _context.Students
                             select new StudentDto
                             {
                                 StudentID = s.StudentID,
                                 studetName = s.studetName,
                                 feeBalance = s.feeBalance,
                                 Courses = new CourseDto()
                                 {
                                     CoursesID = s.Courses.CoursesID,
                                     courseName = s.Courses.courseName
                                 }
                             }).ToList();

            return _students;
        }

        public StudentDto GetStudentByID(int StudentId)
        {
            var _student = (from s in _context.Students
                            select new StudentDto
                            {
                                StudentID = s.StudentID,
                                studetName = s.studetName,
                                feeBalance = s.feeBalance,
                                Courses = new CourseDto()
                                {
                                    CoursesID = s.Courses.CoursesID,
                                    courseName = s.Courses.courseName
                                }
                            }).FirstOrDefault(a => a.StudentID == StudentId);

            return _student;
        }

        public int DeleteStudent(int StudentId)
        {
            var stud = _context.Students.FirstOrDefault(a => a.StudentID == StudentId);
            _context.Remove(stud);
            _context.SaveChanges();

            return StudentId;
        }

        public Student SearchStudentByCourseName(string CourseName)
        {
            throw new NotImplementedException();
        }

        public Student UpdateStudent(int StudentId, Student studentItem)
        {
            throw new NotImplementedException();
        }
    }
}

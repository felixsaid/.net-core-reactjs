using SchoolManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagement.Repository
{
    public interface ICoursesRepository
    {
        public Courses CreatCourse(Courses courseItem);
        public List<Courses> GetAllCourses();
        public Courses GetCourseById(int CourseId);
        public Courses UpdateCourses(int CourseId, Courses courseItem);
        public int DeleteCourse(int CourseId);
        public Courses SearchCourseByName(string CourseName);
    }
}

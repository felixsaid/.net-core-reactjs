using SchoolManagement.Models;
using SchoolManagement.Repository;
using SchoolManagement.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagement.DataManager
{
    public class CourseDataManager : ICoursesRepository
    {
        readonly StudentDatabaseContext _context;

        public CourseDataManager(StudentDatabaseContext context)
        {
            _context = context;
        }

        public Courses CreatCourse(Courses courseItem)
        {
            _context.Add(courseItem);
            _context.SaveChanges();

            return courseItem;
        }

        public List<Courses> GetAllCourses()
        {
            var _courses = (from c in _context.Courses
                            select new Courses
                            {
                                CoursesID = c.CoursesID,
                                courseName = c.courseName
                            }).ToList();

            return _courses;
        }

        public Courses GetCourseById(int CourseId)
        {
            var _course = (from c in _context.Courses
                           select new Courses
                           {
                               CoursesID = c.CoursesID,
                               courseName = c.courseName
                           }).FirstOrDefault(a => a.CoursesID == CourseId);

            return _course;
        }
        public int DeleteCourse(int CourseId)
        {
            var _course = _context.Courses.FirstOrDefault(a => a.CoursesID == CourseId);
            _context.Remove(_course);
            _context.SaveChanges();

            return CourseId;
        }

        public Courses SearchCourseByName(string CourseName)
        {
            throw new NotImplementedException();
        }

        public Courses UpdateCourses(int CourseId, Courses courseItem)
        {
            throw new NotImplementedException();
        }
    }
}

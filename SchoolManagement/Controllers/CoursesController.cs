using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SchoolManagement.Models;
using SchoolManagement.Repository;
using SchoolManagement.Wrappers;

namespace SchoolManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private ILogger _logger;
        private ICoursesRepository _coursesRepository;

        public CoursesController(ILogger<CoursesController> logger, ICoursesRepository coursesRepository)
        {
            _logger = logger;
            _coursesRepository = coursesRepository;
        }

        [HttpPost]
        public IActionResult createCourse([FromBody] Courses courses) 
        {
            _coursesRepository.CreatCourse(courses);

            Response res = new Response();
            res.error = false;
            res.data = courses;
            res.message = "course was successfully added!";

            return Ok(res);
        }

        [HttpGet]
        public IActionResult getAllCourses()
        {
           var _courses = _coursesRepository.GetAllCourses();

            Response res = new Response();
            res.error = false;
            res.data = _courses;
            res.message = "courses' data was successfully retreived!";

            return Ok(res);
        }

        [HttpGet]
        [Route("{courseId}")]
        public IActionResult getCourseById(int courseId)
        {
            var _course = _coursesRepository.GetCourseById(courseId);

            Response res = new Response();
            res.error = false;
            res.data = _course;
            res.message = "course data with course id " + courseId + " was successfully retreived!";

            return Ok(res);
        }

        [HttpDelete]
        [Route("{courseId}")]
        public IActionResult deleteCourse(int courseId)
        {
            _coursesRepository.DeleteCourse(courseId);

            Response res = new Response();
            res.error = false;
            res.data = courseId;
            res.message = "course with course id " + courseId + " was successfully deleted!";

            return Ok(res);
        }
    }
}

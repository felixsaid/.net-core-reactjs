using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SchoolManagement.Models;
using SchoolManagement.Repository;
using SchoolManagement.Wrappers;

namespace SchoolManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private ILogger _logger;
        private IStudentRepository _studentRepository;

        public StudentsController(ILogger<StudentsController> logger, IStudentRepository studentRepository)
        {
            _logger = logger;
            _studentRepository = studentRepository;
        }

        [HttpPost]
        public IActionResult createStudent([FromBody] Student student)
        {
            _studentRepository.CreateStudent(student);

            Response res = new Response();
            res.error = false;
            res.data = student;
            res.message = "student was successfully added!";

            return Ok(res);

        }

        [HttpGet]
        public IActionResult getAllStudents()
        {
            var _students = _studentRepository.GetAllStudents();

            Response res = new Response();
            res.error = false;
            res.data = _students;
            res.message = "students' data was successfully retreived!";

            return Ok(res);
        }

        [HttpGet]
        [Route("{studentId}")]
        public IActionResult getStudentById(int studentId)
        {
            var _student = _studentRepository.GetStudentByID(studentId);

            Response res = new Response();
            res.error = false;
            res.data = _student;
            res.message = "student data with student id " + studentId + " was successfully retreived!";

            return Ok(res);
        }
    }
}

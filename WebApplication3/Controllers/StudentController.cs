
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Interfaces;
using WebApplication3.Models;
using AutoMapper;
using WebApplication3.Dto;

namespace WebApplication3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : Controller
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IMapper _mapper;
        public StudentController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;

        }
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Student>))]
        public IActionResult GetStudent()
        {
            var student = _studentRepository.GetStudents();

            if (!ModelState.IsValid)
            { return BadRequest(ModelState);

            }
            return Ok(student);
        }
        [HttpGet("{id}")]
        [ProducesResponseType(200, Type = typeof(Student))]
        [ProducesResponseType(400)]
        public IActionResult GetStudent(int id)
        {
            if (!_studentRepository.HasStudent(id))
                return NotFound();

            var student = _studentRepository.GetStudent(id);

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(student);
        }
        [HttpPost]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        public IActionResult CreateStudent([FromBody] Student student)
        {
            if (student == null)
                return BadRequest(ModelState);

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (!_studentRepository.CreateStudent(student))
            {
                ModelState.AddModelError("", "Something went wrong ...");
                return StatusCode(500, ModelState);
            }

            return Ok( Json("ok"));
        }

        [HttpPut]
        [ProducesResponseType(400)]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public IActionResult UpdateStudent( [FromBody] Student student)
        {
            if (student == null)
                return BadRequest(ModelState);

            if (!ModelState.IsValid)
                return BadRequest();

            if (!_studentRepository.UpdateStudent( student))
            {
                ModelState.AddModelError("", "Something went wrong updating...");
                return StatusCode(500, ModelState);
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(400)]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public IActionResult DeleteStudent(int id)
        {
            if (!_studentRepository.HasStudent(id))
                return NotFound();

            if (!ModelState.IsValid) return BadRequest(ModelState);

            if(!_studentRepository.DeleteStudent(id))
            {
                ModelState.AddModelError("", "Sonething went wronf deleting ower");
            }
            return Ok(Json("Succsusfully Deleted"));
        }

    } 
}

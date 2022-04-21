using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        //Loosely coupled
        //naming convention
        //IoC container -- Inversion of Control
        IStudentService _studentService;

        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
        
            var result = _studentService.GetAll();
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbystudentschoolid")]
        public IActionResult GetByStudentSchoolId(int id)
        {
            var result = _studentService.GetByStudentSchoolId(id);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbystudentcardnumber")]
        public IActionResult GetByStudentCardNumber(int cardId)
        {
            var result = _studentService.GetByStudentCardNumber(cardId);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getstudentdetail")]
        public IActionResult GetStudentDetails()
        {
            var result = _studentService.GetStudentDetails();
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getdetailbystudentschoolid")]
        public IActionResult GetDetailByStudentSchoolId(int studentSchoolId)
        {
            var result = _studentService.GetDetailByStudentSchoolId(studentSchoolId);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Student student)
        {
            var result = _studentService.Add(student);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Student student)
        {
            var result = _studentService.Delete(student);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Student student)
        {
            var result = _studentService.Update(student);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}

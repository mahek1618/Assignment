using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Student.Models;
using Student.RequestModel;

namespace Student.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentInfoController : ControllerBase
    {
        private readonly StudentContext _studentContext;
        public StudentInfoController(StudentContext studentContext) 
        {
            _studentContext = studentContext;
        }
        // GET: api/StudentInfo
        [HttpGet]
        public IActionResult Get()
        {
            var getStudent = _studentContext.StudentInfo.ToList();
            return Ok(getStudent);
        }

        // GET: api/StudentInfo/5
        [HttpGet( "GetStudent")]
        public IActionResult GetStudent(int id)
        {
            var getStud = _studentContext.StudentInfo.First(o => o.StudentId == id);
                return Ok(getStud);
        }
        [HttpGet("Student/{value}")]
        public IActionResult Get(string value)
        {



            var result = _studentContext.StudentInfo.Where(obj => obj.FirstName.Contains(value));
            return Ok(result);



        }
        // POST: api/StudentInfo
        [HttpPost]
        public void Post([FromBody] StudentInfoRequest value)
        {
            StudentInfo stA = new StudentInfo()
            {
                FirstName = value.FirstName,
                LastName = value.LastName,
                Age = value.Age,
                EmailAddress = value.EmailAddress,
                Course = value.Course,
                CreatedBy="MahekGarg",
                CreatedAt=value.CreatedAt
            };
            _studentContext.StudentInfo.Add(stA);
            _studentContext.SaveChanges();
            
            
        }

        // PUT: api/StudentInfo/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        // DELETE: api/ApiWithActions/5
        //    [HttpDelete("{id}")]
        //    public void Delete(int id)
        //    {
        //    }
    }
}

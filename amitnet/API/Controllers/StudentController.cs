using Microsoft.AspNetCore.Mvc;
using API.Data;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
         private readonly LibraryContext context;
        public   StudentController(LibraryContext context)
        {
            this.context = context;

        }

        [HttpGet]

        public async Task<ActionResult<List<Student>>> GetStudents()
        {
            var students=await context.Students.ToListAsync();
            return students;
        }
    }
}

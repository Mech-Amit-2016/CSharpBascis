using Microsoft.AspNetCore.Mvc;
using API.Data;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
         private readonly LibraryContext context;
        public   EmployeeController(LibraryContext context)
        {
            this.context = context;

        }
        [HttpGet]
        public async Task< ActionResult<List<Employee>>> GEmployees()
        {
        var employees=await context.Employees.ToListAsync();
        return employees;
        }


          }
}
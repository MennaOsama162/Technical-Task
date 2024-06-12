using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.DTO;
using WebApplication1.Models;
using WebApplication1.UnitOfWork;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        UnitWork unit;
        IMapper mapper;
        public EmployeeController(UnitWork unit , IMapper mapper) 
        {
            this.unit = unit;
            this.mapper = mapper;
        }
        // GET: api/Employee
        [HttpGet]
        public ActionResult<IEnumerable<Employee>> Get()
        {
            var employees = unit.EmployeeRepository.selectall();
            return Ok(employees);
        }

        // GET: api/Employee/{id}
        [HttpGet("{id}")]
        public ActionResult<Employee> Get(int id)
        {
            var employee = unit.EmployeeRepository.selectbyid(id);
            if (employee == null)
            {
                return NotFound();
            }
            return Ok(employee);
        }

        // POST: api/Employee
        [HttpPost]
        public ActionResult<Employee> Post(EmpDTO newEmp)
        {
            if (newEmp == null)
            {
                return BadRequest();
            }

            Employee emp = mapper.Map<Employee>(newEmp);

            unit.EmployeeRepository.add(emp);
            unit.SaveChanges();
            return Ok(emp);
        }
        // PUT: api/Employee/{id}
        [HttpPut]
        public ActionResult Put( Employee employee)
        {
            if (employee == null)
            {
                return NotFound();
            }

            unit.EmployeeRepository.update(employee);
            unit.SaveChanges(); // Ensure to save changes
            return NoContent();
        }


        // DELETE: api/Employee/{id}
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var employee = unit.EmployeeRepository.selectbyid(id);
            if (employee == null)
            {
                return NotFound();
            }

            unit.EmployeeRepository.delete(id);
            unit.SaveChanges(); // Ensure to save changes
            return NoContent();
        }
    }
}
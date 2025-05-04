using Microsoft.AspNetCore.Mvc;
using MyApi.Application.Dtos.Employee;
using MyApi.Application.Interfaces;
using MyApi.Domain.Entities;

namespace MyApi.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {

        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Employee>>> GetEmployees()
        {
            var employees = await _employeeService.GetAllEmployeeWithUserAsync();

            return Ok(employees);
        }

        [HttpPost]
        public async Task<ActionResult> CreateEmployee([FromBody] CreateEmployeeDto dto)
        {

            var employee = new Employee
            {
                Name = dto.Name,
                LastName = dto.LastName,
                Email = dto.Email,
                Ci = dto.Ci,
                User = dto.User != null
                ? new User
                {
                    UserName = dto.User.UserName,
                    Password = dto.User.Password,
                }
                : null

            };
            await _employeeService.CreateEmployeeAsync(employee);


            return Ok(new { message = "Created successfully", Object = employee });

            // var employeeDto = new ResponseEmployeeDto
            // {
            //     Id = employee.Id,
            //     Name = employee.Name,
            //     lastName = employee.LastName,
            //     UserName = employee.User?.UserName,
            // };

            // return CreatedAtAction(nameof(GetEmployees), new { id = employee.Id }, employeeDto);

        }

    }
}
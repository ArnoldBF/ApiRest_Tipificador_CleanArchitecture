using MyApi.Application.Dtos.User;

namespace MyApi.Application.Dtos.Employee
{
    public class CreateEmployeeDto
    {
        required public string Name { get; set; }
        required public string LastName { get; set; }

        required public string Email { get; set; }
        required public string Ci { get; set; }


        public CreateUserDto? User { get; set; }
    }
}
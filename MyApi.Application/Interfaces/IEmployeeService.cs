using MyApi.Domain.Entities;

namespace MyApi.Application.Interfaces
{
    public interface IEmployeeService
    {

        Task<List<Employee>> GetAllEmployeeWithUserAsync();

        Task<Employee> GetEmployeeByIdAsync(int id);

        Task<Employee> CreateEmployeeAsync(Employee employee);

    }
}
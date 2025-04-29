using MyApi.Domain.Entities;


namespace MyApi.Application.Interfaces
{
    public interface IEmployeeRepository : IRepository<Employee>
    {


        Task<List<Employee>> GetAllEmployeeWithUserAsync();

        // Task<Person> GetByIdAsync(int id);

        // Task<Person> AddAsync(Person person);

    }
}
using MyApi.Domain.Entities;
using MyApi.Infrastructure.Data;
using MyApi.Application.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MyApi.Infrastructure.Repositories
{
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<List<Employee>> GetAllEmployeeWithUserAsync()
        {
            return await _context.Employees.Include(p => p.User).ToListAsync();
        }




    }
}
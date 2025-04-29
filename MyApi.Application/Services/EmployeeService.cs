using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyApi.Application.Interfaces;
using MyApi.Domain.Entities;

namespace MyApi.Application.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<List<Employee>> GetAllEmployeeWithUserAsync()
        {
            return await _employeeRepository.GetAllEmployeeWithUserAsync();
        }

        public async Task<Employee> GetEmployeeByIdAsync(int id)
        {
            return await _employeeRepository.GetByIdAsync(id);
        }

        public async Task<Employee> CreateEmployeeAsync(Employee employee)
        {
            await _employeeRepository.AddAsync(employee);
            return employee;
        }

    }
}
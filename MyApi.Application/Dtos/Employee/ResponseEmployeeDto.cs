using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApi.Application.Dtos.Employee
{
    public class ResponseEmployeeDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string lastName { get; set; } = string.Empty;
        public string? UserName { get; set; }
    }
}
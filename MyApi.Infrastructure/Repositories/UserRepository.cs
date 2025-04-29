using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyApi.Domain.Entities;
using MyApi.Infrastructure.Data;
using MyApi.Application.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MyApi.Infrastructure.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<List<User>> GetAllUserWithEmployeeAsync()
        {
            return await _context.Users.Include(u => u.Employee).ToListAsync();
        }

        public async Task<User?> GetUserByCredentialsAsync(string username, string password)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.UserName == username && u.Password == password);
        }

    }

}
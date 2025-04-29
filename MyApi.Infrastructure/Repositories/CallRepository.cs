using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyApi.Application.Interfaces;
using MyApi.Domain.Entities;
using MyApi.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace MyApi.Infrastructure.Repositories
{
    public class CallRepository : Repository<Call>, ICallRepository
    {

        public CallRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<List<Call>> GetAllCallWithUserAsync()
        {
            return await _context.Calls.Include(c => c.User).ToListAsync();
        }

    }
}
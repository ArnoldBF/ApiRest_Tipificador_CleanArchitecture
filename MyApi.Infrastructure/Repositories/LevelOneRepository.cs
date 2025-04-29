
using MyApi.Domain.Entities;
using MyApi.Application.Interfaces;
using MyApi.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace MyApi.Infrastructure.Repositories
{
    public class LevelOneRepository : Repository<LevelOne>, ILevelOneRepository
    {

        public LevelOneRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<List<LevelOne>> GetAllLevelOneWithLevelTwoAsync()
        {
            return await _context.LevelOnes.Include(c => c.LevelTwos).ThenInclude(l2 => l2.LevelThrees).ToListAsync();
        }

        public async Task<LevelOne> GetLevelOneByIdAsync(int id)
        {
            return await _context.LevelOnes.Include(c => c.LevelTwos).ThenInclude(l2 => l2.LevelThrees).FirstOrDefaultAsync(c => c.Id == id) ?? throw new KeyNotFoundException($"Entity with id {id} not found.");
        }

    }
}
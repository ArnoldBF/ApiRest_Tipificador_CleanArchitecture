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
    public class LevelTwoRepository : Repository<LevelTwo>, ILevelTwoRepository
    {

        public LevelTwoRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<List<LevelTwo>> GetAllLevelTwoWithLevelThreeAsync()
        {
            return await _context.LevelTwos.Include(sc => sc.LevelThrees).ToListAsync();
        }

        public async Task<LevelTwo> GetLevelTwoByIdAsync(int id)
        {
            return await _context.LevelTwos.Include(sc => sc.LevelThrees).FirstOrDefaultAsync(sc => sc.Id == id) ?? throw new KeyNotFoundException($"Entity with id {id} not found.");
        }

        public async Task<List<LevelTwo>> GetLevelTwosByLevelOneIdAsync(int levelOneId)
        {
            return await _context.LevelTwos
                .Where(l2 => l2.LevelOneId == levelOneId)
                .ToListAsync();
        }

    }
}
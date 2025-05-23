using Microsoft.EntityFrameworkCore;
using MyApi.Domain.Entities;
using MyApi.Application.Interfaces;
using MyApi.Infrastructure.Data;

namespace MyApi.Infrastructure.Repositories
{
    public class LevelThreeRepository : Repository<LevelThree>, ILevelThreeRepository
    {

        public LevelThreeRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<List<LevelThree>> GetAllLevelThreeWithLevelTwoAsync()
        {
            return await _context.LevelThrees.Include(ssc => ssc.LevelTwo).ToListAsync();
        }
        public async Task<List<LevelThree>> GetLevelThreesByLevelTwoIdAsync(int levelTwoId)
        {
            return await _context.LevelThrees
                .Where(l3 => l3.LevelTwoId == levelTwoId)
                .ToListAsync();
        }

    }
}
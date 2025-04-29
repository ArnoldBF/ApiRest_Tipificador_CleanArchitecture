using Microsoft.EntityFrameworkCore;
using MyApi.Domain.Entities;
using MyApi.Infrastructure.Data;
using MyApi.Application.Interfaces;

namespace MyApi.Infrastructure.Repositories
{
    public class TripletRepository : Repository<Triplet>, ITripletRepository
    {
        public TripletRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<List<Triplet>> GetAllTripletWithLevelOneAsync()
        {
            return await _context.Triplets.Include(t => t.LevelOne).ToListAsync();
        }

        public async Task<List<Triplet>> GetAllTripletWithLevelTwoAsync()
        {
            return await _context.Triplets.Include(t => t.LevelTwo).ToListAsync();
        }

        public async Task<List<Triplet>> GetAllTripletWithLevelThreeAsync()
        {
            return await _context.Triplets.Include(t => t.LevelThree).ToListAsync();
        }

    }
}
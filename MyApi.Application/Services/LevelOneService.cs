
using System.Runtime.InteropServices;
using MyApi.Application.Interfaces;
using MyApi.Domain.Entities;
namespace MyApi.Application.Services
{
    public class LevelOneService : ILevelOneService
    {
        private readonly ILevelOneRepository _levelOneRepository;

        public LevelOneService(ILevelOneRepository levelOneRepository)
        {
            _levelOneRepository = levelOneRepository;
        }

        public async Task<IEnumerable<LevelOne>> GetAllLevelOneAsync()
        {
            return await _levelOneRepository.GetAllAsync();
        }

        public async Task<List<LevelOne>> GetAllLevelOneWithLevelTwoAsync()
        {
            return await _levelOneRepository.GetAllLevelOneWithLevelTwoAsync();
        }

        public async Task<LevelOne> GetLevelOneByIdAsync(int id)
        {
            return await _levelOneRepository.GetLevelOneByIdAsync(id);
        }

        public async Task<LevelOne> GetLevelOneByIdTestAsync(int id)
        {
            return await _levelOneRepository.GetByIdAsync(id);
        }

        public async Task<LevelOne> CreateLevelOneAsync(LevelOne levelOne)
        {
            await _levelOneRepository.AddAsync(levelOne);
            Console.WriteLine($"LevelOneService: {levelOne.Id}");
            return levelOne;
        }



    }
}
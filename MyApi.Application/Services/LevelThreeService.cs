using MyApi.Application.Interfaces;
using MyApi.Domain.Entities;

namespace MyApi.Application.Services
{


    public class LevelThreeService : ILevelThreeService
    {

        private readonly ILevelThreeRepository _levelThreeRepository;

        public LevelThreeService(ILevelThreeRepository levelThreeRepository)
        {
            _levelThreeRepository = levelThreeRepository;
        }

        public async Task<IEnumerable<LevelThree>> GetAllLevelThreeAsync()
        {
            return await _levelThreeRepository.GetAllAsync();
        }

        public async Task<List<LevelThree>> GetAllLevelThreeWithLevelTwoAsync()
        {
            return await _levelThreeRepository.GetAllLevelThreeWithLevelTwoAsync();
        }

        public async Task<LevelThree> GetLevelThreeByIdAsync(int id)
        {
            return await _levelThreeRepository.GetByIdAsync(id);
        }

        public async Task<LevelThree> CreateLevelThreeAsync(LevelThree levelThree)
        {
            await _levelThreeRepository.AddAsync(levelThree);
            return levelThree;
        }
        public async Task<List<LevelThree>> GetLevelThreesByLevelTwoIdAsync(int levelTwoId)
        {
            return await _levelThreeRepository.GetLevelThreesByLevelTwoIdAsync(levelTwoId);
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyApi.Application.Interfaces;
using MyApi.Domain.Entities;

namespace MyApi.Application.Services
{
    public class LevelTwoService : ILevelTwoService
    {
        private readonly ILevelTwoRepository _levelTwoRepository;

        public LevelTwoService(ILevelTwoRepository levelTwoRepository)
        {
            _levelTwoRepository = levelTwoRepository;
        }

        public async Task<List<LevelTwo>> GetAllLevelTwoWithLevelThreeAsync()
        {
            return await _levelTwoRepository.GetAllLevelTwoWithLevelThreeAsync();
        }

        public async Task<IEnumerable<LevelTwo>> GetAllLevelTwoAsync()
        {
            return await _levelTwoRepository.GetAllAsync();
        }

        public async Task<LevelTwo> GetLevelTwoByIdAsync(int id)
        {
            return await _levelTwoRepository.GetLevelTwoByIdAsync(id);
        }

        public async Task<LevelTwo> CreateLevelTwoAsync(LevelTwo levelTwo)
        {
            await _levelTwoRepository.AddAsync(levelTwo);
            return levelTwo;
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyApi.Domain.Entities;

namespace MyApi.Application.Interfaces
{
    public interface ILevelTwoService
    {
        Task<List<LevelTwo>> GetAllLevelTwoWithLevelThreeAsync();
        Task<IEnumerable<LevelTwo>> GetAllLevelTwoAsync();
        Task<LevelTwo> GetLevelTwoByIdAsync(int id);
        Task<LevelTwo> CreateLevelTwoAsync(LevelTwo levelTwo);
        Task<List<LevelTwo>> GetLevelTwosByLevelOneIdAsync(int levelOneId);
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyApi.Domain.Entities;

namespace MyApi.Application.Interfaces
{
    public interface ILevelTwoRepository : IRepository<LevelTwo>
    {
        Task<List<LevelTwo>> GetAllLevelTwoWithLevelThreeAsync();

        Task<LevelTwo> GetLevelTwoByIdAsync(int id);

        Task<List<LevelTwo>> GetLevelTwosByLevelOneIdAsync(int levelOneId);
    }
}
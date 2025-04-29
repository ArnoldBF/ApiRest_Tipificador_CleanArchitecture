using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyApi.Domain.Entities;

namespace MyApi.Application.Interfaces
{
    public interface ILevelOneService
    {

        Task<IEnumerable<LevelOne>> GetAllLevelOneAsync();
        Task<List<LevelOne>> GetAllLevelOneWithLevelTwoAsync();
        Task<LevelOne> GetLevelOneByIdAsync(int id);
        Task<LevelOne> CreateLevelOneAsync(LevelOne levelOne);

        Task<LevelOne> GetLevelOneByIdTestAsync(int id);
    }
}
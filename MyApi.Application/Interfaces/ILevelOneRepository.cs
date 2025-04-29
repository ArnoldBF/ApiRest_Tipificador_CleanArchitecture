using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyApi.Domain.Entities;

namespace MyApi.Application.Interfaces
{
    public interface ILevelOneRepository : IRepository<LevelOne>
    {

        Task<List<LevelOne>> GetAllLevelOneWithLevelTwoAsync();

        Task<LevelOne> GetLevelOneByIdAsync(int id);
    }
}
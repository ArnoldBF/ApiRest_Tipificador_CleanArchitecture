using MyApi.Domain.Entities;

namespace MyApi.Application.Interfaces
{
    public interface ILevelThreeRepository : IRepository<LevelThree>
    {

        Task<List<LevelThree>> GetAllLevelThreeWithLevelTwoAsync();
    }
}
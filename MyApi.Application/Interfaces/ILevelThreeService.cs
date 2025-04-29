using MyApi.Domain.Entities;

namespace MyApi.Application.Interfaces
{
    public interface ILevelThreeService
    {

        Task<IEnumerable<LevelThree>> GetAllLevelThreeAsync();
        Task<List<LevelThree>> GetAllLevelThreeWithLevelTwoAsync();
        Task<LevelThree> GetLevelThreeByIdAsync(int id);
        Task<LevelThree> CreateLevelThreeAsync(LevelThree levelThree);
    }
}
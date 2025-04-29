
using MyApi.Domain.Entities;


namespace MyApi.Application.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {

        Task<List<User>> GetAllUserWithEmployeeAsync();
        Task<User?> GetUserByCredentialsAsync(string userName, string password);

    }
}
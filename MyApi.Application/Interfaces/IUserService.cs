using MyApi.Domain.Entities;

namespace MyApi.Application.Interfaces
{
    public interface IUserService
    {

        Task<List<User>> GetAllUserWithEmployeeAsync();

    }
}
using MyApi.Domain.Entities;

namespace MyApi.Application.Interfaces
{
    public interface ICallService
    {

        Task<IEnumerable<Call>> GetAllCallsAsync();
        Task<Call> GetCalltByIdAsync(int id);
        Task<Call> CreateCallAsync(Call call);

    }
}
using MyApi.Domain.Entities;
using MyApi.Application.Interfaces;

namespace MyApi.Application.Services
{
    public class CallService : ICallService
    {

        private readonly ICallRepository _callRepository;

        public CallService(ICallRepository callRepository)
        {
            _callRepository = callRepository;
        }

        public async Task<IEnumerable<Call>> GetAllCallsAsync()
        {
            return await _callRepository.GetAllAsync();
        }

        public async Task<Call> GetCalltByIdAsync(int id)
        {
            return await _callRepository.GetByIdAsync(id);
        }

        public async Task<Call> CreateCallAsync(Call call)
        {
            await _callRepository.AddAsync(call);
            return call;
        }
    }
}
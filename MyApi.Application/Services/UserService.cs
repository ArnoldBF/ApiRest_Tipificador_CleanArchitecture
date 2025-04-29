using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyApi.Application.Interfaces;
using MyApi.Domain.Entities;

namespace MyApi.Application.Services
{
    public class UserService : IUserService
    {

        private readonly IUserRepository _userRepository;


        public UserService(IUserRepository userRepository)
        {

            _userRepository = userRepository;
        }

        public async Task<List<User>> GetAllUserWithEmployeeAsync()
        {
            return await _userRepository.GetAllUserWithEmployeeAsync();
        }

        public async Task<User> GetUserByIdAsync(int id)
        {
            return await _userRepository.GetByIdAsync(id);
        }

        public async Task<User> CreateUserAsync(User user)
        {
            await _userRepository.AddAsync(user);
            return user;
        }


    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyApi.Application.Dtos.Auth;

namespace MyApi.Application.Interfaces
{
    public interface IAuthService
    {
        Task<string?> Authenticate(LoginDto loginDto);
    }
}
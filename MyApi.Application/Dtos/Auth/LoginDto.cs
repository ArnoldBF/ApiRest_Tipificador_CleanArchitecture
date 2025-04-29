using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApi.Application.Dtos.Auth
{
    public class LoginDto
    {
        required public string UserName { get; set; } = string.Empty;
        required public string Password { get; set; } = string.Empty;
    }
}
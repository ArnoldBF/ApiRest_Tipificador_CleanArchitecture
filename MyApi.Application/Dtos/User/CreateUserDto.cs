using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApi.Application.Dtos.User
{
    public class CreateUserDto
    {
        required public string UserName { get; set; }
        required public string Password { get; set; }
    }
}
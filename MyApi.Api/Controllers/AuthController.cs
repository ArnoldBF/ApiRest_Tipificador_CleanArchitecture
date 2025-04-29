using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyApi.Application.Dtos.Auth;
using MyApi.Application.Interfaces;

namespace MyApi.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {

        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginDto loginDto)
        {
            var token = await _authService.Authenticate(loginDto);

            if (token == null) return Unauthorized(new { message = "Invalid credentials" });

            return Ok(new { token });
        }



    }
}
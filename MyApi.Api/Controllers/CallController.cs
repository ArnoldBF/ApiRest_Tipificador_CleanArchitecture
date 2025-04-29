using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyApi.Application.Dtos.Call;
using MyApi.Application.Interfaces;
using MyApi.Domain.Entities;

namespace MyApi.Api.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class CallController : ControllerBase
    {

        private readonly ICallService _callService;

        public CallController(ICallService callService)
        {
            _callService = callService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Call>>> GetCalls()
        {
            var calls = await _callService.GetAllCallsAsync();

            return Ok(calls);
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Call>> GetCallById(int id)
        {
            var call = await _callService.GetCalltByIdAsync(id);

            if (call == null)
            {
                return NotFound();
            }

            return Ok(call);
        }


        [Authorize]
        [HttpPost]
        public async Task<ActionResult> CreateCall([FromBody] CreateCallDto createCallDto)
        {

            var userIdClaim = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier);

            if (userIdClaim == null)
            {
                return Unauthorized("User ID claim not found.");
            }
            var userId = int.Parse(userIdClaim.Value);

            createCallDto.UserId = userId; // Set the UserId from the claim

            var call = new Call
            {
                Comment = createCallDto.Comment,
                CallId = createCallDto.CallId,
                UserId = createCallDto.UserId,
                TripletId = createCallDto.TripletId,
            };

            await _callService.CreateCallAsync(call);
            var callDto = new ResponseCallDto
            {
                Id = call.Id,
                CallId = call.CallId,
                Comment = call.Comment,
                UserId = call.UserId,
                TripletId = call.TripletId,
            };

            return Ok(new { message = "Created successfully", Object = callDto });



            // return CreatedAtAction(nameof(GetCalls), new { id = call.Id }, callDto);
        }
    }
}
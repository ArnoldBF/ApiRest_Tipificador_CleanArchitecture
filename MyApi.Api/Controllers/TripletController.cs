using Microsoft.AspNetCore.Mvc;
using MyApi.Application.Dtos.Triplet;
using MyApi.Application.Interfaces;
using MyApi.Domain.Entities;

namespace MyApi.Api.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class TripletController : ControllerBase
    {
        private readonly ITripletService _tripletService;

        public TripletController(ITripletService tripletService)
        {
            _tripletService = tripletService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Triplet>>> GetTriplets()
        {
            var triplets = await _tripletService.GetAllTripletsAsync();

            return Ok(triplets);
        }


        [HttpPost]
        public async Task<ActionResult> CreateTriplet([FromBody] CreateTripletDto createTripletDto)
        {
            var triplet = new Triplet
            {
                LevelOneId = createTripletDto.LevelOneId,
                LevelTwoId = createTripletDto.LevelTwoId,
                LevelThreeId = createTripletDto.LevelThreeId,

            };

            await _tripletService.CreateTripletAsync(triplet);

            var tripletDto = new ResponseTripletDto
            {
                Id = triplet.Id,
                LevelOneId = triplet.LevelOneId,
                LevelTwoId = triplet.LevelTwoId,
                LevelThreeId = triplet.LevelThreeId,
            };



            return Ok(new { message = "Created successfully", Object = tripletDto });


            // return CreatedAtAction(nameof(GetTriplets), new { id = triplet.Id }, tripletDto);




        }

    }
}
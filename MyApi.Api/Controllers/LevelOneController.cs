using Microsoft.AspNetCore.Mvc;
using MyApi.Application.Interfaces;
using MyApi.Domain.Entities;

namespace MyApi.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LevelOneController : ControllerBase
    {

        private readonly ILevelOneService _levelOneService;

        public LevelOneController(ILevelOneService levelOneService)
        {
            _levelOneService = levelOneService;
        }



        [HttpGet]
        public async Task<IEnumerable<LevelOne>> GetAllLevelOneAsync()
        {
            return await _levelOneService.GetAllLevelOneAsync();
        }

        [HttpGet("with-level-twos")]
        public async Task<ActionResult<List<LevelOne>>> GetLevelOneWithsLevelTwos()
        {
            var levelOnes = await _levelOneService.GetAllLevelOneWithLevelTwoAsync();

            return Ok(levelOnes);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<LevelOne>> GetLevelOneByIdAsync(int id)
        {
            var levelOne = await _levelOneService.GetLevelOneByIdAsync(id);

            if (levelOne == null)
            {
                return NotFound();
            }

            return Ok(levelOne);
        }

        [HttpPost]
        public async Task<ActionResult> CreateLevelOne([FromBody] LevelOne levelOne)
        {
            await _levelOneService.CreateLevelOneAsync(levelOne);
            Console.WriteLine($"LevelOne Id in Controller: {levelOne.Id}");

            if (levelOne.Id == 0)
            {
                return BadRequest("No se pudo crear el recurso. El Id no fue asignado.");
            }

            return Ok(new { message = "Created successfully", Object = levelOne });

            // return CreatedAtAction(nameof(GetLevelOneByIdAsync), new { id = levelOne.Id }, levelOne);   


        }
    }
}
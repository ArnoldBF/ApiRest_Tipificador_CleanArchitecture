using Microsoft.AspNetCore.Mvc;
using MyApi.Application.Dtos.LevelTwo;
using MyApi.Application.Interfaces;
using MyApi.Domain.Entities;

namespace MyApi.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LevelTwoController : ControllerBase
    {

        private readonly ILevelTwoService _levelTwoService;

        public LevelTwoController(ILevelTwoService levelTwoService)
        {
            _levelTwoService = levelTwoService;
        }

        [HttpGet]
        public async Task<ActionResult<List<LevelTwo>>> GetAllLevelTwos()
        {
            var levelTwos = await _levelTwoService.GetAllLevelTwoAsync();

            return Ok(levelTwos);
        }
        [HttpGet("by-level-one/{levelOneId}")]
        public async Task<ActionResult<List<LevelTwo>>> GetLevelTwosByLevelOneId(int levelOneId)
        {
            var levelTwos = await _levelTwoService.GetLevelTwosByLevelOneIdAsync(levelOneId);

            if (levelTwos == null || !levelTwos.Any())
            {
                return NotFound(new { message = $"No LevelTwo records found for LevelOneId {levelOneId}" });
            }

            return Ok(levelTwos);
        }

        [HttpGet("with-level-threes")]
        public async Task<ActionResult<List<LevelTwo>>> GetLevelTwosWithLevelThree()
        {
            var levelTwos = await _levelTwoService.GetAllLevelTwoWithLevelThreeAsync();

            return Ok(levelTwos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<LevelTwo>> GetLevelTwoByIdAsync(int id)
        {
            var levelTwo = await _levelTwoService.GetLevelTwoByIdAsync(id);

            if (levelTwo == null)
            {
                return NotFound();
            }

            return Ok(levelTwo);
        }

        [HttpPost]
        public async Task<ActionResult> CreateLevelTwo([FromBody] CreateLevelTwoDto createLevelTwoDto)
        {
            var levelTwo = new LevelTwo
            {
                Name = createLevelTwoDto.Name,
                Description = createLevelTwoDto.Description,
                LevelOneId = createLevelTwoDto.LevelOneId,
            };

            await _levelTwoService.CreateLevelTwoAsync(levelTwo);


            return Ok(new { message = "Created successfully", Object = levelTwo });

            // return CreatedAtAction(nameof(GetLevelTwoByIdAsync), new { id = levelTwo.Id }, levelTwo);

        }
    }
}
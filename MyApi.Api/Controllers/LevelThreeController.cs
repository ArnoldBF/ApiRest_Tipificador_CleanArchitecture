using Microsoft.AspNetCore.Mvc;
using MyApi.Domain.Entities;
using MyApi.Application.Interfaces;
using MyApi.Application.Dtos.LevelThree;

namespace MyApi.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LevelThreeController : ControllerBase
    {

        private readonly ILevelThreeService _levelThreeService;

        public LevelThreeController(ILevelThreeService levelThreeService)
        {
            _levelThreeService = levelThreeService;
        }

        [HttpGet]
        public async Task<IEnumerable<LevelThree>> GetAllLevelThreeAsync()
        {
            return await _levelThreeService.GetAllLevelThreeAsync();
        }
        [HttpGet("by-level-two/{levelTwoId}")]
        public async Task<ActionResult<List<LevelThree>>> GetLevelThreesByLevelTwoId(int levelTwoId)
        {
            var levelThrees = await _levelThreeService.GetLevelThreesByLevelTwoIdAsync(levelTwoId);

            if (levelThrees == null || !levelThrees.Any())
            {
                return NotFound(new { message = $"No LevelThree records found for LevelTwoId {levelTwoId}" });
            }

            return Ok(levelThrees);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<LevelThree>> GetLevelThreeByIdAsync(int id)
        {
            var levelThree = await _levelThreeService.GetLevelThreeByIdAsync(id);

            if (levelThree == null)
            {
                return NotFound();
            }

            return Ok(levelThree);
        }

        [HttpGet("with-level-twos")]
        public async Task<ActionResult<List<LevelThree>>> GetAllLevelThreesWithLevelTwos()
        {
            var levelThrees = await _levelThreeService.GetAllLevelThreeWithLevelTwoAsync();

            return Ok(levelThrees);
        }

        [HttpPost]
        public async Task<ActionResult> CreateLevelThree([FromBody] CreateLevelThreeDto createLevelThreeDto)
        {

            var levelThree = new LevelThree
            {
                Name = createLevelThreeDto.Name,
                Description = createLevelThreeDto.Description,
                LevelTwoId = createLevelThreeDto.LevelTwoId,
            };

            await _levelThreeService.CreateLevelThreeAsync(levelThree);

            return Ok(new { message = "Created successfully", Object = levelThree });

            // return CreatedAtAction(nameof(GetLevelThreeByIdAsync), new { id = levelThree.Id }, levelThree);




        }

    }
}
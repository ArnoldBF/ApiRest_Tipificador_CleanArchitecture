using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApi.Application.Dtos.LevelThree
{
    public class CreateLevelThreeDto
    {
        required public string Name { get; set; } = string.Empty;
        required public string Description { get; set; } = string.Empty;
        required public int LevelTwoId { get; set; }
    }
}
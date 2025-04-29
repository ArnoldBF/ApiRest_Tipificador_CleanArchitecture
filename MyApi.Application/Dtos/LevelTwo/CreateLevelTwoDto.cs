using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApi.Application.Dtos.LevelTwo
{
    public class CreateLevelTwoDto
    {

        required public string Name { get; set; } = string.Empty;
        required public string Description { get; set; } = string.Empty;
        required public int LevelOneId { get; set; }
    }
}
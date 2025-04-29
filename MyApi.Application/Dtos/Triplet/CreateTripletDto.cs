

namespace MyApi.Application.Dtos.Triplet
{
    public class CreateTripletDto
    {
        required public int LevelOneId { get; set; }
        required public int LevelTwoId { get; set; }
        required public int LevelThreeId { get; set; }
    }
}
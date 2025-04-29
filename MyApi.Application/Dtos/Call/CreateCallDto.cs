

namespace MyApi.Application.Dtos.Call
{
    public class CreateCallDto
    {

        public string Comment { get; set; } = string.Empty;
        required public string CallId { get; set; } = string.Empty;
        public int UserId { get; set; } = 0;
        required public int TripletId { get; set; } = 0;

        // public DateOnly TypificationDate { get; set; } = DateOnly.FromDateTime(DateTime.Now);
        // public TimeOnly TypificationTime { get; set; } = TimeOnly.FromDateTime(DateTime.Now);
    }
}
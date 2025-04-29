using System.Text.Json.Serialization;

namespace MyApi.Domain.Entities
{
    public class LevelThree
    {

        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        public int LevelTwoId { get; set; } // Relacion de muchos a uno con SubCategory

        [JsonIgnore]
        public LevelTwo LevelTwo { get; set; } = null!; // Relacion de muchos a uno con SubCategory

        // public ICollection<Triplet> Triplets { get; set; } = new List<Triplet>(); // Relacion de uno

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApi.Domain.Entities
{
    public class LevelOne
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;


        public ICollection<LevelTwo> LevelTwos { get; set; } = new List<LevelTwo>();

        // public ICollection<Triplet> Triplets { get; set; } = new List<Triplet>(); // Relacion de uno a muchos con Triplet
    }
}
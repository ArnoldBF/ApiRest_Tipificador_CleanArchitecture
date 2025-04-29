using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MyApi.Domain.Entities
{
    public class LevelTwo
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        public int LevelOneId { get; set; } // Relacion de muchos a uno con Category

        [JsonIgnore]
        public LevelOne LevelOne { get; set; } = null!; // Relacion de muchos a uno con Category

        public ICollection<LevelThree> LevelThrees { get; set; } = new List<LevelThree>(); // Relacion de uno a muchos con SubSubCategory
        // public ICollection<Triplet> Triplets { get; set; } = new List<Triplet>(); // Relacion de uno a muchos con Triplet

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApi.Domain.Entities
{
    public class Triplet
    {

        public int Id { get; set; }



        public int LevelOneId { get; set; } // Relacion de muchos a uno con Category
        public LevelOne LevelOne { get; set; } = null!; // Relacion de muchos a uno con Category


        public int LevelTwoId { get; set; } // Relacion de muchos a uno con SubCategory
        public LevelTwo LevelTwo { get; set; } = null!; // Relacion de muchos a uno con SubCategory

        public int LevelThreeId { get; set; }
        public LevelThree LevelThree { get; set; } = null!; // Relacion de muchos a uno con SubSubCategory

        public ICollection<Call> Calls { get; set; } = new List<Call>();

    }
}
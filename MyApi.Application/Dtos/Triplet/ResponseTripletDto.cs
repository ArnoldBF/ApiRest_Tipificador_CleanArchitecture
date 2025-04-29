using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApi.Application.Dtos.Triplet
{
    public class ResponseTripletDto
    {

        public int Id { get; set; }

        public int LevelOneId { get; set; }
        public int LevelTwoId { get; set; }
        public int LevelThreeId { get; set; }



    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MyApi.Domain.Entities;

namespace MyApi.Application.Interfaces
{
    public interface ITripletRepository : IRepository<Triplet>
    {

        Task<List<Triplet>> GetAllTripletWithLevelOneAsync();
        Task<List<Triplet>> GetAllTripletWithLevelTwoAsync();
        Task<List<Triplet>> GetAllTripletWithLevelThreeAsync();

        // Task<List<Triplet>> GetAllTripletWithLevelOneAndLevelTwoAndLevelThreeAsync();

    }

}
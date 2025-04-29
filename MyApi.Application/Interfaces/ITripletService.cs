using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MyApi.Domain.Entities;

namespace MyApi.Application.Interfaces
{
    public interface ITripletService
    {

        Task<IEnumerable<Triplet>> GetAllTripletsAsync();

        Task<Triplet> GetTripletByIdAsync(int id);
        Task<Triplet> CreateTripletAsync(Triplet triplet);

    }
}
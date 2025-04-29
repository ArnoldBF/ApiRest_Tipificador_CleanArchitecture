using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyApi.Application.Interfaces;
using MyApi.Domain.Entities;


namespace MyApi.Application.Services
{
    public class TripletService : ITripletService
    {

        private readonly ITripletRepository _tripletRepository;

        public TripletService(ITripletRepository tripletRepository)
        {
            _tripletRepository = tripletRepository;
        }

        public async Task<IEnumerable<Triplet>> GetAllTripletsAsync()
        {
            return await _tripletRepository.GetAllAsync();
        }

        public async Task<Triplet> GetTripletByIdAsync(int id)
        {
            return await _tripletRepository.GetByIdAsync(id);
        }

        public async Task<Triplet> CreateTripletAsync(Triplet triplet)
        {
            await _tripletRepository.AddAsync(triplet);
            return triplet;
        }

    }
}